namespace UI_AppChat
{
    partial class FormListFriendChatting
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListFriendChatting));
            this.pnlListFriend = new Guna.UI2.WinForms.Guna2Panel();
            this.flpListItem = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.ChattingPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SendMessagePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Messagetxt = new System.Windows.Forms.TextBox();
            this.SendMessagebtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pnlListFriend.SuspendLayout();
            this.flpListItem.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SendMessagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlListFriend
            // 
            this.pnlListFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.pnlListFriend.Controls.Add(this.flpListItem);
            this.pnlListFriend.Controls.Add(this.guna2Panel1);
            this.pnlListFriend.CustomBorderColor = System.Drawing.Color.DimGray;
            this.pnlListFriend.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.pnlListFriend.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlListFriend.Location = new System.Drawing.Point(0, 0);
            this.pnlListFriend.Name = "pnlListFriend";
            this.pnlListFriend.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.pnlListFriend.ShadowDecoration.Enabled = true;
            this.pnlListFriend.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 5, 7);
            this.pnlListFriend.Size = new System.Drawing.Size(298, 646);
            this.pnlListFriend.TabIndex = 4;
            // 
            // flpListItem
            // 
            this.flpListItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpListItem.AutoScroll = true;
            this.flpListItem.Controls.Add(this.flowLayoutPanel1);
            this.flpListItem.Location = new System.Drawing.Point(0, 73);
            this.flpListItem.Name = "flpListItem";
            this.flpListItem.Padding = new System.Windows.Forms.Padding(4);
            this.flpListItem.Size = new System.Drawing.Size(298, 573);
            this.flpListItem.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(298, 73);
            this.guna2Panel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txbSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(12, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 24);
            this.panel1.TabIndex = 3;
            // 
            // txbSearch
            // 
            this.txbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txbSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSearch.Location = new System.Drawing.Point(38, 0);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.txbSearch.MinimumSize = new System.Drawing.Size(227, 24);
            this.txbSearch.Multiline = true;
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(227, 24);
            this.txbSearch.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageSize = new System.Drawing.Size(18, 18);
            this.btnSearch.IndicateFocus = true;
            this.btnSearch.Location = new System.Drawing.Point(0, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 24);
            this.btnSearch.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.panel2.BackgroundImage = global::UI_AppChat.Properties.Resources.background_2;
            this.panel2.Controls.Add(this.ChattingPanel);
            this.panel2.Controls.Add(this.SendMessagePanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(298, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 646);
            this.panel2.TabIndex = 5;
            // 
            // ChattingPanel
            // 
            this.ChattingPanel.AutoScroll = true;
            this.ChattingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.ChattingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChattingPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ChattingPanel.Location = new System.Drawing.Point(0, 0);
            this.ChattingPanel.Name = "ChattingPanel";
            this.ChattingPanel.Size = new System.Drawing.Size(610, 592);
            this.ChattingPanel.TabIndex = 14;
            this.ChattingPanel.WrapContents = false;
            // 
            // SendMessagePanel
            // 
            this.SendMessagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.SendMessagePanel.Controls.Add(this.guna2CircleButton2);
            this.SendMessagePanel.Controls.Add(this.guna2CircleButton1);
            this.SendMessagePanel.Controls.Add(this.Messagetxt);
            this.SendMessagePanel.Controls.Add(this.SendMessagebtn);
            this.SendMessagePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SendMessagePanel.Location = new System.Drawing.Point(0, 592);
            this.SendMessagePanel.Name = "SendMessagePanel";
            this.SendMessagePanel.Size = new System.Drawing.Size(610, 54);
            this.SendMessagePanel.TabIndex = 13;
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton2.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton2.Image")));
            this.guna2CircleButton2.Location = new System.Drawing.Point(410, 11);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.Size = new System.Drawing.Size(32, 32);
            this.guna2CircleButton2.TabIndex = 4;
            this.guna2CircleButton2.Click += new System.EventHandler(this.guna2CircleButton2_Click);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.Image")));
            this.guna2CircleButton1.Location = new System.Drawing.Point(372, 11);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(32, 32);
            this.guna2CircleButton1.TabIndex = 3;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // Messagetxt
            // 
            this.Messagetxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Messagetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Messagetxt.Location = new System.Drawing.Point(12, 11);
            this.Messagetxt.Multiline = true;
            this.Messagetxt.Name = "Messagetxt";
            this.Messagetxt.Size = new System.Drawing.Size(307, 32);
            this.Messagetxt.TabIndex = 2;
            // 
            // SendMessagebtn
            // 
            this.SendMessagebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendMessagebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SendMessagebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SendMessagebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SendMessagebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SendMessagebtn.FillColor = System.Drawing.Color.Transparent;
            this.SendMessagebtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SendMessagebtn.ForeColor = System.Drawing.Color.White;
            this.SendMessagebtn.Image = ((System.Drawing.Image)(resources.GetObject("SendMessagebtn.Image")));
            this.SendMessagebtn.Location = new System.Drawing.Point(330, 11);
            this.SendMessagebtn.Name = "SendMessagebtn";
            this.SendMessagebtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.SendMessagebtn.Size = new System.Drawing.Size(32, 32);
            this.SendMessagebtn.TabIndex = 0;
            this.SendMessagebtn.Click += new System.EventHandler(this.SendMessagebtn_Click);
            // 
            // FormListFriendChatting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 646);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlListFriend);
            this.Name = "FormListFriendChatting";
            this.Text = "FormListFriendChatting";
            this.pnlListFriend.ResumeLayout(false);
            this.flpListItem.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.SendMessagePanel.ResumeLayout(false);
            this.SendMessagePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlListFriend;
        private FlowLayoutPanel flpListItem;
        private FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private TextBox txbSearch;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Panel panel2;
        private FlowLayoutPanel ChattingPanel;
        private Guna.UI2.WinForms.Guna2Panel SendMessagePanel;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private TextBox Messagetxt;
        private Guna.UI2.WinForms.Guna2CircleButton SendMessagebtn;
    }
}