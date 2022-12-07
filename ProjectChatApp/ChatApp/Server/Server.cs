﻿using System.Net;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Text.Json;
using System.Text.Json.Serialization;
using MySql.Data.MySqlClient;
using Server.BLL;
using Server.DB;
using Server.DTO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Packet;
using System.Net.NetworkInformation;
using Server.DAL;
using Microsoft.VisualBasic.Logging;
using Microsoft.Win32;
using System.Net.WebSockets;
using DTO.DTO;

namespace Server
{
    public partial class Server : Form
    {
        IPEndPoint iep;
        Socket server;
        List<int> listFriendOfUsserId = new List<int>();
        List<user> userlist;
        List<string> listUsernaemReponse = new List<string>();
        Dictionary<string, Socket> OnlineClientList;
        Dictionary<int, string> UserListFromDB;
        bool active = false;
        BLLUser BLLuser = new BLLUser();
        BLLMessage BLLmessage = new BLLMessage();
        BLLFriend BLLfriend = new BLLFriend();
        MySqlConnection conn = DB.dbconnect.getconnect();
        private Packet.Packet com;

        public Server()
        {
            InitializeComponent();
        }
        private void sendJson(Socket client, object obj)
        {
            byte[] jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(obj);
            client.Send(jsonUtf8Bytes, jsonUtf8Bytes.Length, SocketFlags.None);
        }
        private void KhoiTaoUser()
        {
            UserListFromDB = new Dictionary<int, string>();
            userlist = new List<user>();
            userlist = BLLuser.LoadAllUser();
            for (int i = 0; i < userlist.Count(); i++)
            {
                UserListFromDB.Add(userlist[i].Id, userlist[i].Email);
            }
            OnlineClientList = new Dictionary<string, Socket>();

        }

        /*private List<user> getAllUser()
        {
            userlist = new List<user>();
            userlist = DALuser.LoadAllUser();
            return userlist;
        }*/
        private void updateTotalUser()
        {
            TotalUsertxt.Text = UserListFromDB.Count().ToString();
        }

