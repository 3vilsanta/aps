namespace eparkmo.forgot_password
{
    partial class reset
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
            this.components = new System.ComponentModel.Container();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.btnNext = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_email = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tmr_countdown = new System.Windows.Forms.Timer(this.components);
            this.panel_nextpage = new System.Windows.Forms.Panel();
            this.btnVerify = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lbl_countdown = new System.Windows.Forms.Label();
            this.panel_nextpage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_msg.Location = new System.Drawing.Point(42, 136);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(49, 13);
            this.lbl_msg.TabIndex = 8;
            this.lbl_msg.Text = "message";
            this.lbl_msg.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext.Depth = 0;
            this.btnNext.Icon = null;
            this.btnNext.Location = new System.Drawing.Point(409, 136);
            this.btnNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNext.Name = "btnNext";
            this.btnNext.Primary = true;
            this.btnNext.Size = new System.Drawing.Size(55, 36);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txt_email
            // 
            this.txt_email.Depth = 0;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Hint = "Email Address";
            this.txt_email.Location = new System.Drawing.Point(42, 105);
            this.txt_email.Margin = new System.Windows.Forms.Padding(5);
            this.txt_email.MaxLength = 32767;
            this.txt_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.SelectedText = "";
            this.txt_email.SelectionLength = 0;
            this.txt_email.SelectionStart = 0;
            this.txt_email.Size = new System.Drawing.Size(423, 23);
            this.txt_email.TabIndex = 6;
            this.txt_email.TabStop = false;
            this.txt_email.UseSystemPasswordChar = false;
            this.txt_email.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_email_KeyUp);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(42, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter your Email Address";
            // 
            // tmr_countdown
            // 
            this.tmr_countdown.Interval = 1000;
            this.tmr_countdown.Tick += new System.EventHandler(this.tmr_countdown_Tick);
            // 
            // panel_nextpage
            // 
            this.panel_nextpage.BackColor = System.Drawing.Color.White;
            this.panel_nextpage.Controls.Add(this.lbl_countdown);
            this.panel_nextpage.Controls.Add(this.txtCode);
            this.panel_nextpage.Controls.Add(this.label2);
            this.panel_nextpage.Controls.Add(this.btnVerify);
            this.panel_nextpage.Location = new System.Drawing.Point(12, 71);
            this.panel_nextpage.Name = "panel_nextpage";
            this.panel_nextpage.Size = new System.Drawing.Size(482, 126);
            this.panel_nextpage.TabIndex = 10;
            this.panel_nextpage.Visible = false;
            // 
            // btnVerify
            // 
            this.btnVerify.AutoSize = true;
            this.btnVerify.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerify.Depth = 0;
            this.btnVerify.Icon = null;
            this.btnVerify.Location = new System.Drawing.Point(112, 84);
            this.btnVerify.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Primary = true;
            this.btnVerify.Size = new System.Drawing.Size(128, 36);
            this.btnVerify.TabIndex = 11;
            this.btnVerify.Text = "click to Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(145, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "VERIFICATION CODE";
            // 
            // txtCode
            // 
            this.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.DimGray;
            this.txtCode.Location = new System.Drawing.Point(112, 43);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(260, 35);
            this.txtCode.TabIndex = 14;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_countdown
            // 
            this.lbl_countdown.AutoSize = true;
            this.lbl_countdown.BackColor = System.Drawing.Color.White;
            this.lbl_countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_countdown.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_countdown.Location = new System.Drawing.Point(246, 91);
            this.lbl_countdown.Name = "lbl_countdown";
            this.lbl_countdown.Size = new System.Drawing.Size(33, 20);
            this.lbl_countdown.TabIndex = 11;
            this.lbl_countdown.Text = "[ .. ]";
            // 
            // reset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 201);
            this.Controls.Add(this.panel_nextpage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txt_email);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "reset";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.reset_Load);
            this.panel_nextpage.ResumeLayout(false);
            this.panel_nextpage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_msg;
        private MaterialSkin.Controls.MaterialRaisedButton btnNext;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_email;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmr_countdown;
        private System.Windows.Forms.Panel panel_nextpage;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialRaisedButton btnVerify;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lbl_countdown;
    }
}