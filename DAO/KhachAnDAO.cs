using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOANWINDOWFORM;
using DOANWINDOWFORM.DTO;
namespace DOANWINDOWFORM.DAO
{
    class KhachAnDAO
    {
        DataConnect dtgv=new DataConnect();
        public SqlDataReader Them(KhachAnDTO ka)
        {
            string ngay = ka.NgayThangDat.ToString("yyyy-MM-dd");
            string sql = string.Format("Insert into KhachAn values(N'{0}','{1}', '{2}', '{3}', '{4}', '{5}','{6}',dbo.AUTO_IDKH(), '{7}','{8}')", ka.TenKhachHang, ka.MucGia, ka.SoNguoiLon, ka.SoTreEm, ka.BanSo, ka.SoDienThoai, ngay, ka.TongTien,ka.ThanhToan);
            return dtgv.ThucThiSql(sql);
        }
        public SqlDataReader Sua(KhachAnDTO ka)
        {
            string ngay = ka.NgayThangDat.ToString("yyyy-MM-dd");
            return dtgv.ThucThiSql("UPDATE KhachAn " + " SET " + " TenKhachHang = N'" + ka.TenKhachHang+ "', MucGia = N'" + ka.MucGia+ "',SoNguoiLon = '" + ka.SoNguoiLon + "', SoTreEm = '" + ka.SoTreEm + "', BanSo = N'" + ka.BanSo + "',SoDienThoai = '" + ka.SoDienThoai + "', NgayThangDat = '" + ngay + "', TongTien = N'" + ka.TongTien + "' WHERE MaKhach = '" + ka.MaKhach+ "'");
        }
        public SqlDataReader Xoa(string ma,string ten)
        {
            return dtgv.ThucThiSql("DELETE FROM KhachAn WHERE MaKhach='"+ma+ "' OR TenKhachHang=N'" + ten + "'");
        }
        public SqlDataReader TimKiem(string ma,string ten)
        {
            return dtgv.ThucThiSql("SELECT TenKhachHang, MucGia, SoNguoiLon, SoTreEm, BanSo, SoDienThoai, NgayThangDat, MaKhach, ThanhToan FROM KhachAn  WHERE MaKhach='" +ma+ "' OR TenKhachHang=N'"+ten+"'");
        }
        public SqlDataReader TimKiemBan(string ma)
        {
        return dtgv.ThucThiSql("SELECT BanSo FROM KhachAn  WHERE BanSo='"+ma+"'");
        }
        public SqlDataReader TimKiemBanThanhToan(string ma)
        {
            return dtgv.ThucThiSql("SELECT BanSo FROM KhachAn  WHERE ThanhToan='"+ma+"'");
        }
        public SqlDataReader ChotThanhToan(string ma)
        {
            return dtgv.ThucThiSql("UPDATE  KhachAn  SET ThanhToan='"+"DaThanhToan"+"' WHERE BanSo='" + ma + "'");
        }
        public SqlDataReader HienThi() 
        {
            return dtgv.ThucThiSql("SELECT * FROM KhachAn");
        } 
    }
}

