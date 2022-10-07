namespace ChatApp.GUI
{
    partial class MainChatApp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RightPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.HeadPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.ImageUser = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.ChatPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ImageChatUser = new System.Windows.Forms.PictureBox();
            this.UserChatNamelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.HeadPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageUser)).BeginInit();
            this.ChatPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageChatUser)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.RightPanel.BorderColor = System.Drawing.Color.FloralWhite;
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(900, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(339, 710);
            this.RightPanel.TabIndex = 1;
            // 
            // HeadPanel
            // 
            this.HeadPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.HeadPanel.Controls.Add(this.ImageUser);
            this.HeadPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(900, 73);
            this.HeadPanel.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2GradientPanel2);
            this.guna2Panel1.Controls.Add(this.guna2GradientPanel1);
            this.guna2Panel1.Controls.Add(this.ChatPanel);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 73);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(313, 637);
            this.guna2Panel1.TabIndex = 3;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(313, 655);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(587, 55);
            this.guna2Panel2.TabIndex = 4;
            // 
            // ImageUser
            // 
            this.ImageUser.Image = global::ChatApp.Properties.Resources.male_default;
            this.ImageUser.ImageRotate = 0F;
            this.ImageUser.Location = new System.Drawing.Point(12, 12);
            this.ImageUser.Name = "ImageUser";
            this.ImageUser.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ImageUser.Size = new System.Drawing.Size(50, 52);
            this.ImageUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageUser.TabIndex = 0;
            this.ImageUser.TabStop = false;
            // 
            // ChatPanel
            // 
            this.ChatPanel.Controls.Add(this.label1);
            this.ChatPanel.Controls.Add(this.label2);
            this.ChatPanel.Controls.Add(this.UserChatNamelbl);
            this.ChatPanel.Controls.Add(this.ImageChatUser);
            this.ChatPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.ChatPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.ChatPanel.Location = new System.Drawing.Point(12, 20);
            this.ChatPanel.Name = "ChatPanel";
            this.ChatPanel.Size = new System.Drawing.Size(284, 103);
            this.ChatPanel.TabIndex = 0;
            // 
            // ImageChatUser
            // 
            this.ImageChatUser.Image = global::ChatApp.Properties.Resources.male_default;
            this.ImageChatUser.Location = new System.Drawing.Point(12, 17);
            this.ImageChatUser.Name = "ImageChatUser";
            this.ImageChatUser.Size = new System.Drawing.Size(46, 46);
            this.ImageChatUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageChatUser.TabIndex = 0;
            this.ImageChatUser.TabStop = false;
            // 
            // UserChatNamelbl
            // 
            this.UserChatNamelbl.AutoSize = true;
            this.UserChatNamelbl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserChatNamelbl.ForeColor = System.Drawing.Color.Silver;
            this.UserChatNamelbl.Location = new System.Drawing.Point(64, 17);
            this.UserChatNamelbl.Name = "UserChatNamelbl";
            this.UserChatNamelbl.Size = new System.Drawing.Size(75, 21);
            this.UserChatNamelbl.TabIndex = 1;
            this.UserChatNamelbl.Text = "Username";
            this.UserChatNamelbl.Click += new System.EventHandler(this.UserChatNamelbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(64, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hello Word!!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(222, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Active";
            this.label2.Click += new System.EventHandler(this.UserChatNamelbl_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.label3);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(249)))), ((int)(((byte)(243)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(248)))), ((int)(((byte)(254)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(12, 149);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(284, 103);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(64, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hello Word!!!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(222, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Active";
            this.label4.Click += new System.EventHandler(this.UserChatNamelbl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(64, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Username";
            this.label5.Click += new System.EventHandler(this.UserChatNamelbl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChatApp.Properties.Resources.male_default;
            this.pictureBox1.Location = new System.Drawing.Point(12, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Controls.Add(this.label6);
            this.guna2GradientPanel2.Controls.Add(this.label7);
            this.guna2GradientPanel2.Controls.Add(this.label8);
            this.guna2GradientPanel2.Controls.Add(this.pictureBox2);
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.guna2GradientPanel2.Location = new System.Drawing.Point(12, 279);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(284, 103);
            this.guna2GradientPanel2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(64, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Hello Word!!!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(222, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Active";
            this.label7.Click += new System.EventHandler(this.UserChatNamelbl_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(64, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Username";
            this.label8.Click += new System.EventHandler(this.UserChatNamelbl_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ChatApp.Properties.Resources.male_default;
            this.pictureBox2.Location = new System.Drawing.Point(12, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // MainChatApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1239, 710);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.HeadPanel);
            this.Controls.Add(this.RightPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainChatApp";
            this.Text = "MainChatApp";
            this.HeadPanel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageUser)).EndInit();
            this.ChatPanel.ResumeLayout(false);
            this.ChatPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageChatUser)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel RightPanel;
        private Guna.UI2.WinForms.Guna2Panel HeadPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ImageUser;
        private Guna.UI2.WinForms.Guna2GradientPanel ChatPanel;
        private Label UserChatNamelbl;
        private PictureBox ImageChatUser;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}