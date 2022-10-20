using Microsoft.VisualBasic.Logging;
using Microsoft.Win32;
using Packet;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace ChatApp.GUI
{
    public partial class MainChatApp : Form
    {
        IPEndPoint iep;
        Socket client;
        string username = null;
        public MainChatApp()
        {
            InitializeComponent();
        }
        public MainChatApp(IPEndPoint ipep, string user,int num)
        {
            InitializeComponent();
            iep= ipep;
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            username = user;

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
        private void sendJson(object obj)
        {
            byte[] jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(obj);
            client.Send(jsonUtf8Bytes, jsonUtf8Bytes.Length, SocketFlags.None);
        }
        private void ExitApp()
        {
            byte[] data = new byte[1024];
            Packet.EXIT exit = new Packet.EXIT(username, "Exit");
            string jsonString = JsonSerializer.Serialize(exit);
            Packet.Packet packet = new Packet.Packet("ExitApp", jsonString);
            sendJson(packet);
            int recv = client.Receive(data);
            jsonString = Encoding.ASCII.GetString(data, 0, recv);
            jsonString.Replace("\\u0022", "\"");
            Packet.Packet? com = JsonSerializer.Deserialize<Packet.Packet>(jsonString);
            if(com != null)
            {
                if(com.mess.Equals("OK"))
                {
                    this.Close();
                    LoginForm lf = new LoginForm();
                    lf.Show();
                }
            }

        }
        private void Loginbtn_Click(object sender, EventArgs e)
        {
            client.Connect(iep);
            ExitApp();        
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


        public void FriendRequestConnect()
        {
            //-------Nhận dữ liệu từ textbox và thông báo---------//
            string username = SearchFriendtxt.Text;
            byte[] data = new byte[1024];
            Packet.SENFRIENDREQUEST friendRequest = new Packet.SENFRIENDREQUEST(username);
            string jsonString = JsonSerializer.Serialize(friendRequest);
            Packet.Packet packet = new Packet.Packet("FrientRequest", jsonString);
            DialogResult dlr = MessageBox.Show("Bạn muốn kết bạn với: " + username,
            "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //-------Kết thúc Nhận dữ liệu từ textbox và thông báo---------//



            if (dlr == DialogResult.Yes)
            {

                //---------Gửi Nhận packet-server------------------------------//
                sendJson(packet);
                int recv = client.Receive(data);
                jsonString = Encoding.ASCII.GetString(data, 0, recv);
                jsonString.Replace("\\u0022", "\"");
                Packet.Packet? com = JsonSerializer.Deserialize<Packet.Packet>(jsonString);
                if (com != null)
                {
                    if (com.mess.Equals("OK"))
                    {
                        MessageBox.Show(com.content);
                    }
                }
            }
            else
            {
                MessageBox.Show("Code sai rồi");
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

            string ipaddress = getIPAdress();
            iep = new IPEndPoint(IPAddress.Parse(ipaddress), 2008);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client.Connect(iep);
            FriendRequestConnect();
        }
    }
}
