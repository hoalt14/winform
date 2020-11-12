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

namespace QuanLyKhachSan
{
    public partial class frmNhanVien : Form
    {
        public bool themmoi = false;
        NhanVien nv = new NhanVien();
        public frmNhanVien()
        {
            InitializeComponent();
        }
        void HienthiNhanvien()
        {
            lsvNhanVien.Items.Clear();
            DataTable dt = nv.LayDSNhanVien();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvNhanVien.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
            }
        }
        void SetNull()
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
        }
        void SetButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnThoat.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
        }
        void HienthiChucvu()
        {
            DataTable dt = nv.LayChucVu();
            cboChucVu.DataSource = dt;
            cboChucVu.DisplayMember = "TenChucVu";
            cboChucVu.ValueMember = "MaChucVu";
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            SetNull();
            SetButton(true);
            HienthiNhanvien();
            HienthiChucvu();
        }
        private void lsvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedIndices.Count > 0)
            {
                txtHoTen.Text = lsvNhanVien.SelectedItems[0].SubItems[1].Text;
                dtpNgaySinh.Value = DateTime.Parse(lsvNhanVien.SelectedItems[0].SubItems[2].Text);
                txtDiaChi.Text = lsvNhanVien.SelectedItems[0].SubItems[3].Text;
                txtDienThoai.Text = lsvNhanVien.SelectedItems[0].SubItems[4].Text;
                cboChucVu.SelectedIndex = cboChucVu.FindString(lsvNhanVien.SelectedItems[0].SubItems[5].Text);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            SetButton(false);
            txtHoTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    nv.XoaNhanVien(lsvNhanVien.SelectedItems[0].SubItems[0].Text);
                    lsvNhanVien.Items.RemoveAt(lsvNhanVien.SelectedIndices[0]);
                    SetNull();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedIndices.Count > 0)
            {
                themmoi = false;
                SetButton(false);
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật", "Sửa mẫu tin");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ngay = String.Format("{0:MM/dd/yyyy}", dtpNgaySinh.Value);
            if (themmoi)
            {
                nv.ThemNhanVien(txtHoTen.Text, ngay, txtDiaChi.Text, txtDienThoai.Text, cboChucVu.SelectedValue.ToString());
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                nv.CapNhatNhanVien(lsvNhanVien.SelectedItems[0].SubItems[0].Text, txtHoTen.Text, ngay, txtDiaChi.Text, txtDienThoai.Text, cboChucVu.SelectedValue.ToString());
            }
            HienthiNhanvien();
            SetNull();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetButton(true);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
