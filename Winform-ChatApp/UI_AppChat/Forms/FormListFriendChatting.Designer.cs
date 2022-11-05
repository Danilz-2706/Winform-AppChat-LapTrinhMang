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
            this.panelChattingDetail = new System.Windows.Forms.Panel();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.pnlListFriend.SuspendLayout();
            this.flpListItem.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // panelChattingDetail
            // 
            this.panelChattingDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.panelChattingDetail.BackgroundImage = global::UI_AppChat.Properties.Resources.background_2;
            this.panelChattingDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelChattingDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChattingDetail.Location = new System.Drawing.Point(298, 0);
            this.panelChattingDetail.Name = "panelChattingDetail";
            this.panelChattingDetail.Size = new System.Drawing.Size(610, 646);
            this.panelChattingDetail.TabIndex = 5;
            // 
            // FormListFriendChatting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 646);
            this.Controls.Add(this.panelChattingDetail);
            this.Controls.Add(this.pnlListFriend);
            this.Name = "FormListFriendChatting";
            this.Text = "FormListFriendChatting";
            this.pnlListFriend.ResumeLayout(false);
            this.flpListItem.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlListFriend;
        private Panel panelChattingDetail;
        private FlowLayoutPanel flpListItem;
        private FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private TextBox txbSearch;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}