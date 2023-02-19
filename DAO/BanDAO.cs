using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOANWINDOWFORM.DTO;
namespace DOANWINDOWFORM.DAO
{
    class BanDAO
    {
        DataConnect dtgv = new DataConnect();
        public SqlDataReader Them(BanDTO ka)
        {
            string sql = string.Format("Insert into Ban values('{0}','{1}'", ka.BanKin, ka.BanSo);
            return dtgv.ThucThiSql(sql);
        }
        public SqlDataReader Sua(BanDTO ka)
        {
            return dtgv.ThucThiSql("UPDATE Ban " + " SET " + " BanKin = '" + ka.BanKin + "' WHERE BanSo='"+ka.BanSo+"'");
        }
        public SqlDataReader Xoa(string ma)
        {
            return dtgv.ThucThiSql("DELETE FROM Ban WHERE BanKin='" + ma + "'");
        }
        public SqlDataReader TimKiem(string ma)
        {
            return dtgv.ThucThiSql("SELECT  BanSo  WHERE BanKin='" + ma + "'");
        }
        public SqlDataReader HienThi()
        {
            return dtgv.ThucThiSql("SELECT * FROM Ban");
        }
    }
}
