using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class Phong
    {
        Database db;
        public Phong()
        {
            db = new Database();
        }
        public DataTable LayDSPhong()
        {
            string strSQL = "Select MaPhong, TenPhong, TenLoaiPhong, GiaPhong, TinhTrang from PHONG P, LOAIPHONG LP where P.MaLoaiPhong = LP.MaLoaiPhong";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable LayLoaiPhong()
        {
            string strSQL = "Select MaLoaiPhong, TenLoaiPhong from LOAIPHONG";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public void XoaPhong(string index_p)
        {
            string sql = "Delete from PHONG where MaPhong = " + index_p;
            db.ExecuteNonQuery(sql);
        }
        public void ThemPhong(string ten, string loai, string gia, string tinhtrang)
        {
            string sql = string.Format("Insert into PHONG values(N'{0}','{1}',{2},N'{3}')", ten, loai, gia, tinhtrang);
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatPhong(string index_p, string ten, string loai, string gia, string tinhtrang)
        {
            string str = string.Format("Update PHONG set TenPhong = N'{0}', MaLoaiPhong = '{1}', GiaPhong = '{2}', TinhTrang = N'{3}' where MaPhong = {4}", ten, loai, gia, tinhtrang, index_p);
            db.ExecuteNonQuery(str);
        }
    }
}
