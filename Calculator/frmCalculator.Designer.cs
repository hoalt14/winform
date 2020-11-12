namespace Calculator
{
    partial class frmCalculator
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
            this.lblCal = new System.Windows.Forms.Label();
            this.lblSon = new System.Windows.Forms.Label();
            this.lblSom = new System.Windows.Forms.Label();
            this.txtSon = new System.Windows.Forms.TextBox();
            this.txtSom = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.lblKetqua = new System.Windows.Forms.Label();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCal
            // 
            this.lblCal.AutoSize = true;
            this.lblCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCal.ForeColor = System.Drawing.Color.Blue;
            this.lblCal.Location = new System.Drawing.Point(30, 18);
            this.lblCal.Name = "lblCal";
            this.lblCal.Size = new System.Drawing.Size(230, 18);
            this.lblCal.TabIndex = 0;
            this.lblCal.Text = "THỰC HIỆN CÁC PHÉP TÍNH";
            // 
            // lblSon
            // 
            this.lblSon.AutoSize = true;
            this.lblSon.Location = new System.Drawing.Point(30, 70);
            this.lblSon.Name = "lblSon";
            this.lblSon.Size = new System.Drawing.Size(59, 13);
            this.lblSon.TabIndex = 1;
            this.lblSon.Text = "Nhập số n:";
            // 
            // lblSom
            // 
            this.lblSom.AutoSize = true;
            this.lblSom.Location = new System.Drawing.Point(30, 110);
            this.lblSom.Name = "lblSom";
            this.lblSom.Size = new System.Drawing.Size(61, 13);
            this.lblSom.TabIndex = 2;
            this.lblSom.Text = "Nhập số m:";
            // 
            // txtSon
            // 
            this.txtSon.Location = new System.Drawing.Point(117, 63);
            this.txtSon.Name = "txtSon";
            this.txtSon.Size = new System.Drawing.Size(100, 20);
            this.txtSon.TabIndex = 3;
            // 
            // txtSom
            // 
            this.txtSom.Location = new System.Drawing.Point(117, 103);
            this.txtSom.Name = "txtSom";
            this.txtSom.Size = new System.Drawing.Size(100, 20);
            this.txtSom.TabIndex = 4;
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(40, 183);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(47, 23);
            this.btnCong.TabIndex = 5;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // lblKetqua
            // 
            this.lblKetqua.AutoSize = true;
            this.lblKetqua.Location = new System.Drawing.Point(30, 149);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(47, 13);
            this.lblKetqua.TabIndex = 6;
            this.lblKetqua.Text = "Kết quả:";
            // 
            // txtKetqua
            // 
            this.txtKetqua.Enabled = false;
            this.txtKetqua.Location = new System.Drawing.Point(117, 142);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(100, 20);
            this.txtKetqua.TabIndex = 7;
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(93, 183);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(47, 23);
            this.btnTru.TabIndex = 8;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(199, 183);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(47, 23);
            this.btnChia.TabIndex = 10;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(146, 183);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(47, 23);
            this.btnNhan.TabIndex = 9;
            this.btnNhan.Text = "*";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(65, 227);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(146, 227);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.lblKetqua);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtSom);
            this.Controls.Add(this.txtSon);
            this.Controls.Add(this.lblSom);
            this.Controls.Add(this.lblSon);
            this.Controls.Add(this.lblCal);
            this.Name = "frmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCal;
        private System.Windows.Forms.Label lblSon;
        private System.Windows.Forms.Label lblSom;
        private System.Windows.Forms.TextBox txtSon;
        private System.Windows.Forms.TextBox txtSom;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Label lblKetqua;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}

