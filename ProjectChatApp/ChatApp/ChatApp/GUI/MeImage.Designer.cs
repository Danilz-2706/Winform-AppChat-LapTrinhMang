namespace ChatApp.GUI
{
    partial class MeImage
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
            this.seenlbl = new System.Windows.Forms.Label();
            this.ImageContent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageContent)).BeginInit();
            this.SuspendLayout();
            // 
            // seenlbl
            // 
            this.seenlbl.AutoSize = true;
            this.seenlbl.Location = new System.Drawing.Point(3, 9);
            this.seenlbl.Name = "seenlbl";
            this.seenlbl.Size = new System.Drawing.Size(56, 20);
            this.seenlbl.TabIndex = 0;
            this.seenlbl.Text = "seenlbl";
            // 
            // ImageContent
            // 
            this.ImageContent.Location = new System.Drawing.Point(110, 13);
            this.ImageContent.Name = "ImageContent";
            this.ImageContent.Size = new System.Drawing.Size(180, 150);
            this.ImageContent.TabIndex = 1;
            this.ImageContent.TabStop = false;
            // 
            // MeImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.seenlbl);
            this.Controls.Add(this.ImageContent);
            this.Name = "MeImage";
            this.Size = new System.Drawing.Size(339, 178);
            ((System.ComponentModel.ISupportInitialize)(this.ImageContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label seenlbl;
        private PictureBox ImageContent;
    }
}
