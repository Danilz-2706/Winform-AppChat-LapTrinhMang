﻿namespace UI_AppChat.Forms
{
    partial class FormLogin
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
            this.LogoLogin = new System.Windows.Forms.PictureBox();
            this.LoginTitle = new System.Windows.Forms.Label();
            this.UserPic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PasswordPic = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Clean = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.Usertxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.Registerbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPic)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoLogin
            // 
            this.LogoLogin.Image = global::UI_AppChat.Properties.Resources.logoteam;
            this.LogoLogin.Location = new System.Drawing.Point(101, 28);
            this.LogoLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoLogin.Name = "LogoLogin";
            this.LogoLogin.Size = new System.Drawing.Size(67, 55);
            this.LogoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoLogin.TabIndex = 0;
            this.LogoLogin.TabStop = false;
            // 
            // LoginTitle
            // 
            this.LoginTitle.AutoSize = true;
            this.LoginTitle.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.LoginTitle.Location = new System.Drawing.Point(71, 98);
            this.LoginTitle.Name = "LoginTitle";
            this.LoginTitle.Size = new System.Drawing.Size(114, 36);
            this.LoginTitle.TabIndex = 1;
            this.LoginTitle.Text = "LOG IN";
            // 
            // UserPic
            // 
            this.UserPic.Image = global::UI_AppChat.Properties.Resources.user;
            this.UserPic.Location = new System.Drawing.Point(19, 149);
            this.UserPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserPic.Name = "UserPic";
            this.UserPic.Size = new System.Drawing.Size(22, 19);
            this.UserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPic.TabIndex = 2;
            this.UserPic.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(19, 172);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 1);
            this.panel1.TabIndex = 3;
            // 
            // PasswordPic
            // 
            this.PasswordPic.Image = global::UI_AppChat.Properties.Resources._lock;
            this.PasswordPic.Location = new System.Drawing.Point(19, 199);
            this.PasswordPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordPic.Name = "PasswordPic";
            this.PasswordPic.Size = new System.Drawing.Size(22, 19);
            this.PasswordPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PasswordPic.TabIndex = 2;
            this.PasswordPic.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(19, 222);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 1);
            this.panel2.TabIndex = 3;
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Loginbtn.FlatAppearance.BorderSize = 0;
            this.Loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbtn.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Loginbtn.ForeColor = System.Drawing.Color.White;
            this.Loginbtn.Location = new System.Drawing.Point(19, 265);
            this.Loginbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(219, 28);
            this.Loginbtn.TabIndex = 4;
            this.Loginbtn.Text = "LOG IN";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // Clean
            // 
            this.Clean.AutoSize = true;
            this.Clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Clean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Clean.Location = new System.Drawing.Point(128, 241);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(94, 17);
            this.Clean.TabIndex = 5;
            this.Clean.Text = "Clear Fields";
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Exit.Location = new System.Drawing.Point(109, 336);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(34, 17);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Usertxt
            // 
            this.Usertxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Usertxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Usertxt.Location = new System.Drawing.Point(45, 151);
            this.Usertxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Usertxt.Name = "Usertxt";
            this.Usertxt.Size = new System.Drawing.Size(193, 17);
            this.Usertxt.TabIndex = 6;
            this.Usertxt.Text = "test123@gmail.com";
            this.Usertxt.TextChanged += new System.EventHandler(this.Usertxt_TextChanged);
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Passwordtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Passwordtxt.Location = new System.Drawing.Point(45, 200);
            this.Passwordtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.PasswordChar = '*';
            this.Passwordtxt.Size = new System.Drawing.Size(193, 17);
            this.Passwordtxt.TabIndex = 6;
            this.Passwordtxt.Text = "123";
            // 
            // Registerbtn
            // 
            this.Registerbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Registerbtn.FlatAppearance.BorderSize = 0;
            this.Registerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registerbtn.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Registerbtn.ForeColor = System.Drawing.Color.White;
            this.Registerbtn.Location = new System.Drawing.Point(19, 298);
            this.Registerbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Size = new System.Drawing.Size(219, 28);
            this.Registerbtn.TabIndex = 4;
            this.Registerbtn.Text = "SIGN UP";
            this.Registerbtn.UseVisualStyleBackColor = false;
            this.Registerbtn.Click += new System.EventHandler(this.Registerbtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(270, 364);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.Usertxt);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.Registerbtn);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PasswordPic);
            this.Controls.Add(this.UserPic);
            this.Controls.Add(this.LoginTitle);
            this.Controls.Add(this.LogoLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox LogoLogin;
        private Label LoginTitle;
        private PictureBox UserPic;
        private Panel panel1;
        private PictureBox PasswordPic;
        private Panel panel2;
        private Button Loginbtn;
        private Label Clean;
        private Label Exit;
        private TextBox Usertxt;
        private TextBox Passwordtxt;
        private Button Registerbtn;
    }
}