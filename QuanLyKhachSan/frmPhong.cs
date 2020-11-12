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
    public partial class frmPhong : Form
    {
        public bool themmoi = false;
        Phong p = new Phong();
        public frmPhong()
        {
            InitializeComponent();
        }
        void HienthiPhong()
        {
            lsvPhong.Items.Clear();
            DataTable dt = p.LayDSPhong();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvPhong.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
            }
        }
        void SetNull()
        {
            txtTenPhong.Text = "";
            txtGiaPhong.Text = "";
            txtTinhTrang.Text = "";
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
        void HienthiLoaiPhong()
        {
            DataTable dt = p.LayLoaiPhong();
            cboLoaiPhong.DataSource = dt;
            cboLoaiPhong.DisplayMember = "TenLoaiPhong";
            cboLoaiPhong.ValueMember = "MaLoaiPhong";
        }
        private void frmPhong_Load(object sender, EventArgs e)
        {
            SetNull();
            SetButton(true);
            HienthiPhong();
            HienthiLoaiPhong();
        }
        private void lsvPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvPhong.SelectedIndices.Count > 0)
            {
                txtTenPhong.Text = lsvPhong.SelectedItems[0].SubItems[1].Text;
                cboLoaiPhong.SelectedIndex = cboLoaiPhong.FindString(lsvPhong.SelectedItems[0].SubItems[2].Text);
                txtGiaPhong.Text = lsvPhong.SelectedItems[0].SubItems[3].Text;
                txtTinhTrang.Text = lsvPhong.SelectedItems[0].SubItems[4].Text;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            SetButton(false);
            txtTenPhong.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvPhong.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Xóa phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    p.XoaPhong(lsvPhong.SelectedItems[0].SubItems[0].Text);
                    lsvPhong.Items.RemoveAt(lsvPhong.SelectedIndices[0]);
                    SetNull();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvPhong.SelectedIndices.Count > 0)
            {
                themmoi = false;
                SetButton(false);
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật", "Sửa mẫu tin");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //float gia = (float)double.Parse(txtGiaDV.Text);
            string gia = String.Format("{0: #.### 'vnd'}", txtGiaPhong.Text);
            if (themmoi)
            {
                p.ThemPhong(txtTenPhong.Text, cboLoaiPhong.SelectedValue.ToString(), gia, txtTinhTrang.Text);
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                p.CapNhatPhong(lsvPhong.SelectedItems[0].SubItems[0].Text, txtTenPhong.Text, cboLoaiPhong.SelectedValue.ToString(), gia, txtTinhTrang.Text);
            }
            HienthiPhong();
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