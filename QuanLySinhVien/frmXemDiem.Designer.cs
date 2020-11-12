namespace QuanLySinhVien
{
    partial class frmXemDiem
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
            this.lblMSSV = new System.Windows.Forms.Label();
            this.comboBoxMSSV = new System.Windows.Forms.ComboBox();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet = new QuanLySinhVien.StudentDataSet();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.comboBoxTenSV = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.dataGridViewXemDiem = new System.Windows.Forms.DataGridView();
            this.sinhVienTableAdapter = new QuanLySinhVien.StudentDataSetTableAdapters.SinhVienTableAdapter();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaTableAdapter = new QuanLySinhVien.StudentDataSetTableAdapters.KhoaTableAdapter();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(35, 61);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(56, 13);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "Mã số SV:";
            // 
            // comboBoxMSSV
            // 
            this.comboBoxMSSV.DataSource = this.sinhVienBindingSource;
            this.comboBoxMSSV.DisplayMember = "MaSo";
            this.comboBoxMSSV.FormattingEnabled = true;
            this.comboBoxMSSV.Location = new System.Drawing.Point(97, 58);
            this.comboBoxMSSV.Name = "comboBoxMSSV";
            this.comboBoxMSSV.Size = new System.Drawing.Size(143, 21);
            this.comboBoxMSSV.TabIndex = 1;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.studentDataSet;
            // 
            // studentDataSet
            // 
            this.studentDataSet.DataSetName = "StudentDataSet";
            this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Location = new System.Drawing.Point(35, 98);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(42, 13);
            this.lblTenSV.TabIndex = 2;
            this.lblTenSV.Text = "Họ tên:";
            // 
            // comboBoxTenSV
            // 
            this.comboBoxTenSV.DataSource = this.sinhVienBindingSource;
            this.comboBoxTenSV.DisplayMember = "HoTen";
            this.comboBoxTenSV.FormattingEnabled = true;
            this.comboBoxTenSV.Location = new System.Drawing.Point(97, 95);
            this.comboBoxTenSV.Name = "comboBoxTenSV";
            this.comboBoxTenSV.Size = new System.Drawing.Size(143, 21);
            this.comboBoxTenSV.TabIndex = 3;
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(35, 136);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(35, 13);
            this.lblKhoa.TabIndex = 4;
            this.lblKhoa.Text = "Khoa:";
            // 
            // txtKhoa
            // 
            this.txtKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "MaKhoa", true));
            this.txtKhoa.Location = new System.Drawing.Point(97, 133);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(143, 20);
            this.txtKhoa.TabIndex = 5;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(108, 186);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 6;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dataGridViewXemDiem
            // 
            this.dataGridViewXemDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXemDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMH,
            this.Diem});
            this.dataGridViewXemDiem.Location = new System.Drawing.Point(266, 58);
            this.dataGridViewXemDiem.Name = "dataGridViewXemDiem";
            this.dataGridViewXemDiem.Size = new System.Drawing.Size(243, 150);
            this.dataGridViewXemDiem.TabIndex = 7;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
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
            // TenMH
            // 
            this.TenMH.DataPropertyName = "TenMH";
            this.TenMH.HeaderText = "Tên MH";
            this.TenMH.Name = "TenMH";
            this.TenMH.Width = 120;
            // 
            // Diem
            // 
            this.Diem.DataPropertyName = "Diem";
            this.Diem.HeaderText = "Điểm";
            this.Diem.Name = "Diem";
            this.Diem.Width = 80;
            // 
            // frmXemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 259);
            this.Controls.Add(this.dataGridViewXemDiem);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.txtKhoa);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.comboBoxTenSV);
            this.Controls.Add(this.lblTenSV);
            this.Controls.Add(this.comboBoxMSSV);
            this.Controls.Add(this.lblMSSV);
            this.Name = "frmXemDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem Điểm";
            this.Load += new System.EventHandler(this.frmXemDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.ComboBox comboBoxMSSV;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.ComboBox comboBoxTenSV;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DataGridView dataGridViewXemDiem;
        private StudentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private StudentDataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private StudentDataSetTableAdapters.KhoaTableAdapter khoaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem;
    }
}