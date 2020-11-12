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
    public partial class frmXemDiem : Form
    {
        public frmXemDiem()
        {
            InitializeComponent();
        }

        private void frmXemDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.studentDataSet.Khoa);
            // TODO: This line of code loads data into the 'studentDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.studentDataSet.SinhVien);

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string conn = global::QuanLySinhVien.Properties.Settings.Default.StudentConnectionString;
            string str;
            str = string.Format("SELECT TenMH, Diem FROM KetQua, Mon WHERE [KetQua].MaMH = [Mon].MaMH AND MaSo = {0}", comboBoxMSSV.Text);
            SqlDataAdapter da = new SqlDataAdapter(str, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewXemDiem.DataSource = ds.Tables[0];
        }
    }
}