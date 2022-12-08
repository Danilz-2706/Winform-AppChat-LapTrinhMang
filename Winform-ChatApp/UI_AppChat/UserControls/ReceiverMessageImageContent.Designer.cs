namespace UI_AppChat.UserControls
{
    partial class ReceiverMessageImageContent
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
            this.imgAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserNameMessage = new System.Windows.Forms.Label();
            this.UserMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imgAvatar
            // 
            this.imgAvatar.BackColor = System.Drawing.Color.Transparent;
            this.imgAvatar.ImageRotate = 0F;
            this.imgAvatar.Location = new System.Drawing.Point(20, 10);
            this.imgAvatar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.ShadowDecoration.Color = System.Drawing.Color.Fuchsia;
            this.imgAvatar.ShadowDecoration.Enabled = true;
            this.imgAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imgAvatar.Size = new System.Drawing.Size(39, 45);
            this.imgAvatar.TabIndex = 22;
            this.imgAvatar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(88, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 133);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UserNameMessage
            // 
            this.UserNameMessage.AutoSize = true;
            this.UserNameMessage.BackColor = System.Drawing.Color.Transparent;
            this.UserNameMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserNameMessage.ForeColor = System.Drawing.Color.Silver;
            this.UserNameMessage.Location = new System.Drawing.Point(65, 10);
            this.UserNameMessage.Name = "UserNameMessage";
            this.UserNameMessage.Size = new System.Drawing.Size(49, 20);
            this.UserNameMessage.TabIndex = 23;
            this.UserNameMessage.Text = "Katsu";
            // 
            // UserMessage
            // 
            this.UserMessage.AllowDrop = true;
            this.UserMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserMessage.AutoSize = true;
            this.UserMessage.BackColor = System.Drawing.Color.Transparent;
            this.UserMessage.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.UserMessage.Location = new System.Drawing.Point(88, 43);
            this.UserMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserMessage.MaximumSize = new System.Drawing.Size(274, 13333);
            this.UserMessage.Name = "UserMessage";
            this.UserMessage.Size = new System.Drawing.Size(21, 20);
            this.UserMessage.TabIndex = 24;
            this.UserMessage.Text = "la";
            this.UserMessage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ReceiverMessageImageContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.UserMessage);
            this.Controls.Add(this.UserNameMessage);
            this.Controls.Add(this.imgAvatar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ReceiverMessageImageContent";
            this.Size = new System.Drawing.Size(412, 206);
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox imgAvatar;
        private PictureBox pictureBox1;
        private Label UserNameMessage;
        private Label UserMessage;
    }
}