        private void updateOnlineUser()
        {
            OnlineUsertxt.Text = OnlineClientList.Count().ToString();

        }
        private void ThreadClient(Socket client)
        {
            try
            {
                bool tieptuc = true;
                while(tieptuc)
                {
                    string mess = "";
                    byte[] data = new byte[1024*20*1000];
                    //nhan thong tin tu client
                    int recv = client.Receive(data);

                    if (recv == 0) return;
                    string jsonString = Encoding.ASCII.GetString(data, 0, recv);
                    Packet.Packet? com = JsonSerializer.Deserialize<Packet.Packet>(jsonString);
                    AppendTextBox("Nhan duoc goi:" + com.mess + Environment.NewLine);
                    if (com != null)
                    {
                        if (com.content != null)
                        {
                            switch (com.mess)
                            {
                                case "SendMessage":
                                    SENDMESSAGE? sm = JsonSerializer.Deserialize<SENDMESSAGE>(com.content);                              
                                    if(sm!=null)
                                    {
                                        BLLmessage.addMessage(sm.idsender, sm.idrec, sm.contentmess, sm.url);
                                    }
                                    break;
                                case "Login":
                                    LOGIN? login = JsonSerializer.Deserialize<LOGIN>(com.content);
                                    if (login != null && login.username != null && login.pass != null)
                                    {
                                        mess = BLLuser.Login(login.username, login.pass);
                                        switch (mess)
                                        {
                                            case "khongduocdetrong":
                                                com = new Packet.Packet(mess, "CANCEL");
                                                sendJson(client, com);
                                                break;
                                            case "emaildetrong":
                                                com = new Packet.Packet(mess, "CANCEL");
                                                sendJson(client, com);
                                                break;
                                            case "dangnhapthatbai":
                                                com = new Packet.Packet(mess, "CANCEL");
                                                sendJson(client, com);
                                                break;
                                            case "taikhoanbikhoa":
                                                com = new Packet.Packet(mess, "CANCEL");
                                                sendJson(client, com);
                                                break;
                                            case "passdetrong":
                                                com = new Packet.Packet(mess, "CANCEL");
                                                sendJson(client, com);
                                                break;
                                            case "dangnhapthanhcong":
                                                //tra ve cho client thong tin dang nhap thanh cong
                                                user temp = new user();
                                                temp = BLLuser.getInfoUser(login.username);
                                                OnlineClientList.Add(temp.Email, client);
                                                BeginInvoke((Action)(() => updateOnlineUser()));

                                                BLLuser.updateonlinestatus(temp.Id, "online");
                                                //com = new Packet.Packet(mess, "OK");


                                                //------------------khanh-------------------------
                                                /*List<int> listFriendOfUsserId = BLLfriend.getFriendByID(temp.Id);
                                                List<user> listFriendOfUsser = new List<user>();
                                                foreach (int i in listFriendOfUsserId)
                                                {
                                                    user friend = new user();
                                                    friend = BLLuser.getInfoUserById(i);
                                                    listFriendOfUsser.Add(friend);
                                                }*/

                                                //-------------------khanh-------------------------

                                                List<user> listFriendOfUsser = new List<user>();
                                                listFriendOfUsser = getFriendofUser(temp.Id);


                                                List<user> listFriendRequestOfUsser = new List<user>();
                                                listFriendRequestOfUsser = getFriendRequestOfUser(temp.Id);

                                                AppendTextBox("listFriendRequestOfUsser " + listFriendRequestOfUsser.Count());


                                                List<int> listUsernameReponseOffById = BLLfriend.getFriendReponseOffByID(temp.Id);
                                                List<string> listUsernameReponseOff = new List<string>();
                                                foreach (int i in listUsernameReponseOffById)
                                                {
                                                    user userTmp = BLLuser.getInfoUserById(i);
                                                    listUsernameReponseOff.Add(userTmp.Email);
                                                }

                                                Packet.LOGINSUCESS lgsucess = new Packet.LOGINSUCESS(temp.Id, temp.Email, temp.Password, temp.Name, temp.Sex, temp.Bd, temp.Online_status, temp.Is_active, temp.Server_block, listFriendOfUsser, listFriendRequestOfUsser, listUsernameReponseOff);
                                                string ResultJson = JsonSerializer.Serialize(lgsucess);
                                                com = new Packet.Packet(mess, ResultJson);
                                                //tra thong tin ve cho client mo len mainchatapp
                                                sendJson(client, com);
                                                AppendTextBox("IP: " + client.AddressFamily.ToString() +
                                                    client.RemoteEndPoint.ToString() + " voi username la " +
                                                    login.username + "da ket noi toi server!" + Environment.NewLine);

                                                //send status user (online or offline cho mainchatapp

                                                SendDataToMainChatApp(OnlineClientList, temp.Email, (int)temp.Id);

                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                    break;

                                case "Register":
                                    REGISTER? register = JsonSerializer.Deserialize<REGISTER>(com.content);
                                    if (register != null)
                                    {
                                        mess = BLLuser.addAcount(register.username, register.pass, register.confirmpass, register.name, (int)register.sex, register.bd);
                                        switch (mess)
                                        {
                                            case "khongduocdetrong":
                                                com = new Packet.Packet(mess, "CANCEL");
                                                sendJson(client, com);
                                                break;
                                            case "emailtrong":
                                                com = new Packet.Packet(mess, "CANCEL");
                                                sendJson(client, com);
                                                break;
                                            case "passwordtrong":
                                                com = new Packet.Packet(mess, "CANCEL");
                                                sendJson(client, com);
                                                break;
                                            case "confirmpasstrong":
                                                com = new Packet.Packet(mess, "CANCEL");
                                                sendJson(client, com);
                                                break;
                                            case "nametrong":
                                                com = new Packet.Packet(mess, "CANCEL");
                                                sendJson(client, com);
                                                break;
                                            case "saidinhdangemail":
                                                com = new Packet.Packet(mess, "CANCEL");
                                                sendJson(client, com);
                                                break;
                                            case "passwordvaconfirmkhongtrung":
                                                com = new Packet.Packet(mess, "CANCEL");
                                                sendJson(client, com);
                                                break;
                                            case "themuserthanhcong":
                                                updateTotalUser();
                                                //sua o day
                                                user temp = new user();
                                                temp = BLLuser.getInfoUser(register.username);
                                                UserListFromDB.Add(temp.Id, register.username);
                                                updateTotalUser();
                                                com = new Packet.Packet(mess, "OK");
                                                sendJson(client, com);
                                                AppendTextBox(register.username + " da dang ky thanh cong!!!" + Environment.NewLine);
                                                //tieptuc = false;
                                                break;
                                            default:
                                                break;
                                        }

                                    }
                                    break;

                                case "ExitApp":
                                    EXIT? exit = JsonSerializer.Deserialize<EXIT>(com.content);
                                    if (exit != null)
                                    {
                                        string s = "";
                                        user temp = new user();
                                        temp = BLLuser.getInfoUser(exit.username);
                                        BLLuser.updateonlinestatus(temp.Id, "offline");
                                        List<user> listFriendOfUsser = new List<user>();
                                        listFriendOfUsser = getFriendofUser(temp.Id);
                                        SendDataToMainChatApp(OnlineClientList, temp.Email, (int)temp.Id);



                                        com = new Packet.Packet("OK", "LOGOUT");
                                        AppendTextBox(exit.username + " da log out!!!" + Environment.NewLine);
                                        sendJson(client, com);
                                       // client.Close();
                                        /*foreach (KeyValuePair<string, Socket> item in OnlineClientList)
                                        {
                                            var itemKey = item.Key;
                                            var itemValue = item.Value;
                                            if (itemKey.Equals(exit.username))
                                            {
                                                try
                                                {
                                                    itemValue.Shutdown(SocketShutdown.Both);
                                                    break;
                                                }
                                                catch (Exception e)
                                                {
                                                    MessageBox.Show(e.ToString());
                                                    throw;
                                                }
                                            }
                                        }*/
                                        OnlineClientList.Remove(exit.username);
                                        BeginInvoke((Action)(() => updateOnlineUser()));
                                        
                                        tieptuc = false;
                                        //client.Close();
                                    }
                                    break;

                                case "RequestHistoryChat":                    
                                    Socket socket = null;
                                    List<message> listHostoryChat = new List<message>();
                                    REQUESTHISTORYCHAT? rq = JsonSerializer.Deserialize<REQUESTHISTORYCHAT>(com.content);
                                    user usend = new user();
                                    user urev = new user();
                                    usend = BLLuser.getInfoUserById(rq.idsender);
                                    urev = BLLuser.getInfoUserById(rq.idrec);
                                    listHostoryChat = BLLmessage.getHistoryChat(rq.idsender, rq.idrec);
                                    Packet.SENDHISTORYCHAT send = new Packet.SENDHISTORYCHAT(listHostoryChat);
                                    string Json = JsonSerializer.Serialize(send);
                                    com = new Packet.Packet("SendHistoryChat", Json);
                                    if(OnlineClientList.ContainsKey(usend.Email))
                                    {
                                        socket = OnlineClientList[usend.Email];
                                        sendJson(socket, com);
                                        AppendTextBox("Da gui history chat den id " + usend.Id + Environment.NewLine);
                                    }
                                    if(OnlineClientList.ContainsKey(urev.Email))
                                    {
                                        socket = OnlineClientList[urev.Email];
                                        sendJson(socket, com);
                                        AppendTextBox("Da gui history chat den id " + urev.Id + Environment.NewLine);
                                    }
                                    //sendJson(client, Json);
                                    
                                    break;

                                ///Khanh---------------------
                                case "FrientRequest":
                                    SENFRIENDREQUEST? frientRequest = JsonSerializer.Deserialize<SENFRIENDREQUEST>(com.content);
                                    if (frientRequest != null)
                                    {
                                        //lấy được id kiểm tra 
                                        
                                        foreach (user user in userlist)
                                        {
                                            if (user.Email.Equals(frientRequest.usernameRequest))  //có nằm trong danh sách user 
                                            {
                                                user userCheck = BLLuser.getInfoUser(frientRequest.usernameRequest); //lấy user đó kiểm tra 2 điều kiện tiếp theo
                                                List<int> listFriend = BLLfriend.getFriendByID((int)frientRequest.id);        //lấy all bạn của user gửi lời kết bạn
                                                List<int> listFriendRequest = BLLfriend.getFriendRequestByID((int)frientRequest.id);
                                                List<int> listMyRequest = BLLfriend.getMyRequestByID((int)frientRequest.id);
                                                if (!listFriend.Contains(userCheck.Id) && !listFriendRequest.Contains(userCheck.Id) 
                                                    && !listMyRequest.Contains(userCheck.Id) && (int)frientRequest.id != userCheck.Id) // nếu user request k nằm trong danh sách bạn và k nằm trong danh sách đã gửi gửi cầu kết bạn đến mình
                                                {
                                                    BLLfriend.addFriend((int)frientRequest.id, userCheck.Id, 1);
                                                    com = new Packet.Packet("FrientRequest", "Send friend request success");
                                                    AppendTextBox(frientRequest.usernameRequest + " server nhan duoc roi!!!" + Environment.NewLine);
                                                    sendJson(client, com);
                                                }
                                                else
                                                {
                                                    com = new Packet.Packet("NoFrientRequest", "Send friend request no success");
                  
                                                    sendJson(client, com);
                                                }
                                            }
                                            else
                                            {

                                                com = new Packet.Packet("NoFrientRequest", "Send friend request no success");
                                                sendJson(client, com);
                                            }
                                            
                                        }
                                    }
                                    break;
                                case "FriendReponse":  // user được yêu cầu kb (idReponse) phản hồi user yêu cầu kb (id Request)
                                    SENFRIENDREPONSE? frientReponse = JsonSerializer.Deserialize<SENFRIENDREPONSE>(com.content);
                                    user userRequest = BLLuser.getInfoUserById(frientReponse.idRequest);
                                    user userReponse = BLLuser.getInfoUserById(frientReponse.idReponse);
                                    if (OnlineClientList.ContainsKey(userRequest.Email))   //kiểm tra xem thằng request có online k?
                                    {
                                        socket = OnlineClientList[userRequest.Email];
                                        com = new Packet.Packet("FrientResponseOnline", userReponse.Email+" accept friend request");
                                        sendJson(socket, com);
                                        BLLfriend.addFriend(userReponse.Id, userRequest.Id, 1);
                                        AppendTextBox("FiendReponseOnl " + userRequest.Id + ":" + userReponse.Id + Environment.NewLine);
                                    }
                                    else
                                    {
                                        BLLfriend.addFriend(userReponse.Id, userRequest.Id, 0);
                                    }

                                    /*socket = OnlineClientList[userRequest.Email];
                                    com = new Packet.Packet("FrientResponseOffline", userReponse.Email + " accept friend request");
                                    sendJson(socket, com);
                                    AppendTextBox("FiendReponseOff " + frientReponse.idReponse + ":" + frientReponse.idRequest + Environment.NewLine);
                                    */


                                    //nếu như k online luu friend vào list gởi gói phản hồi khi offline
                                   
                                    //bên cliet đăng nhập nhận gói
                                   

                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }

                client.Shutdown(SocketShutdown.Both);
                client.Close();
            }
            catch (Exception)
            {

                throw;
            }
            

        }

        public List<user> getFriendofUser(int id)
        {
            List<int> listFriendOfUsserId = BLLfriend.getFriendByID(id);
            List<user> listFriendOfUsser = new List<user>();
            foreach (int i in listFriendOfUsserId)
            {
                user friend = new user();
                friend = BLLuser.getInfoUserById(i);
                listFriendOfUsser.Add(friend);
            }
            return listFriendOfUsser;
        }

        //khanh---------------
        public List<user> getFriendRequestOfUser(int id)
        {
            List<int> listFriendRequestOfUserId = BLLfriend.getFriendRequestByID(id);
            List<user> listFriendRequestOfUser = new List<user>();
            foreach (int i in listFriendRequestOfUserId)
            {
                user friend = new user();
                friend = BLLuser.getInfoUserById(i);
                listFriendRequestOfUser.Add(friend);
            }
            return listFriendRequestOfUser;
        }
        //------------------
        private List<string> getListUserOnlineFromAnotherSocket(Dictionary<string, Socket> OnlineClientList)
        {
            List<string> list = new List<string>();
            foreach (KeyValuePair<string, Socket> item in OnlineClientList)
            {
                var itemKey = item.Key;
                list.Add(itemKey);
            }
            return list;
        }
        private void SendDataToMainChatApp(Dictionary<string, Socket> OnlineClientList, string email, int id)
        {
            List<user> temp = new List<user>();
            temp = getFriendofUser(id);
            user u = new user();
            u = BLLuser.getInfoUser(email);

            if (OnlineClientList.Count > 1)
            {
                foreach (KeyValuePair<string, Socket> item in OnlineClientList)
                {
                    List<string> list = getListUserOnlineFromAnotherSocket(OnlineClientList);
                    var itemKey = item.Key;
                    var itemValue = item.Value;
                    for (int i = 0; i < temp.Count; i++)
                    {
                        if (itemKey == temp[i].Email)
                        {
                            byte[] data = new byte[1024];
                            Packet.SENDUSERSTATUS senduserstatus = new Packet.SENDUSERSTATUS(u);
                            string jsonString = JsonSerializer.Serialize(senduserstatus);
                            com = new Packet.Packet("StatusUser", jsonString);
                            sendJson(item.Value, com);
                        }
                    }
                }
            }
        }


        private void ServerWaitConnect()
        {
            while (active)
            {
                try
                {
                    Socket client = server.Accept();
                    var t = new Thread(() => ThreadClient(client));
                    t.Start();
                }
                catch (Exception)
                {
                    active = false;
                }
            }
        }
        private void Startbtn_Click(object sender, EventArgs e)
        {
            active = true;
            iep = new IPEndPoint(IPAddress.Parse(IPtxt.Text), int.Parse(Porttxt.Text));
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(iep);
            server.Listen(10);
            Logtxt.Text = "Cho ket noi den client" + Environment.NewLine;

            Thread trd = new Thread(new ThreadStart(this.ServerWaitConnect));
            trd.IsBackground = true;
            trd.Start();
        }

        private void Server_Load(object sender, EventArgs e)
        {

            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    //Console.WriteLine(ni.Name);
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            IPtxt.Text = ip.Address.ToString();
                        }
                    }
                }
            }
            KhoiTaoUser();
            updateTotalUser();
            updateOnlineUser();
        }

        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            Logtxt.Text += value;
        }

        private void Stopbtn_Click(object sender, EventArgs e)
        {
            active = false;
            try
            {
                if (!active)
                {
                    server.Close();
                }
                Close();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}