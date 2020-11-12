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
    public partial class frmDichVu : Form
    {
        public bool themmoi = false;
        DichVu dv = new DichVu();
        public frmDichVu()
        {
            InitializeComponent();
        }
        void HienthiDichvu()
        {
            lsvDichVu.Items.Clear();
            DataTable dt = dv.LayDSDichVu();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvDichVu.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
            }
        }
        void SetNull()
        {
            txtTenDV.Text = "";
            txtGiaDV.Text = "";
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
        private void frmDichVu_Load(object sender, EventArgs e)
        {
            SetNull();
            SetButton(true);
            HienthiDichvu();
        }
        private void lsvDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDichVu.SelectedIndices.Count > 0)
            {
                txtTenDV.Text = lsvDichVu.SelectedItems[0].SubItems[1].Text;
                txtGiaDV.Text = lsvDichVu.SelectedItems[0].SubItems[2].Text;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            SetButton(false);
            txtTenDV.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvDichVu.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Xóa dịch vụ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    dv.XoaDichVu(lsvDichVu.SelectedItems[0].SubItems[0].Text);
                    lsvDichVu.Items.RemoveAt(lsvDichVu.SelectedIndices[0]);
                    SetNull();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvDichVu.SelectedIndices.Count > 0)
            {
                themmoi = false;
                SetButton(false);
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật", "Sửa mẫu tin");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string gia = String.Format("{0: #.### 'vnd'}", txtGiaDV.Text);
            if (themmoi)
            {
                dv.ThemDichVu(txtTenDV.Text, gia);
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                dv.CapNhatDichVu(lsvDichVu.SelectedItems[0].SubItems[0].Text, txtTenDV.Text, gia);
            }
            HienthiDichvu();
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
