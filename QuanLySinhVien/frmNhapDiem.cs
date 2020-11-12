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
    public partial class frmNhapDiem : Form
    {
        public frmNhapDiem()
        {
            InitializeComponent();
        }
        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet.Mon' table. You can move, or remove it, as needed.
            this.monTableAdapter.Fill(this.studentDataSet.Mon);
            // TODO: This line of code loads data into the 'studentDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.studentDataSet.SinhVien);

        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            string conn = global::QuanLySinhVien.Properties.Settings.Default.StudentConnectionString;
            string str;
            str = string.Format("INSERT INTO KetQua VALUES (" + comboBoxMSSV.Text + ", '" + comboBoxMaMH.Text + "', " + textBoxDiem.Text + ")");
            SqlDataAdapter da = new SqlDataAdapter(str, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("Đã nhập dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
