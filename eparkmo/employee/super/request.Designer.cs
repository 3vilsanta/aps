namespace eparkmo.employee.super
{
    partial class request
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
            this.btnEntrance = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnCarCount = new System.Windows.Forms.TextBox();
            this.txtEnMotorCount = new System.Windows.Forms.TextBox();
            this.btnEnEnd = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnExEnd = new System.Windows.Forms.Button();
            this.txtExMotorCount = new System.Windows.Forms.TextBox();
            this.txtExCarCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEntrance
            // 
            this.btnEntrance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrance.Location = new System.Drawing.Point(33, 28);
            this.btnEntrance.Name = "btnEntrance";
            this.btnEntrance.Size = new System.Drawing.Size(203, 77);
            this.btnEntrance.TabIndex = 0;
            this.btnEntrance.Text = "Entrance";
            this.btnEntrance.UseVisualStyleBackColor = true;
            this.btnEntrance.Click += new System.EventHandler(this.btnEntrance_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(268, 28);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(203, 77);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "How many Car? :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "How many Motorcycle? :";
            // 
            // txtEnCarCount
            // 
            this.txtEnCarCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnCarCount.Location = new System.Drawing.Point(33, 142);
            this.txtEnCarCount.Name = "txtEnCarCount";
            this.txtEnCarCount.Size = new System.Drawing.Size(160, 23);
            this.txtEnCarCount.TabIndex = 4;
            this.txtEnCarCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnCarCount_KeyPress);
            this.txtEnCarCount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEnCarCount_KeyUp);
            // 
            // txtEnMotorCount
            // 
            this.txtEnMotorCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnMotorCount.Location = new System.Drawing.Point(33, 204);
            this.txtEnMotorCount.Name = "txtEnMotorCount";
            this.txtEnMotorCount.Size = new System.Drawing.Size(160, 23);
            this.txtEnMotorCount.TabIndex = 5;
            this.txtEnMotorCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnMotorCount_KeyPress);
            this.txtEnMotorCount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEnMotorCount_KeyUp);
            // 
            // btnEnEnd
            // 
            this.btnEnEnd.Enabled = false;
            this.btnEnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnEnd.Location = new System.Drawing.Point(33, 233);
            this.btnEnEnd.Name = "btnEnEnd";
            this.btnEnEnd.Size = new System.Drawing.Size(108, 30);
            this.btnEnEnd.TabIndex = 6;
            this.btnEnEnd.Text = "End Request";
            this.btnEnEnd.UseVisualStyleBackColor = true;
            this.btnEnEnd.Click += new System.EventHandler(this.btnEnEnd_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM8";
            // 
            // btnExEnd
            // 
            this.btnExEnd.Enabled = false;
            this.btnExEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExEnd.Location = new System.Drawing.Point(268, 233);
            this.btnExEnd.Name = "btnExEnd";
            this.btnExEnd.Size = new System.Drawing.Size(108, 30);
            this.btnExEnd.TabIndex = 11;
            this.btnExEnd.Text = "End Request";
            this.btnExEnd.UseVisualStyleBackColor = true;
            this.btnExEnd.Click += new System.EventHandler(this.btnExEnd_Click);
            // 
            // txtExMotorCount
            // 
            this.txtExMotorCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExMotorCount.Location = new System.Drawing.Point(268, 204);
            this.txtExMotorCount.Name = "txtExMotorCount";
            this.txtExMotorCount.Size = new System.Drawing.Size(160, 23);
            this.txtExMotorCount.TabIndex = 10;
            this.txtExMotorCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExMotorCount_KeyPress);
            this.txtExMotorCount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtExMotorCount_KeyUp);
            // 
            // txtExCarCount
            // 
            this.txtExCarCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExCarCount.Location = new System.Drawing.Point(268, 142);
            this.txtExCarCount.Name = "txtExCarCount";
            this.txtExCarCount.Size = new System.Drawing.Size(160, 23);
            this.txtExCarCount.TabIndex = 9;
            this.txtExCarCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExCarCount_KeyPress);
            this.txtExCarCount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtExCarCount_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "How many Motorcycle? :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(265, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "How many Car? :";
            // 
            // request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 284);
            this.Controls.Add(this.btnExEnd);
            this.Controls.Add(this.txtExMotorCount);
            this.Controls.Add(this.txtExCarCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEnEnd);
            this.Controls.Add(this.txtEnMotorCount);
            this.Controls.Add(this.txtEnCarCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEntrance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "request";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Request";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.request_FormClosed);
            this.Load += new System.EventHandler(this.request_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrance;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnCarCount;
        private System.Windows.Forms.TextBox txtEnMotorCount;
        private System.Windows.Forms.Button btnEnEnd;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnExEnd;
        private System.Windows.Forms.TextBox txtExMotorCount;
        private System.Windows.Forms.TextBox txtExCarCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}