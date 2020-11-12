using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USCLN_BSCNN
{
    public partial class frmUocBoi : Form
    {
        public frmUocBoi()
        {
            InitializeComponent();
        }

        private void ckbBSCNN_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát hay không", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            Close();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            txtSoa.Text = "";
            txtSob.Text = "";
            txtKetqua.Text = "";
            ckbUSCLN.Checked = false;
            ckbBSCNN.Checked = false;
        }
        int USCLN(int a, int b)
        {
            while(a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }
        int BSCNN(int a, int b)
        {
            return (a * b) / USCLN(a, b);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int a = Math.Abs(int.Parse(txtSoa.Text));
            int b = Math.Abs(int.Parse(txtSob.Text));
            if(ckbUSCLN.Checked == true)
            {
                txtKetqua.Text = USCLN(a, b).ToString();
            }
            if(ckbBSCNN.Checked == true)
            {
                txtKetqua.Text = BSCNN(a, b).ToString();
            }
        }
    }
}
