namespace eparkmo.employee
{
    partial class time_out
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
            this.lbl_plateno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cash = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_timeout = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbl_fees = new System.Windows.Forms.Label();
            this.lbl_timein = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_timeout = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_totalhours = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_change = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plate No. :";
            // 
            // lbl_plateno
            // 
            this.lbl_plateno.AutoSize = true;
            this.lbl_plateno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_plateno.Location = new System.Drawing.Point(153, 83);
            this.lbl_plateno.Name = "lbl_plateno";
            this.lbl_plateno.Size = new System.Drawing.Size(19, 20);
            this.lbl_plateno.TabIndex = 1;
            this.lbl_plateno.Text = "..";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fee :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cash :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Change :";
            // 
            // txt_cash
            // 
            this.txt_cash.Depth = 0;
            this.txt_cash.Hint = "";
            this.txt_cash.Location = new System.Drawing.Point(153, 223);
            this.txt_cash.MaxLength = 32767;
            this.txt_cash.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_cash.Name = "txt_cash";
            this.txt_cash.PasswordChar = '\0';
            this.txt_cash.SelectedText = "";
            this.txt_cash.SelectionLength = 0;
            this.txt_cash.SelectionStart = 0;
            this.txt_cash.Size = new System.Drawing.Size(92, 23);
            this.txt_cash.TabIndex = 5;
            this.txt_cash.TabStop = false;
            this.txt_cash.UseSystemPasswordChar = false;
            this.txt_cash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cash_KeyPress);
            this.txt_cash.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_cash_KeyUp);
            // 
            // btn_timeout
            // 
            this.btn_timeout.AutoSize = true;
            this.btn_timeout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_timeout.Depth = 0;
            this.btn_timeout.Enabled = false;
            this.btn_timeout.Icon = null;
            this.btn_timeout.Location = new System.Drawing.Point(153, 280);
            this.btn_timeout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_timeout.Name = "btn_timeout";
            this.btn_timeout.Primary = true;
            this.btn_timeout.Size = new System.Drawing.Size(83, 36);
            this.btn_timeout.TabIndex = 6;
            this.btn_timeout.Text = "Time out";
            this.btn_timeout.UseVisualStyleBackColor = true;
            this.btn_timeout.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // lbl_fees
            // 
            this.lbl_fees.AutoSize = true;
            this.lbl_fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fees.Location = new System.Drawing.Point(153, 192);
            this.lbl_fees.Name = "lbl_fees";
            this.lbl_fees.Size = new System.Drawing.Size(19, 20);
            this.lbl_fees.TabIndex = 7;
            this.lbl_fees.Text = "..";
            // 
            // lbl_timein
            // 
            this.lbl_timein.AutoSize = true;
            this.lbl_timein.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timein.Location = new System.Drawing.Point(153, 110);
            this.lbl_timein.Name = "lbl_timein";
            this.lbl_timein.Size = new System.Drawing.Size(19, 20);
            this.lbl_timein.TabIndex = 9;
            this.lbl_timein.Text = "..";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Time_in :";
            // 
            // lbl_timeout
            // 
            this.lbl_timeout.AutoSize = true;
            this.lbl_timeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timeout.Location = new System.Drawing.Point(153, 135);
            this.lbl_timeout.Name = "lbl_timeout";
            this.lbl_timeout.Size = new System.Drawing.Size(19, 20);
            this.lbl_timeout.TabIndex = 11;
            this.lbl_timeout.Text = "..";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Time_out :";
            // 
            // lbl_totalhours
            // 
            this.lbl_totalhours.AutoSize = true;
            this.lbl_totalhours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalhours.Location = new System.Drawing.Point(153, 163);
            this.lbl_totalhours.Name = "lbl_totalhours";
            this.lbl_totalhours.Size = new System.Drawing.Size(19, 20);
            this.lbl_totalhours.TabIndex = 14;
            this.lbl_totalhours.Text = "..";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total Hour\'s of Stay :";
            // 
            // lbl_change
            // 
            this.lbl_change.AutoSize = true;
            this.lbl_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_change.Location = new System.Drawing.Point(153, 249);
            this.lbl_change.Name = "lbl_change";
            this.lbl_change.Size = new System.Drawing.Size(19, 20);
            this.lbl_change.TabIndex = 15;
            this.lbl_change.Text = "..";
            // 
            // time_out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 328);
            this.Controls.Add(this.lbl_change);
            this.Controls.Add(this.lbl_totalhours);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_timeout);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_timein);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_fees);
            this.Controls.Add(this.btn_timeout);
            this.Controls.Add(this.txt_cash);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_plateno);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "time_out";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "time_out";
            this.Load += new System.EventHandler(this.time_out_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_plateno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_cash;
        private MaterialSkin.Controls.MaterialRaisedButton btn_timeout;
        private System.Windows.Forms.Label lbl_fees;
        private System.Windows.Forms.Label lbl_timein;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_timeout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_totalhours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_change;
    }
}