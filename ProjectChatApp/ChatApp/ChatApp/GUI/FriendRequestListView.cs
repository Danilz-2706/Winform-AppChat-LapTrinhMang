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
    public partial class FriendRequestListView : UserControl
    {

        private string username;
        public FriendRequestListView()
        {
            InitializeComponent();
        }
        [Category("CustomPros")]
        public string Username
        {
            get { return username; }
            set { username = value; UsernameRequestlbl.Text = value; }
        }
        private void FriendRequestListView_Load(object sender, EventArgs e)
        {

        }
    }
}
