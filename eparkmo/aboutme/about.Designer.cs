namespace eparkmo.aboutme
{
    partial class about
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
            this.lsb_aboutuser = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lsb_aboutuser
            // 
            this.lsb_aboutuser.FormattingEnabled = true;
            this.lsb_aboutuser.Location = new System.Drawing.Point(12, 11);
            this.lsb_aboutuser.Name = "lsb_aboutuser";
            this.lsb_aboutuser.Size = new System.Drawing.Size(258, 160);
            this.lsb_aboutuser.TabIndex = 0;
            // 
            // about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 183);
            this.Controls.Add(this.lsb_aboutuser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "about";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About me";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsb_aboutuser;
    }
}