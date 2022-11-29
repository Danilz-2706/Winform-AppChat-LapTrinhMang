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

        public string Message
        {
            get { return UserMessage.Text; }
            set { UserMessage.Text = value; }
        }


        //void FlowHeight()
        //{
        //    UserMessage.Height = ListChatUtilities.GetTextHeight(UserMessage) + 10;
        //    MessPanel.Height = UserMessage.Top + MessPanel.Top + UserMessage.Height;
        //    this.Height = MessPanel.Bottom + 10;
        //}

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
    }
}
