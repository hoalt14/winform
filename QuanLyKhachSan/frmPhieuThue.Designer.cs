namespace QuanLyKhachSan
{
    partial class frmPhieuThue
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
            this.lsvPhieuThue = new System.Windows.Forms.ListView();
            this.columnHeaderMaPT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTenPT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNgayThue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNgayTra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTenKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTenPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbTTChitiet = new System.Windows.Forms.GroupBox();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.cboTenKH = new System.Windows.Forms.ComboBox();
            this.txtTenPT = new System.Windows.Forms.TextBox();
            this.lblTenPT = new System.Windows.Forms.Label();
            this.dtpNgayThue = new System.Windows.Forms.DateTimePicker();
            this.lblNgayThue = new System.Windows.Forms.Label();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.lblPhieuThue = new System.Windows.Forms.Label();
            this.listBoxPhieuThue = new System.Windows.Forms.ListBox();
            this.btnXuatPT = new System.Windows.Forms.Button();
            this.btnInPT = new System.Windows.Forms.Button();
            this.btnTaiPT = new System.Windows.Forms.Button();
            this.grbTTChung.SuspendLayout();
            this.grbTTChitiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTTChung
            // 
            this.grbTTChung.Controls.Add(this.lsvPhieuThue);
            this.grbTTChung.Location = new System.Drawing.Point(12, 303);
            this.grbTTChung.Name = "grbTTChung";
            this.grbTTChung.Size = new System.Drawing.Size(714, 189);
            this.grbTTChung.TabIndex = 17;
            this.grbTTChung.TabStop = false;
            this.grbTTChung.Text = "Thông tin chung";
            // 
            // lsvPhieuThue
            // 
            this.lsvPhieuThue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMaPT,
            this.columnHeaderTenPT,
            this.columnHeaderNgayThue,
            this.columnHeaderNgayTra,
            this.columnHeaderTenKH,
            this.columnHeaderTenPhong});
            this.lsvPhieuThue.FullRowSelect = true;
            this.lsvPhieuThue.GridLines = true;
            this.lsvPhieuThue.Location = new System.Drawing.Point(23, 31);
            this.lsvPhieuThue.Name = "lsvPhieuThue";
            this.lsvPhieuThue.Size = new System.Drawing.Size(664, 137);
            this.lsvPhieuThue.TabIndex = 0;
            this.lsvPhieuThue.UseCompatibleStateImageBehavior = false;
            this.lsvPhieuThue.View = System.Windows.Forms.View.Details;
            this.lsvPhieuThue.SelectedIndexChanged += new System.EventHandler(this.lsvPhieuThue_SelectedIndexChanged);
            // 
            // columnHeaderMaPT
            // 
            this.columnHeaderMaPT.Text = "Mã PT";
            // 
            // columnHeaderTenPT
            // 
            this.columnHeaderTenPT.Text = "Tên phiếu thuê";
            this.columnHeaderTenPT.Width = 120;
            // 
            // columnHeaderNgayThue
            // 
            this.columnHeaderNgayThue.Text = "Ngày thuê";
            this.columnHeaderNgayThue.Width = 150;
            // 
            // columnHeaderNgayTra
            // 
            this.columnHeaderNgayTra.Text = "Ngày trả";
            this.columnHeaderNgayTra.Width = 150;
            // 
            // columnHeaderTenKH
            // 
            this.columnHeaderTenKH.Text = "Tên khách hàng";
            this.columnHeaderTenKH.Width = 120;
            // 
            // columnHeaderTenPhong
            // 
            this.columnHeaderTenPhong.Text = "Phòng";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(246, 259);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(327, 259);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(408, 259);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(489, 259);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(570, 259);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(651, 259);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grbTTChitiet
            // 
            this.grbTTChitiet.Controls.Add(this.cboPhong);
            this.grbTTChitiet.Controls.Add(this.cboTenKH);
            this.grbTTChitiet.Controls.Add(this.txtTenPT);
            this.grbTTChitiet.Controls.Add(this.lblTenPT);
            this.grbTTChitiet.Controls.Add(this.dtpNgayThue);
            this.grbTTChitiet.Controls.Add(this.lblNgayThue);
            this.grbTTChitiet.Controls.Add(this.dtpNgayTra);
            this.grbTTChitiet.Controls.Add(this.lblNgayTra);
            this.grbTTChitiet.Controls.Add(this.lblTenKH);
            this.grbTTChitiet.Controls.Add(this.lblTenPhong);
            this.grbTTChitiet.Location = new System.Drawing.Point(12, 83);
            this.grbTTChitiet.Name = "grbTTChitiet";
            this.grbTTChitiet.Size = new System.Drawing.Size(714, 152);
            this.grbTTChitiet.TabIndex = 10;
            this.grbTTChitiet.TabStop = false;
            this.grbTTChitiet.Text = "Thông tin chi tiết";
            // 
            // cboPhong
            // 
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(133, 109);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(215, 21);
            this.cboPhong.TabIndex = 18;
            // 
            // cboTenKH
            // 
            this.cboTenKH.FormattingEnabled = true;
            this.cboTenKH.Location = new System.Drawing.Point(133, 70);
            this.cboTenKH.Name = "cboTenKH";
            this.cboTenKH.Size = new System.Drawing.Size(215, 21);
            this.cboTenKH.TabIndex = 17;
            // 
            // txtTenPT
            // 
            this.txtTenPT.Location = new System.Drawing.Point(133, 31);
            this.txtTenPT.Name = "txtTenPT";
            this.txtTenPT.Size = new System.Drawing.Size(215, 20);
            this.txtTenPT.TabIndex = 14;
            // 
            // lblTenPT
            // 
            this.lblTenPT.AutoSize = true;
            this.lblTenPT.Location = new System.Drawing.Point(20, 34);
            this.lblTenPT.Name = "lblTenPT";
            this.lblTenPT.Size = new System.Drawing.Size(79, 13);
            this.lblTenPT.TabIndex = 13;
            this.lblTenPT.Text = "Tên phiếu thuê";
            // 
            // dtpNgayThue
            // 
            this.dtpNgayThue.Location = new System.Drawing.Point(471, 28);
            this.dtpNgayThue.Name = "dtpNgayThue";
            this.dtpNgayThue.Size = new System.Drawing.Size(216, 20);
            this.dtpNgayThue.TabIndex = 11;
            this.dtpNgayThue.Value = new System.DateTime(2019, 10, 12, 0, 34, 19, 0);
            // 
            // lblNgayThue
            // 
            this.lblNgayThue.AutoSize = true;
            this.lblNgayThue.Location = new System.Drawing.Point(389, 34);
            this.lblNgayThue.Name = "lblNgayThue";
            this.lblNgayThue.Size = new System.Drawing.Size(56, 13);
            this.lblNgayThue.TabIndex = 10;
            this.lblNgayThue.Text = "Ngày thuê";
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Location = new System.Drawing.Point(471, 67);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(216, 20);
            this.dtpNgayTra.TabIndex = 7;
            this.dtpNgayTra.Value = new System.DateTime(2019, 10, 12, 0, 34, 19, 0);
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Location = new System.Drawing.Point(389, 73);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(47, 13);
            this.lblNgayTra.TabIndex = 1;
            this.lblNgayTra.Text = "Ngày trả";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(20, 73);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(86, 13);
            this.lblTenKH.TabIndex = 3;
            this.lblTenKH.Text = "Tên khách hàng";
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Location = new System.Drawing.Point(20, 112);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(59, 13);
            this.lblTenPhong.TabIndex = 2;
            this.lblTenPhong.Text = "Tên phòng";
            // 
            // lblPhieuThue
            // 
            this.lblPhieuThue.AutoSize = true;
            this.lblPhieuThue.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieuThue.ForeColor = System.Drawing.Color.Blue;
            this.lblPhieuThue.Location = new System.Drawing.Point(427, 29);
            this.lblPhieuThue.Name = "lblPhieuThue";
            this.lblPhieuThue.Size = new System.Drawing.Size(260, 24);
            this.lblPhieuThue.TabIndex = 9;
            this.lblPhieuThue.Text = "THÔNG TIN PHIẾU THUÊ";
            // 
            // listBoxPhieuThue
            // 
            this.listBoxPhieuThue.FormattingEnabled = true;
            this.listBoxPhieuThue.Location = new System.Drawing.Point(743, 150);
            this.listBoxPhieuThue.Name = "listBoxPhieuThue";
            this.listBoxPhieuThue.Size = new System.Drawing.Size(327, 342);
            this.listBoxPhieuThue.TabIndex = 18;
            // 
            // btnXuatPT
            // 
            this.btnXuatPT.ForeColor = System.Drawing.Color.Red;
            this.btnXuatPT.Location = new System.Drawing.Point(854, 107);
            this.btnXuatPT.Name = "btnXuatPT";
            this.btnXuatPT.Size = new System.Drawing.Size(105, 23);
            this.btnXuatPT.TabIndex = 34;
            this.btnXuatPT.Text = "Xuất phiếu thuê";
            this.btnXuatPT.UseVisualStyleBackColor = true;
            this.btnXuatPT.Click += new System.EventHandler(this.btnXuatPT_Click);
            // 
            // btnInPT
            // 
            this.btnInPT.ForeColor = System.Drawing.Color.Blue;
            this.btnInPT.Location = new System.Drawing.Point(743, 107);
            this.btnInPT.Name = "btnInPT";
            this.btnInPT.Size = new System.Drawing.Size(105, 23);
            this.btnInPT.TabIndex = 33;
            this.btnInPT.Text = "In phiếu thuê";
            this.btnInPT.UseVisualStyleBackColor = true;
            this.btnInPT.Click += new System.EventHandler(this.btnInPT_Click);
            // 
            // btnTaiPT
            // 
            this.btnTaiPT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTaiPT.Location = new System.Drawing.Point(965, 107);
            this.btnTaiPT.Name = "btnTaiPT";
            this.btnTaiPT.Size = new System.Drawing.Size(105, 23);
            this.btnTaiPT.TabIndex = 35;
            this.btnTaiPT.Text = "Tải phiếu thuê";
            this.btnTaiPT.UseVisualStyleBackColor = true;
            this.btnTaiPT.Click += new System.EventHandler(this.btnTaiPT_Click);
            // 
            // frmPhieuThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 517);
            this.Controls.Add(this.btnTaiPT);
            this.Controls.Add(this.btnXuatPT);
            this.Controls.Add(this.btnInPT);
            this.Controls.Add(this.listBoxPhieuThue);
            this.Controls.Add(this.grbTTChung);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grbTTChitiet);
            this.Controls.Add(this.lblPhieuThue);
            this.Name = "frmPhieuThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Thuê";
            this.Load += new System.EventHandler(this.frmPhieuThue_Load);
            this.grbTTChung.ResumeLayout(false);
            this.grbTTChitiet.ResumeLayout(false);
            this.grbTTChitiet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTTChung;
        private System.Windows.Forms.ListView lsvPhieuThue;
        private System.Windows.Forms.ColumnHeader columnHeaderMaPT;
        private System.Windows.Forms.ColumnHeader columnHeaderTenKH;
        private System.Windows.Forms.ColumnHeader columnHeaderTenPhong;
        private System.Windows.Forms.ColumnHeader columnHeaderNgayThue;
        private System.Windows.Forms.ColumnHeader columnHeaderNgayTra;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grbTTChitiet;
        private System.Windows.Forms.DateTimePicker dtpNgayThue;
        private System.Windows.Forms.Label lblNgayThue;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.Label lblPhieuThue;
        private System.Windows.Forms.ColumnHeader columnHeaderTenPT;
        private System.Windows.Forms.TextBox txtTenPT;
        private System.Windows.Forms.Label lblTenPT;
        private System.Windows.Forms.ComboBox cboTenKH;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.ListBox listBoxPhieuThue;
        private System.Windows.Forms.Button btnXuatPT;
        private System.Windows.Forms.Button btnInPT;
        private System.Windows.Forms.Button btnTaiPT;
    }
}