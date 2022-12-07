using Org.BouncyCastle.Bcpg.OpenPgp;
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
    public partial class MeChat : UserControl
    {
        public MeChat()
        {
            InitializeComponent();
        }

        private string seen;
        private string nameFriendChatWithMe;

        public string NameFriendChatWithMe
        {
            get { return nameFriendChatWithMe; }
            set { nameFriendChatWithMe = value;}
        }
        public string SeenMessage
        {
            get { return seen;  }
            set { seen = value; seenlbl.Text = value; }
        }

        public string Message
        {
            get { return UserMessage.Text; }
            set { UserMessage.Text = value; FlowHeight(); } 
        }
        public bool ShowSeen
        {
            get { return seenlbl.Visible; }
            set { seenlbl.Visible = value; }
        }

        void FlowHeight()
        {
            UserMessage.Height = ListChatUtilities.GetTextHeight(UserMessage) + 10;
            MessPanel.Height = UserMessage.Top + MessPanel.Top + UserMessage.Height;
            this.Height = MessPanel.Bottom + 10;
        }

        


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ListChat_Load(object sender, EventArgs e)
        {

        }
    }
}
