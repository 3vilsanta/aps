namespace eparkmo.admin.employee
{
    partial class newEmployee
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
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cb_view = new System.Windows.Forms.CheckBox();
            this.txt_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_email = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmb_areacode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.cmb_gender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_lname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_fname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_browseimage = new MaterialSkin.Controls.MaterialFlatButton();
            this.pb_profilepicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profilepicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(637, 285);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(107, 36);
            this.btnSave.TabIndex = 63;
            this.btnSave.Text = ".....  Save  .....";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cb_view
            // 
            this.cb_view.AutoSize = true;
            this.cb_view.Location = new System.Drawing.Point(696, 124);
            this.cb_view.Name = "cb_view";
            this.cb_view.Size = new System.Drawing.Size(48, 17);
            this.cb_view.TabIndex = 62;
            this.cb_view.Text = "view";
            this.cb_view.UseVisualStyleBackColor = true;
            this.cb_view.CheckedChanged += new System.EventHandler(this.cb_view_CheckedChanged);
            // 
            // txt_password
            // 
            this.txt_password.Depth = 0;
            this.txt_password.Hint = "Password";
            this.txt_password.Location = new System.Drawing.Point(513, 122);
            this.txt_password.MaxLength = 32767;
            this.txt_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '.';
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.Size = new System.Drawing.Size(177, 23);
            this.txt_password.TabIndex = 61;
            this.txt_password.TabStop = false;
            this.txt_password.UseSystemPasswordChar = false;
            // 
            // txt_email
            // 
            this.txt_email.Depth = 0;
            this.txt_email.Hint = "Email";
            this.txt_email.Location = new System.Drawing.Point(513, 89);
            this.txt_email.MaxLength = 32767;
            this.txt_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.SelectedText = "";
            this.txt_email.SelectionLength = 0;
            this.txt_email.SelectionStart = 0;
            this.txt_email.Size = new System.Drawing.Size(231, 23);
            this.txt_email.TabIndex = 60;
            this.txt_email.TabStop = false;
            this.txt_email.UseSystemPasswordChar = false;
            // 
            // cmb_areacode
            // 
            this.cmb_areacode.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_areacode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_areacode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_areacode.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmb_areacode.FormattingEnabled = true;
            this.cmb_areacode.Location = new System.Drawing.Point(349, 268);
            this.cmb_areacode.Name = "cmb_areacode";
            this.cmb_areacode.Size = new System.Drawing.Size(147, 21);
            this.cmb_areacode.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(247, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Parking Area Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(250, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Address";
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(247, 197);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(249, 59);
            this.txt_address.TabIndex = 53;
            // 
            // cmb_gender
            // 
            this.cmb_gender.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_gender.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmb_gender.FormattingEnabled = true;
            this.cmb_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Alien"});
            this.cmb_gender.Location = new System.Drawing.Point(298, 153);
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.Size = new System.Drawing.Size(198, 21);
            this.cmb_gender.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(250, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Gender";
            // 
            // txt_lname
            // 
            this.txt_lname.Depth = 0;
            this.txt_lname.Hint = "Last name";
            this.txt_lname.Location = new System.Drawing.Point(247, 122);
            this.txt_lname.MaxLength = 32767;
            this.txt_lname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.PasswordChar = '\0';
            this.txt_lname.SelectedText = "";
            this.txt_lname.SelectionLength = 0;
            this.txt_lname.SelectionStart = 0;
            this.txt_lname.Size = new System.Drawing.Size(249, 23);
            this.txt_lname.TabIndex = 50;
            this.txt_lname.TabStop = false;
            this.txt_lname.UseSystemPasswordChar = false;
            // 
            // txt_fname
            // 
            this.txt_fname.Depth = 0;
            this.txt_fname.Hint = "First name";
            this.txt_fname.Location = new System.Drawing.Point(247, 89);
            this.txt_fname.MaxLength = 32767;
            this.txt_fname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.PasswordChar = '\0';
            this.txt_fname.SelectedText = "";
            this.txt_fname.SelectionLength = 0;
            this.txt_fname.SelectionStart = 0;
            this.txt_fname.Size = new System.Drawing.Size(249, 23);
            this.txt_fname.TabIndex = 49;
            this.txt_fname.TabStop = false;
            this.txt_fname.UseSystemPasswordChar = false;
            // 
            // btn_browseimage
            // 
            this.btn_browseimage.AutoSize = true;
            this.btn_browseimage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_browseimage.Depth = 0;
            this.btn_browseimage.Icon = null;
            this.btn_browseimage.Location = new System.Drawing.Point(65, 293);
            this.btn_browseimage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_browseimage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_browseimage.Name = "btn_browseimage";
            this.btn_browseimage.Primary = false;
            this.btn_browseimage.Size = new System.Drawing.Size(121, 36);
            this.btn_browseimage.TabIndex = 48;
            this.btn_browseimage.Text = "browse image";
            this.btn_browseimage.UseVisualStyleBackColor = true;
            // 
            // pb_profilepicture
            // 
            this.pb_profilepicture.BackgroundImage = global::eparkmo.Properties.Resources.icon_user_default3;
            this.pb_profilepicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_profilepicture.Location = new System.Drawing.Point(28, 89);
            this.pb_profilepicture.Name = "pb_profilepicture";
            this.pb_profilepicture.Size = new System.Drawing.Size(200, 200);
            this.pb_profilepicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_profilepicture.TabIndex = 47;
            this.pb_profilepicture.TabStop = false;
            // 
            // newEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 355);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cb_view);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.cmb_areacode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.cmb_gender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.btn_browseimage);
            this.Controls.Add(this.pb_profilepicture);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "newEmployee";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Employee";
            this.Load += new System.EventHandler(this.newEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_profilepicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private System.Windows.Forms.CheckBox cb_view;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_password;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_email;
        private System.Windows.Forms.ComboBox cmb_areacode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.ComboBox cmb_gender;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_lname;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_fname;
        private MaterialSkin.Controls.MaterialFlatButton btn_browseimage;
        private System.Windows.Forms.PictureBox pb_profilepicture;
    }
}