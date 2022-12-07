namespace Server
{
    partial class Server
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IPlbl = new System.Windows.Forms.Label();
            this.IPtxt = new System.Windows.Forms.TextBox();
            this.Portlbl = new System.Windows.Forms.Label();
            this.Porttxt = new System.Windows.Forms.TextBox();
            this.Startbtn = new System.Windows.Forms.Button();
            this.Stopbtn = new System.Windows.Forms.Button();
            this.Logtxt = new System.Windows.Forms.TextBox();
            this.TotalUserlbl = new System.Windows.Forms.Label();
            this.TotalUsertxt = new System.Windows.Forms.TextBox();
            this.OnlineUserlbl = new System.Windows.Forms.Label();
            this.OnlineUsertxt = new System.Windows.Forms.TextBox();
            this.testlb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IPlbl
            // 
            this.IPlbl.AutoSize = true;
            this.IPlbl.Location = new System.Drawing.Point(79, 44);
            this.IPlbl.Name = "IPlbl";
            this.IPlbl.Size = new System.Drawing.Size(58, 15);
            this.IPlbl.TabIndex = 0;
            this.IPlbl.Text = "Server IP :";
            // 
            // IPtxt
            // 
            this.IPtxt.Location = new System.Drawing.Point(148, 42);
            this.IPtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IPtxt.Name = "IPtxt";
            this.IPtxt.Size = new System.Drawing.Size(213, 23);
            this.IPtxt.TabIndex = 1;
            // 
            // Portlbl
            // 
            this.Portlbl.AutoSize = true;
            this.Portlbl.Location = new System.Drawing.Point(413, 44);
            this.Portlbl.Name = "Portlbl";
            this.Portlbl.Size = new System.Drawing.Size(35, 15);
            this.Portlbl.TabIndex = 2;
            this.Portlbl.Text = "Port :";
            // 
            // Porttxt
            // 
            this.Porttxt.Location = new System.Drawing.Point(455, 42);
            this.Porttxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Porttxt.Name = "Porttxt";
            this.Porttxt.Size = new System.Drawing.Size(110, 23);
            this.Porttxt.TabIndex = 3;
            this.Porttxt.Text = "2008";
            // 
            // Startbtn
            // 
            this.Startbtn.Location = new System.Drawing.Point(195, 100);
            this.Startbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(82, 22);
            this.Startbtn.TabIndex = 4;
            this.Startbtn.Text = "Start";
            this.Startbtn.UseVisualStyleBackColor = true;
            this.Startbtn.Click += new System.EventHandler(this.Startbtn_Click);
            // 
            // Stopbtn
            // 
            this.Stopbtn.Location = new System.Drawing.Point(428, 100);
            this.Stopbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Stopbtn.Name = "Stopbtn";
            this.Stopbtn.Size = new System.Drawing.Size(82, 22);
            this.Stopbtn.TabIndex = 5;
            this.Stopbtn.Text = "Stop";
            this.Stopbtn.UseVisualStyleBackColor = true;
            this.Stopbtn.Click += new System.EventHandler(this.Stopbtn_Click);
            // 
            // Logtxt
            // 
            this.Logtxt.Location = new System.Drawing.Point(79, 159);
            this.Logtxt.Margin = new System.Windows.Forms.Padding(2);
            this.Logtxt.Multiline = true;
            this.Logtxt.Name = "Logtxt";
            this.Logtxt.Size = new System.Drawing.Size(546, 140);
            this.Logtxt.TabIndex = 6;
            // 
            // TotalUserlbl
            // 
            this.TotalUserlbl.AutoSize = true;
            this.TotalUserlbl.Location = new System.Drawing.Point(79, 322);
            this.TotalUserlbl.Name = "TotalUserlbl";
            this.TotalUserlbl.Size = new System.Drawing.Size(66, 15);
            this.TotalUserlbl.TabIndex = 7;
            this.TotalUserlbl.Text = "Total Users:";
            this.TotalUserlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // TotalUsertxt
            // 
            this.TotalUsertxt.Location = new System.Drawing.Point(158, 320);
            this.TotalUsertxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TotalUsertxt.Name = "TotalUsertxt";
            this.TotalUsertxt.Size = new System.Drawing.Size(39, 23);
            this.TotalUsertxt.TabIndex = 8;
            // 
            // OnlineUserlbl
            // 
            this.OnlineUserlbl.AutoSize = true;
            this.OnlineUserlbl.Location = new System.Drawing.Point(226, 322);
            this.OnlineUserlbl.Name = "OnlineUserlbl";
            this.OnlineUserlbl.Size = new System.Drawing.Size(76, 15);
            this.OnlineUserlbl.TabIndex = 9;
            this.OnlineUserlbl.Text = "Online Users:";
            // 
            // OnlineUsertxt
            // 
            this.OnlineUsertxt.Location = new System.Drawing.Point(311, 320);
            this.OnlineUsertxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OnlineUsertxt.Name = "OnlineUsertxt";
            this.OnlineUsertxt.Size = new System.Drawing.Size(50, 23);
            this.OnlineUsertxt.TabIndex = 10;
            // 
            // testlb
            // 
            this.testlb.AutoSize = true;
            this.testlb.Location = new System.Drawing.Point(486, 324);
            this.testlb.Name = "testlb";
            this.testlb.Size = new System.Drawing.Size(38, 15);
            this.testlb.TabIndex = 11;
            this.testlb.Text = "label1";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 370);
            this.Controls.Add(this.testlb);
            this.Controls.Add(this.OnlineUsertxt);
            this.Controls.Add(this.OnlineUserlbl);
            this.Controls.Add(this.TotalUsertxt);
            this.Controls.Add(this.TotalUserlbl);
            this.Controls.Add(this.Logtxt);
            this.Controls.Add(this.Stopbtn);
            this.Controls.Add(this.Startbtn);
            this.Controls.Add(this.Porttxt);
            this.Controls.Add(this.Portlbl);
            this.Controls.Add(this.IPtxt);
            this.Controls.Add(this.IPlbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label IPlbl;
        private TextBox IPtxt;
        private Label Portlbl;
        private TextBox Porttxt;
        private Button Startbtn;
        private Button Stopbtn;
        private TextBox Logtxt;
        private Label TotalUserlbl;
        private TextBox TotalUsertxt;
        private Label OnlineUserlbl;
        private TextBox OnlineUsertxt;
        private Label testlb;
    }
}