using ChatApp.Properties;
using Microsoft.VisualBasic.Logging;
using Packet;
using Server.DTO;
using System.Net;
using System.Net.Sockets;
using System.Security.Permissions;
using System.Text;
using System.Text.Json;
using System.Threading;

namespace ChatApp.GUI
{
    public partial class MainChatApp : Form
    {
        private volatile bool m_StopThread;
        Thread trd;
        IPEndPoint iep;
        Socket _client;
        string email = null;
        int id_user = 0;
        string name_user = null;
        bool active = false;
        int n;
        List<user> listFriendOfUser = new List<user>();
        public MainChatApp()
        {
            InitializeComponent();
        }
        public MainChatApp(IPEndPoint ipep,int id ,string emailuser, string name,int num,Socket client, List<user> listFriendOfUser)
        {
            InitializeComponent();
            active = true;
            iep= ipep;
            _client = client;
            email = emailuser;
            id_user = id;
            name_user = name;
            n = listFriendOfUser.Count;
            Username.Text = name_user;
            this.listFriendOfUser = listFriendOfUser;
            populateListView(n);       
            //new Thread(new ThreadStart(this.NewThread)).Start();
            trd = new Thread(NewThread);
            //trd.IsBackground = true;
            trd.Start();
        }
        private void NewThread()
        {
            while (active)
            {
                try
                {
              
                    string jsonString = null;
                    byte[] data = new byte[1024];
                    int recv = _client.Receive(data);
                    jsonString = Encoding.ASCII.GetString(data, 0, recv);
                    jsonString.Replace("\\u0022", "\"");                   
                    Packet.Packet com = JsonSerializer.Deserialize<Packet.Packet>(jsonString);               
                    if (com != null)
                    {
                        switch (com.mess)
                        {
                            case "StatusUser":
                                SENDUSERSTATUS? senduserstatusonline = JsonSerializer.Deserialize<SENDUSERSTATUS>(com.content);                             
                                for(int i=0;i<listFriendOfUser.Count();i++)
                                {
                                    if (listFriendOfUser[i].Email == senduserstatusonline.u.Email)
                                    {
                                        listFriendOfUser[i].Online_status = senduserstatusonline.u.Online_status;
                                        break;
                                    }
                                }
                                //muốn thay đổi 1 thứ gì đó không đồng bộ 
                                BeginInvoke((Action)(() => populateListView(n)));
                                //MessageBox.Show(u.Name);                               
                                break;                   
                                BeginInvoke((Action)(() => populateListView(n)));
                                break;
                            default:
                                break;
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
            //MessageBox.Show("Thread da chet");
        }

        private void populateListView(int n)
        {
            ChatFriendPanel.Controls.Clear();
            ChatFriendListView[] listItem = new ChatFriendListView[n];
            for(int i=0;i< listItem.Length;i++)
            {


                listItem[i] = new ChatFriendListView();
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


                listItem[i].LastChat = "Hello World";
                listItem[i].LastchatColor = Color.Gray;
                listItem[i].UserIcon = Resources.male_default;
                //list[i].Click += (sender, e) => TestEvent(sender, e);
                listItem[i].Name = "Friend" + i;
                ChatFriendPanel.Controls.Add(listItem[i]);

                listItem[i].Click += new System.EventHandler(this.ClickEvent);


            }

            
        }

        void ClickEvent(object sender,EventArgs e)
        {
            ChatFriendListView obj = (ChatFriendListView)sender;

           MessageBox.Show(obj.Name);
           
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
            _client.Send(jsonUtf8Bytes, jsonUtf8Bytes.Length, SocketFlags.None);
        }
        [SecurityPermission(SecurityAction.Demand, ControlThread = true)]
        public void killthread(Thread trd)
        {

            trd.Interrupt();
            
            
        }
        private void Loginbtn_Click(object sender, EventArgs e)
        {
            active = false;               
           
            _client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _client.Connect(iep);
            byte[] data = new byte[1024];
            Packet.EXIT exit = new Packet.EXIT(email, "Exit");
            string jsonString = JsonSerializer.Serialize(exit);
            Packet.Packet packet = new Packet.Packet("ExitApp", jsonString);
            sendJson(packet);
            int recv = _client.Receive(data);
            jsonString = Encoding.ASCII.GetString(data, 0, recv);
            jsonString.Replace("\\u0022", "\"");
            Packet.Packet? com = JsonSerializer.Deserialize<Packet.Packet>(jsonString);
            if (com != null)
            {
                if (com.mess.Equals("OK"))
                {                 
                    this.Close();
                    LoginForm lf = new LoginForm();
                    lf.Show();
                }
            }
            
           _client.Close();
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
    }
}
