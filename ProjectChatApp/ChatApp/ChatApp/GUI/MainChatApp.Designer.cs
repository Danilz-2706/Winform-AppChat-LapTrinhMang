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
            this.RightPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.NotiPanel = new System.Windows.Forms.Panel();
            this.NofiItemPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.FriendDenybtn = new System.Windows.Forms.Button();
            this.FriendAcpectbtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.HeadPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SearchFriendtxt = new System.Windows.Forms.TextBox();
            this.ImageUser = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.ChattingPanel = new System.Windows.Forms.Panel();
            this.MyFriendChattingPanel = new System.Windows.Forms.Panel();
            this.MyFriendlbl = new System.Windows.Forms.Label();
            this.MyFriendChattxt = new System.Windows.Forms.TextBox();
            this.MyUsernameChattingPanel = new System.Windows.Forms.Panel();
            this.MyUsernameChatlbl = new System.Windows.Forms.Label();
            this.MyUsernameChattxt = new System.Windows.Forms.TextBox();
            this.ChatFriendPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RightPanel.SuspendLayout();
            this.NotiPanel.SuspendLayout();
            this.NofiItemPanel.SuspendLayout();
            this.HeadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageUser)).BeginInit();
            this.ChattingPanel.SuspendLayout();
            this.MyFriendChattingPanel.SuspendLayout();
            this.MyUsernameChattingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.RightPanel.BorderColor = System.Drawing.Color.FloralWhite;
            this.RightPanel.Controls.Add(this.NotiPanel);
            this.RightPanel.Controls.Add(this.Logoutbtn);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(900, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(339, 710);
            this.RightPanel.TabIndex = 1;
            // 
            // NotiPanel
            // 
            this.NotiPanel.AutoScroll = true;
            this.NotiPanel.Controls.Add(this.NofiItemPanel);
            this.NotiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NotiPanel.Location = new System.Drawing.Point(0, 0);
            this.NotiPanel.Name = "NotiPanel";
            this.NotiPanel.Size = new System.Drawing.Size(339, 593);
            this.NotiPanel.TabIndex = 6;
            // 
            // NofiItemPanel
            // 
            this.NofiItemPanel.Controls.Add(this.FriendDenybtn);
            this.NofiItemPanel.Controls.Add(this.FriendAcpectbtn);
            this.NofiItemPanel.Controls.Add(this.label10);
            this.NofiItemPanel.Location = new System.Drawing.Point(7, 23);
            this.NofiItemPanel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.NofiItemPanel.Name = "NofiItemPanel";
            this.NofiItemPanel.Size = new System.Drawing.Size(325, 108);
            this.NofiItemPanel.TabIndex = 0;
            // 
            // FriendDenybtn
            // 
            this.FriendDenybtn.Location = new System.Drawing.Point(196, 60);
            this.FriendDenybtn.Name = "FriendDenybtn";
            this.FriendDenybtn.Size = new System.Drawing.Size(94, 29);
            this.FriendDenybtn.TabIndex = 5;
            this.FriendDenybtn.Text = "Hủy";
            this.FriendDenybtn.UseVisualStyleBackColor = true;
            // 
            // FriendAcpectbtn
            // 
            this.FriendAcpectbtn.Location = new System.Drawing.Point(32, 60);
            this.FriendAcpectbtn.Name = "FriendAcpectbtn";
            this.FriendAcpectbtn.Size = new System.Drawing.Size(94, 29);
            this.FriendAcpectbtn.TabIndex = 4;
            this.FriendAcpectbtn.Text = "Đồng ý";
            this.FriendAcpectbtn.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(3, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "User2 muốn kết bạn ";
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.BackColor = System.Drawing.Color.OrangeRed;
            this.Logoutbtn.FlatAppearance.BorderSize = 0;
            this.Logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logoutbtn.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Logoutbtn.ForeColor = System.Drawing.Color.White;
            this.Logoutbtn.Location = new System.Drawing.Point(96, 626);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(177, 64);
            this.Logoutbtn.TabIndex = 5;
            this.Logoutbtn.Text = "LOG OUT";
            this.Logoutbtn.UseVisualStyleBackColor = false;
            this.Logoutbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // HeadPanel
            // 
            this.HeadPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
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
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(215, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Online";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Username.ForeColor = System.Drawing.Color.Silver;
            this.Username.Location = new System.Drawing.Point(72, 24);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(99, 29);
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
            this.SearchFriendtxt.ForeColor = System.Drawing.Color.Black;
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
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 626);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(900, 84);
            this.guna2Panel2.TabIndex = 4;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // ChattingPanel
            // 
            this.ChattingPanel.AutoScroll = true;
            this.ChattingPanel.Controls.Add(this.MyFriendChattingPanel);
            this.ChattingPanel.Controls.Add(this.MyUsernameChattingPanel);
            this.ChattingPanel.Location = new System.Drawing.Point(313, 73);
            this.ChattingPanel.Name = "ChattingPanel";
            this.ChattingPanel.Size = new System.Drawing.Size(587, 553);
            this.ChattingPanel.TabIndex = 5;
            this.ChattingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ChattingPanel_Paint);
            // 
            // MyFriendChattingPanel
            // 
            this.MyFriendChattingPanel.Controls.Add(this.MyFriendlbl);
            this.MyFriendChattingPanel.Controls.Add(this.MyFriendChattxt);
            this.MyFriendChattingPanel.Location = new System.Drawing.Point(299, 126);
            this.MyFriendChattingPanel.Name = "MyFriendChattingPanel";
            this.MyFriendChattingPanel.Size = new System.Drawing.Size(255, 50);
            this.MyFriendChattingPanel.TabIndex = 2;
            // 
            // MyFriendlbl
            // 
            this.MyFriendlbl.BackColor = System.Drawing.Color.Transparent;
            this.MyFriendlbl.ForeColor = System.Drawing.Color.White;
            this.MyFriendlbl.Location = new System.Drawing.Point(180, 12);
            this.MyFriendlbl.Name = "MyFriendlbl";
            this.MyFriendlbl.Size = new System.Drawing.Size(62, 25);
            this.MyFriendlbl.TabIndex = 1;
            this.MyFriendlbl.Text = "label9";
            // 
            // MyFriendChattxt
            // 
            this.MyFriendChattxt.ForeColor = System.Drawing.Color.OrangeRed;
            this.MyFriendChattxt.Location = new System.Drawing.Point(13, 10);
            this.MyFriendChattxt.Name = "MyFriendChattxt";
            this.MyFriendChattxt.Size = new System.Drawing.Size(151, 27);
            this.MyFriendChattxt.TabIndex = 0;
            this.MyFriendChattxt.Text = "Hello";
            this.MyFriendChattxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MyUsernameChattingPanel
            // 
            this.MyUsernameChattingPanel.Controls.Add(this.MyUsernameChatlbl);
            this.MyUsernameChattingPanel.Controls.Add(this.MyUsernameChattxt);
            this.MyUsernameChattingPanel.Location = new System.Drawing.Point(37, 37);
            this.MyUsernameChattingPanel.Name = "MyUsernameChattingPanel";
            this.MyUsernameChattingPanel.Size = new System.Drawing.Size(255, 50);
            this.MyUsernameChattingPanel.TabIndex = 1;
            // 
            // MyUsernameChatlbl
            // 
            this.MyUsernameChatlbl.BackColor = System.Drawing.Color.Transparent;
            this.MyUsernameChatlbl.ForeColor = System.Drawing.Color.White;
            this.MyUsernameChatlbl.Location = new System.Drawing.Point(19, 13);
            this.MyUsernameChatlbl.Name = "MyUsernameChatlbl";
            this.MyUsernameChatlbl.Size = new System.Drawing.Size(62, 25);
            this.MyUsernameChatlbl.TabIndex = 1;
            this.MyUsernameChatlbl.Text = "label9";
            this.MyUsernameChatlbl.Click += new System.EventHandler(this.label9_Click);
            // 
            // MyUsernameChattxt
            // 
            this.MyUsernameChattxt.ForeColor = System.Drawing.Color.OrangeRed;
            this.MyUsernameChattxt.Location = new System.Drawing.Point(88, 9);
            this.MyUsernameChattxt.Name = "MyUsernameChattxt";
            this.MyUsernameChattxt.Size = new System.Drawing.Size(151, 27);
            this.MyUsernameChattxt.TabIndex = 0;
            this.MyUsernameChattxt.Text = "Hello";
            // 
            // ChatFriendPanel
            // 
            this.ChatFriendPanel.AutoScroll = true;
            this.ChatFriendPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ChatFriendPanel.Location = new System.Drawing.Point(0, 73);
            this.ChatFriendPanel.Name = "ChatFriendPanel";
            this.ChatFriendPanel.Size = new System.Drawing.Size(315, 553);
            this.ChatFriendPanel.TabIndex = 6;
            // 
            // MainChatApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1239, 710);
            this.Controls.Add(this.ChatFriendPanel);
            this.Controls.Add(this.ChattingPanel);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.HeadPanel);
            this.Controls.Add(this.RightPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainChatApp";
            this.Text = "MainChatApp";
            this.RightPanel.ResumeLayout(false);
            this.NotiPanel.ResumeLayout(false);
            this.NofiItemPanel.ResumeLayout(false);
            this.NofiItemPanel.PerformLayout();
            this.HeadPanel.ResumeLayout(false);
            this.HeadPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageUser)).EndInit();
            this.ChattingPanel.ResumeLayout(false);
            this.MyFriendChattingPanel.ResumeLayout(false);
            this.MyFriendChattingPanel.PerformLayout();
            this.MyUsernameChattingPanel.ResumeLayout(false);
            this.MyUsernameChattingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel RightPanel;
        private Guna.UI2.WinForms.Guna2Panel HeadPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ImageUser;
        private Panel ChattingPanel;
        private Panel MyUsernameChattingPanel;
        private Label MyUsernameChatlbl;
        private TextBox MyUsernameChattxt;
        private Panel MyFriendChattingPanel;
        private Label MyFriendlbl;
        private TextBox MyFriendChattxt;
        private Button Logoutbtn;
        private Panel panel4;
        private TextBox SearchFriendtxt;
        private Label Username;
        private Label label9;
        private Panel NotiPanel;
        private Guna.UI2.WinForms.Guna2Panel NofiItemPanel;
        private Button FriendDenybtn;
        private Button FriendAcpectbtn;
        private Label label10;
        private PictureBox pictureBox3;
        private FlowLayoutPanel ChatFriendPanel;
    }
}