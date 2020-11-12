namespace QuanLySinhVien
{
    partial class frmThongKe
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
            System.Windows.Forms.Label maKhoaLabel;
            System.Windows.Forms.Label tenKhoaLabel;
            this.studentDataSet = new QuanLySinhVien.StudentDataSet();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaTableAdapter = new QuanLySinhVien.StudentDataSetTableAdapters.KhoaTableAdapter();
            this.tableAdapterManager = new QuanLySinhVien.StudentDataSetTableAdapters.TableAdapterManager();
            this.ketQuaTableAdapter = new QuanLySinhVien.StudentDataSetTableAdapters.KetQuaTableAdapter();
            this.sinhVienTableAdapter = new QuanLySinhVien.StudentDataSetTableAdapters.SinhVienTableAdapter();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxMaKhoa = new System.Windows.Forms.ComboBox();
            this.comboBoxTenKhoa = new System.Windows.Forms.ComboBox();
            this.dataGridViewThongKe = new System.Windows.Forms.DataGridView();
            this.buttonXem = new System.Windows.Forms.Button();
            this.ketQuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MaSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maKhoaLabel = new System.Windows.Forms.Label();
            tenKhoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maKhoaLabel
            // 
            maKhoaLabel.AutoSize = true;
            maKhoaLabel.Location = new System.Drawing.Point(36, 47);
            maKhoaLabel.Name = "maKhoaLabel";
            maKhoaLabel.Size = new System.Drawing.Size(52, 13);
            maKhoaLabel.TabIndex = 1;
            maKhoaLabel.Text = "Mã khoa:";
            // 
            // tenKhoaLabel
            // 
            tenKhoaLabel.AutoSize = true;
            tenKhoaLabel.Location = new System.Drawing.Point(36, 78);
            tenKhoaLabel.Name = "tenKhoaLabel";
            tenKhoaLabel.Size = new System.Drawing.Size(56, 13);
            tenKhoaLabel.TabIndex = 3;
            tenKhoaLabel.Text = "Tên khoa:";
            // 
            // studentDataSet
            // 
            this.studentDataSet.DataSetName = "StudentDataSet";
            this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "Khoa";
            this.khoaBindingSource.DataSource = this.studentDataSet;
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KetQuaTableAdapter = this.ketQuaTableAdapter;
            this.tableAdapterManager.KhoaTableAdapter = this.khoaTableAdapter;
            this.tableAdapterManager.MonTableAdapter = null;
            this.tableAdapterManager.SinhVienTableAdapter = this.sinhVienTableAdapter;
            this.tableAdapterManager.UpdateOrder = QuanLySinhVien.StudentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ketQuaTableAdapter
            // 
            this.ketQuaTableAdapter.ClearBeforeFill = true;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.studentDataSet;
            // 
            // comboBoxMaKhoa
            // 
            this.comboBoxMaKhoa.DataSource = this.khoaBindingSource;
            this.comboBoxMaKhoa.DisplayMember = "MaKhoa";
            this.comboBoxMaKhoa.FormattingEnabled = true;
            this.comboBoxMaKhoa.Location = new System.Drawing.Point(105, 44);
            this.comboBoxMaKhoa.Name = "comboBoxMaKhoa";
            this.comboBoxMaKhoa.Size = new System.Drawing.Size(199, 21);
            this.comboBoxMaKhoa.TabIndex = 6;
            // 
            // comboBoxTenKhoa
            // 
            this.comboBoxTenKhoa.DataSource = this.khoaBindingSource;
            this.comboBoxTenKhoa.DisplayMember = "TenKhoa";
            this.comboBoxTenKhoa.FormattingEnabled = true;
            this.comboBoxTenKhoa.Location = new System.Drawing.Point(105, 75);
            this.comboBoxTenKhoa.Name = "comboBoxTenKhoa";
            this.comboBoxTenKhoa.Size = new System.Drawing.Size(199, 21);
            this.comboBoxTenKhoa.TabIndex = 7;
            // 
            // dataGridViewThongKe
            // 
            this.dataGridViewThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSo,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh,
            this.DiaChi,
            this.DienThoai});
            this.dataGridViewThongKe.Location = new System.Drawing.Point(12, 113);
            this.dataGridViewThongKe.Name = "dataGridViewThongKe";
            this.dataGridViewThongKe.Size = new System.Drawing.Size(653, 213);
            this.dataGridViewThongKe.TabIndex = 8;
            // 
            // buttonXem
            // 
            this.buttonXem.Location = new System.Drawing.Point(424, 58);
            this.buttonXem.Name = "buttonXem";
            this.buttonXem.Size = new System.Drawing.Size(75, 23);
            this.buttonXem.TabIndex = 9;
            this.buttonXem.Text = "Xem";
            this.buttonXem.UseVisualStyleBackColor = true;
            this.buttonXem.Click += new System.EventHandler(this.buttonXem_Click);
            // 
            // ketQuaBindingSource
            // 
            this.ketQuaBindingSource.DataMember = "KetQua";
            this.ketQuaBindingSource.DataSource = this.studentDataSet;
            // 
            // MaSo
            // 
            this.MaSo.DataPropertyName = "MaSo";
            this.MaSo.HeaderText = "Mã số SV";
            this.MaSo.Name = "MaSo";
            this.MaSo.Width = 90;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 120;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện thoại";
            this.DienThoai.Name = "DienThoai";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 359);
            this.Controls.Add(this.buttonXem);
            this.Controls.Add(this.dataGridViewThongKe);
            this.Controls.Add(this.comboBoxTenKhoa);
            this.Controls.Add(this.comboBoxMaKhoa);
            this.Controls.Add(tenKhoaLabel);
            this.Controls.Add(maKhoaLabel);
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê sinh viên theo Khoa";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private StudentDataSetTableAdapters.KhoaTableAdapter khoaTableAdapter;
        private StudentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private StudentDataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private System.Windows.Forms.ComboBox comboBoxMaKhoa;
        private System.Windows.Forms.ComboBox comboBoxTenKhoa;
        private System.Windows.Forms.DataGridView dataGridViewThongKe;
        private System.Windows.Forms.Button buttonXem;
        private StudentDataSetTableAdapters.KetQuaTableAdapter ketQuaTableAdapter;
        private System.Windows.Forms.BindingSource ketQuaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
    }
}