using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSon.Text = "";
            txtSom.Text = "";
            txtKetqua.Text = "";
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if(txtSon.Text == "" || txtSom.Text == "")
            {
                MessageBox.Show("Cần nhập đầy đủ số n và m", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int n = int.Parse(txtSon.Text);
                int m = int.Parse(txtSom.Text);
                int Tong = n + m;
                txtKetqua.Text = Tong.ToString();
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (txtSon.Text == "" || txtSom.Text == "")
            {
                MessageBox.Show("Cần nhập đầy đủ số n và m", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int n = int.Parse(txtSon.Text);
                int m = int.Parse(txtSom.Text);
                int Hieu = n - m;
                txtKetqua.Text = Hieu.ToString();
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (txtSon.Text == "" || txtSom.Text == "")
            {
                MessageBox.Show("Cần nhập đầy đủ số n và m", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int n = int.Parse(txtSon.Text);
                int m = int.Parse(txtSom.Text);
                int Nhan = n * m;
                txtKetqua.Text = Nhan.ToString();
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (txtSon.Text == "" || txtSom.Text == "")
            {
                MessageBox.Show("Cần nhập đầy đủ số n và m", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float n = float.Parse(txtSon.Text);
                float m = float.Parse(txtSom.Text);
                float Chia = n / m;
                txtKetqua.Text = Chia.ToString();
            }
        }
    }
}
