using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    
    class TaiKhoan
    {
        Database db;
        public TaiKhoan()
        {
            db = new Database();
        }
        public void KiemTraTaiKhoan()
        {
            string sql = "Select * from TAIKHOAN";
            db.ExecuteGetReader(sql);
        }
    }
}
