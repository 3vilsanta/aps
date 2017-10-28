namespace eparkmo.admin
{
    partial class change_password
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
            this.txt_o_p = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_result = new System.Windows.Forms.PictureBox();
            this.pnl_new = new System.Windows.Forms.Panel();
            this.txt_n_p = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_update = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txt_n_rp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.pb_result)).BeginInit();
            this.pnl_new.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_o_p
            // 
            this.txt_o_p.Depth = 0;
            this.txt_o_p.Hint = "Old Password";
            this.txt_o_p.Location = new System.Drawing.Point(38, 99);
            this.txt_o_p.MaxLength = 32767;
            this.txt_o_p.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_o_p.Name = "txt_o_p";
            this.txt_o_p.PasswordChar = '*';
            this.txt_o_p.SelectedText = "";
            this.txt_o_p.SelectionLength = 0;
            this.txt_o_p.SelectionStart = 0;
            this.txt_o_p.Size = new System.Drawing.Size(271, 23);
            this.txt_o_p.TabIndex = 11;
            this.txt_o_p.TabStop = false;
            this.txt_o_p.UseSystemPasswordChar = false;
            this.txt_o_p.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_o_p_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Old Password";
            // 
            // pb_result
            // 
            this.pb_result.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_result.Location = new System.Drawing.Point(313, 98);
            this.pb_result.Name = "pb_result";
            this.pb_result.Size = new System.Drawing.Size(24, 24);
            this.pb_result.TabIndex = 13;
            this.pb_result.TabStop = false;
            // 
            // pnl_new
            // 
            this.pnl_new.Controls.Add(this.txt_n_p);
            this.pnl_new.Controls.Add(this.btn_update);
            this.pnl_new.Controls.Add(this.txt_n_rp);
            this.pnl_new.Enabled = false;
            this.pnl_new.Location = new System.Drawing.Point(21, 143);
            this.pnl_new.Name = "pnl_new";
            this.pnl_new.Size = new System.Drawing.Size(333, 112);
            this.pnl_new.TabIndex = 12;
            // 
            // txt_n_p
            // 
            this.txt_n_p.Depth = 0;
            this.txt_n_p.Hint = "New Password";
            this.txt_n_p.Location = new System.Drawing.Point(17, 8);
            this.txt_n_p.MaxLength = 32767;
            this.txt_n_p.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_n_p.Name = "txt_n_p";
            this.txt_n_p.PasswordChar = '\0';
            this.txt_n_p.SelectedText = "";
            this.txt_n_p.SelectionLength = 0;
            this.txt_n_p.SelectionStart = 0;
            this.txt_n_p.Size = new System.Drawing.Size(298, 23);
            this.txt_n_p.TabIndex = 1;
            this.txt_n_p.TabStop = false;
            this.txt_n_p.UseSystemPasswordChar = false;
            // 
            // btn_update
            // 
            this.btn_update.AutoSize = true;
            this.btn_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update.Depth = 0;
            this.btn_update.Icon = null;
            this.btn_update.Location = new System.Drawing.Point(243, 70);
            this.btn_update.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_update.Name = "btn_update";
            this.btn_update.Primary = true;
            this.btn_update.Size = new System.Drawing.Size(73, 36);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_n_rp
            // 
            this.txt_n_rp.Depth = 0;
            this.txt_n_rp.Hint = "Retype New Password";
            this.txt_n_rp.Location = new System.Drawing.Point(17, 41);
            this.txt_n_rp.MaxLength = 32767;
            this.txt_n_rp.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_n_rp.Name = "txt_n_rp";
            this.txt_n_rp.PasswordChar = '*';
            this.txt_n_rp.SelectedText = "";
            this.txt_n_rp.SelectionLength = 0;
            this.txt_n_rp.SelectionStart = 0;
            this.txt_n_rp.Size = new System.Drawing.Size(298, 23);
            this.txt_n_rp.TabIndex = 2;
            this.txt_n_rp.TabStop = false;
            this.txt_n_rp.UseSystemPasswordChar = false;
            // 
            // change_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 294);
            this.Controls.Add(this.txt_o_p);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_result);
            this.Controls.Add(this.pnl_new);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(372, 294);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(372, 294);
            this.Name = "change_password";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "change_password";
            this.Load += new System.EventHandler(this.change_password_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_result)).EndInit();
            this.pnl_new.ResumeLayout(false);
            this.pnl_new.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txt_o_p;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_result;
        private System.Windows.Forms.Panel pnl_new;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_n_p;
        private MaterialSkin.Controls.MaterialRaisedButton btn_update;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_n_rp;
    }
}