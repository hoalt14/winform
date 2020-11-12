using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmPhieuThue : Form
    {
        public bool themmoi = false;
        PhieuThue pt = new PhieuThue();
        public frmPhieuThue()
        {
            InitializeComponent();
        }
        void HienthiPhieuThue()
        {
            lsvPhieuThue.Items.Clear();
            DataTable dt = pt.LayDSPhieuThue();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvPhieuThue.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
            }
        }
        void SetNull()
        {
            txtTenPT.Text = "";
        }
        void SetButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnThoat.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
            btnInPT.Enabled = val;
            btnXuatPT.Enabled = val;
            btnTaiPT.Enabled = val;
        }
        void HienthiKhachHang()
        {
            cboTenKH.Items.Clear();
            DataTable dt = pt.LayDSKhachHang();
            cboTenKH.DataSource = dt;
            cboTenKH.DisplayMember = "HoTenKhachHang";
            cboTenKH.ValueMember = "MaKhachHang";
        }
        void HienthiPhong()
        {
            cboPhong.Items.Clear();
            DataTable dtp = pt.LayDSPhong();
            cboPhong.DataSource = dtp;
            cboPhong.DisplayMember = "TenPhong";
            cboPhong.ValueMember = "MaPhong";
        }
        private void frmPhieuThue_Load(object sender, EventArgs e)
        {
            SetNull();
            SetButton(true);
            HienthiPhieuThue();
            HienthiKhachHang();
            HienthiPhong();

        }
        private void lsvPhieuThue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvPhieuThue.SelectedIndices.Count > 0)
            {
                txtTenPT.Text = lsvPhieuThue.SelectedItems[0].SubItems[1].Text;
                dtpNgayThue.Value = DateTime.Parse(lsvPhieuThue.SelectedItems[0].SubItems[2].Text);
                dtpNgayTra.Value = DateTime.Parse(lsvPhieuThue.SelectedItems[0].SubItems[3].Text);
                cboTenKH.SelectedIndex = cboTenKH.FindString(lsvPhieuThue.SelectedItems[0].SubItems[4].Text);
                cboPhong.SelectedIndex = cboPhong.FindString(lsvPhieuThue.SelectedItems[0].SubItems[5].Text);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            SetButton(false);
            txtTenPT.Focus();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvPhieuThue.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Xóa phiếu thuê", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    pt.XoaPhieuThue(lsvPhieuThue.SelectedItems[0].SubItems[0].Text);
                    lsvPhieuThue.Items.RemoveAt(lsvPhieuThue.SelectedIndices[0]);
                    SetNull();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvPhieuThue.SelectedIndices.Count > 0)
            {
                themmoi = false;
                SetButton(false);
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật", "Sửa mẫu tin");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ngaythue = String.Format("{0:MM/dd/yyyy}", dtpNgayThue.Value);
            string ngaytra = String.Format("{0:MM/dd/yyyy}", dtpNgayTra.Value);
            if (themmoi)
            {
                pt.ThemPhieuThue(txtTenPT.Text, ngaythue, ngaytra, cboTenKH.SelectedValue.ToString(), cboPhong.SelectedValue.ToString());
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                pt.CapNhatPhieuThue(lsvPhieuThue.SelectedItems[0].SubItems[0].Text, txtTenPT.Text, ngaythue, ngaytra, cboTenKH.SelectedValue.ToString(), cboPhong.SelectedValue.ToString());
            }
            HienthiPhieuThue();
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

        private void btnInPT_Click(object sender, EventArgs e)
        {
            if (txtTenPT.Text == "")
            {
                MessageBox.Show("Chưa nhập tên phiếu thuê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                listBoxPhieuThue.Items.Add(txtTenPT.Text + " / " + cboTenKH.Text + " / " + cboPhong.Text + " / " + dtpNgayThue.Text + " / " + dtpNgayTra.Text);
            }
        }

        private void btnXuatPT_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("C:/Users/boi/Desktop/test/log.txt", FileMode.Create);
            StreamWriter wr = new StreamWriter(fs, Encoding.UTF8);
            foreach (string xuatpt in listBoxPhieuThue.Items)
            {
                wr.WriteLine(xuatpt);
            }
            wr.Flush();
            fs.Close();
        }

        private void btnTaiPT_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("C:/Users/boi/Desktop/test/log.txt", FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            string taipt = rd.ReadToEnd();
            listBoxPhieuThue.Items.Add(taipt);
            rd.Close();
        }
    }
}
