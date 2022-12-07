using MySqlX.XDevAPI;
using Packet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Server.DTO;
using DTO.DTO;
using UI_AppChat.Properties;
using UI_AppChat.Forms;
using UI_AppChat.UserControls;
using System.Security.Permissions;

namespace UI_AppChat
{
    public partial class FormListFriendChatting : Form
    {
        private Form activeForm;
        int checkFlag = 1;
        int IdRec = 0;
        int IdSender = 0;
        int Noti = 0;


        Thread trd;
        IPEndPoint iep;
        Socket _client;
        string email = null;
        string name_user = null;
        bool active = false ;
        int n;
        List<user> listFriendOfUser = new List<user>();
        List<message> HistoryChat = new List<message>();
        Dictionary<int, message> messlist = new Dictionary<int, message>();
        Dictionary<int, bool> CheckSeenMessage = new Dictionary<int, bool>();

        ItemFriend[] listItem;
        List<int>? checkSeenMessagerUsers = new List<int>();


        public FormListFriendChatting()
        {
            InitializeComponent();
            
        }
        public FormListFriendChatting(IPEndPoint ipep, int id, string emailuser, string name, int num, Socket client, List<user> listFriendOfUser, Dictionary<int, message> messlist, Dictionary<int, bool> CheckSeenMessage)
        {
            InitializeComponent();
            active = true;
            iep = ipep;
            this.CheckSeenMessage = CheckSeenMessage;
            _client = client;
            email = emailuser;
            IdSender = id;
            name_user = name;
            n = listFriendOfUser.Count;
            this.listFriendOfUser = listFriendOfUser;
            this.messlist = messlist;
            listItem = new ItemFriend[n];
            populateFriendListView(n,0,0,HistoryChat,false);

            trd = new Thread(NewThread);
            trd.IsBackground = true;
            trd.Start();
            

            ChattingPanel.Hide();
            SendMessagePanel.Hide();

        }
        private void NewThread()
        {
            try
            {
                while (active)
                {
                    int size = 1024 * 1000 * 5;
                    byte[] data = new byte[size];
                    int recv = _client.Receive(data);
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
                                BeginInvoke((Action)(() => populateFriendListView(n, 0, 0, HistoryChat, false)));                                                           
                                break;
                            case "SendHistoryChat": //lay lich su chat box giua 2 nguoi dung
                                SENDHISTORYCHAT? send = JsonSerializer.Deserialize<SENDHISTORYCHAT>(com.content);
                                HistoryChat = send.listHistoryChat;
                                checkSeenMessagerUsers = send.checkSeenMessageUsers;

                                if (messlist.ContainsKey(send.idrec))
                                {
                                    messlist[send.idrec] = send.lastmess;
                                }
                                else
                                if (messlist.ContainsKey(send.idsender))
                                {
                                    messlist[send.idsender] = send.lastmess;
                                }

                                if (send.idrec == IdRec)
                                {
                                    BeginInvoke((Action)(() => populateHistoryChat(HistoryChat)));
                                    BeginInvoke((Action)(() => populateFriendListView(n, send.idrec, send.idsender, HistoryChat, send.noti)));

                                }
                                else
                                {
                                    if (send.idsender == IdRec)
                                    {
                                        BeginInvoke((Action)(() => populateHistoryChat(HistoryChat)));
                                        BeginInvoke((Action)(() => populateFriendListView(n, send.idrec, send.idsender, HistoryChat, send.noti)));
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
                            default:
                                active = false;
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

        }
        public void OpenLF()
        {
            this.Close();
            FormLoginMain lf = new FormLoginMain();
            lf.Show();

        }

        private void populateHistoryChat(List<message> HistoryChat)
        {
            if (HistoryChat.Count == 0)
            {
                ChattingPanel.Controls.Clear();
            }
            else
            {
                int me = 0;
                int f = 0;
                ChattingPanel.Controls.Clear();
                ReceiverMessageContent[] FriendChatMess = new ReceiverMessageContent[HistoryChat.Count];
                SenderMessageContent[] MeChatMess = new SenderMessageContent[HistoryChat.Count];
                for (int i = 0; i < HistoryChat.Count; i++)
                {
                    if (HistoryChat[i].Idsender == IdSender)
                    {
                        MeChatMess[i] = new SenderMessageContent();
                        MeChatMess[i].ShowSeen = false;
                        MeChatMess[i].Message = HistoryChat[i].Messagecontent;

                        for (int j = 0; j < listFriendOfUser.Count; j++)
                        {
                            if (HistoryChat[i].Idreceiver == listFriendOfUser[j].Id)
                            {
                                MeChatMess[i].NameFriendChatWithMe = listFriendOfUser[j].Name;
                            }
                        }

                        ChattingPanel.Controls.Add(MeChatMess[i]);

                        me = 1;
                        f = 0;
                    }
                    else
                    {
                        FriendChatMess[i] = new ReceiverMessageContent();
                        FriendChatMess[i].ShowSeen = false;
                        for (int j = 0; j < listFriendOfUser.Count; j++)
                        {
                            if (HistoryChat[i].Idsender == listFriendOfUser[j].Id)
                            {
                                FriendChatMess[i].Username = listFriendOfUser[j].Name;
                                break;
                            }
                        }
                        FriendChatMess[i].Message = HistoryChat[i].Messagecontent;
                        ChattingPanel.Controls.Add(FriendChatMess[i]);
                        f = 1;
                        me = 0;
                    }
                }
                if (f == 1)
                {
                    if (checkSeenMessagerUsers.Count == 1)
                    {
                        FriendChatMess[HistoryChat.Count - 1].SeenMessage = "";
                    }
                    else
                    {
                        FriendChatMess[HistoryChat.Count - 1].SeenMessage = "";
                        //FriendChatMess[HistoryChat.Count - 1].SeenMessage = "You," + FriendChatMess[HistoryChat.Count - 1].Username.ToString() + "had seen";
                    }
                    FriendChatMess[HistoryChat.Count - 1].ShowSeen = true;

                    ChattingPanel.ScrollControlIntoView(FriendChatMess[HistoryChat.Count - 1]);
                }
                else
                {
                    if (checkSeenMessagerUsers.Count == 1)
                    {
                        MeChatMess[HistoryChat.Count - 1].SeenMessage = "Send";
                    }
                    else
                    {
                        MeChatMess[HistoryChat.Count - 1].SeenMessage = "Seen";
                        //MeChatMess[HistoryChat.Count - 1].SeenMessage = "You," + MeChatMess[HistoryChat.Count - 1].NameFriendChatWithMe.ToString() + "had seen";
                    }
                    MeChatMess[HistoryChat.Count - 1].ShowSeen = true;

                    ChattingPanel.ScrollControlIntoView(MeChatMess[HistoryChat.Count - 1]);
                }
            }

        }
        private void populateFriendListView(int n, int Noti, int OwnClient, List<message> M, bool noti)
        {

            if (Noti == 0)
            {
                flpListItem.Controls.Clear();
                for (int i = 0; i < listItem.Length; i++)
                {


                    listItem[i] = new ItemFriend();
                    listItem[i].ShowNoti = Color.Transparent;

                    listItem[i].Iduser = listFriendOfUser[i].Id;

                    

                    if (messlist.ContainsKey(listFriendOfUser[i].Id))
                    {
                        message temp = new message();
                        temp = messlist[listFriendOfUser[i].Id];
                        if (temp.Idsender == IdSender)
                        {
                            listItem[i].Lastmessage = "You: " + temp.Messagecontent.ToString();
                        }
                        else
                        {
                            listItem[i].Lastmessage = listFriendOfUser[i].Name + ": " + temp.Messagecontent.ToString();
                        }
                    }

                    if (CheckSeenMessage.ContainsKey(listFriendOfUser[i].Id))
                    {
                        if (!CheckSeenMessage[listFriendOfUser[i].Id])
                        {
                            listItem[i].ShowNoti = Color.Purple;
                            listItem[i].LastmessageColor = Color.White;
                        }
                    }
                    listItem[i].UserName = listFriendOfUser[i].Name;
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


                    listItem[i].LastmessageColor = Color.Gray;
                    listItem[i].Avatar = Resources.male_default;
                    listItem[i].Name = listItem[i].UserName;
                    flpListItem.Controls.Add(listItem[i]);

                    listItem[i].Click += new System.EventHandler(this.ClickEvent);


                }
            }
            else
            {

                if (noti == false)
                {
                    flpListItem.Controls.Clear();
                    for (int i = 0; i < listItem.Length; i++)
                    {


                        listItem[i] = new ItemFriend();
                        listItem[i].Iduser = listFriendOfUser[i].Id;
                        listItem[i].ShowNoti = Color.Transparent;
                        

                        if (messlist.ContainsKey(listFriendOfUser[i].Id))
                        {
                            message temp = new message();
                            temp = messlist[listFriendOfUser[i].Id];
                            if (temp.Idsender == IdSender)
                            {
                                listItem[i].Lastmessage = "You: " + temp.Messagecontent.ToString();
                            }
                            else
                            {
                                listItem[i].Lastmessage = listFriendOfUser[i].Name + ": " + temp.Messagecontent.ToString();
                            }
                        }
                        listItem[i].UserName = listFriendOfUser[i].Name;
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
                            listItem[i].ShowNoti = Color.Transparent;
                        }

                        listItem[i].LastmessageColor = Color.Gray;
                        listItem[i].Avatar = Resources.male_default;
                        listItem[i].Name = listItem[i].UserName;
                        flpListItem.Controls.Add(listItem[i]);

                        listItem[i].Click += new System.EventHandler(this.ClickEvent);
                        checkFlag = 2;

                    }
                }
                else
                {
                    flpListItem.Controls.Clear();
                    ItemFriend[] listItem = new ItemFriend[n];
                    for (int i = 0; i < listItem.Length; i++)
                    {
                        listItem[i] = new ItemFriend();
                        listItem[i].Iduser = listFriendOfUser[i].Id;

                        listItem[i].ShowNoti = Color.Transparent;

                        listItem[i].UserName = listFriendOfUser[i].Name;
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
                            if (OwnClient == IdSender)
                            {
                                listItem[i].ShowNoti = Color.Transparent;
                                if (messlist.ContainsKey(listFriendOfUser[i].Id))
                                {
                                    message temp = new message();
                                    temp = messlist[listFriendOfUser[i].Id];
                                    if (temp.Idsender == IdSender)
                                    {
                                        listItem[i].Lastmessage = "You: " + temp.Messagecontent.ToString();
                                        listItem[i].LastmessageColor = Color.Gray;
                                    }
                                    else
                                    {
                                        listItem[i].Lastmessage = listFriendOfUser[i].Name + ": " + temp.Messagecontent.ToString();
                                        listItem[i].LastmessageColor = Color.Gray;
                                    }
                                }
                            }
                            else
                            {
                                listItem[i].ShowNoti = Color.Purple;
                                if (messlist.ContainsKey(listFriendOfUser[i].Id))
                                {
                                    message temp = new message();
                                    temp = messlist[listFriendOfUser[i].Id];
                                    if (temp.Idsender == IdSender)
                                    {
                                        listItem[i].Lastmessage = "You: " + temp.Messagecontent.ToString();
                                        listItem[i].LastmessageColor = Color.White;
                                    }
                                    else
                                    {
                                        listItem[i].Lastmessage = listFriendOfUser[i].Name + ": " + temp.Messagecontent.ToString();
                                        listItem[i].LastmessageColor = Color.White;
                                    }
                                }
                            }
                        }
                        else
                        {
                            listItem[i].ShowNoti = Color.Transparent;
                            if (messlist.ContainsKey(listFriendOfUser[i].Id))
                            {
                                message temp = new message();
                                temp = messlist[listFriendOfUser[i].Id];
                                if (temp.Idsender == IdSender)
                                {
                                    listItem[i].Lastmessage = "You: " + temp.Messagecontent.ToString();
                                    listItem[i].LastmessageColor = Color.Gray;
                                }
                                else
                                {
                                    listItem[i].Lastmessage = listFriendOfUser[i].Name + ": " + temp.Messagecontent.ToString();
                                    listItem[i].LastmessageColor = Color.Gray;
                                }
                            }
                        }

                        listItem[i].Avatar = Resources.male_default;
                        listItem[i].Name = listItem[i].UserName;

                        flpListItem.Controls.Add(listItem[i]);

                        listItem[i].Click += new System.EventHandler(this.ClickEvent);
                    }
                }

            }
        }

        void ClickEvent(object sender, EventArgs e)
        {
            ChattingPanel.Show();
            SendMessagePanel.Show();
            ItemFriend obj = (ItemFriend)sender;

            obj.ShowNoti = Color.Transparent;
            IdRec = obj.Iduser;


            Packet.REQUESTHISTORYCHAT rqhc = new Packet.REQUESTHISTORYCHAT(IdSender, IdRec, false);
            string jsonString = JsonSerializer.Serialize(rqhc);
            Packet.Packet packet = new Packet.Packet("RequestHistoryChat", jsonString);
            sendJson(packet);



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

        }
        private void sendJson(object obj)
        {
            try
            {
                byte[] jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(obj);
                _client.Send(jsonUtf8Bytes, jsonUtf8Bytes.Length, SocketFlags.None);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void SendMessagebtn_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        [SecurityPermission(SecurityAction.Demand, ControlThread = true)]
        public void killthread(Thread trd) => trd.Interrupt();

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAllFriend a = new FormAllFriend();
            a.ShowDialog();
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            FormAllFriend al = new FormAllFriend();
            al.ShowDialog();
            
        }
    }
}
