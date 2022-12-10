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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainChatApp));
            this.HeadPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SearchFriendtxt = new System.Windows.Forms.TextBox();
            this.ImageUser = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.ChatFriendPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SendMessgapanel = new System.Windows.Forms.Panel();
            this.SendMessagebtn = new System.Windows.Forms.Button();
            this.Messagetxt = new System.Windows.Forms.TextBox();
            this.ChattingPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.starttochatlbl = new System.Windows.Forms.Label();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.RightPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.FriendRequestPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.HeadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageUser)).BeginInit();
            this.SendMessgapanel.SuspendLayout();
            this.ChattingPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadPanel
            // 
            this.HeadPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.HeadPanel.Controls.Add(this.label1);
            this.HeadPanel.Controls.Add(this.pictureBox3);
            this.HeadPanel.Controls.Add(this.label9);
            this.HeadPanel.Controls.Add(this.Username);
            this.HeadPanel.Controls.Add(this.panel4);
            this.HeadPanel.Controls.Add(this.SearchFriendtxt);
            this.HeadPanel.Controls.Add(this.ImageUser);
            this.HeadPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(900, 73);
            this.HeadPanel.TabIndex = 2;
            this.HeadPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HeadPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(313, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(609, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(215, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Online";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Username.ForeColor = System.Drawing.Color.Silver;
            this.Username.Location = new System.Drawing.Point(72, 24);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(124, 29);
            this.Username.TabIndex = 2;
            this.Username.Text = "Username";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(644, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 1);
            this.panel4.TabIndex = 10;
            // 
            // SearchFriendtxt
            // 
            this.SearchFriendtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.SearchFriendtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchFriendtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchFriendtxt.ForeColor = System.Drawing.Color.Transparent;
            this.SearchFriendtxt.Location = new System.Drawing.Point(644, 24);
            this.SearchFriendtxt.Name = "SearchFriendtxt";
            this.SearchFriendtxt.PlaceholderText = "Tìm kiếm bạn bè";
            this.SearchFriendtxt.Size = new System.Drawing.Size(248, 21);
            this.SearchFriendtxt.TabIndex = 9;
            this.SearchFriendtxt.TextChanged += new System.EventHandler(this.Fullnametxt_TextChanged);
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
            this.ImageUser.Click += new System.EventHandler(this.ImageUser_Click);
            // 
            // ChatFriendPanel
            // 
            this.ChatFriendPanel.AutoScroll = true;
            this.ChatFriendPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ChatFriendPanel.Location = new System.Drawing.Point(0, 73);
            this.ChatFriendPanel.Name = "ChatFriendPanel";
            this.ChatFriendPanel.Size = new System.Drawing.Size(315, 637);
            this.ChatFriendPanel.TabIndex = 6;
            // 
            // SendMessgapanel
            // 
            this.SendMessgapanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SendMessgapanel.Controls.Add(this.SendMessagebtn);
            this.SendMessgapanel.Controls.Add(this.Messagetxt);
            this.SendMessgapanel.Location = new System.Drawing.Point(313, 637);
            this.SendMessgapanel.Name = "SendMessgapanel";
            this.SendMessgapanel.Size = new System.Drawing.Size(588, 70);
            this.SendMessgapanel.TabIndex = 7;
            this.SendMessgapanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SendMessgapanel_Paint);
            // 
            // SendMessagebtn
            // 
            this.SendMessagebtn.Location = new System.Drawing.Point(469, 26);
            this.SendMessagebtn.Name = "SendMessagebtn";
            this.SendMessagebtn.Size = new System.Drawing.Size(94, 29);
            this.SendMessagebtn.TabIndex = 1;
            this.SendMessagebtn.Text = "Send";
            this.SendMessagebtn.UseVisualStyleBackColor = true;
            this.SendMessagebtn.Click += new System.EventHandler(this.SendMessagebtn_Click);
            // 
            // Messagetxt
            // 
            this.Messagetxt.Location = new System.Drawing.Point(244, 26);
            this.Messagetxt.Name = "Messagetxt";
            this.Messagetxt.Size = new System.Drawing.Size(219, 27);
            this.Messagetxt.TabIndex = 0;
            // 
            // ChattingPanel
            // 
            this.ChattingPanel.AutoScroll = true;
            this.ChattingPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChattingPanel.Controls.Add(this.starttochatlbl);
            this.ChattingPanel.Location = new System.Drawing.Point(313, 73);
            this.ChattingPanel.Name = "ChattingPanel";
            this.ChattingPanel.Size = new System.Drawing.Size(588, 569);
            this.ChattingPanel.TabIndex = 8;
            // 
            // starttochatlbl
            // 
            this.starttochatlbl.AutoSize = true;
            this.starttochatlbl.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.starttochatlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.starttochatlbl.Location = new System.Drawing.Point(3, 0);
            this.starttochatlbl.Name = "starttochatlbl";
            this.starttochatlbl.Size = new System.Drawing.Size(166, 38);
            this.starttochatlbl.TabIndex = 0;
            this.starttochatlbl.Text = "Start to chat";
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.BackColor = System.Drawing.Color.OrangeRed;
            this.Logoutbtn.FlatAppearance.BorderSize = 0;
            this.Logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Logoutbtn.ForeColor = System.Drawing.Color.White;
            this.Logoutbtn.Location = new System.Drawing.Point(96, 626);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(177, 64);
            this.Logoutbtn.TabIndex = 5;
            this.Logoutbtn.Text = "LOG OUT";
            this.Logoutbtn.UseVisualStyleBackColor = false;
            this.Logoutbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.RightPanel.BorderColor = System.Drawing.Color.FloralWhite;
            this.RightPanel.Controls.Add(this.FriendRequestPanel);
            this.RightPanel.Controls.Add(this.Logoutbtn);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(900, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(339, 710);
            this.RightPanel.TabIndex = 1;
            // 
            // FriendRequestPanel
            // 
            this.FriendRequestPanel.Location = new System.Drawing.Point(7, 51);
            this.FriendRequestPanel.Name = "FriendRequestPanel";
            this.FriendRequestPanel.Size = new System.Drawing.Size(290, 534);
            this.FriendRequestPanel.TabIndex = 6;
            // 
            // MainChatApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1239, 710);
            this.Controls.Add(this.ChattingPanel);
            this.Controls.Add(this.SendMessgapanel);
            this.Controls.Add(this.ChatFriendPanel);
            this.Controls.Add(this.HeadPanel);
            this.Controls.Add(this.RightPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainChatApp";
            this.Text = "MainChatApp";
            this.HeadPanel.ResumeLayout(false);
            this.HeadPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageUser)).EndInit();
            this.SendMessgapanel.ResumeLayout(false);
            this.SendMessgapanel.PerformLayout();
            this.ChattingPanel.ResumeLayout(false);
            this.ChattingPanel.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel HeadPanel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ImageUser;
        private Panel panel4;
        private TextBox SearchFriendtxt;
        private Label Username;
        private Label label9;
        private PictureBox pictureBox3;
        private FlowLayoutPanel ChatFriendPanel;
        private Panel SendMessgapanel;
        private Button SendMessagebtn;
        private TextBox Messagetxt;
        private FlowLayoutPanel ChattingPanel;
        private Label starttochatlbl;
        private Label label1;
        private Button Logoutbtn;
        private Guna.UI2.WinForms.Guna2Panel RightPanel;
        private FlowLayoutPanel FriendRequestPanel;
    }
}