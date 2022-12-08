namespace UI_AppChat.UserControls
{
    partial class SenderMessageImageContent
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.UserMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(32, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // imgAvatar
            // 
            this.imgAvatar.BackColor = System.Drawing.Color.Transparent;
            this.imgAvatar.ImageRotate = 0F;
            this.imgAvatar.Location = new System.Drawing.Point(339, 4);
            this.imgAvatar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.ShadowDecoration.Color = System.Drawing.Color.Fuchsia;
            this.imgAvatar.ShadowDecoration.Enabled = true;
            this.imgAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imgAvatar.Size = new System.Drawing.Size(39, 45);
            this.imgAvatar.TabIndex = 20;
            this.imgAvatar.TabStop = false;
            // 
            // UserMessage
            // 
            this.UserMessage.AllowDrop = true;
            this.UserMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserMessage.AutoSize = true;
            this.UserMessage.BackColor = System.Drawing.Color.Transparent;
            this.UserMessage.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.UserMessage.Location = new System.Drawing.Point(32, 19);
            this.UserMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserMessage.MaximumSize = new System.Drawing.Size(274, 13333);
            this.UserMessage.Name = "UserMessage";
            this.UserMessage.Size = new System.Drawing.Size(21, 20);
            this.UserMessage.TabIndex = 21;
            this.UserMessage.Text = "la";
            this.UserMessage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SenderMessageImageContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.UserMessage);
            this.Controls.Add(this.imgAvatar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SenderMessageImageContent";
            this.Size = new System.Drawing.Size(412, 206);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox imgAvatar;
        private Label UserMessage;
    }
}
