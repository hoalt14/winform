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
    public partial class frmHoaDon : Form
    {
        public bool themmoi = false;
        HoaDon hd = new HoaDon();
        public frmHoaDon()
        {
            InitializeComponent();
        }
        void HienthiHoaDon()
        {
            lsvHoaDon.Items.Clear();
            DataTable dt = hd.LayDSHoaDon();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvHoaDon.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][7].ToString());
                lvi.SubItems.Add(dt.Rows[i][8].ToString());
                lvi.SubItems.Add(dt.Rows[i][9].ToString());
            }
        }
        void SetNull()
        {
            txtTenHD.Text = "";
            txtGiaDV.Text = "";
            txtGiaPhong.Text = "";
            txtSoLuongDV.Text = "";
            txtSoNgayThue.Text = "";
            txtTongTien.Text = "";
        }
        void SetButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnThoat.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
            btnThanhTien.Enabled = val;
            btnXuatHD.Enabled = val;
        }
        void HienthiPhieuThue()
        {
            cboTenPT.Items.Clear();
            DataTable dt = hd.LayDSPhieuThue();
            cboTenPT.DataSource = dt;
            cboTenPT.DisplayMember = "TenPhieuThue";
            cboTenPT.ValueMember = "MaPhieuThue";
        }
        void HienthiNhanVien()
        {
            cboTenNV.Items.Clear();
            DataTable dt = hd.LayDSNhanVien();
            cboTenNV.DataSource = dt;
            cboTenNV.DisplayMember = "HoTenNhanVien";
            cboTenNV.ValueMember = "MaNhanVien";
        }
        void HienthiKhachHang()
        {
            cboTenKH.Items.Clear();
            DataTable dt = hd.LayDSKhachHang();
            cboTenKH.DataSource = dt;
            cboTenKH.DisplayMember = "HoTenKhachHang";
            cboTenKH.ValueMember = "MaKhachHang";
        }
        void HienthiDichVu()
        {
            cboTenDV.Items.Clear();
            DataTable dt = hd.LayDSDichVu();
            cboTenDV.DataSource = dt;
            cboTenDV.DisplayMember = "TenDichVu";
            cboTenDV.ValueMember = "MaDichVu";
        }
        void HienthiPhong()
        {
            cboTenPhong.Items.Clear();
            DataTable dtp = hd.LayDSPhong();
            cboTenPhong.DataSource = dtp;
            cboTenPhong.DisplayMember = "TenPhong";
            cboTenPhong.ValueMember = "MaPhong";
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            SetNull();
            SetButton(true);
            HienthiHoaDon();
            HienthiPhieuThue();
            HienthiNhanVien();
            HienthiKhachHang();
            HienthiDichVu();
            HienthiPhong();
        }
        private void lsvHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvHoaDon.SelectedIndices.Count > 0)
            {
                txtTenHD.Text = lsvHoaDon.SelectedItems[0].SubItems[1].Text;
                cboTenPT.SelectedIndex = cboTenPT.FindString(lsvHoaDon.SelectedItems[0].SubItems[2].Text);
                dtpNgayLapHD.Value = DateTime.Parse(lsvHoaDon.SelectedItems[0].SubItems[3].Text);
                cboTenNV.SelectedIndex = cboTenNV.FindString(lsvHoaDon.SelectedItems[0].SubItems[4].Text);
                cboTenKH.SelectedIndex = cboTenKH.FindString(lsvHoaDon.SelectedItems[0].SubItems[5].Text);
                cboTenDV.SelectedIndex = cboTenDV.FindString(lsvHoaDon.SelectedItems[0].SubItems[6].Text);
                txtGiaDV.Text = lsvHoaDon.SelectedItems[0].SubItems[7].Text;
                cboTenPhong.SelectedIndex = cboTenPhong.FindString(lsvHoaDon.SelectedItems[0].SubItems[8].Text);
                txtGiaPhong.Text = lsvHoaDon.SelectedItems[0].SubItems[9].Text;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            SetButton(false);
            txtTenHD.Focus();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvHoaDon.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Xóa hóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    hd.XoaHoaDon(lsvHoaDon.SelectedItems[0].SubItems[0].Text);
                    lsvHoaDon.Items.RemoveAt(lsvHoaDon.SelectedIndices[0]);
                    SetNull();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvHoaDon.SelectedIndices.Count > 0)
            {
                themmoi = false;
                SetButton(false);
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật", "Sửa mẫu tin");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ngaylaphd = String.Format("{0:MM/dd/yyyy}", dtpNgayLapHD.Value);
            if (themmoi)
            {
                hd.ThemHoaDon(txtTenHD.Text, ngaylaphd, cboTenDV.SelectedValue.ToString(), cboTenPT.SelectedValue.ToString(), cboTenNV.SelectedValue.ToString());
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                hd.CapNhatHoaDon(lsvHoaDon.SelectedItems[0].SubItems[0].Text, txtTenHD.Text, ngaylaphd, cboTenDV.SelectedValue.ToString(), cboTenPT.SelectedValue.ToString(), cboTenNV.SelectedValue.ToString());
            }
            HienthiHoaDon();
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

        private void btnThanhTien_Click(object sender, EventArgs e)
        {
            if (txtSoLuongDV.Text == "" || txtSoNgayThue.Text == "")
            {
                MessageBox.Show("Cần nhập đầy đủ số lượng dịch vụ và số ngày thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float a = float.Parse(txtGiaDV.Text);
                float b = float.Parse(txtGiaPhong.Text);
                float n = float.Parse(txtSoLuongDV.Text);
                float m = float.Parse(txtSoNgayThue.Text);
                float ketqua = a * n + b * m;
                txtTongTien.Text = ketqua.ToString();
            }
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream("C:/Users/boi/Desktop/test/log.txt", FileMode.Create);
            //StreamWriter wr = new StreamWriter(fs, Encoding.UTF8);
            //foreach (string xuathd in listBoxHoaDon.Items)
            //{
            //    wr.WriteLine(xuathd);
            //}
            //wr.Flush();
            //fs.Close();
        }
    }
}
