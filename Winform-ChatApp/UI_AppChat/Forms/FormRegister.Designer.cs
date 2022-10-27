namespace UI_AppChat.Forms
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.Sologan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Signupbtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.FemaleradioButton = new System.Windows.Forms.RadioButton();
            this.MaleradioButton = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Fullnametxt = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordtxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.Mailtxt = new System.Windows.Forms.TextBox();
            this.Birthdaylbl = new System.Windows.Forms.Label();
            this.Sexlbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmPasswordlbl = new System.Windows.Forms.Label();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.UserEmaillbl = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panelLeft.Controls.Add(this.Sologan);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(273, 680);
            this.panelLeft.TabIndex = 0;
            // 
            // Sologan
            // 
            this.Sologan.AutoSize = true;
            this.Sologan.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sologan.ForeColor = System.Drawing.Color.White;
            this.Sologan.Location = new System.Drawing.Point(29, 309);
            this.Sologan.Name = "Sologan";
            this.Sologan.Size = new System.Drawing.Size(208, 76);
            this.Sologan.TabIndex = 1;
            this.Sologan.Text = "Welcome to \r\nChatApp";
            this.Sologan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI_AppChat.Properties.Resources.logoteam;
            this.pictureBox1.Location = new System.Drawing.Point(52, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.pictureBox2);
            this.panelRight.Controls.Add(this.Signupbtn);
            this.panelRight.Controls.Add(this.dateTimePicker1);
            this.panelRight.Controls.Add(this.FemaleradioButton);
            this.panelRight.Controls.Add(this.MaleradioButton);
            this.panelRight.Controls.Add(this.panel4);
            this.panelRight.Controls.Add(this.panel3);
            this.panelRight.Controls.Add(this.panel2);
            this.panelRight.Controls.Add(this.panel1);
            this.panelRight.Controls.Add(this.Fullnametxt);
            this.panelRight.Controls.Add(this.ConfirmPasswordtxt);
            this.panelRight.Controls.Add(this.Passwordtxt);
            this.panelRight.Controls.Add(this.Mailtxt);
            this.panelRight.Controls.Add(this.Birthdaylbl);
            this.panelRight.Controls.Add(this.Sexlbl);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.ConfirmPasswordlbl);
            this.panelRight.Controls.Add(this.Passwordlbl);
            this.panelRight.Controls.Add(this.UserEmaillbl);
            this.panelRight.Controls.Add(this.Title);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(273, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(356, 680);
            this.panelRight.TabIndex = 1;
            this.panelRight.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRight_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(286, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Signupbtn
            // 
            this.Signupbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Signupbtn.FlatAppearance.BorderSize = 0;
            this.Signupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signupbtn.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Signupbtn.ForeColor = System.Drawing.Color.White;
            this.Signupbtn.Location = new System.Drawing.Point(107, 603);
            this.Signupbtn.Name = "Signupbtn";
            this.Signupbtn.Size = new System.Drawing.Size(132, 38);
            this.Signupbtn.TabIndex = 12;
            this.Signupbtn.Text = "JOIN US";
            this.Signupbtn.UseVisualStyleBackColor = false;
            this.Signupbtn.Click += new System.EventHandler(this.Signupbtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 542);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // FemaleradioButton
            // 
            this.FemaleradioButton.AutoSize = true;
            this.FemaleradioButton.Location = new System.Drawing.Point(35, 467);
            this.FemaleradioButton.Name = "FemaleradioButton";
            this.FemaleradioButton.Size = new System.Drawing.Size(78, 24);
            this.FemaleradioButton.TabIndex = 10;
            this.FemaleradioButton.TabStop = true;
            this.FemaleradioButton.Text = "Female";
            this.FemaleradioButton.UseVisualStyleBackColor = true;
            // 
            // MaleradioButton
            // 
            this.MaleradioButton.AutoSize = true;
            this.MaleradioButton.Location = new System.Drawing.Point(35, 437);
            this.MaleradioButton.Name = "MaleradioButton";
            this.MaleradioButton.Size = new System.Drawing.Size(63, 24);
            this.MaleradioButton.TabIndex = 9;
            this.MaleradioButton.TabStop = true;
            this.MaleradioButton.Text = "Male";
            this.MaleradioButton.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel4.Location = new System.Drawing.Point(33, 379);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 1);
            this.panel4.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel3.Location = new System.Drawing.Point(33, 295);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 1);
            this.panel3.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(33, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(33, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 8;
            // 
            // Fullnametxt
            // 
            this.Fullnametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Fullnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Fullnametxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Fullnametxt.Location = new System.Drawing.Point(35, 349);
            this.Fullnametxt.Name = "Fullnametxt";
            this.Fullnametxt.PlaceholderText = "Nguyễn Văn A";
            this.Fullnametxt.Size = new System.Drawing.Size(248, 21);
            this.Fullnametxt.TabIndex = 7;
            // 
            // ConfirmPasswordtxt
            // 
            this.ConfirmPasswordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmPasswordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmPasswordtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ConfirmPasswordtxt.Location = new System.Drawing.Point(35, 265);
            this.ConfirmPasswordtxt.Name = "ConfirmPasswordtxt";
            this.ConfirmPasswordtxt.PasswordChar = '*';
            this.ConfirmPasswordtxt.Size = new System.Drawing.Size(248, 21);
            this.ConfirmPasswordtxt.TabIndex = 7;
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Passwordtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Passwordtxt.Location = new System.Drawing.Point(35, 185);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.PasswordChar = '*';
            this.Passwordtxt.Size = new System.Drawing.Size(248, 21);
            this.Passwordtxt.TabIndex = 7;
            // 
            // Mailtxt
            // 
            this.Mailtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Mailtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Mailtxt.Location = new System.Drawing.Point(35, 106);
            this.Mailtxt.Name = "Mailtxt";
            this.Mailtxt.PlaceholderText = "abc123@gmail.com";
            this.Mailtxt.Size = new System.Drawing.Size(248, 21);
            this.Mailtxt.TabIndex = 7;
            // 
            // Birthdaylbl
            // 
            this.Birthdaylbl.AutoSize = true;
            this.Birthdaylbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Birthdaylbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Birthdaylbl.Location = new System.Drawing.Point(33, 506);
            this.Birthdaylbl.Name = "Birthdaylbl";
            this.Birthdaylbl.Size = new System.Drawing.Size(93, 23);
            this.Birthdaylbl.TabIndex = 0;
            this.Birthdaylbl.Text = "Birthday:";
            // 
            // Sexlbl
            // 
            this.Sexlbl.AutoSize = true;
            this.Sexlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sexlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Sexlbl.Location = new System.Drawing.Point(33, 401);
            this.Sexlbl.Name = "Sexlbl";
            this.Sexlbl.Size = new System.Drawing.Size(48, 23);
            this.Sexlbl.TabIndex = 0;
            this.Sexlbl.Text = "Sex:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label4.Location = new System.Drawing.Point(27, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Full Name:";
            // 
            // ConfirmPasswordlbl
            // 
            this.ConfirmPasswordlbl.AutoSize = true;
            this.ConfirmPasswordlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmPasswordlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ConfirmPasswordlbl.Location = new System.Drawing.Point(27, 235);
            this.ConfirmPasswordlbl.Name = "ConfirmPasswordlbl";
            this.ConfirmPasswordlbl.Size = new System.Drawing.Size(189, 23);
            this.ConfirmPasswordlbl.TabIndex = 0;
            this.ConfirmPasswordlbl.Text = "Confirm Password:";
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Passwordlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Passwordlbl.Location = new System.Drawing.Point(27, 155);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(108, 23);
            this.Passwordlbl.TabIndex = 0;
            this.Passwordlbl.Text = "Password:";
            // 
            // UserEmaillbl
            // 
            this.UserEmaillbl.AutoSize = true;
            this.UserEmaillbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserEmaillbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.UserEmaillbl.Location = new System.Drawing.Point(27, 76);
            this.UserEmaillbl.Name = "UserEmaillbl";
            this.UserEmaillbl.Size = new System.Drawing.Size(67, 23);
            this.UserEmaillbl.TabIndex = 0;
            this.UserEmaillbl.Text = "Email:";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Title.Location = new System.Drawing.Point(27, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(122, 34);
            this.Title.TabIndex = 0;
            this.Title.Text = "SIGN UP";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 680);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelLeft;
        private PictureBox pictureBox1;
        private Panel panelRight;
        private Label Sologan;
        private Label UserEmaillbl;
        private Label Title;
        private TextBox Mailtxt;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private TextBox textBox3;
        private TextBox ConfirmPasswordtxt;
        private TextBox Passwordtxt;
        private Label label4;
        private Label ConfirmPasswordlbl;
        private Label Passwordlbl;
        private RadioButton FemaleradioButton;
        private RadioButton MaleradioButton;
        private Label Sexlbl;
        private Label Birthdaylbl;
        private DateTimePicker dateTimePicker1;
        private Button Signupbtn;
        private PictureBox pictureBox2;
        private TextBox Fullnametxt;
    }
}