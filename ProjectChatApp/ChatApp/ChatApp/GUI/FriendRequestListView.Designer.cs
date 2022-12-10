namespace ChatApp.GUI
{
    partial class FriendRequestListView
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
            this.UsernameRequestlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_accept = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameRequestlbl
            // 
            this.UsernameRequestlbl.AutoSize = true;
            this.UsernameRequestlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsernameRequestlbl.Location = new System.Drawing.Point(17, 15);
            this.UsernameRequestlbl.Name = "UsernameRequestlbl";
            this.UsernameRequestlbl.Size = new System.Drawing.Size(0, 20);
            this.UsernameRequestlbl.TabIndex = 0;
            this.UsernameRequestlbl.Click += new System.EventHandler(this.lbl_username_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Muon ket ban";
            // 
            // btn_accept
            // 
            this.btn_accept.Location = new System.Drawing.Point(21, 69);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(80, 29);
            this.btn_accept.TabIndex = 2;
            this.btn_accept.Text = "Dong y";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(134, 69);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(80, 29);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Huy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // FriendRequestListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsernameRequestlbl);
            this.Name = "FriendRequestListView";
            this.Size = new System.Drawing.Size(235, 109);
            this.Load += new System.EventHandler(this.FriendRequestListView_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label UsernameRequestlbl;
        private Label label2;
        private Button btn_accept;
        private Button btn_cancel;
    }
}
