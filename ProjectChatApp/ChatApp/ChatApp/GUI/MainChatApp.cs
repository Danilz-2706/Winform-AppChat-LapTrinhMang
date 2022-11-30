using ChatApp.Properties;
using DTO.DTO;
using Microsoft.VisualBasic.Logging;
using Org.BouncyCastle.Bcpg;
using Packet;
using Server.DTO;
using System.Globalization;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Permissions;
using System.Text;
using System.Text.Json;
using System.Threading;

namespace ChatApp.GUI
{
    public partial class MainChatApp : Form
    {
        int checkFlag = 1;
        int IdSender = 0;
        int IdRec = 0;
        int Noti = 0;
        Thread trd;  
        IPEndPoint iep;
        Socket _clientToServer;
        string email = null;     
        string name_user = null;
        bool active = true;
        int n;
        List<user> listFriendOfUser = new List<user>();
        List<message> HistoryChat = new List<message>();
        Dictionary<int, message> messlist = new Dictionary<int, message>();
        ChatFriendListView[] listItem;

        public MainChatApp(IPEndPoint ipep,int id ,string emailuser, string name,int num,Socket client, List<user> listFriendOfUser, Dictionary<int, message> messlist)
        {
            InitializeComponent();            
            iep = ipep;
            _clientToServer = client;         
            email = emailuser;
            IdSender = id;
            name_user = name;
            n = listFriendOfUser.Count;
            Username.Text = name_user;
            this.listFriendOfUser = listFriendOfUser;
            this.messlist = messlist;
            listItem = new ChatFriendListView[n];
            //new Thread(new ThreadStart(this.NewThread)).Start();
            trd = new Thread(NewThread);
            trd.IsBackground = true;
            trd.Start();
            ChattingPanel.Hide();
            SendMessgapanel.Hide();
            starttochatlbl.Show(); 
            populateFriendListView(n,0,0,HistoryChat,false);
        }
        public string getIPAdress()
        {
            string t = "";
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    //Console.WriteLine(ni.Name);
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            t = ip.Address.ToString();
                        }
                    }
                }
            }
            return t;
        }
        private void NewThread()
        {
            try
            {
                while (active)
                {
                    int size = 1024 * 1000 * 3;
                    byte[] data = new byte[size];
                    int recv = _clientToServer.Receive(data);
                    string jsonString = Encoding.ASCII.GetString(data, 0, recv);
                    jsonString.Replace("\\u0022", "\"");
                    Packet.Packet com = JsonSerializer.Deserialize<Packet.Packet>(jsonString);

                    if (com != null)
                    {
                        switch (com.mess)
                        {
                            case "StatusUser":
                                SENDUSERSTATUS? senduserstatusonline = JsonSerializer.Deserialize<SENDUSERSTATUS>(com.content);
                                for (int i = 0; i < listFriendOfUser.Count(); i++)
                                {
                                    if (listFriendOfUser[i].Email == senduserstatusonline.u.Email)
                                    {
                                        listFriendOfUser[i].Online_status = senduserstatusonline.u.Online_status;
                                        break;
                                    }
                                }
                                //muốn thay đổi 1 thứ gì đó không đồng bộ 
                                BeginInvoke((Action)(() => populateFriendListView(n,0,0,HistoryChat,false)));
                                //MessageBox.Show(u.Name);                                                             
                                break;
                            case "SendHistoryChat": //lay lich su chat box giua 2 nguoi dung
                                SENDHISTORYCHAT? send = JsonSerializer.Deserialize<SENDHISTORYCHAT>(com.content);                                                             
                                HistoryChat = send.listHistoryChat;
                                if(messlist.ContainsKey(send.idrec))
                                {
                                    messlist[send.idrec] = send.lastmess;
                                }else
                                if(messlist.ContainsKey(send.idsender))
                                {
                                    messlist[send.idsender] = send.lastmess;
                                }
               
                                //MessageBox.Show(HistoryChat.Count.ToString());
                                if(send.idrec == IdRec)
                                {
                                    BeginInvoke((Action)(() => populateHistoryChat(HistoryChat)));                                  
                                    BeginInvoke((Action)(() => populateFriendListView(n ,send.idrec, send.idsender, HistoryChat,send.noti)));
                                }
                                else
                                {
                                    BeginInvoke((Action)(() => populateFriendListView(n,send.idsender, send.idsender, HistoryChat,send.noti)));
                                }                           
                                break;
                           
                            case "OK":                                                                
                                    active = false;                                                                   
                                break;
                            default:
                                break;
                        }
                    }                
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                active = false;
                throw;
            }
            BeginInvoke((Action)(() => OpenLF()));
            
        }
        public void OpenLF()
        {
            this.Close();
            LoginForm lf = new LoginForm();
            lf.Show();
            //MessageBox.Show("Thread da chet");
            
        }

        private void populateHistoryChat(List<message> HistoryChat)
        {
            if(HistoryChat.Count == 0)
            {
                ChattingPanel.Controls.Clear();
                ChattingPanel.Controls.Add(starttochatlbl);
                starttochatlbl.Show();
            }
            else
            {
                ChattingPanel.Controls.Clear();
                FriendChat[] FriendChatMess = new FriendChat[HistoryChat.Count];
                MeChat[] MeChatMess = new MeChat[HistoryChat.Count];
                for(int i=0;i< HistoryChat.Count;i++)
                {
                    if (HistoryChat[i].Idsender == IdSender)
                    {
                        MeChatMess[i] = new MeChat();
                        MeChatMess[i].Message = HistoryChat[i].Messagecontent;
                        ChattingPanel.Controls.Add(MeChatMess[i]);
                    }
                    else
                    {
                        FriendChatMess[i] = new FriendChat();
                        for(int j=0;j<listFriendOfUser.Count;j++)
                        {
                            if (HistoryChat[i].Idsender == listFriendOfUser[j].Id)
                            {
                                FriendChatMess[i].Username = listFriendOfUser[j].Name;
                                break;
                            }
                        }
                        FriendChatMess[i].Message = HistoryChat[i].Messagecontent;
                        ChattingPanel.Controls.Add(FriendChatMess[i]);
                    }
                }
            }
            
        }
        private void populateFriendListView(int n, int Noti,int OwnClient, List<message> M,bool noti)
        {
            
            if (M.Count == 0 && Noti == 0 && OwnClient == 0)
            {
                ChatFriendPanel.Controls.Clear();
                //ChatFriendListView[] listItem = new ChatFriendListView[n];
                for (int i = 0; i < listItem.Length; i++)
                {
                    listItem[i] = new ChatFriendListView();
                    listItem[i].Iduser = listFriendOfUser[i].Id;                    
                    listItem[i].ShowNoti = false;
                    if (messlist.ContainsKey(listFriendOfUser[i].Id))
                    {
                        message temp = new message();
                        temp = messlist[listFriendOfUser[i].Id];
                        if(temp.Idsender == IdSender)
                        {
                            listItem[i].LastChat = "You: " + temp.Messagecontent.ToString();
                        }
                        else
                        {
                            listItem[i].LastChat = listFriendOfUser[i].Name + ": " + temp.Messagecontent.ToString();
                        }
                    }
                    listItem[i].Username = listFriendOfUser[i].Name;
                    listItem[i].UsernameColor = Color.Silver;

                    if (listFriendOfUser[i].Online_status == 1)
                    {
                        listItem[i].Status = "Online";
                        listItem[i].StatusColor = Color.Lime;
                    }
                    else
                    {
                        listItem[i].Status = "Offline";
                        listItem[i].StatusColor = Color.Red;
                    }

                    //listItem[i].LastChat = "";
                    
                    listItem[i].LastchatColor = Color.Gray;
                    listItem[i].UserIcon = Resources.male_default;
                    //list[i].Click += (sender, e) => TestEvent(sender, e);
                    listItem[i].Name = listItem[i].Username;
                    
                    ChatFriendPanel.Controls.Add(listItem[i]);

                    listItem[i].Click += new System.EventHandler(this.ClickEvent);


                }
            }
            else
            {

                if(noti == false )
                {
                    ChatFriendPanel.Controls.Clear();
                    //ChatFriendListView[] listItem = new ChatFriendListView[n];
                    for (int i = 0; i < listItem.Length; i++)
                    {
                        

                        listItem[i] = new ChatFriendListView();
                        listItem[i].Iduser = listFriendOfUser[i].Id;
                        listItem[i].ShowNoti = false;
                        
                        //listItem[i].ShowNoti = false;
                        if (messlist.ContainsKey(listFriendOfUser[i].Id))
                        {
                            message temp = new message();
                            temp = messlist[listFriendOfUser[i].Id];
                            if (temp.Idsender == IdSender)
                            {
                                listItem[i].LastChat = "You: " + temp.Messagecontent.ToString();
                            }
                            else
                            {
                                listItem[i].LastChat = listFriendOfUser[i].Name + ": " + temp.Messagecontent.ToString();
                            }
                        }
                        listItem[i].Username = listFriendOfUser[i].Name;
                        listItem[i].UsernameColor = Color.Silver;

                        if (listFriendOfUser[i].Online_status == 1)
                        {
                            listItem[i].Status = "Online";
                            listItem[i].StatusColor = Color.Lime;
                        }
                        else
                        {
                            listItem[i].Status = "Offline";
                            listItem[i].StatusColor = Color.Red;
                        }

                        if (Noti == listFriendOfUser[i].Id)
                        {
                            listItem[i].ShowNoti = false;
                        }
                        //listItem[i].LastChat = "Hello World";
                        listItem[i].LastchatColor = Color.Gray;
                        listItem[i].UserIcon = Resources.male_default;
                        //list[i].Click += (sender, e) => TestEvent(sender, e);
                        listItem[i].Name = listItem[i].Username;
                       
                        ChatFriendPanel.Controls.Add(listItem[i]);

                        listItem[i].Click += new System.EventHandler(this.ClickEvent);
                        checkFlag = 2;

                    }
                }
                else
                {
                    ChatFriendPanel.Controls.Clear();
                    ChatFriendListView[] listItem = new ChatFriendListView[n];
                    for (int i = 0; i < listItem.Length; i++)
                    {
                        listItem[i] = new ChatFriendListView();
                        listItem[i].Iduser = listFriendOfUser[i].Id;
                        listItem[i].ShowNoti = false;
                        
                        
                        listItem[i].Username = listFriendOfUser[i].Name;
                        listItem[i].UsernameColor = Color.Silver;

                        if (listFriendOfUser[i].Online_status == 1)
                        {
                            listItem[i].Status = "Online";
                            listItem[i].StatusColor = Color.Lime;
                        }
                        else
                        {
                            listItem[i].Status = "Offline";
                            listItem[i].StatusColor = Color.Red;
                        }
                        if(Noti == listFriendOfUser[i].Id)
                        {
                            if (OwnClient == IdSender)
                            {
                                listItem[i].ShowNoti = false;
                                if (messlist.ContainsKey(listFriendOfUser[i].Id))
                                {
                                    message temp = new message();
                                    temp = messlist[listFriendOfUser[i].Id];
                                    if (temp.Idsender == IdSender)
                                    {
                                        listItem[i].LastChat = "You: " + temp.Messagecontent.ToString();
                                        listItem[i].LastchatColor = Color.Gray;
                                    }
                                    else
                                    {
                                        listItem[i].LastChat = listFriendOfUser[i].Name + ": " + temp.Messagecontent.ToString();
                                        listItem[i].LastchatColor = Color.Gray;
                                    }
                                }
                            }
                            else
                            {
                                listItem[i].ShowNoti = true;
                                if (messlist.ContainsKey(listFriendOfUser[i].Id))
                                {
                                    message temp = new message();
                                    temp = messlist[listFriendOfUser[i].Id];
                                    if (temp.Idsender == IdSender)
                                    {
                                        listItem[i].LastChat = "You: " + temp.Messagecontent.ToString();
                                        listItem[i].LastchatColor = Color.White;
                                    }
                                    else
                                    {
                                        listItem[i].LastChat = listFriendOfUser[i].Name + ": " + temp.Messagecontent.ToString();
                                        listItem[i].LastchatColor = Color.White;
                                    }
                                }
                            }
                        }                       
                        else
                        {
                            listItem[i].ShowNoti = false;
                            if (messlist.ContainsKey(listFriendOfUser[i].Id))
                            {
                                message temp = new message();
                                temp = messlist[listFriendOfUser[i].Id];
                                if (temp.Idsender == IdSender)
                                {
                                    listItem[i].LastChat = "You: " + temp.Messagecontent.ToString();
                                    listItem[i].LastchatColor = Color.Gray;
                                }
                                else
                                {
                                    listItem[i].LastChat = listFriendOfUser[i].Name + ": " + temp.Messagecontent.ToString();
                                    listItem[i].LastchatColor = Color.Gray;
                                }
                            }
                        }                                                                   
                        //listItem[i].LastChat = "Hello World";
                        
                        listItem[i].UserIcon = Resources.male_default;
                        //list[i].Click += (sender, e) => TestEvent(sender, e);
                        listItem[i].Name = listItem[i].Username;

                        ChatFriendPanel.Controls.Add(listItem[i]);

                        listItem[i].Click += new System.EventHandler(this.ClickEvent);
                    }
                }

            }
        }

        void ClickEvent(object sender,EventArgs e)
        {
            ChattingPanel.Show();
            SendMessgapanel.Show();
            ChatFriendListView obj = (ChatFriendListView)sender;
            obj.ShowNoti = false;
            IdRec = obj.Iduser;
            

            Packet.REQUESTHISTORYCHAT rqhc = new Packet.REQUESTHISTORYCHAT(IdSender, IdRec,false);
            string jsonString = JsonSerializer.Serialize(rqhc);
            Packet.Packet packet = new Packet.Packet("RequestHistoryChat", jsonString);
            sendJson(packet);
            



        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserChatNamelbl_Click(object sender, EventArgs e)
        {

        }

        private void MessagePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ChattingPanel_Paint(object sender, PaintEventArgs e)
        {

        }
       
        [SecurityPermission(SecurityAction.Demand, ControlThread = true)]
        public void killthread(Thread trd)
        {

            trd.Interrupt();
            
            
        }
        private void Loginbtn_Click(object sender, EventArgs e)
        {                  
            
            Packet.EXIT exit = new Packet.EXIT(email, "Exit");
            string jsonString = JsonSerializer.Serialize(exit);
            Packet.Packet packet = new Packet.Packet("ExitApp", jsonString);
            sendJson(packet);         

        }

        private void Fullnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void ChatPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HeadPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SendMessgapanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void sendJson(object obj)
        {
            try
            {
                byte[] jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(obj);
                _clientToServer.Send(jsonUtf8Bytes, jsonUtf8Bytes.Length, SocketFlags.None);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void SendMessage()
        {

            string mess = Messagetxt.Text;        
            Packet.SENDMESSAGE sendmess = new Packet.SENDMESSAGE(IdSender, IdRec, mess, 0.ToString());
            string jsonString = JsonSerializer.Serialize(sendmess);
            Packet.Packet packet = new Packet.Packet("SendMessage", jsonString);
            sendJson(packet);
           // MessageBox.Show("ID gui:" + IdSender + "ID nhan:" + IdRec + "ND:" + packet.content);
            Messagetxt.Text = "";

            Packet.REQUESTHISTORYCHAT rqhc = new Packet.REQUESTHISTORYCHAT(IdSender, IdRec,true);
            string jsonString1 = JsonSerializer.Serialize(rqhc);
            Packet.Packet packet1 = new Packet.Packet("RequestHistoryChat", jsonString1);
            sendJson(packet1);

           // populateHistoryChat(HistoryChat);

            
        }
        private void SendMessagebtn_Click(object sender, EventArgs e)
        {

           // MessageBox.Show(_clientToServer.Connected.ToString());
            SendMessage();        
        }

        private void FriendAcpectbtn_Click(object sender, EventArgs e)
        {

        }

        private void ImageUser_Click(object sender, EventArgs e)
        {

        }
    }
}
