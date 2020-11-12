namespace QuanLyKhachSan
{
    partial class frmHoaDon
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbTTChung = new System.Windows.Forms.GroupBox();
            this.lsvHoaDon = new System.Windows.Forms.ListView();
            this.columnHeaderMaHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTenHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTenPT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNgayLapHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTenNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTenKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTenDV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGiaDV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTenPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGiaPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.cboTenNV = new System.Windows.Forms.ComboBox();
            this.cboTenPT = new System.Windows.Forms.ComboBox();
            this.txtTenHD = new System.Windows.Forms.TextBox();
            this.lblTenHD = new System.Windows.Forms.Label();
            this.dtpNgayLapHD = new System.Windows.Forms.DateTimePicker();
            this.lblNgayLapHD = new System.Windows.Forms.Label();
            this.cboTenKH = new System.Windows.Forms.ComboBox();
            this.lblTenPT = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.grbChiTiet = new System.Windows.Forms.GroupBox();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.lblGiaPhong = new System.Windows.Forms.Label();
            this.txtGiaDV = new System.Windows.Forms.TextBox();
            this.lblGiaDV = new System.Windows.Forms.Label();
            this.cboTenDV = new System.Windows.Forms.ComboBox();
            this.cboTenPhong = new System.Windows.Forms.ComboBox();
            this.lblTenDV = new System.Windows.Forms.Label();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.btnThanhTien = new System.Windows.Forms.Button();
            this.btnXuatHD = new System.Windows.Forms.Button();
            this.grbThanhToan = new System.Windows.Forms.GroupBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtSoNgayThue = new System.Windows.Forms.TextBox();
            this.lblSoNgayThue = new System.Windows.Forms.Label();
            this.txtSoLuongDV = new System.Windows.Forms.TextBox();
            this.lblSoLuongDV = new System.Windows.Forms.Label();
            this.grbTTChung.SuspendLayout();
            this.grbThongTin.SuspendLayout();
            this.grbChiTiet.SuspendLayout();
            this.grbThanhToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(398, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(228, 24);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "THÔNG TIN HÓA ĐƠN";
            // 
            // grbTTChung
            // 
            this.grbTTChung.Controls.Add(this.lsvHoaDon);
            this.grbTTChung.Location = new System.Drawing.Point(12, 342);
            this.grbTTChung.Name = "grbTTChung";
            this.grbTTChung.Size = new System.Drawing.Size(974, 189);
            this.grbTTChung.TabIndex = 30;
            this.grbTTChung.TabStop = false;
            this.grbTTChung.Text = "Thông tin chung";
            // 
            // lsvHoaDon
            // 
            this.lsvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMaHD,
            this.columnHeaderTenHD,
            this.columnHeaderTenPT,
            this.columnHeaderNgayLapHD,
            this.columnHeaderTenNV,
            this.columnHeaderTenKH,
            this.columnTenDV,
            this.columnHeaderGiaDV,
            this.columnHeaderTenPhong,
            this.columnHeaderGiaPhong});
            this.lsvHoaDon.FullRowSelect = true;
            this.lsvHoaDon.GridLines = true;
            this.lsvHoaDon.Location = new System.Drawing.Point(9, 32);
            this.lsvHoaDon.Name = "lsvHoaDon";
            this.lsvHoaDon.Size = new System.Drawing.Size(954, 137);
            this.lsvHoaDon.TabIndex = 0;
            this.lsvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lsvHoaDon.View = System.Windows.Forms.View.Details;
            this.lsvHoaDon.SelectedIndexChanged += new System.EventHandler(this.lsvHoaDon_SelectedIndexChanged);
            // 
            // columnHeaderMaHD
            // 
            this.columnHeaderMaHD.Text = "Mã HD";
            // 
            // columnHeaderTenHD
            // 
            this.columnHeaderTenHD.Text = "Tên hóa đơn";
            this.columnHeaderTenHD.Width = 80;
            // 
            // columnHeaderTenPT
            // 
            this.columnHeaderTenPT.Text = "Tên phiếu thuê";
            this.columnHeaderTenPT.Width = 100;
            // 
            // columnHeaderNgayLapHD
            // 
            this.columnHeaderNgayLapHD.Text = "Ngày lập hóa đơn";
            this.columnHeaderNgayLapHD.Width = 150;
            // 
            // columnHeaderTenNV
            // 
            this.columnHeaderTenNV.Text = "Tên nhân viên";
            this.columnHeaderTenNV.Width = 120;
            // 
            // columnHeaderTenKH
            // 
            this.columnHeaderTenKH.Text = "Tên khách hàng";
            this.columnHeaderTenKH.Width = 120;
            // 
            // columnTenDV
            // 
            this.columnTenDV.Text = "Tên dịch vụ";
            this.columnTenDV.Width = 80;
            // 
            // columnHeaderGiaDV
            // 
            this.columnHeaderGiaDV.Text = "Giá dịch vụ";
            this.columnHeaderGiaDV.Width = 80;
            // 
            // columnHeaderTenPhong
            // 
            this.columnHeaderTenPhong.Text = "Tên phòng";
            this.columnHeaderTenPhong.Width = 80;
            // 
            // columnHeaderGiaPhong
            // 
            this.columnHeaderGiaPhong.Text = "Giá phòng";
            this.columnHeaderGiaPhong.Width = 80;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(457, 304);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(538, 304);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(619, 304);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(700, 304);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 26;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(781, 304);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 25;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(862, 304);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.cboTenNV);
            this.grbThongTin.Controls.Add(this.cboTenPT);
            this.grbThongTin.Controls.Add(this.txtTenHD);
            this.grbThongTin.Controls.Add(this.lblTenHD);
            this.grbThongTin.Controls.Add(this.dtpNgayLapHD);
            this.grbThongTin.Controls.Add(this.lblNgayLapHD);
            this.grbThongTin.Controls.Add(this.cboTenKH);
            this.grbThongTin.Controls.Add(this.lblTenPT);
            this.grbThongTin.Controls.Add(this.lblTenNV);
            this.grbThongTin.Controls.Add(this.lblTenKH);
            this.grbThongTin.Location = new System.Drawing.Point(12, 63);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(385, 264);
            this.grbThongTin.TabIndex = 23;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin";
            // 
            // cboTenNV
            // 
            this.cboTenNV.FormattingEnabled = true;
            this.cboTenNV.Location = new System.Drawing.Point(144, 172);
            this.cboTenNV.Name = "cboTenNV";
            this.cboTenNV.Size = new System.Drawing.Size(215, 21);
            this.cboTenNV.TabIndex = 18;
            // 
            // cboTenPT
            // 
            this.cboTenPT.FormattingEnabled = true;
            this.cboTenPT.Location = new System.Drawing.Point(144, 75);
            this.cboTenPT.Name = "cboTenPT";
            this.cboTenPT.Size = new System.Drawing.Size(215, 21);
            this.cboTenPT.TabIndex = 17;
            // 
            // txtTenHD
            // 
            this.txtTenHD.Location = new System.Drawing.Point(144, 31);
            this.txtTenHD.Name = "txtTenHD";
            this.txtTenHD.Size = new System.Drawing.Size(215, 20);
            this.txtTenHD.TabIndex = 14;
            // 
            // lblTenHD
            // 
            this.lblTenHD.AutoSize = true;
            this.lblTenHD.Location = new System.Drawing.Point(20, 34);
            this.lblTenHD.Name = "lblTenHD";
            this.lblTenHD.Size = new System.Drawing.Size(69, 13);
            this.lblTenHD.TabIndex = 13;
            this.lblTenHD.Text = "Tên hóa đơn";
            // 
            // dtpNgayLapHD
            // 
            this.dtpNgayLapHD.Location = new System.Drawing.Point(144, 124);
            this.dtpNgayLapHD.Name = "dtpNgayLapHD";
            this.dtpNgayLapHD.Size = new System.Drawing.Size(215, 20);
            this.dtpNgayLapHD.TabIndex = 11;
            this.dtpNgayLapHD.Value = new System.DateTime(2019, 10, 12, 0, 34, 19, 0);
            // 
            // lblNgayLapHD
            // 
            this.lblNgayLapHD.AutoSize = true;
            this.lblNgayLapHD.Location = new System.Drawing.Point(20, 130);
            this.lblNgayLapHD.Name = "lblNgayLapHD";
            this.lblNgayLapHD.Size = new System.Drawing.Size(92, 13);
            this.lblNgayLapHD.TabIndex = 10;
            this.lblNgayLapHD.Text = "Ngày lập hóa đơn";
            // 
            // cboTenKH
            // 
            this.cboTenKH.FormattingEnabled = true;
            this.cboTenKH.Location = new System.Drawing.Point(144, 224);
            this.cboTenKH.Name = "cboTenKH";
            this.cboTenKH.Size = new System.Drawing.Size(215, 21);
            this.cboTenKH.TabIndex = 17;
            // 
            // lblTenPT
            // 
            this.lblTenPT.AutoSize = true;
            this.lblTenPT.Location = new System.Drawing.Point(20, 78);
            this.lblTenPT.Name = "lblTenPT";
            this.lblTenPT.Size = new System.Drawing.Size(79, 13);
            this.lblTenPT.TabIndex = 3;
            this.lblTenPT.Text = "Tên phiếu thuê";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(20, 176);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(116, 13);
            this.lblTenNV.TabIndex = 2;
            this.lblTenNV.Text = "Nhân viên lập hóa đơn";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(20, 227);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(99, 13);
            this.lblTenKH.TabIndex = 3;
            this.lblTenKH.Text = "Họ tên khách hàng";
            // 
            // grbChiTiet
            // 
            this.grbChiTiet.Controls.Add(this.txtGiaPhong);
            this.grbChiTiet.Controls.Add(this.lblGiaPhong);
            this.grbChiTiet.Controls.Add(this.txtGiaDV);
            this.grbChiTiet.Controls.Add(this.lblGiaDV);
            this.grbChiTiet.Controls.Add(this.cboTenDV);
            this.grbChiTiet.Controls.Add(this.cboTenPhong);
            this.grbChiTiet.Controls.Add(this.lblTenDV);
            this.grbChiTiet.Controls.Add(this.lblTenPhong);
            this.grbChiTiet.Location = new System.Drawing.Point(413, 63);
            this.grbChiTiet.Name = "grbChiTiet";
            this.grbChiTiet.Size = new System.Drawing.Size(307, 222);
            this.grbChiTiet.TabIndex = 24;
            this.grbChiTiet.TabStop = false;
            this.grbChiTiet.Text = "Chi tiết";
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Enabled = false;
            this.txtGiaPhong.Location = new System.Drawing.Point(108, 173);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(172, 20);
            this.txtGiaPhong.TabIndex = 22;
            // 
            // lblGiaPhong
            // 
            this.lblGiaPhong.AutoSize = true;
            this.lblGiaPhong.Location = new System.Drawing.Point(21, 176);
            this.lblGiaPhong.Name = "lblGiaPhong";
            this.lblGiaPhong.Size = new System.Drawing.Size(56, 13);
            this.lblGiaPhong.TabIndex = 21;
            this.lblGiaPhong.Text = "Giá phòng";
            // 
            // txtGiaDV
            // 
            this.txtGiaDV.Enabled = false;
            this.txtGiaDV.Location = new System.Drawing.Point(108, 75);
            this.txtGiaDV.Name = "txtGiaDV";
            this.txtGiaDV.Size = new System.Drawing.Size(172, 20);
            this.txtGiaDV.TabIndex = 20;
            // 
            // lblGiaDV
            // 
            this.lblGiaDV.AutoSize = true;
            this.lblGiaDV.Location = new System.Drawing.Point(21, 78);
            this.lblGiaDV.Name = "lblGiaDV";
            this.lblGiaDV.Size = new System.Drawing.Size(61, 13);
            this.lblGiaDV.TabIndex = 19;
            this.lblGiaDV.Text = "Giá dịch vụ";
            // 
            // cboTenDV
            // 
            this.cboTenDV.FormattingEnabled = true;
            this.cboTenDV.Location = new System.Drawing.Point(108, 31);
            this.cboTenDV.Name = "cboTenDV";
            this.cboTenDV.Size = new System.Drawing.Size(172, 21);
            this.cboTenDV.TabIndex = 19;
            // 
            // cboTenPhong
            // 
            this.cboTenPhong.FormattingEnabled = true;
            this.cboTenPhong.Location = new System.Drawing.Point(108, 127);
            this.cboTenPhong.Name = "cboTenPhong";
            this.cboTenPhong.Size = new System.Drawing.Size(172, 21);
            this.cboTenPhong.TabIndex = 18;
            // 
            // lblTenDV
            // 
            this.lblTenDV.AutoSize = true;
            this.lblTenDV.Location = new System.Drawing.Point(21, 34);
            this.lblTenDV.Name = "lblTenDV";
            this.lblTenDV.Size = new System.Drawing.Size(64, 13);
            this.lblTenDV.TabIndex = 13;
            this.lblTenDV.Text = "Tên dịch vụ";
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Location = new System.Drawing.Point(21, 130);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(59, 13);
            this.lblTenPhong.TabIndex = 2;
            this.lblTenPhong.Text = "Tên phòng";
            // 
            // btnThanhTien
            // 
            this.btnThanhTien.ForeColor = System.Drawing.Color.Blue;
            this.btnThanhTien.Location = new System.Drawing.Point(13, 173);
            this.btnThanhTien.Name = "btnThanhTien";
            this.btnThanhTien.Size = new System.Drawing.Size(105, 23);
            this.btnThanhTien.TabIndex = 31;
            this.btnThanhTien.Text = "Thành tiền";
            this.btnThanhTien.UseVisualStyleBackColor = true;
            this.btnThanhTien.Click += new System.EventHandler(this.btnThanhTien_Click);
            // 
            // btnXuatHD
            // 
            this.btnXuatHD.ForeColor = System.Drawing.Color.Red;
            this.btnXuatHD.Location = new System.Drawing.Point(124, 173);
            this.btnXuatHD.Name = "btnXuatHD";
            this.btnXuatHD.Size = new System.Drawing.Size(105, 23);
            this.btnXuatHD.TabIndex = 32;
            this.btnXuatHD.Text = "Xuất hóa đơn";
            this.btnXuatHD.UseVisualStyleBackColor = true;
            this.btnXuatHD.Click += new System.EventHandler(this.btnXuatHD_Click);
            // 
            // grbThanhToan
            // 
            this.grbThanhToan.Controls.Add(this.txtTongTien);
            this.grbThanhToan.Controls.Add(this.btnXuatHD);
            this.grbThanhToan.Controls.Add(this.btnThanhTien);
            this.grbThanhToan.Controls.Add(this.lblTongTien);
            this.grbThanhToan.Controls.Add(this.txtSoNgayThue);
            this.grbThanhToan.Controls.Add(this.lblSoNgayThue);
            this.grbThanhToan.Controls.Add(this.txtSoLuongDV);
            this.grbThanhToan.Controls.Add(this.lblSoLuongDV);
            this.grbThanhToan.Location = new System.Drawing.Point(738, 63);
            this.grbThanhToan.Name = "grbThanhToan";
            this.grbThanhToan.Size = new System.Drawing.Size(248, 222);
            this.grbThanhToan.TabIndex = 25;
            this.grbThanhToan.TabStop = false;
            this.grbThanhToan.Text = "Thanh toán";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(100, 127);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(129, 20);
            this.txtTongTien.TabIndex = 24;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(26, 128);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(67, 15);
            this.lblTongTien.TabIndex = 23;
            this.lblTongTien.Text = "Tổng tiền";
            // 
            // txtSoNgayThue
            // 
            this.txtSoNgayThue.Location = new System.Drawing.Point(160, 75);
            this.txtSoNgayThue.Name = "txtSoNgayThue";
            this.txtSoNgayThue.Size = new System.Drawing.Size(69, 20);
            this.txtSoNgayThue.TabIndex = 22;
            // 
            // lblSoNgayThue
            // 
            this.lblSoNgayThue.AutoSize = true;
            this.lblSoNgayThue.Location = new System.Drawing.Point(26, 78);
            this.lblSoNgayThue.Name = "lblSoNgayThue";
            this.lblSoNgayThue.Size = new System.Drawing.Size(103, 13);
            this.lblSoNgayThue.TabIndex = 21;
            this.lblSoNgayThue.Text = "Số ngày thuê phòng";
            // 
            // txtSoLuongDV
            // 
            this.txtSoLuongDV.Location = new System.Drawing.Point(160, 31);
            this.txtSoLuongDV.Name = "txtSoLuongDV";
            this.txtSoLuongDV.Size = new System.Drawing.Size(69, 20);
            this.txtSoLuongDV.TabIndex = 20;
            // 
            // lblSoLuongDV
            // 
            this.lblSoLuongDV.AutoSize = true;
            this.lblSoLuongDV.Location = new System.Drawing.Point(26, 34);
            this.lblSoLuongDV.Name = "lblSoLuongDV";
            this.lblSoLuongDV.Size = new System.Drawing.Size(128, 13);
            this.lblSoLuongDV.TabIndex = 19;
            this.lblSoLuongDV.Text = "Số lượng sử dụng dịch vụ";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 546);
            this.Controls.Add(this.grbThanhToan);
            this.Controls.Add(this.grbChiTiet);
            this.Controls.Add(this.grbTTChung);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.grbTTChung.ResumeLayout(false);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.grbChiTiet.ResumeLayout(false);
            this.grbChiTiet.PerformLayout();
            this.grbThanhToan.ResumeLayout(false);
            this.grbThanhToan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbTTChung;
        private System.Windows.Forms.ListView lsvHoaDon;
        private System.Windows.Forms.ColumnHeader columnHeaderMaHD;
        private System.Windows.Forms.ColumnHeader columnHeaderTenPT;
        private System.Windows.Forms.ColumnHeader columnHeaderNgayLapHD;
        private System.Windows.Forms.ColumnHeader columnHeaderTenNV;
        private System.Windows.Forms.ColumnHeader columnHeaderTenKH;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.ComboBox cboTenNV;
        private System.Windows.Forms.ComboBox cboTenPT;
        private System.Windows.Forms.TextBox txtTenHD;
        private System.Windows.Forms.Label lblTenHD;
        private System.Windows.Forms.DateTimePicker dtpNgayLapHD;
        private System.Windows.Forms.Label lblNgayLapHD;
        private System.Windows.Forms.Label lblTenPT;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.GroupBox grbChiTiet;
        private System.Windows.Forms.ComboBox cboTenPhong;
        private System.Windows.Forms.ComboBox cboTenKH;
        private System.Windows.Forms.Label lblTenDV;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.ComboBox cboTenDV;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.Label lblGiaPhong;
        private System.Windows.Forms.TextBox txtGiaDV;
        private System.Windows.Forms.Label lblGiaDV;
        private System.Windows.Forms.ColumnHeader columnHeaderTenHD;
        private System.Windows.Forms.ColumnHeader columnTenDV;
        private System.Windows.Forms.ColumnHeader columnHeaderGiaDV;
        private System.Windows.Forms.ColumnHeader columnHeaderTenPhong;
        private System.Windows.Forms.ColumnHeader columnHeaderGiaPhong;
        private System.Windows.Forms.Button btnThanhTien;
        private System.Windows.Forms.Button btnXuatHD;
        private System.Windows.Forms.GroupBox grbThanhToan;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtSoNgayThue;
        private System.Windows.Forms.Label lblSoNgayThue;
        private System.Windows.Forms.TextBox txtSoLuongDV;
        private System.Windows.Forms.Label lblSoLuongDV;
    }
}