namespace UI_AppChat.UserControls
{
    partial class ReceiverMessageContent
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
            this.MessPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.UserMessage = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.imgAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.UserNameMessage = new System.Windows.Forms.Label();
            this.MessPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // MessPanel
            // 
            this.MessPanel.AutoSize = true;
            this.MessPanel.BorderRadius = 16;
            this.MessPanel.Controls.Add(this.UserMessage);
            this.MessPanel.Controls.Add(this.guna2CirclePictureBox1);
            this.MessPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.MessPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(36)))), ((int)(((byte)(206)))));
            this.MessPanel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.MessPanel.Location = new System.Drawing.Point(22, 37);
            this.MessPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MessPanel.MaximumSize = new System.Drawing.Size(323, 13333);
            this.MessPanel.Name = "MessPanel";
            this.MessPanel.Size = new System.Drawing.Size(80, 55);
            this.MessPanel.TabIndex = 17;
            // 
            // UserMessage
            // 
            this.UserMessage.AllowDrop = true;
            this.UserMessage.AutoSize = true;
            this.UserMessage.BackColor = System.Drawing.Color.Transparent;
            this.UserMessage.ForeColor = System.Drawing.Color.Black;
            this.UserMessage.Location = new System.Drawing.Point(27, 19);
            this.UserMessage.MaximumSize = new System.Drawing.Size(274, 13333);
            this.UserMessage.Name = "UserMessage";
            this.UserMessage.Size = new System.Drawing.Size(50, 20);
            this.UserMessage.TabIndex = 2;
            this.UserMessage.Text = "label1";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(-14, -19);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(43, 45);
            this.guna2CirclePictureBox1.TabIndex = 1;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // imgAvatar
            // 
            this.imgAvatar.BackColor = System.Drawing.Color.Transparent;
            this.imgAvatar.ImageRotate = 0F;
            this.imgAvatar.Location = new System.Drawing.Point(8, 9);
            this.imgAvatar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.ShadowDecoration.Color = System.Drawing.Color.Fuchsia;
            this.imgAvatar.ShadowDecoration.Enabled = true;
            this.imgAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imgAvatar.Size = new System.Drawing.Size(39, 45);
            this.imgAvatar.TabIndex = 19;
            this.imgAvatar.TabStop = false;
            // 
            // UserNameMessage
            // 
            this.UserNameMessage.AutoSize = true;
            this.UserNameMessage.BackColor = System.Drawing.Color.Transparent;
            this.UserNameMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserNameMessage.ForeColor = System.Drawing.Color.Silver;
            this.UserNameMessage.Location = new System.Drawing.Point(49, 13);
            this.UserNameMessage.Name = "UserNameMessage";
            this.UserNameMessage.Size = new System.Drawing.Size(49, 20);
            this.UserNameMessage.TabIndex = 20;
            this.UserNameMessage.Text = "Katsu";
            this.UserNameMessage.Click += new System.EventHandler(this.lbUsername_Click);
            // 
            // ReceiverMessageContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.imgAvatar);
            this.Controls.Add(this.UserNameMessage);
            this.Controls.Add(this.MessPanel);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "ReceiverMessageContent";
            this.Size = new System.Drawing.Size(345, 133);
            this.Load += new System.EventHandler(this.MessageContent_Load);
            this.MessPanel.ResumeLayout(false);
            this.MessPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel MessPanel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox imgAvatar;
        private Label UserNameMessage;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Label UserMessage;
    }
}
