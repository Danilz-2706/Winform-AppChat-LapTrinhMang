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

        private void itPerson_Click(object sender, EventArgs e)
        {
            this.itPerson.FillColor = Color.FromArgb(250, 48, 90);
            this.itPerson.FillColor2 = Color.FromArgb(128, 36, 206);
            OpenChildForm(new FormChatting(), sender);

        }
        


    }
}
