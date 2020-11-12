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
    public partial class frmDangNhap : Form
    {
        TaiKhoan tk = new TaiKhoan();
        public frmDangNhap()
        {
            InitializeComponent();
        }
        
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn hủy bỏ?", "Xác nhân", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTaiKhoan.Text.Trim();
            string matkhau = txtMatKhau.Text.Trim();
            string err = string.Empty;
            if (taikhoan == string.Empty)
                err = "Bạn vui lòng nhập tên đăng nhập";
            if (matkhau == string.Empty)
                err += "\n Bạn chưa nhập mật khẩu";
            if (err != string.Empty)
            {
                MessageBox.Show("Lỗi: " + err);
                return;
            }
            if(taikhoan == "admin" && matkhau == "admin")
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                txtTaiKhoan.Clear();
                txtMatKhau.Clear();
            }
        }
    }
}
