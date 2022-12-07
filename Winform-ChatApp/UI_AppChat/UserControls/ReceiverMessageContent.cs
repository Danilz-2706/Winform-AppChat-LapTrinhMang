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
    public partial class ReceiverMessageContent : UserControl
    {
        public ReceiverMessageContent()
        {
            InitializeComponent();
        }

        private string seen;

        public string SeenMessage
        {
            get { return seen; }
            set { seen = value; seenlbl.Text = value; }
        }
        public string Username
        {
            get { return UserNameMessage.Text; }
            set { UserNameMessage.Text = value; }
        }

        public bool ShowSeen
        {
            get { return seenlbl.Visible; }
            set { seenlbl.Visible = value; }
        }

        public string Message
        {
            get { return UserMessage.Text; }
            set { UserMessage.Text = value; }
        }
        

        private void MessageContent_Load(object sender, EventArgs e)
        {

        }

        private void lbUsername_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
