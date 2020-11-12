using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void khoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataSet);

        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet.KetQua' table. You can move, or remove it, as needed.
            this.ketQuaTableAdapter.Fill(this.studentDataSet.KetQua);
            // TODO: This line of code loads data into the 'studentDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.studentDataSet.SinhVien);
            // TODO: This line of code loads data into the 'studentDataSet.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.studentDataSet.Khoa);

        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            string conn = global::QuanLySinhVien.Properties.Settings.Default.StudentConnectionString;
            string str;
            str = string.Format("SELECT MaSo, HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai FROM SinhVien WHERE MaKhoa = '" + comboBoxMaKhoa.Text + "'");
            SqlDataAdapter da = new SqlDataAdapter(str, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewThongKe.DataSource = ds.Tables[0];
        }
    }
}
