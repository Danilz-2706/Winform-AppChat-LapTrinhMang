using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp.GUI
{
    public partial class ChatFriendListView : UserControl
    {
        public ChatFriendListView()
        {
            InitializeComponent();
        }


        private string lastchat;
        private int iduser;
        private string status;
        private string username;
        private Image userimage; 
        private Color status_color;
        private Color username_color;
        private Color lastchat_color;
        


        public bool ShowNoti
        {
            get { return noti.Visible; }
            set { noti.Visible = value; }
        }

        [Category("CustomPros")]
        public Color StatusColor
        {
            get { return status_color; }
            set { status_color = value; Statuslbl.ForeColor = value; }
        }
        [Category("CustomPros")]
        public Color UsernameColor
        {
            get { return username_color; }
            set { username_color = value; UserChatNamelbl.ForeColor = value; }
        }
        [Category("CustomPros")]
        public Color LastchatColor
        {
            get { return lastchat_color; }
            set { lastchat_color = value; LastChatlbl.ForeColor = value; }
        }
        [Category("CustomPros")]
        public string Username
        {
            get { return username; }
            set { username = value; UserChatNamelbl.Text = value; }
        }
        public int Iduser
        {
            get { return iduser; }
            set { iduser = value; }
        }

        [Category("CustomPros")]
        public string LastChat
        {
            get { return lastchat; }
            set { lastchat = value; LastChatlbl.Text = value; }
        }

        [Category("CustomPros")]
        public string Status
        {
            get { return status; }
            set { status = value; Statuslbl.Text = value; }
        }

        [Category("CustomPros")]
        public Image UserIcon
        {
            get { return userimage; }
            set
            {
                userimage = value; ImageChatUser.Image = value;
            }

        }
        /*public Image Noti
        {
            get { return notiImgage; }
            set
            {
                notiImgage = value; ImageChatUser.Image = value;
            }

        }*/

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void LastChatlbl_Click(object sender, EventArgs e)
        {

        }

        private void ChatFriendListView_Load(object sender, EventArgs e)
        {

        }
    }
}
