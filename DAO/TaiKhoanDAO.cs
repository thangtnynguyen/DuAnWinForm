using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOANWINDOWFORM.DTO;

namespace DOANWINDOWFORM.DAO
{
    class TaiKhoanDAO
    {
        DataConnect dtgv = new DataConnect();
        public SqlDataReader Them(TaiKhoanDTO ka)
        {
            string sql = string.Format("Insert into [dbo].[dbo.taikhoann] values('{0}','{1}', '{2}')", ka.taikhoan, ka.matkhau, ka.per);
            return dtgv.ThucThiSql(sql);
        }
        public SqlDataReader Sua(TaiKhoanDTO ka)
        {
            return dtgv.ThucThiSql("UPDATE [dbo].[dbo.taikhoann] " + " SET " + " matkhau ='"+ka.matkhaumoi+ "' WHERE taikhoan ='" + ka.taikhoan+ "'");
        }
        public SqlDataReader Xoa(string ma)
        {
            return dtgv.ThucThiSql("DELETE FROM [dbo].[dbo.taikhoann] WHERE taikhoan ='"+ ma +"'");
        }
        public SqlDataReader TimKiem(string ma)
        {
            return dtgv.ThucThiSql("SELECT  taikhoan, matkhau, per  FROM [dbo].[dbo.taikhoann]  WHERE taikhoan='" +ma+ "'");
        }
        public SqlDataReader TimKiemDoiMK(string ma,string matkhau)
        {
            return dtgv.ThucThiSql("SELECT  taikhoan, matkhau, per  FROM [dbo].[dbo.taikhoann]  WHERE taikhoan='" +ma+ "' AND matkhau='"+matkhau+"'");
        }
        public SqlDataReader HienThi()
        {
            return dtgv.ThucThiSql("SELECT * FROM [dbo].[dbo.taikhoann]");
        }
    }
}
