namespace QuanLyKhachSan
{
    partial class frmDichVu
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblDichVu = new System.Windows.Forms.Label();
            this.grbTTChitiet = new System.Windows.Forms.GroupBox();
            this.txtGiaDV = new System.Windows.Forms.TextBox();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.lblGiaDV = new System.Windows.Forms.Label();
            this.lblTenDV = new System.Windows.Forms.Label();
            this.grbTTChung = new System.Windows.Forms.GroupBox();
            this.lsvDichVu = new System.Windows.Forms.ListView();
            this.columnHeaderMaDV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTenDV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbTTChitiet.SuspendLayout();
            this.grbTTChung.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(21, 225);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(102, 225);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(183, 225);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(21, 254);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(102, 254);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(183, 254);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblDichVu
            // 
            this.lblDichVu.AutoSize = true;
            this.lblDichVu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDichVu.ForeColor = System.Drawing.Color.Blue;
            this.lblDichVu.Location = new System.Drawing.Point(170, 35);
            this.lblDichVu.Name = "lblDichVu";
            this.lblDichVu.Size = new System.Drawing.Size(218, 24);
            this.lblDichVu.TabIndex = 14;
            this.lblDichVu.Text = "DANH MỤC DỊCH VỤ";
            // 
            // grbTTChitiet
            // 
            this.grbTTChitiet.Controls.Add(this.txtGiaDV);
            this.grbTTChitiet.Controls.Add(this.txtTenDV);
            this.grbTTChitiet.Controls.Add(this.lblGiaDV);
            this.grbTTChitiet.Controls.Add(this.lblTenDV);
            this.grbTTChitiet.Location = new System.Drawing.Point(21, 93);
            this.grbTTChitiet.Name = "grbTTChitiet";
            this.grbTTChitiet.Size = new System.Drawing.Size(237, 114);
            this.grbTTChitiet.TabIndex = 15;
            this.grbTTChitiet.TabStop = false;
            this.grbTTChitiet.Text = "Thông tin chi tiết";
            // 
            // txtGiaDV
            // 
            this.txtGiaDV.Location = new System.Drawing.Point(61, 70);
            this.txtGiaDV.Name = "txtGiaDV";
            this.txtGiaDV.Size = new System.Drawing.Size(154, 20);
            this.txtGiaDV.TabIndex = 6;
            // 
            // txtTenDV
            // 
            this.txtTenDV.Location = new System.Drawing.Point(61, 29);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(154, 20);
            this.txtTenDV.TabIndex = 5;
            // 
            // lblGiaDV
            // 
            this.lblGiaDV.AutoSize = true;
            this.lblGiaDV.Location = new System.Drawing.Point(19, 73);
            this.lblGiaDV.Name = "lblGiaDV";
            this.lblGiaDV.Size = new System.Drawing.Size(23, 13);
            this.lblGiaDV.TabIndex = 3;
            this.lblGiaDV.Text = "Giá";
            // 
            // lblTenDV
            // 
            this.lblTenDV.AutoSize = true;
            this.lblTenDV.Location = new System.Drawing.Point(19, 32);
            this.lblTenDV.Name = "lblTenDV";
            this.lblTenDV.Size = new System.Drawing.Size(26, 13);
            this.lblTenDV.TabIndex = 0;
            this.lblTenDV.Text = "Tên";
            // 
            // grbTTChung
            // 
            this.grbTTChung.Controls.Add(this.lsvDichVu);
            this.grbTTChung.Location = new System.Drawing.Point(274, 93);
            this.grbTTChung.Name = "grbTTChung";
            this.grbTTChung.Size = new System.Drawing.Size(308, 253);
            this.grbTTChung.TabIndex = 16;
            this.grbTTChung.TabStop = false;
            this.grbTTChung.Text = "Thông tin chung";
            // 
            // lsvDichVu
            // 
            this.lsvDichVu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMaDV,
            this.columnHeaderTenDV,
            this.columnHeaderGia});
            this.lsvDichVu.FullRowSelect = true;
            this.lsvDichVu.GridLines = true;
            this.lsvDichVu.Location = new System.Drawing.Point(23, 29);
            this.lsvDichVu.Name = "lsvDichVu";
            this.lsvDichVu.Size = new System.Drawing.Size(264, 204);
            this.lsvDichVu.TabIndex = 0;
            this.lsvDichVu.UseCompatibleStateImageBehavior = false;
            this.lsvDichVu.View = System.Windows.Forms.View.Details;
            this.lsvDichVu.SelectedIndexChanged += new System.EventHandler(this.lsvDichVu_SelectedIndexChanged);
            // 
            // columnHeaderMaDV
            // 
            this.columnHeaderMaDV.Text = "Mã DV";
            // 
            // columnHeaderTenDV
            // 
            this.columnHeaderTenDV.Text = "Tên";
            this.columnHeaderTenDV.Width = 120;
            // 
            // columnHeaderGia
            // 
            this.columnHeaderGia.Text = "Giá";
            this.columnHeaderGia.Width = 80;
            // 
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 359);
            this.Controls.Add(this.grbTTChung);
            this.Controls.Add(this.grbTTChitiet);
            this.Controls.Add(this.lblDichVu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThoat);
            this.Name = "frmDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dịch Vụ";
            this.Load += new System.EventHandler(this.frmDichVu_Load);
            this.grbTTChitiet.ResumeLayout(false);
            this.grbTTChitiet.PerformLayout();
            this.grbTTChung.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblDichVu;
        private System.Windows.Forms.GroupBox grbTTChitiet;
        private System.Windows.Forms.TextBox txtGiaDV;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.Label lblGiaDV;
        private System.Windows.Forms.Label lblTenDV;
        private System.Windows.Forms.GroupBox grbTTChung;
        private System.Windows.Forms.ListView lsvDichVu;
        private System.Windows.Forms.ColumnHeader columnHeaderMaDV;
        private System.Windows.Forms.ColumnHeader columnHeaderTenDV;
        private System.Windows.Forms.ColumnHeader columnHeaderGia;
    }
}