using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOANWINDOWFORM.DTO;
namespace DOANWINDOWFORM.DAO
{
    class ThucPhamDAO
    {
        DataConnect dtgv = new DataConnect();
        public SqlDataReader Them(ThucPhamDTO ka)
        {
            string ngay = DateTime.Now.ToString("yyyy-MM-dd");
            string sql = string.Format("Insert into ThucPham values(dbo.AUTO_IDTP(),N'{0}', '{1}', N'{2}', '{3}', '{4}','{5}','{6}')",  ka.TenSP, ka.MaLoai, ka.MoTa, ka.SoLuong, ka.DonGia,ka.TongTien,ngay);//ka.MaSP,
            return dtgv.ThucThiSql(sql);
        }
        public SqlDataReader Sua(ThucPhamDTO ka)
        {
            return dtgv.ThucThiSql("UPDATE ThucPham " + " SET " + " TenSP = N'" + ka.TenSP + "', MaLoai = N'" + ka.MaLoai + "', MoTa = N'" + ka.MoTa + "',SoLuong='"+ ka.SoLuong + "',DonGia='" + ka.DonGia + "' WHERE MaSP = '" + ka.MaSP + "'");
        }
        public SqlDataReader Xoa(string ma)
        {
            return dtgv.ThucThiSql("DELETE FROM ThucPham WHERE MaSP='" + ma + "'");
        }
        public SqlDataReader TimKiem(string ma)
        {
            return dtgv.ThucThiSql("SELECT  MaSP, TenSP, MaLoai, MoTa,SoLuong, DonGia FROM ThucPham WHERE MaSP='" + ma + "'");
        }
        public SqlDataReader HienThi()
        {
            return dtgv.ThucThiSql("SELECT * FROM ThucPham");
        }
    }
}
