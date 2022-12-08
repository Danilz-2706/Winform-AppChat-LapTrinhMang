using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Packet;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text.Json;
namespace UI_AppChat.Forms
{
    public partial class FormLoginMain : Form
    {
        IPEndPoint iep;
        // string username = null;
        Socket server;
        Socket client;
        bool flag = false;
        bool thoat = false;
        public FormLoginMain()
        {
            InitializeComponent();
        }

        public string getIPAdress()
        {
            string t = "";
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                //if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
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
        private void Clean_Click(object sender, EventArgs e)
        {
            Usertxt.Clear();
            Passwordtxt.Clear();
            Usertxt.Focus();
        }

        private void sendJson(object obj)
        {
            byte[] jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(obj);
            client.Send(jsonUtf8Bytes, jsonUtf8Bytes.Length, SocketFlags.None);
        }

        private void LoginConnect()
        {
            byte[] data = new byte[1024 * 40 * 1000];
            Packet.LOGIN login = new Packet.LOGIN(Usertxt.Text, Passwordtxt.Text);
            //username = Usertxt.Text;
            string jsonString = JsonSerializer.Serialize(login);
            Packet.Packet packet = new Packet.Packet("Login", jsonString);
            //MessageBox.Show(jsonString);
            sendJson(packet);
            int recv = client.Receive(data);
            jsonString = Encoding.ASCII.GetString(data, 0, recv);
            jsonString.Replace("\\u0022", "\"");
            Packet.Packet? com = JsonSerializer.Deserialize<Packet.Packet>(jsonString);

            if (com != null)
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
                        LOGINSUCESS? lgsucess = JsonSerializer.Deserialize<LOGINSUCESS>(com.content);

                        this.Visible = false;
                        FormMenuContainer mainChatApp = new FormMenuContainer(iep, (int)lgsucess.id, lgsucess.email, lgsucess.name, 5, (Socket)client, lgsucess.listFriendOfUser, lgsucess.messlist,lgsucess.CheckSeenMessage, lgsucess.listFriendRequestOfUser, lgsucess.listUsernaemReponseOff);
                        mainChatApp.ShowDialog();
                        break;
                    default:
                        break;
                }
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Button_Click(object sender, EventArgs e)
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

        private void Register_Button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormRegisterMain registerForm = new FormRegisterMain();
            registerForm.Visible = true;
        }

    }
}
