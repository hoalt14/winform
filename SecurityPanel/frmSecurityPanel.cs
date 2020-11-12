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

namespace SecurityPanel
{
    public partial class frmSecurityPanel : Form
    {
        public frmSecurityPanel()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text = "";
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtSecurityCode.Text += btn.Text;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string data = txtSecurityCode.Text.ToString();
            switch (data)
            {
                case "1645":
                case "1689":
                    lbxAccessLog.Items.Add(DateTime.Now.ToString() + "\tTechnicians");
                    break;
                case "8345":
                    lbxAccessLog.Items.Add(DateTime.Now.ToString() + "\tCustodians");
                    break;
                case "9998":
                case "1006":
                case "1008":
                    lbxAccessLog.Items.Add(DateTime.Now.ToString() + "\tScientist");
                    break;
                default:
                    lbxAccessLog.Items.Add(DateTime.Now.ToString() + "\tRestricted Access");
                    break;
            }
            txtSecurityCode.Text = "";
        }

        private void btnSaveLog_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("C:/Users/boi/Desktop/test/log.txt", FileMode.Open);
            StreamWriter wr = new StreamWriter(fs, Encoding.UTF8);
            foreach(string n in lbxAccessLog.Items)
            {
                wr.WriteLine(n);
            }
            wr.Flush();
            fs.Close();
        }
        private void txtSecurityCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}