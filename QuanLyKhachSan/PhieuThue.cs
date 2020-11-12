using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class PhieuThue
    {
        Database db;
        public PhieuThue()
        {
            db = new Database();
        }
        public DataTable LayDSPhieuThue()
        {
            string strSQL = "Select MaPhieuThue, TenPhieuThue, NgayThue, NgayTra, HoTenKhachHang, TenPhong from PHIEUTHUE PT, PHONG P, KHACHHANG KH where PT.MaPhong = P.MaPhong and PT.MaKhachHang = KH.MaKhachHang";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable LayDSKhachHang()
        {
            string strSQL = "Select HoTenKhachHang, MaKhachHang from KHACHHANG";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable LayDSPhong()
        {
            string strSQL = "Select TenPhong, MaPhong from PHONG";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public void XoaPhieuThue(string index_pt)
        {
            string sql = "Delete from PHIEUTHUE where MaPhieuThue = " + index_pt;
            db.ExecuteNonQuery(sql);
        }
        public void ThemPhieuThue(string tenpt, string ngaythue, string ngaytra, string tenkh, string phong)
        {
            string sql = string.Format("Insert into PHIEUTHUE values(N'{0}','{1}','{2}',N'{3}',N'{4}')", tenpt, ngaythue, ngaytra, tenkh, phong);
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatPhieuThue(string index_pt, string tenpt, string ngaythue, string ngaytra, string tenkh, string phong)
        {
            string str = string.Format("Update PHIEUTHUE set TenPhieuThue = '{0}', NgayThue = '{1}', NgayTra = '{2}', MaKhachHang = '{3}', MaPhong = '{4}' where MaPhieuThue = {5}", tenpt, ngaythue, ngaytra, tenkh, phong, index_pt);
            db.ExecuteNonQuery(str);
        }
    }
}
