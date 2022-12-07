using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_AppChat.UserControls
{
    public partial class SenderMessageContent : UserControl
    {
        public SenderMessageContent()
        {
            InitializeComponent();
        }

        private string seen;
        private string nameFriendChatWithMe;

        public string NameFriendChatWithMe
        {
            get { return nameFriendChatWithMe; }
            set { nameFriendChatWithMe = value; }
        }
        public string SeenMessage
        {
            get { return seen; }
            set { seen = value; seenlbl.Text = value; }
        }


        public string Message
        {
            get { return UserMessage.Text; }
            set { UserMessage.Text = value; }
        }

        public bool ShowSeen
        {
            get { return seenlbl.Visible; }
            set { seenlbl.Visible = value; }
        }


        private void MessageContent_Load(object sender, EventArgs e)
        {

        }

        private void lbUsername_Click(object sender, EventArgs e)
        {

        }

        private void MessPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void imgAvatar_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
