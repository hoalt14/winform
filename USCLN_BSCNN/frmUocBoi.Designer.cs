namespace USCLN_BSCNN
{
    partial class frmUocBoi
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
            this.grbNhap = new System.Windows.Forms.GroupBox();
            this.lblSoa = new System.Windows.Forms.Label();
            this.lblSob = new System.Windows.Forms.Label();
            this.txtSoa = new System.Windows.Forms.TextBox();
            this.txtSob = new System.Windows.Forms.TextBox();
            this.grbChon = new System.Windows.Forms.GroupBox();
            this.ckbUSCLN = new System.Windows.Forms.CheckBox();
            this.ckbBSCNN = new System.Windows.Forms.CheckBox();
            this.grbKetqua = new System.Windows.Forms.GroupBox();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbNhap.SuspendLayout();
            this.grbChon.SuspendLayout();
            this.grbKetqua.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbNhap
            // 
            this.grbNhap.Controls.Add(this.txtSob);
            this.grbNhap.Controls.Add(this.txtSoa);
            this.grbNhap.Controls.Add(this.lblSob);
            this.grbNhap.Controls.Add(this.lblSoa);
            this.grbNhap.Location = new System.Drawing.Point(12, 12);
            this.grbNhap.Name = "grbNhap";
            this.grbNhap.Size = new System.Drawing.Size(200, 100);
            this.grbNhap.TabIndex = 0;
            this.grbNhap.TabStop = false;
            this.grbNhap.Text = "Nhập";
            // 
            // lblSoa
            // 
            this.lblSoa.AutoSize = true;
            this.lblSoa.Location = new System.Drawing.Point(18, 27);
            this.lblSoa.Name = "lblSoa";
            this.lblSoa.Size = new System.Drawing.Size(17, 13);
            this.lblSoa.TabIndex = 0;
            this.lblSoa.Text = "A:";
            // 
            // lblSob
            // 
            this.lblSob.AutoSize = true;
            this.lblSob.Location = new System.Drawing.Point(18, 61);
            this.lblSob.Name = "lblSob";
            this.lblSob.Size = new System.Drawing.Size(17, 13);
            this.lblSob.TabIndex = 1;
            this.lblSob.Text = "B:";
            // 
            // txtSoa
            // 
            this.txtSoa.Location = new System.Drawing.Point(41, 27);
            this.txtSoa.Name = "txtSoa";
            this.txtSoa.Size = new System.Drawing.Size(135, 20);
            this.txtSoa.TabIndex = 2;
            // 
            // txtSob
            // 
            this.txtSob.Location = new System.Drawing.Point(41, 58);
            this.txtSob.Name = "txtSob";
            this.txtSob.Size = new System.Drawing.Size(135, 20);
            this.txtSob.TabIndex = 3;
            // 
            // grbChon
            // 
            this.grbChon.Controls.Add(this.ckbBSCNN);
            this.grbChon.Controls.Add(this.ckbUSCLN);
            this.grbChon.Location = new System.Drawing.Point(242, 12);
            this.grbChon.Name = "grbChon";
            this.grbChon.Size = new System.Drawing.Size(110, 100);
            this.grbChon.TabIndex = 1;
            this.grbChon.TabStop = false;
            this.grbChon.Text = "Chọn";
            // 
            // ckbUSCLN
            // 
            this.ckbUSCLN.AutoSize = true;
            this.ckbUSCLN.Location = new System.Drawing.Point(29, 30);
            this.ckbUSCLN.Name = "ckbUSCLN";
            this.ckbUSCLN.Size = new System.Drawing.Size(62, 17);
            this.ckbUSCLN.TabIndex = 2;
            this.ckbUSCLN.Text = "USCLN";
            this.ckbUSCLN.UseVisualStyleBackColor = true;
            // 
            // ckbBSCNN
            // 
            this.ckbBSCNN.AutoSize = true;
            this.ckbBSCNN.Location = new System.Drawing.Point(29, 61);
            this.ckbBSCNN.Name = "ckbBSCNN";
            this.ckbBSCNN.Size = new System.Drawing.Size(63, 17);
            this.ckbBSCNN.TabIndex = 3;
            this.ckbBSCNN.Text = "BSCNN";
            this.ckbBSCNN.UseVisualStyleBackColor = true;
            this.ckbBSCNN.CheckedChanged += new System.EventHandler(this.ckbBSCNN_CheckedChanged);
            // 
            // grbKetqua
            // 
            this.grbKetqua.Controls.Add(this.btnThoat);
            this.grbKetqua.Controls.Add(this.btnBoqua);
            this.grbKetqua.Controls.Add(this.btnTim);
            this.grbKetqua.Controls.Add(this.txtKetqua);
            this.grbKetqua.Location = new System.Drawing.Point(12, 132);
            this.grbKetqua.Name = "grbKetqua";
            this.grbKetqua.Size = new System.Drawing.Size(340, 100);
            this.grbKetqua.TabIndex = 2;
            this.grbKetqua.TabStop = false;
            this.grbKetqua.Text = "Kết quả";
            // 
            // txtKetqua
            // 
            this.txtKetqua.Enabled = false;
            this.txtKetqua.Location = new System.Drawing.Point(87, 19);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(189, 20);
            this.txtKetqua.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(21, 56);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(125, 56);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 3;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(230, 56);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmUocBoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 262);
            this.Controls.Add(this.grbKetqua);
            this.Controls.Add(this.grbChon);
            this.Controls.Add(this.grbNhap);
            this.Name = "frmUocBoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm USCLN và BSCNN của A và B";
            this.grbNhap.ResumeLayout(false);
            this.grbNhap.PerformLayout();
            this.grbChon.ResumeLayout(false);
            this.grbChon.PerformLayout();
            this.grbKetqua.ResumeLayout(false);
            this.grbKetqua.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNhap;
        private System.Windows.Forms.TextBox txtSob;
        private System.Windows.Forms.TextBox txtSoa;
        private System.Windows.Forms.Label lblSob;
        private System.Windows.Forms.Label lblSoa;
        private System.Windows.Forms.GroupBox grbChon;
        private System.Windows.Forms.CheckBox ckbBSCNN;
        private System.Windows.Forms.CheckBox ckbUSCLN;
        private System.Windows.Forms.GroupBox grbKetqua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtKetqua;
    }
}

