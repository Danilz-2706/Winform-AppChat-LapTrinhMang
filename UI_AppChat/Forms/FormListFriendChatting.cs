using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_AppChat
{
    public partial class FormListFriendChatting : Form
    {
        private Form activeForm;
        public FormListFriendChatting()
        {
            InitializeComponent();
            
        }
        private void FormListFriendChatting_Load(object sender, EventArgs e)
        {
            PopulateItems();

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

        private void PopulateItems()
        {
            ItemFriend[] itemFriends = new ItemFriend[8];
            for(int i = 0; i < itemFriends.Length; i++)
            {
                itemFriends[i] = new ItemFriend();
                itemFriends[i].UserName = "Danilz Dinh";
                itemFriends[i].Message = "What'up,............mic check......";
                itemFriends[i].Status = 1;

                if (flpListItem.Controls.Count < 0)
                {
                    flpListItem.Controls.Clear();
                }
                else
                {
                    flpListItem.Controls.Add(itemFriends[i]);
                    itemFriends[i].Click += new EventHandler(UserControl_Click);
                }

            }

            
        }
        public void UserControl_Click(object sender, EventArgs e)
        {
            //ItemFriend obj = (ItemFriend)sender;
            
            //MessageBox.Show("day");
            OpenChildForm(new FormChatting(), sender);
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            txbSearch.Multiline = true;
        }
    }
}
