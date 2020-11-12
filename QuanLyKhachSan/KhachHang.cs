using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class KhachHang
    {
        Database db;
        public KhachHang()
        {
            db = new Database();
        }
        public DataTable LayDSKhachHang()
        {
            string strSQL = "Select * from KHACHHANG";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public void XoaKhachHang(string index_kh)
        {
            string sql = "Delete from KHACHHANG where MaKhachHang = " + index_kh;
            db.ExecuteNonQuery(sql);
        }
        public void ThemKhachHang(string hoten, string diachi, string dienthoai, string cmnd)
        {
            string sql = string.Format("Insert into KHACHHANG values(N'{0}',N'{1}','{2}','{3}')", hoten, diachi, dienthoai, cmnd);
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatKhachHang(string index_kh, string hoten, string diachi, string dienthoai, string cmnd)
        {
            string str = string.Format("Update KHACHHANG set HoTenKhachHang = N'{0}', DiaChiKH = N'{1}', DienThoaiKH = '{2}', SoCMND = '{3}' where MaKhachHang = {4}", hoten, diachi, dienthoai, cmnd, index_kh);
            db.ExecuteNonQuery(str);
        }
    }
}
