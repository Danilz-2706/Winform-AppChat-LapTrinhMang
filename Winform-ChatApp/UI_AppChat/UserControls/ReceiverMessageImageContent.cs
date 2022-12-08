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
    public partial class ReceiverMessageImageContent : UserControl
    {
        public ReceiverMessageImageContent()
        {
            InitializeComponent();
        }
        public string Username
        {
            get { return UserNameMessage.Text; }
            set { UserNameMessage.Text = value; }
        }

        public string Message
        {
            get { return UserMessage.Text; }
            set { UserMessage.Text = value; }
        }

        public Image GetImage
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
