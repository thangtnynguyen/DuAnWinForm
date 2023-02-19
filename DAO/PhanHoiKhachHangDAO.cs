using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOANWINDOWFORM.DTO;
namespace DOANWINDOWFORM.DAO
{
    class PhanHoiKhachHangDAO
    {
        DataConnect dtgv = new DataConnect();
        public SqlDataReader Them(PhanHoiKhachHangDTO ka)
        {
            string sql = string.Format("Insert into PhanHoiKhachHang values(N'{0}',N'{1}', N'{2}')", ka.ChatLuongMonAn, ka.ChatLuongPhucVu, ka.PhanHoi);
            return dtgv.ThucThiSql(sql);
        }
        public SqlDataReader Sua(PhanHoiKhachHangDTO ka)
        {
            return dtgv.ThucThiSql("UPDATE PhanHoiKhachHang " + " SET " + " ChatLuongMonAn = N'" + ka.ChatLuongMonAn + "', ChatLuongPhucVu = N'"+ ka.ChatLuongPhucVu + "' WHERE PhanHoi = '" + ka.PhanHoi + "'");
        }
        public SqlDataReader Xoa(string ma)
        {
            return dtgv.ThucThiSql("DELETE FROM PhanHoiKhachHang WHERE PhanHoi='" + ma + "'");
        }
        public SqlDataReader TimKiem(string ma)
        {
            return dtgv.ThucThiSql("SELECT ChatLuongMonAn,ChatLuongPhucVu,PhanHoi FROM PhanHoiKhachHang  WHERE PhanHoi='" + ma + "'");
        }
        public SqlDataReader HienThi()
        {
            return dtgv.ThucThiSql("SELECT * FROM PhanHoiKhachHang");
        }
    }
}
