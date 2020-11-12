using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DentalPaymentApp
{
    public partial class frmDentalPaymentApp : Form
    {
        public frmDentalPaymentApp()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                MessageBox.Show("Chưa nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                float sum = 0;

                if (chkClean.Checked)
                {
                    sum += 100000;
                }

                if (chkWhitening.Checked)
                {
                    sum += 1200000;
                }

                if (chkXRay.Checked)
                {
                    sum += 200000;
                }

                float count = Convert.ToInt32(nUPFilling.Value);
                sum += count * 80000;

                txtTotal.Text = "$" + sum.ToString();
                lbxLog.Items.Add(txtName.Text + " - " + txtTotal.Text);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("C:/Users/boi/Desktop/test/log.txt", FileMode.Create);
            StreamWriter wr = new StreamWriter(fs, Encoding.UTF8);
            foreach (string velo in lbxLog.Items)
            {
                wr.WriteLine(velo);
            }
            wr.Flush();
            fs.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("C:/Users/boi/Desktop/test/log.txt", FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            string velo = rd.ReadToEnd();
            lbxLog.Items.Add(velo);
            rd.Close();
        }
    }
}
