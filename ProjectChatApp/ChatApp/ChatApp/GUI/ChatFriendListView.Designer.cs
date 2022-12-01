namespace ChatApp.GUI
{
    partial class ChatFriendListView
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
            this.LastChatlbl = new System.Windows.Forms.Label();
            this.Statuslbl = new System.Windows.Forms.Label();
            this.UserChatNamelbl = new System.Windows.Forms.Label();
            this.ImageChatUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageChatUser)).BeginInit();
            this.SuspendLayout();
            // 
            // LastChatlbl
            // 
            this.LastChatlbl.AutoSize = true;
            this.LastChatlbl.BackColor = System.Drawing.Color.Transparent;
            this.LastChatlbl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastChatlbl.ForeColor = System.Drawing.Color.Gray;
            this.LastChatlbl.Location = new System.Drawing.Point(63, 53);
            this.LastChatlbl.Name = "LastChatlbl";
            this.LastChatlbl.Size = new System.Drawing.Size(97, 21);
            this.LastChatlbl.TabIndex = 10;
            this.LastChatlbl.Text = "Hello Word!!!";
            // 
            // Statuslbl
            // 
            this.Statuslbl.AutoSize = true;
            this.Statuslbl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Statuslbl.ForeColor = System.Drawing.Color.Red;
            this.Statuslbl.Location = new System.Drawing.Point(221, 28);
            this.Statuslbl.Name = "Statuslbl";
            this.Statuslbl.Size = new System.Drawing.Size(52, 21);
            this.Statuslbl.TabIndex = 8;
            this.Statuslbl.Text = "Offline";
            // 
            // UserChatNamelbl
            // 
            this.UserChatNamelbl.AutoSize = true;
            this.UserChatNamelbl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserChatNamelbl.ForeColor = System.Drawing.Color.Silver;
            this.UserChatNamelbl.Location = new System.Drawing.Point(63, 28);
            this.UserChatNamelbl.Name = "UserChatNamelbl";
            this.UserChatNamelbl.Size = new System.Drawing.Size(75, 21);
            this.UserChatNamelbl.TabIndex = 9;
            this.UserChatNamelbl.Text = "Username";
            // 
            // ImageChatUser
            // 
            this.ImageChatUser.Image = global::ChatApp.Properties.Resources.male_default;
            this.ImageChatUser.Location = new System.Drawing.Point(11, 28);
            this.ImageChatUser.Name = "ImageChatUser";
            this.ImageChatUser.Size = new System.Drawing.Size(46, 46);
            this.ImageChatUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageChatUser.TabIndex = 7;
            this.ImageChatUser.TabStop = false;
            // 
            // ChatFriendListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.LastChatlbl);
            this.Controls.Add(this.Statuslbl);
            this.Controls.Add(this.UserChatNamelbl);
            this.Controls.Add(this.ImageChatUser);
            this.Name = "ChatFriendListView";
            this.Size = new System.Drawing.Size(284, 103);
            this.Load += new System.EventHandler(this.ChatFriendListView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageChatUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LastChatlbl;
        private Label Statuslbl;
        private Label UserChatNamelbl;
        private PictureBox ImageChatUser;
    }
}
