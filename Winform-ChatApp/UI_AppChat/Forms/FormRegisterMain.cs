using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_AppChat.Forms;
using Packet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_AppChat.Forms
{
    public partial class FormRegisterMain : Form
    {
        IPEndPoint iep;
        Socket server;
        Socket client;
        bool thoat = false;
        bool flag = false;

        public FormRegisterMain()
        {
            InitializeComponent();
            Mailtxt.Focus();
            MaleradioButton.Checked = true;
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
        private void sendJson(object obj)
        {
            byte[] jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(obj);
            client.Send(jsonUtf8Bytes, jsonUtf8Bytes.Length, SocketFlags.None);
        }
        private void RegisterConnect()
        {
            string message = "";
            string email = Mailtxt.Text;
            string password = Passwordtxt.Text;
            string confirmpassword = ConfirmPasswordtxt.Text;
            string name = Fullnametxt.Text;
            int sex = 0;
            string bd = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            if (MaleradioButton.Checked == true)
            {
                sex = 1;
            }
            else
            {
                sex = 0;
            }
            byte[] data = new byte[1024 * 20 * 1000];
            Packet.REGISTER register = new Packet.REGISTER(email, password, confirmpassword, name, sex, bd);
            string jsonString = JsonSerializer.Serialize(register);
            Packet.Packet packet = new Packet.Packet("Register", jsonString);
            //gui thong tin ve server
            sendJson(packet);
            //nhan thong tin tu server 
            int recv = client.Receive(data);
            jsonString = Encoding.ASCII.GetString(data, 0, recv);
            jsonString.Replace("\\u0022", "\"");
            Packet.Packet? com = JsonSerializer.Deserialize<Packet.Packet>(jsonString);
            if (com != null)
            {
                switch (com.mess)
                {
                    case "saidinhdangemail":
                        MessageBox.Show("Sai định dạng email!");
                        break;
                    case "khongduocdetrong":
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                        break;
                    case "emailtrong":
                        MessageBox.Show("Email không được để trống!");
                        break;
                    case "passwordtrong":
                        MessageBox.Show("Passwordword không được để trống!");
                        break;
                    case "nametrong":
                        MessageBox.Show("Tên không được để trống!");
                        break;
                    case "confirmpasstrong":
                        MessageBox.Show("Confirm không được để trống");
                        break;
                    case "passwordvaconfirmkhongtrung":
                        MessageBox.Show("Password và Confirmpassword khác nhau!Vui long nhập lại");
                        ConfirmPasswordtxt.Text = "";
                        break;
                    case "themuserthanhcong":
                        MessageBox.Show("Chào mừng bạn đến với loza");
                        this.Visible = false;
                        FormLoginMain login = new FormLoginMain();
                        login.ShowDialog();
                        break;
                    default:
                        break;
                }
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLoginMain loginForm = new FormLoginMain();
            loginForm.Visible = true;
        }


        private void SignUp_Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string ipaddress = getIPAdress();
                iep = new IPEndPoint(IPAddress.Parse(ipaddress), 2008);
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                client.Connect(iep);
                /*Thread trd = new Thread(new ThreadStart(this.RegisterConnect));
                trd.IsBackground = true;
                trd.Start();*/
                RegisterConnect();




            }
            catch (Exception)
            {
                MessageBox.Show("Khong the ket noi den Server!!!");
                throw;
            }
        }
    }
}
