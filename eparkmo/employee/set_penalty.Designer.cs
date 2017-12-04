namespace eparkmo.employee
{
    partial class set_penalty
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtLname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFee = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCash = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChange = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSubmit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "[Note] - Pleas Check the Owner ID and the Vehicle OR/CR for \r\nPlate No Identity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First name :";
            // 
            // txtFname
            // 
            this.txtFname.Depth = 0;
            this.txtFname.Hint = "";
            this.txtFname.Location = new System.Drawing.Point(97, 123);
            this.txtFname.MaxLength = 32767;
            this.txtFname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFname.Name = "txtFname";
            this.txtFname.PasswordChar = '\0';
            this.txtFname.SelectedText = "";
            this.txtFname.SelectionLength = 0;
            this.txtFname.SelectionStart = 0;
            this.txtFname.Size = new System.Drawing.Size(203, 23);
            this.txtFname.TabIndex = 2;
            this.txtFname.TabStop = false;
            this.txtFname.UseSystemPasswordChar = false;
            // 
            // txtLname
            // 
            this.txtLname.Depth = 0;
            this.txtLname.Hint = "";
            this.txtLname.Location = new System.Drawing.Point(97, 152);
            this.txtLname.MaxLength = 32767;
            this.txtLname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLname.Name = "txtLname";
            this.txtLname.PasswordChar = '\0';
            this.txtLname.SelectedText = "";
            this.txtLname.SelectionLength = 0;
            this.txtLname.SelectionStart = 0;
            this.txtLname.Size = new System.Drawing.Size(203, 23);
            this.txtLname.TabIndex = 4;
            this.txtLname.TabStop = false;
            this.txtLname.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last name :";
            // 
            // txtFee
            // 
            this.txtFee.Depth = 0;
            this.txtFee.Enabled = false;
            this.txtFee.Hint = "";
            this.txtFee.Location = new System.Drawing.Point(97, 181);
            this.txtFee.MaxLength = 32767;
            this.txtFee.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFee.Name = "txtFee";
            this.txtFee.PasswordChar = '\0';
            this.txtFee.SelectedText = "";
            this.txtFee.SelectionLength = 0;
            this.txtFee.SelectionStart = 0;
            this.txtFee.Size = new System.Drawing.Size(92, 23);
            this.txtFee.TabIndex = 7;
            this.txtFee.TabStop = false;
            this.txtFee.Text = "300";
            this.txtFee.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "fee :";
            // 
            // txtCash
            // 
            this.txtCash.Depth = 0;
            this.txtCash.Hint = "";
            this.txtCash.Location = new System.Drawing.Point(97, 210);
            this.txtCash.MaxLength = 32767;
            this.txtCash.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCash.Name = "txtCash";
            this.txtCash.PasswordChar = '\0';
            this.txtCash.SelectedText = "";
            this.txtCash.SelectionLength = 0;
            this.txtCash.SelectionStart = 0;
            this.txtCash.Size = new System.Drawing.Size(92, 23);
            this.txtCash.TabIndex = 9;
            this.txtCash.TabStop = false;
            this.txtCash.UseSystemPasswordChar = false;
            this.txtCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            this.txtCash.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCash_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cash :";
            // 
            // txtChange
            // 
            this.txtChange.Depth = 0;
            this.txtChange.Enabled = false;
            this.txtChange.Hint = "";
            this.txtChange.Location = new System.Drawing.Point(97, 239);
            this.txtChange.MaxLength = 32767;
            this.txtChange.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtChange.Name = "txtChange";
            this.txtChange.PasswordChar = '\0';
            this.txtChange.SelectedText = "";
            this.txtChange.SelectionLength = 0;
            this.txtChange.SelectionStart = 0;
            this.txtChange.Size = new System.Drawing.Size(92, 23);
            this.txtChange.TabIndex = 11;
            this.txtChange.TabStop = false;
            this.txtChange.UseSystemPasswordChar = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Change :";
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubmit.Depth = 0;
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Icon = null;
            this.btnSubmit.Location = new System.Drawing.Point(97, 268);
            this.btnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Primary = true;
            this.btnSubmit.Size = new System.Drawing.Size(71, 36);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // set_penalty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 331);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "set_penalty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Penalty";
            this.Load += new System.EventHandler(this.set_penalty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFname;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLname;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFee;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCash;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtChange;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialRaisedButton btnSubmit;
    }
}