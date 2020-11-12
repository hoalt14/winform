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
    public partial class frmQLKS : Form
    {
        public frmQLKS()
        {
            InitializeComponent();
        }
        private void frmQLKS_Load(object sender, EventArgs e)
        {
            About about = new About();
            about.MdiParent = this;
            about.Show();
        }
        private void NhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "frmNhanVien")
                {
                    f.Activate();
                    return;
                }
            frmNhanVien nv = new frmNhanVien();
            nv.MdiParent = this;
            nv.Show();
        }

        private void KhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "frmKhachHang")
                {
                    f.Activate();
                    return;
                }
            frmKhachHang kh = new frmKhachHang();
            kh.MdiParent = this;
            kh.Show();
        }

        private void DichVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "frmDichVu")
                {
                    f.Activate();
                    return;
                }
            frmDichVu dv = new frmDichVu();
            dv.MdiParent = this;
            dv.Show();
        }

        private void PhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "frmPhong")
                {
                    f.Activate();
                    return;
                }
            frmPhong p = new frmPhong();
            p.MdiParent = this;
            p.Show();
        }
        private void toolStripButtonPhieuThue_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "frmPhieuThue")
                {
                    f.Activate();
                    return;
                }
            frmPhieuThue pt = new frmPhieuThue();
            pt.MdiParent = this;
            pt.Show();
        }
        private void toolStripButtonHoaDon_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "frmHoaDon")
                {
                    f.Activate();
                    return;
                }
            frmHoaDon hd = new frmHoaDon();
            hd.MdiParent = this;
            hd.Show();
        }
        private void toolStripButtonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
