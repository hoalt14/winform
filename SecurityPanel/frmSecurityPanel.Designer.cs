namespace SecurityPanel
{
    partial class frmSecurityPanel
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
            this.lblSecurityCode = new System.Windows.Forms.Label();
            this.txtSecurityCode = new System.Windows.Forms.TextBox();
            this.btnSo1 = new System.Windows.Forms.Button();
            this.btnSo2 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSo3 = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSo6 = new System.Windows.Forms.Button();
            this.btnSo5 = new System.Windows.Forms.Button();
            this.btnSo4 = new System.Windows.Forms.Button();
            this.btnSo0 = new System.Windows.Forms.Button();
            this.btnSo9 = new System.Windows.Forms.Button();
            this.btnSo8 = new System.Windows.Forms.Button();
            this.btnSo7 = new System.Windows.Forms.Button();
            this.lblAccessLog = new System.Windows.Forms.Label();
            this.lbxAccessLog = new System.Windows.Forms.ListBox();
            this.btnSaveLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSecurityCode
            // 
            this.lblSecurityCode.AutoSize = true;
            this.lblSecurityCode.Location = new System.Drawing.Point(30, 27);
            this.lblSecurityCode.Name = "lblSecurityCode";
            this.lblSecurityCode.Size = new System.Drawing.Size(73, 13);
            this.lblSecurityCode.TabIndex = 0;
            this.lblSecurityCode.Text = "Security Code";
            // 
            // txtSecurityCode
            // 
            this.txtSecurityCode.Enabled = false;
            this.txtSecurityCode.Location = new System.Drawing.Point(108, 20);
            this.txtSecurityCode.Name = "txtSecurityCode";
            this.txtSecurityCode.PasswordChar = '*';
            this.txtSecurityCode.ReadOnly = true;
            this.txtSecurityCode.Size = new System.Drawing.Size(134, 20);
            this.txtSecurityCode.TabIndex = 1;
            // 
            // btnSo1
            // 
            this.btnSo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSo1.Location = new System.Drawing.Point(36, 63);
            this.btnSo1.Name = "btnSo1";
            this.btnSo1.Size = new System.Drawing.Size(47, 35);
            this.btnSo1.TabIndex = 2;
            this.btnSo1.Text = "1";
            this.btnSo1.UseVisualStyleBackColor = true;
            this.btnSo1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnSo2
            // 
            this.btnSo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSo2.Location = new System.Drawing.Point(89, 63);
            this.btnSo2.Name = "btnSo2";
            this.btnSo2.Size = new System.Drawing.Size(47, 35);
            this.btnSo2.TabIndex = 3;
            this.btnSo2.Text = "2";
            this.btnSo2.UseVisualStyleBackColor = true;
            this.btnSo2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Lime;
            this.btnClear.Location = new System.Drawing.Point(195, 63);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(47, 35);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSo3
            // 
            this.btnSo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSo3.Location = new System.Drawing.Point(142, 63);
            this.btnSo3.Name = "btnSo3";
            this.btnSo3.Size = new System.Drawing.Size(47, 35);
            this.btnSo3.TabIndex = 4;
            this.btnSo3.Text = "3";
            this.btnSo3.UseVisualStyleBackColor = true;
            this.btnSo3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Silver;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Red;
            this.btnLogin.Location = new System.Drawing.Point(195, 104);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(47, 35);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "#";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSo6
            // 
            this.btnSo6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSo6.Location = new System.Drawing.Point(142, 104);
            this.btnSo6.Name = "btnSo6";
            this.btnSo6.Size = new System.Drawing.Size(47, 35);
            this.btnSo6.TabIndex = 8;
            this.btnSo6.Text = "6";
            this.btnSo6.UseVisualStyleBackColor = true;
            this.btnSo6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnSo5
            // 
            this.btnSo5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSo5.Location = new System.Drawing.Point(89, 104);
            this.btnSo5.Name = "btnSo5";
            this.btnSo5.Size = new System.Drawing.Size(47, 35);
            this.btnSo5.TabIndex = 7;
            this.btnSo5.Text = "5";
            this.btnSo5.UseVisualStyleBackColor = true;
            this.btnSo5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnSo4
            // 
            this.btnSo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSo4.Location = new System.Drawing.Point(36, 104);
            this.btnSo4.Name = "btnSo4";
            this.btnSo4.Size = new System.Drawing.Size(47, 35);
            this.btnSo4.TabIndex = 6;
            this.btnSo4.Text = "4";
            this.btnSo4.UseVisualStyleBackColor = true;
            this.btnSo4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnSo0
            // 
            this.btnSo0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSo0.Location = new System.Drawing.Point(195, 145);
            this.btnSo0.Name = "btnSo0";
            this.btnSo0.Size = new System.Drawing.Size(47, 35);
            this.btnSo0.TabIndex = 13;
            this.btnSo0.Text = "0";
            this.btnSo0.UseVisualStyleBackColor = true;
            this.btnSo0.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnSo9
            // 
            this.btnSo9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSo9.Location = new System.Drawing.Point(142, 145);
            this.btnSo9.Name = "btnSo9";
            this.btnSo9.Size = new System.Drawing.Size(47, 35);
            this.btnSo9.TabIndex = 12;
            this.btnSo9.Text = "9";
            this.btnSo9.UseVisualStyleBackColor = true;
            this.btnSo9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnSo8
            // 
            this.btnSo8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSo8.Location = new System.Drawing.Point(89, 145);
            this.btnSo8.Name = "btnSo8";
            this.btnSo8.Size = new System.Drawing.Size(47, 35);
            this.btnSo8.TabIndex = 11;
            this.btnSo8.Text = "8";
            this.btnSo8.UseVisualStyleBackColor = true;
            this.btnSo8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnSo7
            // 
            this.btnSo7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSo7.Location = new System.Drawing.Point(36, 145);
            this.btnSo7.Name = "btnSo7";
            this.btnSo7.Size = new System.Drawing.Size(47, 35);
            this.btnSo7.TabIndex = 10;
            this.btnSo7.Text = "7";
            this.btnSo7.UseVisualStyleBackColor = true;
            this.btnSo7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // lblAccessLog
            // 
            this.lblAccessLog.AutoSize = true;
            this.lblAccessLog.Location = new System.Drawing.Point(293, 27);
            this.lblAccessLog.Name = "lblAccessLog";
            this.lblAccessLog.Size = new System.Drawing.Size(63, 13);
            this.lblAccessLog.TabIndex = 14;
            this.lblAccessLog.Text = "Access Log";
            // 
            // lbxAccessLog
            // 
            this.lbxAccessLog.FormattingEnabled = true;
            this.lbxAccessLog.Location = new System.Drawing.Point(266, 63);
            this.lbxAccessLog.Name = "lbxAccessLog";
            this.lbxAccessLog.Size = new System.Drawing.Size(258, 121);
            this.lbxAccessLog.TabIndex = 15;
            // 
            // btnSaveLog
            // 
            this.btnSaveLog.Location = new System.Drawing.Point(449, 20);
            this.btnSaveLog.Name = "btnSaveLog";
            this.btnSaveLog.Size = new System.Drawing.Size(75, 23);
            this.btnSaveLog.TabIndex = 16;
            this.btnSaveLog.Text = "Save Log";
            this.btnSaveLog.UseVisualStyleBackColor = true;
            this.btnSaveLog.Click += new System.EventHandler(this.btnSaveLog_Click);
            // 
            // frmSecurityPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 200);
            this.Controls.Add(this.btnSaveLog);
            this.Controls.Add(this.lbxAccessLog);
            this.Controls.Add(this.lblAccessLog);
            this.Controls.Add(this.btnSo0);
            this.Controls.Add(this.btnSo9);
            this.Controls.Add(this.btnSo8);
            this.Controls.Add(this.btnSo7);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSo6);
            this.Controls.Add(this.btnSo5);
            this.Controls.Add(this.btnSo4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSo3);
            this.Controls.Add(this.btnSo2);
            this.Controls.Add(this.btnSo1);
            this.Controls.Add(this.txtSecurityCode);
            this.Controls.Add(this.lblSecurityCode);
            this.Name = "frmSecurityPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecurityCode;
        private System.Windows.Forms.TextBox txtSecurityCode;
        private System.Windows.Forms.Button btnSo1;
        private System.Windows.Forms.Button btnSo2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSo3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSo6;
        private System.Windows.Forms.Button btnSo5;
        private System.Windows.Forms.Button btnSo4;
        private System.Windows.Forms.Button btnSo0;
        private System.Windows.Forms.Button btnSo9;
        private System.Windows.Forms.Button btnSo8;
        private System.Windows.Forms.Button btnSo7;
        private System.Windows.Forms.Label lblAccessLog;
        private System.Windows.Forms.ListBox lbxAccessLog;
        private System.Windows.Forms.Button btnSaveLog;
    }
}

