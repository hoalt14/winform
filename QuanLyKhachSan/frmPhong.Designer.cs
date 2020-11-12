namespace QuanLyKhachSan
{
    partial class frmPhong
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
            this.lsvPhong = new System.Windows.Forms.ListView();
            this.columnHeaderMaPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTenPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLoaiPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGiaPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTinhTrang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbTTChitiet = new System.Windows.Forms.GroupBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.lblGiaPhong = new System.Windows.Forms.Label();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.lblPhong = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbTTChung.SuspendLayout();
            this.grbTTChitiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTTChung
            // 
            this.grbTTChung.Controls.Add(this.lsvPhong);
            this.grbTTChung.Location = new System.Drawing.Point(19, 306);
            this.grbTTChung.Name = "grbTTChung";
            this.grbTTChung.Size = new System.Drawing.Size(531, 233);
            this.grbTTChung.TabIndex = 25;
            this.grbTTChung.TabStop = false;
            this.grbTTChung.Text = "Thông tin chung";
            // 
            // lsvPhong
            // 
            this.lsvPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMaPhong,
            this.columnHeaderTenPhong,
            this.columnHeaderLoaiPhong,
            this.columnHeaderGiaPhong,
            this.columnHeaderTinhTrang});
            this.lsvPhong.FullRowSelect = true;
            this.lsvPhong.GridLines = true;
            this.lsvPhong.Location = new System.Drawing.Point(23, 29);
            this.lsvPhong.Name = "lsvPhong";
            this.lsvPhong.Size = new System.Drawing.Size(484, 185);
            this.lsvPhong.TabIndex = 0;
            this.lsvPhong.UseCompatibleStateImageBehavior = false;
            this.lsvPhong.View = System.Windows.Forms.View.Details;
            this.lsvPhong.SelectedIndexChanged += new System.EventHandler(this.lsvPhong_SelectedIndexChanged);
            // 
            // columnHeaderMaPhong
            // 
            this.columnHeaderMaPhong.Text = "Mã Phòng";
            this.columnHeaderMaPhong.Width = 80;
            // 
            // columnHeaderTenPhong
            // 
            this.columnHeaderTenPhong.Text = "Tên";
            this.columnHeaderTenPhong.Width = 80;
            // 
            // columnHeaderLoaiPhong
            // 
            this.columnHeaderLoaiPhong.Text = "Loại";
            this.columnHeaderLoaiPhong.Width = 160;
            // 
            // columnHeaderGiaPhong
            // 
            this.columnHeaderGiaPhong.Text = "Giá";
            this.columnHeaderGiaPhong.Width = 80;
            // 
            // columnHeaderTinhTrang
            // 
            this.columnHeaderTinhTrang.Text = "Tình trạng";
            this.columnHeaderTinhTrang.Width = 80;
            // 
            // grbTTChitiet
            // 
            this.grbTTChitiet.Controls.Add(this.txtTinhTrang);
            this.grbTTChitiet.Controls.Add(this.label1);
            this.grbTTChitiet.Controls.Add(this.cboLoaiPhong);
            this.grbTTChitiet.Controls.Add(this.txtTenPhong);
            this.grbTTChitiet.Controls.Add(this.txtGiaPhong);
            this.grbTTChitiet.Controls.Add(this.lblTenPhong);
            this.grbTTChitiet.Controls.Add(this.lblGiaPhong);
            this.grbTTChitiet.Controls.Add(this.lblLoaiPhong);
            this.grbTTChitiet.Location = new System.Drawing.Point(19, 82);
            this.grbTTChitiet.Name = "grbTTChitiet";
            this.grbTTChitiet.Size = new System.Drawing.Size(258, 198);
            this.grbTTChitiet.TabIndex = 24;
            this.grbTTChitiet.TabStop = false;
            this.grbTTChitiet.Text = "Thông tin chi tiết";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(80, 154);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(154, 20);
            this.txtTinhTrang.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tình trạng";
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.FormattingEnabled = true;
            this.cboLoaiPhong.Location = new System.Drawing.Point(80, 67);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(154, 21);
            this.cboLoaiPhong.TabIndex = 26;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(80, 26);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(154, 20);
            this.txtTenPhong.TabIndex = 8;
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Location = new System.Drawing.Point(80, 111);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(154, 20);
            this.txtGiaPhong.TabIndex = 6;
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Location = new System.Drawing.Point(19, 29);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(26, 13);
            this.lblTenPhong.TabIndex = 7;
            this.lblTenPhong.Text = "Tên";
            // 
            // lblGiaPhong
            // 
            this.lblGiaPhong.AutoSize = true;
            this.lblGiaPhong.Location = new System.Drawing.Point(19, 114);
            this.lblGiaPhong.Name = "lblGiaPhong";
            this.lblGiaPhong.Size = new System.Drawing.Size(23, 13);
            this.lblGiaPhong.TabIndex = 3;
            this.lblGiaPhong.Text = "Giá";
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Location = new System.Drawing.Point(19, 70);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(27, 13);
            this.lblLoaiPhong.TabIndex = 0;
            this.lblLoaiPhong.Text = "Loại";
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.ForeColor = System.Drawing.Color.Blue;
            this.lblPhong.Location = new System.Drawing.Point(183, 31);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(207, 24);
            this.lblPhong.TabIndex = 23;
            this.lblPhong.Text = "DANH MỤC PHÒNG";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(315, 105);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(315, 147);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(315, 191);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(413, 105);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(413, 147);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 18;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(413, 191);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 553);
            this.Controls.Add(this.grbTTChung);
            this.Controls.Add(this.grbTTChitiet);
            this.Controls.Add(this.lblPhong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThoat);
            this.Name = "frmPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng";
            this.Load += new System.EventHandler(this.frmPhong_Load);
            this.grbTTChung.ResumeLayout(false);
            this.grbTTChitiet.ResumeLayout(false);
            this.grbTTChitiet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTTChung;
        private System.Windows.Forms.ListView lsvPhong;
        private System.Windows.Forms.ColumnHeader columnHeaderMaPhong;
        private System.Windows.Forms.ColumnHeader columnHeaderLoaiPhong;
        private System.Windows.Forms.ColumnHeader columnHeaderGiaPhong;
        private System.Windows.Forms.GroupBox grbTTChitiet;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.Label lblGiaPhong;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.ColumnHeader columnHeaderTenPhong;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.ColumnHeader columnHeaderTinhTrang;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label label1;
    }
}