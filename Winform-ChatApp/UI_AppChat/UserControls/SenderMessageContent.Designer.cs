namespace UI_AppChat.UserControls
{
    partial class SenderMessageContent
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
            this.imgAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.seenlbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.MessPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // MessPanel
            // 
            this.MessPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MessPanel.AutoSize = true;
            this.MessPanel.BorderRadius = 16;
            this.MessPanel.Controls.Add(this.UserMessage);
            this.MessPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(93)))));
            this.MessPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(87)))));
            this.MessPanel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.MessPanel.Location = new System.Drawing.Point(14, 28);
            this.MessPanel.MaximumSize = new System.Drawing.Size(283, 10000);
            this.MessPanel.Name = "MessPanel";
            this.MessPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MessPanel.Size = new System.Drawing.Size(283, 41);
            this.MessPanel.TabIndex = 17;
            this.MessPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MessPanel_Paint);
            // 
            // UserMessage
            // 
            this.UserMessage.AllowDrop = true;
            this.UserMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserMessage.AutoSize = true;
            this.UserMessage.BackColor = System.Drawing.Color.Transparent;
            this.UserMessage.ForeColor = System.Drawing.Color.Black;
            this.UserMessage.Location = new System.Drawing.Point(16, 5);
            this.UserMessage.Margin = new System.Windows.Forms.Padding(3);
            this.UserMessage.MaximumSize = new System.Drawing.Size(240, 10000);
            this.UserMessage.Name = "UserMessage";
            this.UserMessage.Size = new System.Drawing.Size(16, 15);
            this.UserMessage.TabIndex = 2;
            this.UserMessage.Text = "la";
            this.UserMessage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.UserMessage.Click += new System.EventHandler(this.label1_Click);
            // 
            // imgAvatar
            // 
            this.imgAvatar.BackColor = System.Drawing.Color.Transparent;
            this.imgAvatar.ImageRotate = 0F;
            this.imgAvatar.Location = new System.Drawing.Point(297, 8);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.ShadowDecoration.Color = System.Drawing.Color.Fuchsia;
            this.imgAvatar.ShadowDecoration.Enabled = true;
            this.imgAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imgAvatar.Size = new System.Drawing.Size(34, 34);
            this.imgAvatar.TabIndex = 19;
            this.imgAvatar.TabStop = false;
            this.imgAvatar.Click += new System.EventHandler(this.imgAvatar_Click);
            // 
            // seenlbl
            // 
            this.seenlbl.BackColor = System.Drawing.Color.Transparent;
            this.seenlbl.Location = new System.Drawing.Point(270, 75);
            this.seenlbl.Name = "seenlbl";
            this.seenlbl.Size = new System.Drawing.Size(27, 17);
            this.seenlbl.TabIndex = 20;
            this.seenlbl.Text = "seen";
            // 
            // SenderMessageContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.seenlbl);
            this.Controls.Add(this.imgAvatar);
            this.Controls.Add(this.MessPanel);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SenderMessageContent";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(342, 100);
            this.Load += new System.EventHandler(this.MessageContent_Load);
            this.MessPanel.ResumeLayout(false);
            this.MessPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel MessPanel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox imgAvatar;
        private Label UserMessage;
        private Guna.UI2.WinForms.Guna2HtmlLabel seenlbl;
    }
}
