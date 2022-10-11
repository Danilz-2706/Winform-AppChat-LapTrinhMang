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
    public partial class ItemFriend : UserControl
    {
        public ItemFriend()
        {
            InitializeComponent();
        }


        #region Properties

        private string _avatar;

        [Category("Custom Props")]
        public string Avatar
        {
            get { return this._avatar; }
            set { this._avatar = value; }
        }
        private string _userName;
        [Category("Custom Props")]

        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; lbUsername.Text = value; }
        }

        private string _message;
        [Category("Custom Props")]

        public string Message
        {
            get { return this._message; }
            set { this._message = value; lbMess.Text = value; }
        }

        private int _status;
        [Category("Custom Props")]

        public int Status
        {
            get { return this._status; }
            set { this._status = value;
                if (value == 1)
                {
                    lbStatus.Text = "Just now";
                }
                else lbStatus.Text = "Offline";
            }
        }

        

        #endregion



        private void pnItemFriend_MouseHover(object sender, EventArgs e)
        {
            this.pnItemFriend.BorderColor = Color.FromArgb(128, 36, 206);
            this.pnItemFriend.BorderThickness = 1;
        }

        private void pnItemFriend_MouseLeave(object sender, EventArgs e)
        {
            this.pnItemFriend.BorderThickness = 0;
            this.pnItemFriend.FillColor = Color.FromArgb(23, 28, 41);
            this.pnItemFriend.FillColor2 = Color.FromArgb(23, 28, 41);
        }

        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                foreach (Control control in Controls)
                {
                    control.Click += value;


                }
            }
            remove
            {
                base.Click -= value;
                foreach (Control control in Controls)
                {
                    control.Click -= value;
                }
            }
        }


        private void ItemFriend_MouseEnter(object sender, EventArgs e)
        {
            //this.pnItemFriend.FillColor = Color.FromArgb(250, 48, 90);
            //this.pnItemFriend.FillColor2 = Color.FromArgb(128, 36, 206);
        }

    }
}
