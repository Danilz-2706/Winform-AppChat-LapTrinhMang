using System.Net;
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

namespace Server
{   
    public partial class Server : Form
    {
        IPEndPoint iep;
        Socket server;
        Dictionary<string, Socket> OnlineClientList;
        Dictionary<string, string> UserListFromDB;
        bool active = false;
        BLLUser BLLuser = new BLLUser();
        MySqlConnection conn = DB.dbconnect.getconnect();
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
            UserListFromDB = new Dictionary<string, string>();
            List<user> userlist = new List<user>();
            userlist = BLLuser.LoadAllUser();
            for(int i=0;i<userlist.Count();i++)
            {
                UserListFromDB.Add(userlist[i].Email, userlist[i].Password);
            }
            OnlineClientList = new Dictionary<string, Socket>();

        }

        private void ThreadClient(Socket client)
        {
            string mess="";
            byte[] data = new byte[1024];
            //nhan thong tin tu client
            int recv = client.Receive(data);
            if (recv == 0) return;
            string jsonString = Encoding.ASCII.GetString(data, 0, recv);
            Packet.Packet? com = JsonSerializer.Deserialize<Packet.Packet>(jsonString);
            if(com!=null)
            { 
                if(com.content != null)
                {
                    switch (com.mess)
                    {
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
                                    case "passdetrong":
                                        com = new Packet.Packet(mess, "CANCEL");
                                        sendJson(client, com);
                                        break;
                                    case "dangnhapthanhcong":
                                        com = new Packet.Packet(mess, "OK");
                                        sendJson(client, com);
                                        AppendTextBox(login.username + "da ket noi toi server!" + Environment.NewLine);
                                        break;
                                    default:
                                        break;
                                }
                            }
                            break;

                        case "Register":
                            REGISTER? register = JsonSerializer.Deserialize<REGISTER>(com.content);
                            if(register != null)
                            {
                                mess = BLLuser.addAcount(register.username,register.pass,register.confirmpass,register.name, (int)register.sex,register.bd);
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
                                        com = new Packet.Packet(mess, "OK");
                                        sendJson(client, com);
                                        AppendTextBox(register.username + " da dang ky thanh cong!!!" + Environment.NewLine);

                                        break;                              
                                    default:
                                        break;
                                }

                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            
        }



        private void ServerWaitConnect()
        {
            while(active)
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
                    throw;
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
                //khi nào cắm mạng LAN thì xài dòng này:
                //if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
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
    }
}