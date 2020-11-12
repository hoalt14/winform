using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class DichVu
    {
        Database db;
        public DichVu()
        {
            db = new Database();
        }
        public DataTable LayDSDichVu()
        {
            string strSQL = "Select * from DICHVU";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public void XoaDichVu(string index_dv)
        {
            string sql = "Delete from DICHVU where MaDichVu = " + index_dv;
            db.ExecuteNonQuery(sql);
        }
        public void ThemDichVu(string ten, string gia)
        {
            string sql = string.Format("Insert into DICHVU values(N'{0}',{1})", ten, gia);
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatDichVu(string index_dv, string ten, string gia)
        {
            string str = string.Format("Update DICHVU set TenDichVu = N'{0}', GiaDichVu = '{1}' where MaDichVu = {2}", ten, gia, index_dv);
            db.ExecuteNonQuery(str);
        }
    }
}
