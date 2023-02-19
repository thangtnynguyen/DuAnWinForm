using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOANWINDOWFORM.DTO;
namespace DOANWINDOWFORM.DAO
{
    class DatBanDAO
    {
        DataConnect dtgv = new DataConnect();
        public SqlDataReader Them(DatBanDTO ka)
        {
            string sql = string.Format("Insert into DatBan values('{0}','{1}', '{2}', '{3}', '{4}', '{5}','{6}', '{7}')", ka.TenKhachHang, ka.MucGia, ka.SoNguoiLon, ka.SoTreEm, ka.BanSo, ka.SoDienThoai, ka.NgayThangDat, ka.GioDat);
            return dtgv.ThucThiSql(sql);
        }
        public SqlDataReader Sua(DatBanDTO ka)
        {
            return dtgv.ThucThiSql("UPDATE DatBan " + " SET " + " TenKhachHang = N'" + ka.TenKhachHang + "', MucGia = N'" + ka.MucGia + "',SoNguoiLon = '" + ka.SoNguoiLon + "', SoTreEm = '" + ka.SoTreEm + "', BanSo = N'" + ka.BanSo + "',SoDienThoai = '" + ka.SoDienThoai + "', NgayThangDat = '" + ka.NgayThangDat + "', GioDat = '" + ka.GioDat + "' WHERE TenKhachHang = '" + ka.TenKhachHang + "'");
        }
        public SqlDataReader Xoa(string ma)
        {
            return dtgv.ThucThiSql("DELETE FROM DatBan WHERE NgayThangDat='" + ma + "'");
        }
        public SqlDataReader XoaAll()
        {
            return dtgv.ThucThiSql("DELETE FROM DatBan ");
        }
        public SqlDataReader TimKiem(string ma)
        {
            return dtgv.ThucThiSql("SELECT TenKhachHang, MucGia, SoNguoiLon, SoTreEm, BanSo, SoDienThoai, NgayThangDat,GioDat FROM DatBan  WHERE NgayThangDat='" + ma + "'");
        }
        public SqlDataReader HienThi()
        {
            return dtgv.ThucThiSql("SELECT * FROM DatBan");
        }

    }
}
