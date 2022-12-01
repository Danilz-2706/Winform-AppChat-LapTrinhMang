namespace ChatApp.GUI
{
    partial class FriendChat
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
            this.UserNameMessage = new System.Windows.Forms.Label();
            this.UserMessage = new System.Windows.Forms.Label();
            this.MessPanel = new System.Windows.Forms.Panel();
            this.MessPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserNameMessage
            // 
            this.UserNameMessage.AutoSize = true;
            this.UserNameMessage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNameMessage.Location = new System.Drawing.Point(6, 41);
            this.UserNameMessage.Name = "UserNameMessage";
            this.UserNameMessage.Size = new System.Drawing.Size(94, 23);
            this.UserNameMessage.TabIndex = 1;
            this.UserNameMessage.Text = "UserName:";
            this.UserNameMessage.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // UserMessage
            // 
            this.UserMessage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserMessage.Location = new System.Drawing.Point(9, 8);
            this.UserMessage.Name = "UserMessage";
            this.UserMessage.Size = new System.Drawing.Size(360, 111);
            this.UserMessage.TabIndex = 2;
            this.UserMessage.Text = "Chat Message";
            // 
            // MessPanel
            // 
            this.MessPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MessPanel.Controls.Add(this.UserMessage);
            this.MessPanel.Location = new System.Drawing.Point(140, 0);
            this.MessPanel.Name = "MessPanel";
            this.MessPanel.Size = new System.Drawing.Size(378, 128);
            this.MessPanel.TabIndex = 3;
            // 
            // FriendChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MessPanel);
            this.Controls.Add(this.UserNameMessage);
            this.Name = "FriendChat";
            this.Size = new System.Drawing.Size(521, 135);
            this.Load += new System.EventHandler(this.ListChat_Load);
            this.MessPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label UserNameMessage;
        private Label UserMessage;
        private Panel MessPanel;
    }
}
