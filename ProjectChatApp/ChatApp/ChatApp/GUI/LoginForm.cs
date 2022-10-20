
using ChatApp.GUI;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Math.Field;
using Packet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp.GUI
{
    public partial class LoginForm : Form
    {
        IPEndPoint iep;
        string username = null;
        Socket server;
        Socket client;
        bool flag = false;
        bool thoat = false;
        public LoginForm()
        {
            InitializeComponent();
          
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
       

       

        

       

        private void Exit_Click(object sender, EventArgs e)
        {         
            
            this.Close();
            //Environment.Exit(1);
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            Usertxt.Clear();
            Passwordtxt.Clear();
            Usertxt.Focus();
        }

       

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RegisterForm registerForm = new RegisterForm();
            registerForm.Visible = true;
            
           
        }

       
        private void sendJson(object obj)
        {
            byte[] jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(obj);
            client.Send(jsonUtf8Bytes, jsonUtf8Bytes.Length, SocketFlags.None);
        }
       
        private void LoginConnect()
        {
            byte[] data = new byte[1024];
            Packet.LOGIN login = new Packet.LOGIN(Usertxt.Text, Passwordtxt.Text);
            username = Usertxt.Text;
            string jsonString = JsonSerializer.Serialize(login);
            Packet.Packet packet = new Packet.Packet("Login", jsonString);
            //MessageBox.Show(jsonString);
            sendJson(packet);
            int recv = client.Receive(data);
            jsonString = Encoding.ASCII.GetString(data, 0, recv);
            jsonString.Replace("\\u0022", "\"");
            Packet.Packet? com = JsonSerializer.Deserialize<Packet.Packet>(jsonString);

            if(com != null)
            {
                switch (com.mess)
                {

                    case "khongduocdetrong":
                        MessageBox.Show("Chưa nhập đầy đủ thông tin!");
                        break;
                    case "emaildetrong":
                        MessageBox.Show("Chưa nhập email!");
                        break;
                    case "passdetrong":
                        MessageBox.Show("Chưa nhập password!");
                        break;
                    case "dangnhapthatbai":
                        MessageBox.Show("Tài khoản sai không tồn tại hoặc mật khẩu sai!");
                        Usertxt.Text = "";
                        Usertxt.Focus();
                        break;
                    case "taikhoanbikhoa":
                        MessageBox.Show("Tai khoan cua ban hien tai dang bi khoa!");
                        break;
                    case "dangnhapthanhcong":
                        MessageBox.Show("Welcome to loza!!!!");

                        this.Visible = false;
                        MainChatApp mainChatApp = new MainChatApp(iep,username,5);
                        mainChatApp.Show();
                        break;
                    default:
                        break;
                }
            }
        }
       
        private void Loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string ipaddress = getIPAdress();               
                iep = new IPEndPoint(IPAddress.Parse(ipaddress), 2008);
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                client.Connect(iep);
                LoginConnect();
                /*Thread trd = new Thread(new ThreadStart(this.LoginConnect));
                trd.IsBackground = true;
                trd.Start();*/                
            }
            catch (Exception)
            {
                MessageBox.Show("Khong the ket noi den Server!!!");
                throw;
            }
        }

        private void Usertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
