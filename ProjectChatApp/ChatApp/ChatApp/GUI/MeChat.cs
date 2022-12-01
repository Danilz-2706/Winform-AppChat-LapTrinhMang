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

       

        public string Message
        {
            get { return UserMessage.Text; }
            set { UserMessage.Text = value; FlowHeight(); } 
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
