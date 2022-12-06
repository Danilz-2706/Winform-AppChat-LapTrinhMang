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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameRequestlbl
            // 
            this.UsernameRequestlbl.AutoSize = true;
            this.UsernameRequestlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsernameRequestlbl.Location = new System.Drawing.Point(30, 21);
            this.UsernameRequestlbl.Name = "UsernameRequestlbl";
            this.UsernameRequestlbl.Size = new System.Drawing.Size(0, 20);
            this.UsernameRequestlbl.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Chấp nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "muốn kết bạn";
            // 
            // FriendRequestListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UsernameRequestlbl);
            this.Name = "FriendRequestListView";
            this.Size = new System.Drawing.Size(251, 116);
            this.Load += new System.EventHandler(this.FriendRequestListView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label UsernameRequestlbl;
        private Button button1;
        private Button button2;
        private Label label1;
    }
}
