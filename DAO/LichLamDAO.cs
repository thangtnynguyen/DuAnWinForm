using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOANWINDOWFORM.DTO;
namespace DOANWINDOWFORM.DAO
{
    class LichLamDAO
    {
        DataConnect dtgv = new DataConnect();
        public SqlDataReader Them(LichLamDTO ka)
        {
            //DateTime date = DateTime.Now;
            //DateTime date = ka.NgayThang;
            //string convert = date.ToString("yyyy-MM-dd");
            string ngay = ka.NgayThang.ToString("yyyy-MM-dd");
            string sql = string.Format("Insert into LichLamDung values(dbo.AUTO_IDNV(),N'{0}', N'{1}',N'{2}','{3}','{4}','{5}','{6}')", ka.TenNhanVien, ka.ChucVu, ka.GioLam,ka.SoDienThoai,ka.TangCa,ka.Luong,ngay);//, ka.NgayThang//,convert
            //string sql = $"INSERT INTO LichLamDung(MANV,TenNhanVien,ChucVu,CaLam,SoDienThoai,TangCa,Luong,NgayThang) VALUES(dbo.AUTO_IDNV(), {ka.TenNhanVien}, {ka.ChucVu}, {ka.GioLam}, {ka.SoDienThoai},{ ka.SoDienThoai},{ka.TangCa},{ka.Luong},{convert})";
            return dtgv.ThucThiSql(sql);
        }
        public SqlDataReader Sua(LichLamDTO ka)
        {
            DateTime date = ka.NgayThang;
            string convert = date.ToString("yyyy-MM-dd");
            string ngay = ka.NgayThang.ToString("yyyy-MM-dd");
            return dtgv.ThucThiSql("UPDATE LichLamDung " + " SET " + " TenNhanVien = N'" + ka.TenNhanVien + "', ChucVu = N'" + ka.ChucVu + "', CaLam = N'" + ka.GioLam + "',SoDienThoai='"+ka.SoDienThoai + "',TangCa='" + ka.TangCa + "',Luong='" + ka.Luong + "',NgayThang='" +ngay+ "' WHERE MaNV = '" + ka.MaNV + "'");
        }

        public SqlDataReader Xoa(string ma,string ten)
        {
            return dtgv.ThucThiSql("DELETE FROM LichLamDung WHERE MaNV='" + ma + "'OR TenNhanVien=N'"+ten+"'");
        }
        public SqlDataReader TimKiem(string ma,string ten)
        {
            return dtgv.ThucThiSql("SELECT TenNhanVien,ChucVu,CaLam,SoDienThoai,TangCa,Luong,NgayThang FROM LichLamDung  WHERE MaNV='" + ma + "' OR TenNhanVien=N'"+ten+"'");
        }
        public SqlDataReader HienThi()
        {
            return dtgv.ThucThiSql("SELECT * FROM LichLamDung");
        }
    }
}
