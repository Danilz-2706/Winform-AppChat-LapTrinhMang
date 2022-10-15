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
            this.SuspendLayout();
            // 
            // IPlbl
            // 
            this.IPlbl.AutoSize = true;
            this.IPlbl.Location = new System.Drawing.Point(90, 59);
            this.IPlbl.Name = "IPlbl";
            this.IPlbl.Size = new System.Drawing.Size(73, 20);
            this.IPlbl.TabIndex = 0;
            this.IPlbl.Text = "Server IP :";
            // 
            // IPtxt
            // 
            this.IPtxt.Location = new System.Drawing.Point(169, 56);
            this.IPtxt.Name = "IPtxt";
            this.IPtxt.Size = new System.Drawing.Size(243, 27);
            this.IPtxt.TabIndex = 1;
            // 
            // Portlbl
            // 
            this.Portlbl.AutoSize = true;
            this.Portlbl.Location = new System.Drawing.Point(472, 59);
            this.Portlbl.Name = "Portlbl";
            this.Portlbl.Size = new System.Drawing.Size(42, 20);
            this.Portlbl.TabIndex = 2;
            this.Portlbl.Text = "Port :";
            // 
            // Porttxt
            // 
            this.Porttxt.Location = new System.Drawing.Point(520, 56);
            this.Porttxt.Name = "Porttxt";
            this.Porttxt.Size = new System.Drawing.Size(125, 27);
            this.Porttxt.TabIndex = 3;
            this.Porttxt.Text = "2008";
            // 
            // Startbtn
            // 
            this.Startbtn.Location = new System.Drawing.Point(223, 134);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(94, 29);
            this.Startbtn.TabIndex = 4;
            this.Startbtn.Text = "Start";
            this.Startbtn.UseVisualStyleBackColor = true;
            this.Startbtn.Click += new System.EventHandler(this.Startbtn_Click);
            // 
            // Stopbtn
            // 
            this.Stopbtn.Location = new System.Drawing.Point(489, 134);
            this.Stopbtn.Name = "Stopbtn";
            this.Stopbtn.Size = new System.Drawing.Size(94, 29);
            this.Stopbtn.TabIndex = 5;
            this.Stopbtn.Text = "Stop";
            this.Stopbtn.UseVisualStyleBackColor = true;
            this.Stopbtn.Click += new System.EventHandler(this.Stopbtn_Click);
            // 
            // Logtxt
            // 
            this.Logtxt.Location = new System.Drawing.Point(90, 212);
            this.Logtxt.Margin = new System.Windows.Forms.Padding(2);
            this.Logtxt.Multiline = true;
            this.Logtxt.Name = "Logtxt";
            this.Logtxt.Size = new System.Drawing.Size(624, 185);
            this.Logtxt.TabIndex = 6;
            // 
            // TotalUserlbl
            // 
            this.TotalUserlbl.AutoSize = true;
            this.TotalUserlbl.Location = new System.Drawing.Point(90, 429);
            this.TotalUserlbl.Name = "TotalUserlbl";
            this.TotalUserlbl.Size = new System.Drawing.Size(84, 20);
            this.TotalUserlbl.TabIndex = 7;
            this.TotalUserlbl.Text = "Total Users:";
            this.TotalUserlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // TotalUsertxt
            // 
            this.TotalUsertxt.Location = new System.Drawing.Point(180, 426);
            this.TotalUsertxt.Name = "TotalUsertxt";
            this.TotalUsertxt.Size = new System.Drawing.Size(44, 27);
            this.TotalUsertxt.TabIndex = 8;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.TotalUsertxt);
            this.Controls.Add(this.TotalUserlbl);
            this.Controls.Add(this.Logtxt);
            this.Controls.Add(this.Stopbtn);
            this.Controls.Add(this.Startbtn);
            this.Controls.Add(this.Porttxt);
            this.Controls.Add(this.Portlbl);
            this.Controls.Add(this.IPtxt);
            this.Controls.Add(this.IPlbl);
            this.Name = "Server";
            this.Text = "Form1";
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
    }
}