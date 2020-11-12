using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmQLTV : Form
    {
        public frmQLTV()
        {
            InitializeComponent();
        }

        private void toolStripButton_NhanVien_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "frmNhanVien")
                {
                    f.Activate();
                    return;
                }
            frmNhanVien sv = new frmNhanVien();
            sv.MdiParent = this;
            sv.Show();
        }
    }
}
