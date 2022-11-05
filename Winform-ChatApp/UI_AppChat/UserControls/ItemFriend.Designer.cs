namespace UI_AppChat
{
    partial class ItemFriend
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
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbMess = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.imgAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUsername.ForeColor = System.Drawing.Color.Silver;
            this.lbUsername.Location = new System.Drawing.Point(53, 14);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(148, 15);
            this.lbUsername.TabIndex = 7;
            this.lbUsername.Text = "Nguoi dung khong ton tai";
            // 
            // lbMess
            // 
            this.lbMess.AllowDrop = true;
            this.lbMess.AutoEllipsis = true;
            this.lbMess.AutoSize = true;
            this.lbMess.BackColor = System.Drawing.Color.Transparent;
            this.lbMess.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMess.ForeColor = System.Drawing.Color.Gray;
            this.lbMess.Location = new System.Drawing.Point(53, 32);
            this.lbMess.MaximumSize = new System.Drawing.Size(140, 30);
            this.lbMess.MinimumSize = new System.Drawing.Size(140, 15);
            this.lbMess.Name = "lbMess";
            this.lbMess.Size = new System.Drawing.Size(140, 30);
            this.lbMess.TabIndex = 8;
            this.lbMess.Text = "Nguoi dung khong ton tai";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbStatus.ForeColor = System.Drawing.Color.Silver;
            this.lbStatus.Location = new System.Drawing.Point(204, 14);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(58, 15);
            this.lbStatus.TabIndex = 9;
            this.lbStatus.Text = "Just Now";
            // 
            // imgAvatar
            // 
            this.imgAvatar.BackColor = System.Drawing.Color.Transparent;
            this.imgAvatar.ImageRotate = 0F;
            this.imgAvatar.Location = new System.Drawing.Point(9, 21);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.ShadowDecoration.Color = System.Drawing.Color.Fuchsia;
            this.imgAvatar.ShadowDecoration.Enabled = true;
            this.imgAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imgAvatar.Size = new System.Drawing.Size(38, 38);
            this.imgAvatar.TabIndex = 11;
            this.imgAvatar.TabStop = false;
            // 
            // ItemFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbMess);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.imgAvatar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ItemFriend";
            this.Size = new System.Drawing.Size(270, 77);
            this.Click += new System.EventHandler(this.ItemFriend_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ItemFriend_Paint);
            this.MouseLeave += new System.EventHandler(this.ItemFriend_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ItemFriend_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbUsername;
        private Label lbMess;
        private Label lbStatus;
        private Guna.UI2.WinForms.Guna2CirclePictureBox imgAvatar;
    }
}
