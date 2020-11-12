using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    class NhanVien
    {
        Database db;
        public NhanVien()
        {
            db = new Database();
        }
        public DataTable LayDSNhanVien()
        {
            string strSQL = "Select MaNhanVien, HoTenNhanVien, NgaySinh, DiaChi, DienThoai, TenBangCap from NHANVIEN N, BANGCAP B where N.MaBangCap = B.MaBangCap";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable LayBangCap()
        {
            string strSQL = "Select * from BANGCAP";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public void XoaNhanVien(string index_nv)
        {
            string sql = "Delete from NHANVIEN where MaNhanVien = " + index_nv;
            db.ExecuteNonQuery(sql);
        }
        public void ThemNhanVien(string ten, string ngaysinh, string diachi, string dienthoai, string index_bc)
        {
            string sql = string.Format("Insert into NHANVIEN values(N'{0}','{1}',N'{2}','{3}',{4})", ten, ngaysinh, diachi, dienthoai, index_bc);
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatNhanVien(string index_nv, string hoten, string ngaysinh, string diachi, string dienthoai, string index_bc)
        {
            string str = string.Format("Update NHANVIEN set HoTenNhanVien = N'{0}', NgaySinh = '{1}', DiaChi = N'{2}', DienThoai = '{3}', MaBangCap = {4} where MaNhanVien = {5}", hoten, ngaysinh, diachi, dienthoai, index_bc, index_nv);
            db.ExecuteNonQuery(str);
        }
    }
}
