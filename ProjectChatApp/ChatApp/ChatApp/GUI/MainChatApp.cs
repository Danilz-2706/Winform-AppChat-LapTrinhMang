using ChatApp.Properties;
using DTO.DTO;
using K4os.Compression.LZ4.Internal;
using Microsoft.VisualBasic.Logging;
using Org.BouncyCastle.Bcpg;
using Packet;
using Server.DTO;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Permissions;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Windows.Forms;
using UI_AppChat.UserControls;

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
        int nFriendRequest;
        List<user> listFriendOfUser = new List<user>();
        List<user>? listFriendRequestOfUser = new List<user>();
        List<string> listUsernameReponseOff = new List<string>();
        List<message> HistoryChat = new List<message>();
       // List<viewmessage> viewmesslist = new List<viewmessage>();
        Dictionary<int, message> messlist = new Dictionary<int, message>();
        Dictionary<int, bool> CheckSeenMessage = new Dictionary<int, bool>();
        ChatFriendListView[] listItem;
        List<int>? checkSeenMessagerUsers = new List<int>();

        public MainChatApp(IPEndPoint ipep,int id ,string emailuser, string name,int num,Socket client, List<user> listFriendOfUser, Dictionary<int, message> messlist, Dictionary<int, bool> CheckSeenMessage, List<user> listFriendRequestOfUser, List<string> listUsernameReponseOff)
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
            this.messlist = messlist;
            this.CheckSeenMessage = CheckSeenMessage;
            listItem = new ChatFriendListView[n];
            //new Thread(new ThreadStart(this.NewThread)).Start();
            trd = new Thread(NewThread);
            trd.IsBackground = true;
            trd.Start();
            ChattingPanel.Hide();
            SendMessgapanel.Hide();
            label1.Hide();
            starttochatlbl.Show(); 
            populateFriendListView(n,0,0,HistoryChat,false);
            populateFriendRequestListView(nFriendRequest);
            testpicMethod(testpic, "logoteam-33023322856.png");
            testpic.Hide();
        }
        public void testpicMethod(PictureBox p, string nameimg)
        {
            p.Image = new Bitmap("../../../../Server/User/" + nameimg);
            p.SizeMode = PictureBoxSizeMode.StretchImage;
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
                BeginInvoke((Action)(() => UpdateStatusFriend()));

            }
            try
            {
                while (active)
                {
                    int size = 1024 * 1000 * 5;
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
                                BeginInvoke((Action)(() => populateFriendRequestListView(nFriendRequest)));
                                //MessageBox.Show(u.Name);                                                             
                                break;
                            case "SendHistoryChat": //lay lich su chat box giua 2 nguoi dung
                                SENDHISTORYCHAT? send = JsonSerializer.Deserialize<SENDHISTORYCHAT>(com.content);                                
                                HistoryChat = send.listHistoryChat;
                                checkSeenMessagerUsers = send.checkSeenMessageUsers;
                                if (messlist.ContainsKey(send.idrec))
                                {
                                    messlist[send.idrec] = send.lastmess;
                                    /*viewmessage temp = new viewmessage();
                                    temp.Iduser = send.idsender;
                                    temp.Idmess = messlist[send.idrec].Id;
                                    viewmesslist.Add(temp);*/
                                    
                                }
                                else
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
                                    if(send.idsender == IdRec)
                                    {
                                        BeginInvoke((Action)(() => populateHistoryChat(HistoryChat)));
                                        BeginInvoke((Action)(() => populateFriendListView(n ,send.idrec, send.idsender, HistoryChat,send.noti)));
                                    }
                                    else
                                    {
                                        BeginInvoke((Action)(() => populateFriendListView(n, send.idsender, send.idsender, HistoryChat, send.noti)));
                                    }
                                    
                                }                           
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
                            case "FrientResponseOnline":      // cập nhật lại list frient của thằng gửi lời mời kết bạn trong khi nó online

                                UPDATELISTFRIENDOFUSER? list = JsonSerializer.Deserialize<UPDATELISTFRIENDOFUSER>(com.content);
                                MessageBox.Show(list.mess);
                                listFriendOfUser = list.listFriendOfUser;
                                n = list.listFriendOfUser.Count();
                                messlist = list.messlist;
                                CheckSeenMessage = list.CheckSeenMessage;
                                BeginInvoke((Action)(() => populateFriendListView(n, 0,0, HistoryChat, false)));
                                break;
                            case "FrientRequestOnline": // cập nhật lại danh sách bạn và danh sách thông báo của được gửi lời mời kb khi nó online
                                UPDATELISTREQUESTFRIENDOFUSER? list2 = JsonSerializer.Deserialize<UPDATELISTREQUESTFRIENDOFUSER>(com.content);
                                listFriendOfUser = list2.listFriendOfUser;
                                n = listFriendOfUser.Count();
                                listFriendRequestOfUser = list2.listFriendRequestOfUser;
                                nFriendRequest = listFriendRequestOfUser.Count();
                                messlist = list2.messlist;
                                CheckSeenMessage = list2.CheckSeenMessage;
                                BeginInvoke((Action)(() => populateFriendListView(n, 0, 0, HistoryChat, false)));
                                BeginInvoke((Action)(() =>populateFriendRequestListView(nFriendRequest)));
                                break;                         
                            case "UpdateListRequestFriendOfUserOnline":
                                UPDATELISTREQUESTFRIENDOFUSERONLINE? list3 = JsonSerializer.Deserialize<UPDATELISTREQUESTFRIENDOFUSERONLINE>(com.content);
                                listFriendRequestOfUser = list3.listFriendRequestOfUser;                            
                                nFriendRequest = listFriendRequestOfUser.Count();                                                          
                                BeginInvoke((Action)(() => populateFriendRequestListView(nFriendRequest)));
                                break;

                            case "UpdateListRequestFriendOfUserOnlineCancel":
                                UPDATELISTREQUESTFRIENDOFUSERONLINE? list4 = JsonSerializer.Deserialize<UPDATELISTREQUESTFRIENDOFUSERONLINE>(com.content);
                                listFriendRequestOfUser = list4.listFriendRequestOfUser;
                                nFriendRequest = listFriendRequestOfUser.Count();
                                BeginInvoke((Action)(() => populateFriendRequestListView(nFriendRequest)));
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
                int meChat = 0;
                int fChat = 0;
                int MeI = 0;
                int FrI = 0;
                ChattingPanel.Controls.Clear();
                ReceiverMessageContent[] ReceiverMessageContentMess = new ReceiverMessageContent[HistoryChat.Count];
                SenderMessageContent[] SenderMessageContentMess = new SenderMessageContent[HistoryChat.Count];
                MeImage[] MeImage = new MeImage[HistoryChat.Count];
                FriendImage[] FriendImage = new FriendImage[HistoryChat.Count];
                for(int i=0;i< HistoryChat.Count;i++)
                {
                    if (HistoryChat[i].Idsender == IdSender)
                    {
                        if (HistoryChat[i].Url == 1)
                        {
                            MeImage[i] = new MeImage();
                            MeImage[i].ShowSeen = false;
                            MeImage[i].ImagePicMethod(HistoryChat[i].Messagecontent.ToString());
                            for (int j = 0; j < listFriendOfUser.Count; j++)
                            {
                                if (HistoryChat[i].Idreceiver == listFriendOfUser[j].Id)
                                {
                                    MeImage[i].NameFriendChatWithMe = listFriendOfUser[j].Name;
                                    break;
                                }
                            }
                            ChattingPanel.Controls.Add(MeImage[i]);
                            meChat = 0;
                            fChat = 0;
                            MeI = 1;
                            FrI = 0;
                        }
                        else
                        {
                            SenderMessageContentMess[i] = new SenderMessageContent();
                            SenderMessageContentMess[i].ShowSeen = false;
                            SenderMessageContentMess[i].Message = HistoryChat[i].Messagecontent;
                            for (int j = 0; j < listFriendOfUser.Count; j++)
                            {
                                if (HistoryChat[i].Idreceiver == listFriendOfUser[j].Id)
                                {
                                    SenderMessageContentMess[i].NameFriendChatWithMe = listFriendOfUser[j].Name;
                                    break;
                                }
                            }
                            ChattingPanel.Controls.Add(SenderMessageContentMess[i]);
                            //ChattingPanel.ScrollControlIntoView(SenderMessageContentMess[i]);
                            meChat = 1;
                            fChat = 0;
                            MeI = 0;
                            FrI = 0;
                        }                       
                    }
                    else
                    {
                        if (HistoryChat[i].Url == 1)
                        {
                            FriendImage[i] = new FriendImage();
                            FriendImage[i].ShowSeen = false;
                            for (int j = 0; j < listFriendOfUser.Count; j++)
                            {
                                if (HistoryChat[i].Idsender == listFriendOfUser[j].Id)
                                {
                                    FriendImage[i].Username = listFriendOfUser[j].Name;
                                    break;
                                }
                            }
                            FriendImage[i].ImagePicMethod(HistoryChat[i].Messagecontent);
                            ChattingPanel.Controls.Add(FriendImage[i]);
                            meChat = 0;
                            fChat = 0;
                            MeI = 0;
                            FrI = 1;
                        }
                        else
                        {
                            ReceiverMessageContentMess[i] = new ReceiverMessageContent();
                            ReceiverMessageContentMess[i].ShowSeen = false;
                            for (int j = 0; j < listFriendOfUser.Count; j++)
                            {
                                if (HistoryChat[i].Idsender == listFriendOfUser[j].Id)
                                {
                                    ReceiverMessageContentMess[i].Username = listFriendOfUser[j].Name;
                                    break;
                                }
                            }
                            ReceiverMessageContentMess[i].Message = HistoryChat[i].Messagecontent;
                            ChattingPanel.Controls.Add(ReceiverMessageContentMess[i]);
                            //  ChattingPanel.ScrollControlIntoView(ReceiverMessageContentMess[i]);
                            meChat = 0;
                            fChat = 1;
                            MeI = 0;
                            FrI = 0;
                        }                       
                    }
                }
                if(fChat == 1)
                {                   
                    if (checkSeenMessagerUsers.Count == 1)
                    {
                        ReceiverMessageContentMess[HistoryChat.Count - 1].SeenMessage = ReceiverMessageContentMess[HistoryChat.Count - 1].Username.ToString() + "had seen";
                    }
                    else
                    {
                        ReceiverMessageContentMess[HistoryChat.Count - 1].SeenMessage = "You,"+ReceiverMessageContentMess[HistoryChat.Count - 1].Username.ToString() + "had seen";
                    }
                    ReceiverMessageContentMess[HistoryChat.Count - 1].ShowSeen = true;
                    ChattingPanel.ScrollControlIntoView(ReceiverMessageContentMess[HistoryChat.Count - 1]);
                }
                else if(meChat == 1)
                {
                    if (checkSeenMessagerUsers.Count == 1)
                    {
                        SenderMessageContentMess[HistoryChat.Count - 1].SeenMessage = "You had seen";
                    }
                    else
                    {
                        SenderMessageContentMess[HistoryChat.Count - 1].SeenMessage = "You," + SenderMessageContentMess[HistoryChat.Count - 1].NameFriendChatWithMe.ToString() + "had seen";
                    }
                    SenderMessageContentMess[HistoryChat.Count - 1].ShowSeen = true;
                    ChattingPanel.ScrollControlIntoView(SenderMessageContentMess[HistoryChat.Count - 1]);
                }else if(MeI == 1)
                {
                    if (checkSeenMessagerUsers.Count == 1)
                    {
                        MeImage[HistoryChat.Count - 1].SeenMessage = "You had seen";
                    }
                    else
                    {
                        MeImage[HistoryChat.Count - 1].SeenMessage = "You," + MeImage[HistoryChat.Count - 1].NameFriendChatWithMe.ToString() + "had seen";
                    }
                    MeImage[HistoryChat.Count - 1].ShowSeen = true;
                    ChattingPanel.ScrollControlIntoView(MeImage[HistoryChat.Count - 1]);
                }
                else
                {
                    if (checkSeenMessagerUsers.Count == 1)
                    {
                        FriendImage[HistoryChat.Count - 1].SeenMessage = FriendImage[HistoryChat.Count - 1].Username.ToString() + "had seen";
                    }
                    else
                    {
                        FriendImage[HistoryChat.Count - 1].SeenMessage = "You," + FriendImage[HistoryChat.Count - 1].Username.ToString() + "had seen";
                    }
                    FriendImage[HistoryChat.Count - 1].ShowSeen = true;
                    ChattingPanel.ScrollControlIntoView(FriendImage[HistoryChat.Count - 1]);
                }
            }
            
        }


        private void populateFriendListView(int n, int Noti,int OwnClient, List<message> M,bool noti)
        {
            
            if (M.Count == 0 && Noti == 0 && OwnClient == 0)
            {
                ChatFriendPanel.Controls.Clear();
                ChatFriendListView[] listItem = new ChatFriendListView[n];
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
                    if (CheckSeenMessage.ContainsKey(listFriendOfUser[i].Id))
                    {
                        if (!CheckSeenMessage[listFriendOfUser[i].Id])
                        {
                            listItem[i].ShowNoti = true;
                            listItem[i].LastchatColor = Color.White;
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
                    ChatFriendListView[] listItem = new ChatFriendListView[n];
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


        //khanh--------------------------
        private void populateFriendRequestListView(int n)
        {
            if (n == 0)
            {
                FriendRequestPanel.Controls.Clear();
            }
            else
            {
                FriendRequestPanel.Controls.Clear();
                FriendRequestListView[] listItem = new FriendRequestListView[n];
                for (int i = 0; i < listItem.Length; i++)
                {

                    listItem[i] = new FriendRequestListView(IdSender, listFriendRequestOfUser[i].Id, _clientToServer);
                    listItem[i].Username = listFriendRequestOfUser[i].Name;

                    FriendRequestPanel.Controls.Add(listItem[i]);


                }
            }

        }
        //---------------------------------

        void ClickEvent(object sender,EventArgs e)
        {
            ChattingPanel.Show();
            SendMessgapanel.Show();
            ChatFriendListView obj = (ChatFriendListView)sender;
            obj.ShowNoti = false;          
            IdRec = obj.Iduser;                  
            label1.Text = obj.Name;
            label1.Visible = true;
            Packet.REQUESTHISTORYCHAT rqhc = new Packet.REQUESTHISTORYCHAT(IdSender,IdRec,false);
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
        public void killthread(Thread trd) => trd.Interrupt();
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

        public void FriendRequestConnect()
        {
            //-------Nhận dữ liệu từ textbox và thông báo---------//
            bool flag = true;
            string username = SearchFriendtxt.Text;
            byte[] data = new byte[1024 * 3 * 1000];
            Packet.SENFRIENDREQUEST friendRequest = new Packet.SENFRIENDREQUEST(IdSender, username);
            string jsonString = JsonSerializer.Serialize(friendRequest);
            Packet.Packet packet = new Packet.Packet("FrientRequest", jsonString);
            DialogResult dlr = MessageBox.Show("Bạn muốn kết bạn với: " + username,
            "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //-------Kết thúc Nhận dữ liệu từ textbox và thông báo---------//



            if (dlr == DialogResult.Yes)
            {

                //---------Gửi Nhận packet-server------------------------------//
                if(username == email)
                {
                    MessageBox.Show("Khong the ket ban voi chinh minh!");
                    flag = false;
                }
                for(int i=0;i<listFriendOfUser.Count;i++)
                {
                    if(username == listFriendOfUser[i].Email)
                    {
                        MessageBox.Show("Nguoi nay da la ban be cua ban!");
                        flag = false;
                        break;
                    }
                }
                if(flag)
                {
                    sendJson(packet);
                }         
                // sai r khuc nay moi thu khi ma client nhan dc no phai nam o thread hieu hk??

            }
           /* else
            {
                MessageBox.Show("Code sai rồi");
            }*/
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
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        public byte[] ImageToByte(Image img)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                img.Save(mStream, img.RawFormat);
                return mStream.ToArray();
            }
        }
        private void filebtn_Click(object sender, EventArgs e)
        {
            
            string path = "";
            string filename = "";

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openFileDialog.FileName;
                string imagepath = path.ToString();
                imagepath = imagepath.Substring(imagepath.LastIndexOf("\\"));
                filename = imagepath.Remove(0, 1);
                Image hinh = Image.FromFile(path);
                //Image hinhresize = (Image)resizeImage(hinh, new Size(150,150));
                //Send Hinh qua Server
                
                byte[] BStream = ImageToByte(hinh);
                Packet.SENDIMAGE sendimage = new Packet.SENDIMAGE(IdSender, IdRec, filename.ToString(), 1.ToString(), BStream);
                string jsonString = JsonSerializer.Serialize(sendimage);
                Packet.Packet packet = new Packet.Packet("SendImage", jsonString);
                sendJson(packet);
            }

            Packet.REQUESTHISTORYCHAT rqhc = new Packet.REQUESTHISTORYCHAT(IdSender, IdRec, true);
            string jsonString1 = JsonSerializer.Serialize(rqhc);
            Packet.Packet packet1 = new Packet.Packet("RequestHistoryChat", jsonString1);
            sendJson(packet1);

        }
    }
}
