namespace eparkmo
{
    partial class login
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
            this.btn_forgotpassword = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_login = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_email = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_forgotpassword
            // 
            this.btn_forgotpassword.AutoSize = true;
            this.btn_forgotpassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_forgotpassword.Depth = 0;
            this.btn_forgotpassword.Icon = null;
            this.btn_forgotpassword.Location = new System.Drawing.Point(290, 321);
            this.btn_forgotpassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_forgotpassword.Name = "btn_forgotpassword";
            this.btn_forgotpassword.Primary = true;
            this.btn_forgotpassword.Size = new System.Drawing.Size(151, 36);
            this.btn_forgotpassword.TabIndex = 30;
            this.btn_forgotpassword.Text = "Forgot Password";
            this.btn_forgotpassword.UseVisualStyleBackColor = true;
            this.btn_forgotpassword.Click += new System.EventHandler(this.btn_forgotpassword_Click);
            // 
            // btn_login
            // 
            this.btn_login.AutoSize = true;
            this.btn_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_login.Depth = 0;
            this.btn_login.Icon = null;
            this.btn_login.Location = new System.Drawing.Point(223, 321);
            this.btn_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_login.Name = "btn_login";
            this.btn_login.Primary = true;
            this.btn_login.Size = new System.Drawing.Size(61, 36);
            this.btn_login.TabIndex = 29;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.Control;
            this.txt_password.Depth = 0;
            this.txt_password.Hint = "Password";
            this.txt_password.Location = new System.Drawing.Point(223, 282);
            this.txt_password.MaxLength = 32767;
            this.txt_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_password.Name = "txt_password";
            this.txt_password.Padding = new System.Windows.Forms.Padding(1);
            this.txt_password.PasswordChar = '*';
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.Size = new System.Drawing.Size(218, 23);
            this.txt_password.TabIndex = 27;
            this.txt_password.TabStop = false;
            this.txt_password.UseSystemPasswordChar = false;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.Control;
            this.txt_email.Depth = 0;
            this.txt_email.Hint = "Email";
            this.txt_email.Location = new System.Drawing.Point(223, 235);
            this.txt_email.MaxLength = 32767;
            this.txt_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_email.Name = "txt_email";
            this.txt_email.Padding = new System.Windows.Forms.Padding(1);
            this.txt_email.PasswordChar = '\0';
            this.txt_email.SelectedText = "";
            this.txt_email.SelectionLength = 0;
            this.txt_email.SelectionStart = 0;
            this.txt_email.Size = new System.Drawing.Size(218, 23);
            this.txt_email.TabIndex = 25;
            this.txt_email.TabStop = false;
            this.txt_email.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(175, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 74);
            this.label1.TabIndex = 24;
            this.label1.Text = "Automated Parking\r\nSystem";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::eparkmo.Properties.Resources.ic_lock_black_24dp;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(193, 282);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::eparkmo.Properties.Resources.ic_account_circle_black_24dp;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(193, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 476);
            this.Controls.Add(this.btn_forgotpassword);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "login";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.login_FormClosed);
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btn_forgotpassword;
        private MaterialSkin.Controls.MaterialRaisedButton btn_login;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_email;
        private System.Windows.Forms.Label label1;
    }
}

