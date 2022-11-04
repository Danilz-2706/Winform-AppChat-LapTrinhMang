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

namespace UI_AppChat
{
    public partial class FormListFriendChatting : Form
    {
        private Form activeForm;

        Thread trd;
        IPEndPoint iep;
        Socket _client;
        string email = null;
        int id_user = 0;
        string name_user = null;
        bool active = false;
        int n;
        List<user> listFriendOfUser = new List<user>();
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
            id_user = id;
            name_user = name;
            n = listFriendOfUser.Count;
            this.listFriendOfUser = listFriendOfUser;
            PopulateListView(n);
            trd = new Thread(NewThread);
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
                                for (int i = 0; i < listFriendOfUser.Count(); i++)
                                {
                                    if (listFriendOfUser[i].Email == senduserstatusonline.u.Email)
                                    {
                                        listFriendOfUser[i].Online_status = senduserstatusonline.u.Online_status;
                                        break;
                                    }
                                }
                                //muốn thay đổi 1 thứ gì đó không đồng bộ 
                                BeginInvoke((Action)(() => PopulateListView(n)));
                                //MessageBox.Show(u.Name);                               
                                break;
                                BeginInvoke((Action)(() => PopulateListView(n)));
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

        private void PopulateListView(int n)
        {
            flpListItem.Controls.Clear();
            ItemFriend[] listItem = new ItemFriend[n];
            for (int i = 0; i < listItem.Length; i++)
            {


                listItem[i] = new ItemFriend();
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
                //listItem[i].Avatar = Resources.male_default;
                //list[i].Click += (sender, e) => TestEvent(sender, e);
                listItem[i].Name = "Friend" + i;
                flpListItem.Controls.Add(listItem[i]);

                listItem[i].Click += new EventHandler(UserControl_Click);


            }


        }
        

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.ControlBox = false;
            childForm.Text = String.Empty;
            this.panelChattingDetail.Controls.Add(childForm);
            this.panelChattingDetail.Tag = childForm;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
        }
        public void UserControl_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormChatting(), sender);
        }



    }
}
