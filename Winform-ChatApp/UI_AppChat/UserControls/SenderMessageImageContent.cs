﻿using System;
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
    public partial class SenderMessageImageContent : UserControl
    {
        public SenderMessageImageContent()
        {
            InitializeComponent();
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
    }
}
