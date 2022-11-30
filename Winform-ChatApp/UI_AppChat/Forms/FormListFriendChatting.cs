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

namespace UI_AppChat
{
    public partial class FormListFriendChatting : Form
    {
        private Form activeForm;
        int checkFlag = 1;
        int IdRec = 0;
        int IdSender = 0;


        Thread trd;
        IPEndPoint iep;
        Socket _client;
        string email = null;
        string name_user = null;
        bool active = false;
        int n;
        List<user> listFriendOfUser = new List<user>();
        List<message> HistoryChat = new List<message>();

        public FormListFriendChatting()
        {
            InitializeComponent();
            
        }
        public FormListFriendChatting(IPEndPoint ipep, int id, string emailuser, string name, int num, Socket client, List<user> listFriendOfUser)
        {
            InitializeComponent();
            active = true;
            iep = ipep;
            _client = client;
            email = emailuser;
            IdSender = id;
            name_user = name;
            n = listFriendOfUser.Count;
            this.listFriendOfUser = listFriendOfUser;
            populateFriendListView(n,0);
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
                    int size = 1024 * 1000 * 3;
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
                                BeginInvoke((Action)(() => populateFriendListView(n, 0)));
                                //MessageBox.Show(u.Name);                                                             
                                break;
                            case "SendHistoryChat": //lay lich su chat box giua 2 nguoi dung
                                SENDHISTORYCHAT? send = JsonSerializer.Deserialize<SENDHISTORYCHAT>(com.content);
                                HistoryChat = send.listHistoryChat;
                                //MessageBox.Show(HistoryChat.Count.ToString());
                                if (send.idrec == IdRec)
                                {
                                    BeginInvoke((Action)(() => populateHistoryChat(HistoryChat)));
                                }
                                else
                                {
                                    BeginInvoke((Action)(() => populateFriendListView(n, send.idsender)));
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
            FormLoginMain lf = new FormLoginMain();
            lf.Show();
            //MessageBox.Show("Thread da chet");

        }

        private void populateHistoryChat(List<message> HistoryChat)
        {
            if (HistoryChat.Count == 0)
            {
                ChattingPanel.Controls.Clear();
            }
            else
            {
                ChattingPanel.Controls.Clear();
                ReceiverMessageContent[] FriendChatMess = new ReceiverMessageContent[HistoryChat.Count];
                SenderMessageContent[] MeChatMess = new SenderMessageContent[HistoryChat.Count];
                for (int i = 0; i < HistoryChat.Count; i++)
                {
                    if (HistoryChat[i].Idsender == IdSender)
                    {
                        MeChatMess[i] = new SenderMessageContent();
                        MeChatMess[i].Message = HistoryChat[i].Messagecontent;
                        ChattingPanel.Controls.Add(MeChatMess[i]);
                        ChattingPanel.ScrollControlIntoView(MeChatMess[i]);
                    }
                    else
                    {
                        FriendChatMess[i] = new ReceiverMessageContent();
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
                        ChattingPanel.ScrollControlIntoView(FriendChatMess[i]);
                    }
                }
            }

        }
        private void populateFriendListView(int n, int Noti)
        {

            if (Noti == 0)
            {
                flpListItem.Controls.Clear();
                ItemFriend[] listItem = new ItemFriend[n];
                for (int i = 0; i < listItem.Length; i++)
                {


                    listItem[i] = new ItemFriend();
                    listItem[i].ShowNoti = false;
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


                    listItem[i].Lastmessage = "Hello World";
                    listItem[i].LastmessageColor = Color.Gray;
                    listItem[i].Avatar = Resources.male_default;
                    //list[i].Click += (sender, e) => TestEvent(sender, e);
                    listItem[i].Name = listItem[i].UserName;
                    listItem[i].Iduser = listFriendOfUser[i].Id;
                    flpListItem.Controls.Add(listItem[i]);

                    listItem[i].Click += new System.EventHandler(this.ClickEvent);


                }
            }
            else
            {

                if (checkFlag == 1)
                {
                    flpListItem.Controls.Clear();
                    ItemFriend[] listItem = new ItemFriend[n];
                    for (int i = 0; i < listItem.Length; i++)
                    {


                        listItem[i] = new ItemFriend();
                        listItem[i].ShowNoti = false;
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


                        listItem[i].Lastmessage = "Hello World";
                        listItem[i].LastmessageColor = Color.Gray;
                        listItem[i].Avatar = Resources.male_default;
                        //list[i].Click += (sender, e) => TestEvent(sender, e);
                        listItem[i].Name = listItem[i].UserName;
                        listItem[i].Iduser = listFriendOfUser[i].Id;
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
                        if (listItem[i].Iduser == Noti)
                        {
                            listItem[i].ShowNoti = true;
                        }
                        else
                        {
                            listItem[i].ShowNoti = false;
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


                        listItem[i].Lastmessage = "Hello World";
                        listItem[i].LastmessageColor = Color.Gray;
                        listItem[i].Avatar = Resources.male_default;
                        //list[i].Click += (sender, e) => TestEvent(sender, e);
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
            obj.ShowNoti = false;
            IdRec = obj.Iduser;


            Packet.REQUESTHISTORYCHAT rqhc = new Packet.REQUESTHISTORYCHAT(IdSender, IdRec);
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

            Packet.REQUESTHISTORYCHAT rqhc = new Packet.REQUESTHISTORYCHAT(IdSender, IdRec);
            string jsonString1 = JsonSerializer.Serialize(rqhc);
            Packet.Packet packet1 = new Packet.Packet("RequestHistoryChat", jsonString1);
            sendJson(packet1);

            populateHistoryChat(HistoryChat);
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

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
