using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_AppChat
{
    public partial class ItemFriend : UserControl
    {
        private bool _bgColor = false;
        private bool _border = false;
        private BorderStyle border;

        private Image _avatar;
        private string _userName;
        private string _lastmessage;
        private string _status;
        private Color _statusColor;
        private Color _lastmessageColor;
        private Color _usernameColor;
        private Color _noti;
        private int iduser;



        public ItemFriend()
        {
            InitializeComponent();
            base.BorderStyle = BorderStyle.None;
        }


        #region Properties

        public Color ShowNoti
        {
            get { return this._noti; }
            set { this._noti = value; noti.FillColor = value; }
        }


        [Category("Custom Props")]
        public int Iduser
        {
            get { return iduser; }
            set { iduser = value; }
        }

        [Category("Custom Props")]
        public Image Avatar
        {
            get { return this._avatar; }
            set { this._avatar = value; imgAvatar.Image = value; }
        }
        
        [Category("Custom Props")]
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; lbUsername.Text = value; }
        }
        
        [Category("Custom Props")]
        public string Lastmessage
        {
            get { return this._lastmessage; }
            set { this._lastmessage = value; lbMess.Text = value; }
        }
        
        [Category("Custom Props")]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; lbStatus.Text = value;
            }
        }
        
        [Category("Custom Props")]
        public Color StatusColor
        {
            get { return this._statusColor; }
            set
            {
                this._statusColor = value; lbStatus.ForeColor = value;
            }
        }
        
        [Category("Custom Props")]
        public Color UsernameColor
        {
            get { return this._usernameColor; }
            set
            {
                this._usernameColor = value; lbUsername.ForeColor = value;
            }
        }
        
        [Category("Custom Props")]
        public Color LastmessageColor
        {
            get { return this._lastmessageColor; }
            set
            {
                this._lastmessageColor = value; lbMess.ForeColor = value;
            }
        }
        #endregion

        #region Events
        public new BorderStyle BorderStyle
        {
            get { return border; }
            set
            {
                border = value;
                Invalidate();
            }
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
        public new event EventHandler MouseHover
        {
            add
            {
                base.MouseHover += value;
                foreach (Control control in Controls)
                {
                    control.MouseHover += value;
                }
            }
            remove
            {
                base.MouseHover -= value;
                foreach (Control control in Controls)
                {
                    control.MouseHover -= value;
                }
            }
        }
        public new event EventHandler MouseLeave
        {
            add
            {
                base.MouseLeave += value;
                foreach (Control control in Controls)
                {
                    control.MouseLeave += value;
                }
            }
            remove
            {
                base.MouseLeave -= value;
                foreach (Control control in Controls)
                {
                    control.MouseLeave -= value;
                }
            }
        }
        #endregion


        private void ItemFriend_Paint(object sender, PaintEventArgs e)
        {
            if(_bgColor == true)
            {


                Point startPoint = new Point(0, 0);
                Point endPoint = new Point(194, 194);
                using (LinearGradientBrush lgb =
                    new LinearGradientBrush(startPoint, endPoint, Color.FromArgb(250, 48, 90), Color.FromArgb(128, 36, 206)))
                {
                    Graphics g = e.Graphics;
                    g.FillRectangle(lgb, 0, 0, 270, 77);
                }
            }
            if (_border == true)
            {
                if (this.BorderStyle == BorderStyle.None)
                    ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.FromArgb(128, 36, 206), ButtonBorderStyle.Solid);

            }

        }

        private void ItemFriend_MouseHover(object sender, EventArgs e)
        {
            _border = true;
            Refresh();

        }

        private void ItemFriend_MouseLeave(object sender, EventArgs e)
        {
            _border = false;
            _bgColor = false;
            Refresh();
        }

        private void ItemFriend_Click(object sender, EventArgs e)
        {
            //noti.FillColor=Color.Transparent;
            _bgColor = false;
            _border = false;
            Refresh();
        }
    }
}
