using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class HoaDon
    {
        Database db;
        public HoaDon()
        {
            db = new Database();
        }
        public DataTable LayDSHoaDon()
        {
            string strSQL = "Select MaHoaDon, TenHoaDon, TenPhieuThue, NgayLap, HoTenNhanVien, HoTenKhachHang, TenDichVu, GiaDichVu, TenPhong, GiaPhong from HOADON HD, DICHVU DV, PHIEUTHUE PT, NHANVIEN NV, KHACHHANG KH, PHONG P where HD.MaDichVu = DV.MaDichVu and HD.MaPhieuThue = PT.MaPhieuThue and HD.MaNhanVien = NV.MaNhanVien and PT.MaKhachHang = KH.MaKhachHang and PT.MaPhong = P.MaPhong";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable LayDSPhieuThue()
        {
            string strSQL = "Select MaPhieuThue, TenPhieuThue from PHIEUTHUE";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable LayDSNhanVien()
        {
            string strSQL = "Select MaNhanVien, HoTenNhanVien from NHANVIEN";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable LayDSKhachHang()
        {
            string strSQL = "Select MaKhachHang, HoTenKhachHang from KHACHHANG";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable LayDSDichVu()
        {
            string strSQL = "Select MaDichVu, TenDichVu from DICHVU";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable LayDSPhong()
        {
            string strSQL = "Select MaPhong, TenPhong from PHONG";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public void XoaHoaDon(string index_hd)
        {
            string sql = "Delete from HOADON where MaHoaDon = " + index_hd;
            db.ExecuteNonQuery(sql);
        }
        public void ThemHoaDon(string tenhd, string ngaylaphd, string index_dv, string index_pt, string index_nv)
        {
            string sql = string.Format("Insert into HOADON values(N'{0}','{1}',{2},{3},{4})", tenhd, ngaylaphd, index_dv, index_pt, index_nv);
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatHoaDon(string index_hd, string tenhd, string ngaylaphd, string index_dv, string index_pt, string index_nv)
        {
            string str = string.Format("Update HOADON set TenHoaDon = N'{0}', NgayLap = '{1}', MaDichVu = '{2}', MaPhieuThue = '{3}', MaNhanVien = '{4}' where MaHoaDon = {5}", tenhd, ngaylaphd, index_dv, index_pt, index_nv, index_hd);
            db.ExecuteNonQuery(str);
        }
    }
}
