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
    public partial class MeImage : UserControl
    {

        private string seen;       
        private string nameFriendChatWithMe;
        

        public MeImage()
        {
            InitializeComponent();
        }


        public string SeenMessage
        {
            get { return seen; }
            set { seen = value; seenlbl.Text = value; }
        }
        public string NameFriendChatWithMe
        {
            get { return nameFriendChatWithMe; }
            set { nameFriendChatWithMe = value; }
        }
        public bool ShowSeen
        {
            get { return seenlbl.Visible; }
            set { seenlbl.Visible = value; }
        }
        public void ImagePicMethod(string nameimage)
        {
            try
            {
                ImageContent.Image = new Bitmap("../../../../Server/User/" + nameimage);
                ImageContent.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
