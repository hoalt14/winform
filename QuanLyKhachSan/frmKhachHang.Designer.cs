namespace QuanLyKhachSan
{
    partial class frmKhachHang
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
            this.grbTTChung = new System.Windows.Forms.GroupBox();
            this.lsvKhachHang = new System.Windows.Forms.ListView();
            this.columnHeaderMaKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDienThoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSoCMND = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbTTChitiet = new System.Windows.Forms.GroupBox();
            this.txtSoCMND = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblSoCMND = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.grbTTChung.SuspendLayout();
            this.grbTTChitiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTTChung
            // 
            this.grbTTChung.Controls.Add(this.lsvKhachHang);
            this.grbTTChung.Location = new System.Drawing.Point(14, 299);
            this.grbTTChung.Name = "grbTTChung";
            this.grbTTChung.Size = new System.Drawing.Size(536, 189);
            this.grbTTChung.TabIndex = 17;
            this.grbTTChung.TabStop = false;
            this.grbTTChung.Text = "Thông tin chung";
            // 
            // lsvKhachHang
            // 
            this.lsvKhachHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMaKH,
            this.columnHeaderHoTen,
            this.columnHeaderDiaChi,
            this.columnHeaderDienThoai,
            this.columnHeaderSoCMND});
            this.lsvKhachHang.FullRowSelect = true;
            this.lsvKhachHang.GridLines = true;
            this.lsvKhachHang.Location = new System.Drawing.Point(14, 33);
            this.lsvKhachHang.Name = "lsvKhachHang";
            this.lsvKhachHang.Size = new System.Drawing.Size(504, 137);
            this.lsvKhachHang.TabIndex = 0;
            this.lsvKhachHang.UseCompatibleStateImageBehavior = false;
            this.lsvKhachHang.View = System.Windows.Forms.View.Details;
            this.lsvKhachHang.SelectedIndexChanged += new System.EventHandler(this.lsvKhachHang_SelectedIndexChanged);
            // 
            // columnHeaderMaKH
            // 
            this.columnHeaderMaKH.Text = "Mã KH";
            // 
            // columnHeaderHoTen
            // 
            this.columnHeaderHoTen.Text = "Họ tên";
            this.columnHeaderHoTen.Width = 120;
            // 
            // columnHeaderDiaChi
            // 
            this.columnHeaderDiaChi.Text = "Địa chỉ";
            this.columnHeaderDiaChi.Width = 100;
            // 
            // columnHeaderDienThoai
            // 
            this.columnHeaderDienThoai.Text = "Điện thoại";
            this.columnHeaderDienThoai.Width = 110;
            // 
            // columnHeaderSoCMND
            // 
            this.columnHeaderSoCMND.Text = "Số CMND";
            this.columnHeaderSoCMND.Width = 110;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(377, 109);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(377, 151);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(377, 196);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(458, 109);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(458, 151);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(458, 196);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grbTTChitiet
            // 
            this.grbTTChitiet.Controls.Add(this.txtSoCMND);
            this.grbTTChitiet.Controls.Add(this.txtDiaChi);
            this.grbTTChitiet.Controls.Add(this.txtDienThoai);
            this.grbTTChitiet.Controls.Add(this.txtHoTen);
            this.grbTTChitiet.Controls.Add(this.lblDiaChi);
            this.grbTTChitiet.Controls.Add(this.lblDienThoai);
            this.grbTTChitiet.Controls.Add(this.lblSoCMND);
            this.grbTTChitiet.Controls.Add(this.lblHoTen);
            this.grbTTChitiet.Location = new System.Drawing.Point(12, 67);
            this.grbTTChitiet.Name = "grbTTChitiet";
            this.grbTTChitiet.Size = new System.Drawing.Size(337, 197);
            this.grbTTChitiet.TabIndex = 10;
            this.grbTTChitiet.TabStop = false;
            this.grbTTChitiet.Text = "Thông tin chi tiết";
            // 
            // txtSoCMND
            // 
            this.txtSoCMND.Location = new System.Drawing.Point(101, 149);
            this.txtSoCMND.Name = "txtSoCMND";
            this.txtSoCMND.Size = new System.Drawing.Size(200, 20);
            this.txtSoCMND.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(101, 71);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 20);
            this.txtDiaChi.TabIndex = 8;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(101, 110);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(200, 20);
            this.txtDienThoai.TabIndex = 6;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(101, 29);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 20);
            this.txtHoTen.TabIndex = 5;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(30, 74);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(40, 13);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(30, 113);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(55, 13);
            this.lblDienThoai.TabIndex = 3;
            this.lblDienThoai.Text = "Điện thoại";
            // 
            // lblSoCMND
            // 
            this.lblSoCMND.AutoSize = true;
            this.lblSoCMND.Location = new System.Drawing.Point(30, 152);
            this.lblSoCMND.Name = "lblSoCMND";
            this.lblSoCMND.Size = new System.Drawing.Size(55, 13);
            this.lblSoCMND.TabIndex = 2;
            this.lblSoCMND.Text = "Số CMND";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(30, 32);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(39, 13);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.ForeColor = System.Drawing.Color.Blue;
            this.lblKhachHang.Location = new System.Drawing.Point(153, 20);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(276, 24);
            this.lblKhachHang.TabIndex = 9;
            this.lblKhachHang.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 500);
            this.Controls.Add(this.grbTTChung);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grbTTChitiet);
            this.Controls.Add(this.lblKhachHang);
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.grbTTChung.ResumeLayout(false);
            this.grbTTChitiet.ResumeLayout(false);
            this.grbTTChitiet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTTChung;
        private System.Windows.Forms.ListView lsvKhachHang;
        private System.Windows.Forms.ColumnHeader columnHeaderMaKH;
        private System.Windows.Forms.ColumnHeader columnHeaderHoTen;
        private System.Windows.Forms.ColumnHeader columnHeaderDienThoai;
        private System.Windows.Forms.ColumnHeader columnHeaderDiaChi;
        private System.Windows.Forms.ColumnHeader columnHeaderSoCMND;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grbTTChitiet;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblSoCMND;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.TextBox txtSoCMND;
    }
}