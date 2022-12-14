namespace ChatApp.GUI
{
    partial class FriendImage
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
            this.seenlbl = new System.Windows.Forms.Label();
            this.UserNameMessage = new System.Windows.Forms.Label();
            this.ImagePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePic)).BeginInit();
            this.SuspendLayout();
            // 
            // seenlbl
            // 
            this.seenlbl.AutoSize = true;
            this.seenlbl.Location = new System.Drawing.Point(3, 9);
            this.seenlbl.Name = "seenlbl";
            this.seenlbl.Size = new System.Drawing.Size(50, 20);
            this.seenlbl.TabIndex = 0;
            this.seenlbl.Text = "label1";
            // 
            // UserNameMessage
            // 
            this.UserNameMessage.AutoSize = true;
            this.UserNameMessage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNameMessage.Location = new System.Drawing.Point(18, 54);
            this.UserNameMessage.Name = "UserNameMessage";
            this.UserNameMessage.Size = new System.Drawing.Size(55, 23);
            this.UserNameMessage.TabIndex = 1;
            this.UserNameMessage.Text = "label1";
            // 
            // ImagePic
            // 
            this.ImagePic.Location = new System.Drawing.Point(158, 18);
            this.ImagePic.Name = "ImagePic";
            this.ImagePic.Size = new System.Drawing.Size(180, 150);
            this.ImagePic.TabIndex = 2;
            this.ImagePic.TabStop = false;
            // 
            // FriendImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ImagePic);
            this.Controls.Add(this.UserNameMessage);
            this.Controls.Add(this.seenlbl);
            this.Name = "FriendImage";
            this.Size = new System.Drawing.Size(408, 189);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label seenlbl;
        private Label UserNameMessage;
        private PictureBox ImagePic;
    }
}
