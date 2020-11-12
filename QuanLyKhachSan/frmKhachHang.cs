using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmKhachHang : Form
    {
        public bool themmoi = false;
        KhachHang kh = new KhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
        }
        void HienthiKhachHang()
        {
            lsvKhachHang.Items.Clear();
            DataTable dt = kh.LayDSKhachHang();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvKhachHang.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
            }
        }
        void SetNull()
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtSoCMND.Text = "";
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
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            SetNull();
            SetButton(true);
            HienthiKhachHang();
        }
        private void lsvKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvKhachHang.SelectedIndices.Count > 0)
            {
                txtHoTen.Text = lsvKhachHang.SelectedItems[0].SubItems[1].Text;
                txtDiaChi.Text = lsvKhachHang.SelectedItems[0].SubItems[2].Text;
                txtDienThoai.Text = lsvKhachHang.SelectedItems[0].SubItems[3].Text;
                txtSoCMND.Text = lsvKhachHang.SelectedItems[0].SubItems[4].Text;
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
            if (lsvKhachHang.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Xóa khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    kh.XoaKhachHang(lsvKhachHang.SelectedItems[0].SubItems[0].Text);
                    lsvKhachHang.Items.RemoveAt(lsvKhachHang.SelectedIndices[0]);
                    SetNull();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvKhachHang.SelectedIndices.Count > 0)
            {
                themmoi = false;
                SetButton(false);
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật", "Sửa mẫu tin");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (themmoi)
            {
                kh.ThemKhachHang(txtHoTen.Text, txtDiaChi.Text, txtDienThoai.Text, txtSoCMND.Text);
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                kh.CapNhatKhachHang(lsvKhachHang.SelectedItems[0].SubItems[0].Text, txtHoTen.Text, txtDiaChi.Text, txtDienThoai.Text, txtSoCMND.Text);
            }
            HienthiKhachHang();
            SetNull();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetButton(true);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
