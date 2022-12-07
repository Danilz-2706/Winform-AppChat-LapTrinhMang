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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ChatApp.GUI
{
    public partial class MainChatApp : Form
    {
        int IdSender = 0;
        int IdRec = 0;        
        Thread trd;  
        IPEndPoint iep;
        Socket _clientToServer;
        string email = null;     
        string name_user = null;
        bool active = true;
        int n;
        int nFriendRequest;
        List<user> listFriendOfUser = new List<user>();
        List<user>? listFriendRequestOfUser = new List<user>();
        List<string> listUsernameReponseOff = new List<string>();
        List<message> HistoryChat = new List<message>();
        
        public MainChatApp(IPEndPoint ipep,int id ,string emailuser, string name,int num,Socket client, List<user> listFriendOfUser, List<user> listFriendRequestOfUser, List<string> listUsernameReponseOff)
        {
            InitializeComponent();            
            iep = ipep;
            _clientToServer = client;         
            email = emailuser;
            IdSender = id;
            name_user = name;
            n = listFriendOfUser.Count;
            
            nFriendRequest = listFriendRequestOfUser.Count;
            Username.Text = name_user;
            this.listFriendOfUser = listFriendOfUser;
            this.listFriendRequestOfUser = listFriendRequestOfUser;
            this.listUsernameReponseOff = listUsernameReponseOff;


            populateFriendListView(n);
            populateFriendRequestListView(nFriendRequest);
            //new Thread(new ThreadStart(this.NewThread)).Start();
            trd = new Thread(NewThread);
            trd.IsBackground = true;
            trd.Start();
            ChattingPanel.Hide();
            SendMessgapanel.Hide();
            starttochatlbl.Show();
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
            if (listUsernameReponseOff.Count() != 0)
            {
                string str = "";
                foreach (string us in listUsernameReponseOff)
                {
                    str += us + "\n";
                }
                MessageBox.Show(str + "accept request friend");
                UpdateStatusFriend();
            }

            try
            {
                while (active)
                {
                    byte[] data = new byte[1024*20*1000];
                    int recv = _clientToServer.Receive(data); // nhan moi thong tin tu server ve o day ne dung r
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
                                BeginInvoke((Action)(() => populateFriendListView(n)));
                                //Khanh sẽ thêm request friend vào đây
                                BeginInvoke((Action)(() => populateFriendRequestListView(nFriendRequest)));

                                //MessageBox.Show(u.Name);                                                             
                                break;
                            case "SendHistoryChat": //lay lich su chat box giua 2 nguoi dung
                                SENDHISTORYCHAT? send = JsonSerializer.Deserialize<SENDHISTORYCHAT>(com.content);
                                HistoryChat = send.listHistoryChat;
                                //MessageBox.Show(HistoryChat.Count.ToString());
                                BeginInvoke((Action)(() => populateHistoryChat(HistoryChat)));
                                    break;
                            case "OK":                                                                
                                    active = false;                                                                   
                                break;
                            case "FrientRequest":
                                MessageBox.Show(com.content);
                                break;
                            case "NoFrientRequest":
                                MessageBox.Show(com.content);
                                break;
                            case "FrientResponseOnline":
                                MessageBox.Show(com.content);
                                 populateFriendListView(n);
                                 populateFriendRequestListView(nFriendRequest);
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
        private void populateFriendListView(int n)
        {
            ChatFriendPanel.Controls.Clear();
            ChatFriendListView[] listItem = new ChatFriendListView[n];
            for(int i=0;i< listItem.Length;i++)
            {
              

                listItem[i] = new ChatFriendListView();
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


                listItem[i].LastChat = "Hello World";
                listItem[i].LastchatColor = Color.Gray;
                listItem[i].UserIcon = Resources.male_default;
                //list[i].Click += (sender, e) => TestEvent(sender, e);
                listItem[i].Name = listItem[i].Username;
                listItem[i].Iduser = listFriendOfUser[i].Id;
                ChatFriendPanel.Controls.Add(listItem[i]);

                listItem[i].Click += new System.EventHandler(this.ClickEvent);


            }

            
        }

        //khanh--------------------------
        private void populateFriendRequestListView(int n)
        {
            FriendRequestPanel.Controls.Clear();
            FriendRequestListView[] listItem = new FriendRequestListView[n];
            for (int i = 0; i < listItem.Length; i++)
            {

                listItem[i] = new FriendRequestListView(IdSender, listFriendRequestOfUser[i].Id,_clientToServer);
                listItem[i].Username = listFriendRequestOfUser[i].Name;

                FriendRequestPanel.Controls.Add(listItem[i]);


            }


        }

        //---------------------------------

        void ClickEvent(object sender,EventArgs e)
        {
            ChattingPanel.Show();
            SendMessgapanel.Show();
            ChatFriendListView obj = (ChatFriendListView)sender;
            IdRec = obj.Iduser;


            Packet.REQUESTHISTORYCHAT rqhc = new Packet.REQUESTHISTORYCHAT(IdSender, IdRec);
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

            Packet.REQUESTHISTORYCHAT rqhc = new Packet.REQUESTHISTORYCHAT(IdSender, IdRec);
            string jsonString1 = JsonSerializer.Serialize(rqhc);
            Packet.Packet packet1 = new Packet.Packet("RequestHistoryChat", jsonString1);
            sendJson(packet1);
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


        public void FriendRequestConnect()
        {
            //-------Nhận dữ liệu từ textbox và thông báo---------//
            string username = SearchFriendtxt.Text;
            byte[] data = new byte[1024];
            Packet.SENFRIENDREQUEST friendRequest = new Packet.SENFRIENDREQUEST(IdSender, username);
            string jsonString = JsonSerializer.Serialize(friendRequest);
            Packet.Packet packet = new Packet.Packet("FrientRequest", jsonString);
            DialogResult dlr = MessageBox.Show("Bạn muốn kết bạn với: " + username,
            "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //-------Kết thúc Nhận dữ liệu từ textbox và thông báo---------//



            if (dlr == DialogResult.Yes)
            {
                
                //---------Gửi Nhận packet-server------------------------------//
                sendJson(packet);
                // sai r khuc nay moi thu khi ma client nhan dc no phai nam o thread hieu hk??
    
            }
            else
            {
                MessageBox.Show("Code sai rồi");
            }
        }


        public void UpdateStatusFriend()
        {
            //-------Nhận dữ liệu từ textbox và thông báo---------//

            Packet.SENUPDATEFRIEND updateStatusFriend = new Packet.SENUPDATEFRIEND(IdSender);
            string jsonString = JsonSerializer.Serialize(updateStatusFriend);
            Packet.Packet packet = new Packet.Packet("UpdateStatusFriend", jsonString);
            sendJson(packet);
                
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FriendRequestConnect();
        }

       

        
    }
}
