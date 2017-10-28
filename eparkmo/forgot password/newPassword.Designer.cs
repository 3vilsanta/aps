namespace eparkmo.forgot_password
{
    partial class newPassword
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
            this.txt_n_p = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_save = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_n_rp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // txt_n_p
            // 
            this.txt_n_p.Depth = 0;
            this.txt_n_p.Hint = "New Password";
            this.txt_n_p.Location = new System.Drawing.Point(70, 105);
            this.txt_n_p.MaxLength = 32767;
            this.txt_n_p.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_n_p.Name = "txt_n_p";
            this.txt_n_p.PasswordChar = '\0';
            this.txt_n_p.SelectedText = "";
            this.txt_n_p.SelectionLength = 0;
            this.txt_n_p.SelectionStart = 0;
            this.txt_n_p.Size = new System.Drawing.Size(298, 23);
            this.txt_n_p.TabIndex = 4;
            this.txt_n_p.TabStop = false;
            this.txt_n_p.UseSystemPasswordChar = false;
            // 
            // btn_save
            // 
            this.btn_save.AutoSize = true;
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Depth = 0;
            this.btn_save.Icon = null;
            this.btn_save.Location = new System.Drawing.Point(295, 184);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.Primary = true;
            this.btn_save.Size = new System.Drawing.Size(73, 36);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "update";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_n_rp
            // 
            this.txt_n_rp.Depth = 0;
            this.txt_n_rp.Hint = "Retype New Password";
            this.txt_n_rp.Location = new System.Drawing.Point(70, 144);
            this.txt_n_rp.MaxLength = 32767;
            this.txt_n_rp.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_n_rp.Name = "txt_n_rp";
            this.txt_n_rp.PasswordChar = '*';
            this.txt_n_rp.SelectedText = "";
            this.txt_n_rp.SelectionLength = 0;
            this.txt_n_rp.SelectionStart = 0;
            this.txt_n_rp.Size = new System.Drawing.Size(298, 23);
            this.txt_n_rp.TabIndex = 5;
            this.txt_n_rp.TabStop = false;
            this.txt_n_rp.UseSystemPasswordChar = false;
            // 
            // newPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 257);
            this.Controls.Add(this.txt_n_p);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_n_rp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "newPassword";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Password";
            this.Load += new System.EventHandler(this.newPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txt_n_p;
        private MaterialSkin.Controls.MaterialRaisedButton btn_save;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_n_rp;
    }
}