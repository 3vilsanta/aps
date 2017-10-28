namespace eparkmo.admin.parking
{
    partial class newParking
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
            this.txtAreaCode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCarCapacity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMotorCapacity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtAreaCode
            // 
            this.txtAreaCode.Depth = 0;
            this.txtAreaCode.Hint = "Area Code";
            this.txtAreaCode.Location = new System.Drawing.Point(22, 116);
            this.txtAreaCode.MaxLength = 32767;
            this.txtAreaCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAreaCode.Name = "txtAreaCode";
            this.txtAreaCode.PasswordChar = '\0';
            this.txtAreaCode.SelectedText = "";
            this.txtAreaCode.SelectionLength = 0;
            this.txtAreaCode.SelectionStart = 0;
            this.txtAreaCode.Size = new System.Drawing.Size(249, 23);
            this.txtAreaCode.TabIndex = 50;
            this.txtAreaCode.TabStop = false;
            this.txtAreaCode.UseSystemPasswordChar = false;
            this.txtAreaCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAreaCode_KeyUp);
            // 
            // txtCarCapacity
            // 
            this.txtCarCapacity.Depth = 0;
            this.txtCarCapacity.Hint = "Car capacity";
            this.txtCarCapacity.Location = new System.Drawing.Point(22, 163);
            this.txtCarCapacity.MaxLength = 32767;
            this.txtCarCapacity.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCarCapacity.Name = "txtCarCapacity";
            this.txtCarCapacity.PasswordChar = '\0';
            this.txtCarCapacity.SelectedText = "";
            this.txtCarCapacity.SelectionLength = 0;
            this.txtCarCapacity.SelectionStart = 0;
            this.txtCarCapacity.Size = new System.Drawing.Size(249, 23);
            this.txtCarCapacity.TabIndex = 51;
            this.txtCarCapacity.TabStop = false;
            this.txtCarCapacity.UseSystemPasswordChar = false;
            this.txtCarCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarCapacity_KeyPress);
            // 
            // txtMotorCapacity
            // 
            this.txtMotorCapacity.Depth = 0;
            this.txtMotorCapacity.Hint = "Motorcycle capacity";
            this.txtMotorCapacity.Location = new System.Drawing.Point(22, 192);
            this.txtMotorCapacity.MaxLength = 32767;
            this.txtMotorCapacity.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMotorCapacity.Name = "txtMotorCapacity";
            this.txtMotorCapacity.PasswordChar = '\0';
            this.txtMotorCapacity.SelectedText = "";
            this.txtMotorCapacity.SelectionLength = 0;
            this.txtMotorCapacity.SelectionStart = 0;
            this.txtMotorCapacity.Size = new System.Drawing.Size(249, 23);
            this.txtMotorCapacity.TabIndex = 52;
            this.txtMotorCapacity.TabStop = false;
            this.txtMotorCapacity.UseSystemPasswordChar = false;
            this.txtMotorCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMotorCapacity_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(22, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Area code";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(216, 221);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // newParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 276);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMotorCapacity);
            this.Controls.Add(this.txtCarCapacity);
            this.Controls.Add(this.txtAreaCode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "newParking";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Parking";
            this.Load += new System.EventHandler(this.newParking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtAreaCode;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCarCapacity;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMotorCapacity;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
    }
}