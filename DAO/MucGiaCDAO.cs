using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOANWINDOWFORM.DTO;
namespace DOANWINDOWFORM.DAO
{
    class MucGiaCDAO
    {
        DataConnect dtgv = new DataConnect();
        public SqlDataReader Them(MucGiaCDTO ka)
        {
            string sql = string.Format("Insert into MucGiaC values('{0}','{1}', '{2}')", ka.MucGia, ka.SoMon, ka.GomCo);
            return dtgv.ThucThiSql(sql);
        }
        public SqlDataReader Sua(MucGiaCDTO ka)
        {
            return dtgv.ThucThiSql("UPDATE MucGiaC " + " SET " + " SoMon = N'" + ka.SoMon + "', GomCo = '" + ka.GomCo + "' WHERE MucGia = '" + ka.MucGia + "'");
        }
        public SqlDataReader Xoa(string ma)
        {
            return dtgv.ThucThiSql("DELETE FROM MucGiaC WHERE MucGia='" + ma + "'");
        }
        public SqlDataReader TimKiem(string ma)
        {
            return dtgv.ThucThiSql("SELECT MucGia,SoMon,GomCo FROM MucGiaC  WHERE MucGia='" + ma + "'");
        }
        public SqlDataReader HienThi()
        {
            return dtgv.ThucThiSql("SELECT * FROM MucGiaC");
        }
    }
}
