using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
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
            string strSQL = "Select MaNhanVien, HoTenNhanVien, NgaySinhNV, DiaChiNV, DienThoaiNV, TenChucVu from NHANVIEN N, CHUCVU C where N.MaChucVu = C.MaChucVu";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable LayChucVu()
        {
            string strSQL = "Select MaChucVu, TenChucVu from CHUCVU";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public void XoaNhanVien(string index_nv)
        {
            string sql = "Delete from NHANVIEN where MaNhanVien = " + index_nv;
            db.ExecuteNonQuery(sql);
        }
        public void ThemNhanVien(string ten, string ngaysinh, string diachi, string dienthoai, string index_cv)
        {
            string sql = string.Format("Insert into NHANVIEN values(N'{0}','{1}',N'{2}','{3}',{4})", ten, ngaysinh, diachi, dienthoai, index_cv);
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatNhanVien(string index_nv, string hoten, string ngaysinh, string diachi, string dienthoai, string index_cv)
        {
            string str = string.Format("Update NHANVIEN set HoTenNhanVien = N'{0}', NgaySinhNV = '{1}', DiaChiNV = N'{2}', DienThoaiNV = '{3}', MaChucVu = {4} where MaNhanVien = {5}", hoten, ngaysinh, diachi, dienthoai, index_cv, index_nv);
            db.ExecuteNonQuery(str);
        }
    }
}
