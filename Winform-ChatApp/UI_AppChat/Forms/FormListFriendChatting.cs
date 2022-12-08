using DTO.DTO;
using Packet;
using Server.DTO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using UI_AppChat.Forms;
using UI_AppChat.Properties;
using UI_AppChat.UserControls;

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
        bool active = false;
        int n;
        List<user> listFriendOfUser = new List<user>();
        List<message> HistoryChat = new List<message>();
        List<message> HistoryImageChat = new List<message>();
        Dictionary<int, message> messlist = new Dictionary<int, message>();
        ItemFriend[] listItem;

        //image
        //private int size = 1024000;
        private OpenFileDialog y;
        private bool initialpic = false;

        public FormListFriendChatting()
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\Public\Pictures\demo.JPG");
            InitializeComponent();

        }
        public FormListFriendChatting(IPEndPoint ipep, int id, string emailuser, string name, int num, Socket client, List<user> listFriendOfUser, Dictionary<int, message> messlist)
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
            this.messlist = messlist;
            listItem = new ItemFriend[n];
            populateFriendListView(n, 0, 0, HistoryChat, false);

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
                    int size = 1024 * 1000 * 500;
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
                                //MessageBox.Show(u.Name);                                                             
                                break;
                            case "SendHistoryChat": //lay lich su chat box giua 2 nguoi dung
                                SENDHISTORYCHAT? send = JsonSerializer.Deserialize<SENDHISTORYCHAT>(com.content);
                                HistoryChat = send.listHistoryChat;
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
                                    BeginInvoke((Action)(() => populateFriendListView(n, send.idsender, send.idsender, HistoryChat, send.noti)));
                                }
                                break;
                            case "SendImageToClient": //lay lich su chat box hinh anh giua 2 nguoi dung
                                SENDHISTORYCHAT? nhanHInh = JsonSerializer.Deserialize<SENDHISTORYCHAT>(com.content);
                                SenderMessageContent(nhanHInh.lastmess);
                                HistoryChat = nhanHInh.listHistoryChat;
                                if (messlist.ContainsKey(nhanHInh.idrec))
                                {
                                    messlist[nhanHInh.idrec] = nhanHInh.lastmess;
                                }
                                else
                                if (messlist.ContainsKey(nhanHInh.idsender))
                                {
                                    messlist[nhanHInh.idsender] = nhanHInh.lastmess;
                                }

                                if (nhanHInh.idrec == IdRec)
                                {
                                    BeginInvoke((Action)(() => populateHistoryImageChat(HistoryChat)));
                                    BeginInvoke((Action)(() => populateFriendListView(n, nhanHInh.idrec, nhanHInh.idsender, HistoryChat, nhanHInh.noti)));

                                }
                                else
                                {
                                    BeginInvoke((Action)(() => populateFriendListView(n, nhanHInh.idsender, nhanHInh.idsender, HistoryChat, nhanHInh.noti)));
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
            //BeginInvoke((Action)(() => OpenLF()));

        }

        private void SenderMessageContent(message? lastmess)
        {
            byte[] hinh = new byte[1024 * 1000 * 5];
            hinh = Encoding.ASCII.GetBytes(lastmess.ToString());
            //ChattingPanel
        }

        //private void NewThread()
        //{
        //    try
        //    {
        //        while (active)
        //        {
        //            int size = 1024 * 1000 *3 ;
        //            byte[] data = new byte[size];
        //            int recv = _client.Receive(data);
        //            string jsonString = Encoding.ASCII.GetString(data, 0, recv);
        //            jsonString.Replace("\\u0022", "\"");
        //            Packet.Packet com = JsonSerializer.Deserialize<Packet.Packet>(jsonString);

        //            if (com != null)
        //            {
        //                switch (com.mess)
        //                {
        //                    case "StatusUser":
        //                        SENDUSERSTATUS? senduserstatusonline = JsonSerializer.Deserialize<SENDUSERSTATUS>(com.content);
        //                        for (int i = 0; i < listFriendOfUser.Count(); i++)
        //                        {
        //                            if (listFriendOfUser[i].Email == senduserstatusonline.u.Email)
        //                            {
        //                                listFriendOfUser[i].Online_status = senduserstatusonline.u.Online_status;
        //                                break;
        //                            }
        //                        }
        //                        //muốn thay đổi 1 thứ gì đó không đồng bộ 
        //                        BeginInvoke((Action)(() => populateFriendListView(n, 0, 0, HistoryChat, false)));
        //                        //MessageBox.Show(u.Name);                                                             
        //                        break;
        //                    case "SendHistoryChat": //lay lich su chat box giua 2 nguoi dung
        //                        SENDHISTORYCHAT? send = JsonSerializer.Deserialize<SENDHISTORYCHAT>(com.content);
        //                        HistoryChat = send.listHistoryChat;
        //                        if (messlist.ContainsKey(send.idrec))
        //                        {
        //                            messlist[send.idrec] = send.lastmess;
        //                        }
        //                        else
        //                        if (messlist.ContainsKey(send.idsender))
        //                        {
        //                            messlist[send.idsender] = send.lastmess;
        //                        }

        //                        if (send.idrec == IdRec)
        //                        {
        //                            BeginInvoke((Action)(() => populateHistoryChat(HistoryChat)));
        //                            BeginInvoke((Action)(() => populateFriendListView(n, send.idrec, send.idsender, HistoryChat, send.noti)));

        //                        }
        //                        else
        //                        {
        //                            BeginInvoke((Action)(() => populateFriendListView(n, send.idsender, send.idsender, HistoryChat, send.noti)));
        //                        }
        //                        break;
        //                    case "SendHistoryImageChat": //lay lich su chat box hinh anh giua 2 nguoi dung
        //                        SENDHISTORYCHAT? send2 = JsonSerializer.Deserialize<SENDHISTORYCHAT>(com.content);
        //                        HistoryChat = send2.listHistoryChat;
        //                        if (messlist.ContainsKey(send2.idrec))
        //                        {
        //                            messlist[send2.idrec] = send2.lastmess;
        //                        }
        //                        else
        //                        if (messlist.ContainsKey(send2.idsender))
        //                        {
        //                            messlist[send2.idsender] = send2.lastmess;
        //                        }

        //                        if (send2.idrec == IdRec)
        //                        {
        //                            BeginInvoke((Action)(() => populateHistoryImageChat(HistoryChat)));
        //                            BeginInvoke((Action)(() => populateFriendListView(n, send2.idrec, send2.idsender, HistoryChat, send2.noti)));

        //                        }
        //                        else
        //                        {
        //                            BeginInvoke((Action)(() => populateFriendListView(n, send2.idsender, send2.idsender, HistoryChat, send2.noti)));
        //                        }
        //                        break;
        //                    case "OK":
        //                        active = false;
        //                        break;

        //                    default:
        //                        active = false;
        //                        break;


        //                }
        //            }
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.ToString());
        //        active = false;
        //        throw;
        //    }
        //    //BeginInvoke((Action)(() => OpenLF()));

        //}

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
        private void populateHistoryImageChat(List<message> HistoryChat)
        {
            byte[] data = new byte[10240000];
            int size = 10240000;
            if (HistoryChat.Count == 0)
            {
                ChattingPanel.Controls.Clear();
            }
            else
            {
                ChattingPanel.Controls.Clear();
                ReceiverMessageImageContent[] FriendChatMess = new ReceiverMessageImageContent[HistoryChat.Count];
                SenderMessageImageContent[] MeChatMess = new SenderMessageImageContent[HistoryChat.Count];
                for (int i = 0; i < HistoryChat.Count; i++)
                {
                    if (HistoryChat[i].Idsender == IdSender)
                    {
                        MeChatMess[i] = new SenderMessageImageContent();
                        MeChatMess[i].Message = HistoryChat[i].Messagecontent;
                        data = Encoding.ASCII.GetBytes(MeChatMess[i].Message);
                        MemoryStream ms = new MemoryStream(data);
                        //MessageBox.Show(ms.ToString());
                        Image returnImage = Image.FromStream(ms);
                        MeChatMess[i].GetImage = returnImage;
                        ChattingPanel.Controls.Add(MeChatMess[i]);
                        ChattingPanel.ScrollControlIntoView(MeChatMess[i]);
                    }
                    else
                    {
                        FriendChatMess[i] = new ReceiverMessageImageContent();
                        for (int j = 0; j < listFriendOfUser.Count; j++)
                        {
                            if (HistoryChat[i].Idsender == listFriendOfUser[j].Id)
                            {
                                FriendChatMess[i].Username = listFriendOfUser[j].Name;
                                break;
                            }
                        }
                        FriendChatMess[i].Message = HistoryChat[i].Messagecontent;
                        data = Encoding.ASCII.GetBytes(FriendChatMess[i].Message);
                        MemoryStream ms = new MemoryStream(data);
                        Image returnImage = Image.FromStream(ms);
                        FriendChatMess[i].GetImage = returnImage;
                        ChattingPanel.Controls.Add(FriendChatMess[i]);
                        ChattingPanel.ScrollControlIntoView(FriendChatMess[i]);
                    }
                }
            }

        }
        private void populateFriendListView(int n, int Noti, int OwnClient, List<message> M, bool noti)
        {

            if (Noti == 0)
            {
                flpListItem.Controls.Clear();
                //ItemFriend[] listItem = new ItemFriend[n];
                for (int i = 0; i < listItem.Length; i++)
                {


                    listItem[i] = new ItemFriend();
                    listItem[i].ShowNoti = Color.Transparent;
                    listItem[i].Iduser = listFriendOfUser[i].Id;

                    listItem[i].UserName = listFriendOfUser[i].Name;
                    listItem[i].UsernameColor = Color.Silver;

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
                    //list[i].Click += (sender, e) => TestEvent(sender, e);
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
                        listItem[i].UserName = listFriendOfUser[i].Name;
                        listItem[i].UsernameColor = Color.Silver;

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
                        //list[i].Click += (sender, e) => TestEvent(sender, e);
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
            obj.ShowNoti = Color.Transparent;
            IdRec = obj.Iduser;


            Packet.REQUESTHISTORYCHAT rqhc = new Packet.REQUESTHISTORYCHAT(IdSender, IdRec, false);
            string jsonString = JsonSerializer.Serialize(rqhc);
            Packet.Packet packet = new Packet.Packet("RequestHistoryImageChat", jsonString);
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

            Packet.REQUESTHISTORYCHAT rqhc = new Packet.REQUESTHISTORYCHAT(IdSender, IdRec, true);
            string jsonString1 = JsonSerializer.Serialize(rqhc);
            Packet.Packet packet1 = new Packet.Packet("RequestHistoryChat", jsonString1);
            sendJson(packet1);

            //populateHistoryChat(HistoryChat);
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
        //Broswe Button
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            y = new OpenFileDialog();
            y.Title = "pic selection";
            y.InitialDirectory = "c:\\";
            y.Filter = "all files (*.*)|*.*|image files(*.jpg,*.bmp,*.gif)|*.jpg;*.bmp;*.gif;*.png";
            y.FilterIndex = 2;
            if (y.ShowDialog() == DialogResult.OK)
            { pictureBox1.Image = Image.FromFile(y.FileName); }

            initialpic = false;
        }

        private void sendImageButton_Click(object sender, EventArgs e)
        {

            FileInfo fileinfo;
            byte[] message;
            FileStream fs;

            if (initialpic == true)
            {
                fileinfo = new FileInfo(@"C:\Users\Public\Pictures\demo.JPG");
                message = new byte[fileinfo.Length];
                fs = new FileStream(@"C:\Users\Public\Pictures\demo.JPG", FileMode.Open, FileAccess.Read);
            }
            else
            {
                fileinfo = new FileInfo(y.FileName);
                message = new byte[fileinfo.Length];
                fs = new FileStream(y.FileName, FileMode.Open, FileAccess.Read);
            }

            fs.Read(message, 0, message.Length);
            fs.Close();
            GC.ReRegisterForFinalize(fileinfo);
            GC.ReRegisterForFinalize(fs);
            //Chuyển byte về string để lưu vào db
            String mess = BitConverter.ToString(message);
            String path = fileinfo.ToString();
            ///
            Packet.SENDIMAGE sendImage = new Packet.SENDIMAGE(IdSender, IdRec, path, mess);
            string jsonString = JsonSerializer.Serialize(sendImage);
            Packet.Packet packet = new Packet.Packet("SendImage", jsonString);
            sendJson(packet);
            pictureBox1 = null;

            Packet.REQUESTHISTORYIMAGECHAT rqhc = new Packet.REQUESTHISTORYIMAGECHAT(IdSender, IdRec, true);
            string jsonString1 = JsonSerializer.Serialize(rqhc);
            Packet.Packet packet1 = new Packet.Packet("returnImage", jsonString1);
            sendJson(packet1);
            //client.BeginSend(message, 0, message.Length, SocketFlags.None,
            //            new AsyncCallback(SendData), client);
        }
        public void SendMessage2()
        {

            string mess = Messagetxt.Text;

            Packet.SENDMESSAGE sendmess = new Packet.SENDMESSAGE(IdSender, IdRec, mess, 0.ToString());
            string jsonString = JsonSerializer.Serialize(sendmess);
            Packet.Packet packet = new Packet.Packet("SendMessage", jsonString);
            sendJson(packet);
            // MessageBox.Show("ID gui:" + IdSender + "ID nhan:" + IdRec + "ND:" + packet.content);
            Messagetxt.Text = "";

            Packet.REQUESTHISTORYCHAT rqhc = new Packet.REQUESTHISTORYCHAT(IdSender, IdRec, true);
            string jsonString1 = JsonSerializer.Serialize(rqhc);
            Packet.Packet packet1 = new Packet.Packet("RequestHistoryChat", jsonString1);
            sendJson(packet1);

            //populateHistoryChat(HistoryChat);
        }
    }
}
