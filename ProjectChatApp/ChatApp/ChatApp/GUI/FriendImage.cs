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
    public partial class FriendImage : UserControl
    {


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
        public void ImagePicMethod(string nameimage)
        {
            ImagePic.Image = new Bitmap("../../../../Server/User/" + nameimage);
            ImagePic.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public FriendImage()
        {
            InitializeComponent();
        }
    }
}
