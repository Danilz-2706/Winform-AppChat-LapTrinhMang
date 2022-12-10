﻿namespace ChatApp.GUI
{
    partial class MeChat
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
            this.UserMessage = new System.Windows.Forms.Label();
            this.MessPanel = new System.Windows.Forms.Panel();
            this.seenlbl = new System.Windows.Forms.Label();
            this.MessPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserMessage
            // 
            this.UserMessage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.UserMessage.Location = new System.Drawing.Point(9, 8);
            this.UserMessage.Name = "UserMessage";
            this.UserMessage.Size = new System.Drawing.Size(305, 44);
            this.UserMessage.TabIndex = 2;
            this.UserMessage.Text = "Chat Message";
            // 
            // MessPanel
            // 
            this.MessPanel.BackColor = System.Drawing.Color.Tomato;
            this.MessPanel.Controls.Add(this.UserMessage);
            this.MessPanel.Location = new System.Drawing.Point(112, 7);
            this.MessPanel.Name = "MessPanel";
            this.MessPanel.Size = new System.Drawing.Size(328, 136);
            this.MessPanel.TabIndex = 3;
            // 
            // seenlbl
            // 
            this.seenlbl.AutoSize = true;
            this.seenlbl.Location = new System.Drawing.Point(3, 7);
            this.seenlbl.Name = "seenlbl";
            this.seenlbl.Size = new System.Drawing.Size(50, 20);
            this.seenlbl.TabIndex = 3;
            this.seenlbl.Text = "label1";
            // 
            // MeChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.seenlbl);
            this.Controls.Add(this.MessPanel);
            this.Name = "MeChat";
            this.Size = new System.Drawing.Size(453, 163);
            this.Load += new System.EventHandler(this.ListChat_Load);
            this.MessPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label UserMessage;
        private Panel MessPanel;
        private Label seenlbl;
    }
}
