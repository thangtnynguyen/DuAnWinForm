using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOANWINDOWFORM.DAO;
using DOANWINDOWFORM.DTO;
namespace DOANWINDOWFORM.BUS
{
    class ThucPhamBUS
    {
        private readonly ThucPhamDAO thucPhamDAO = new ThucPhamDAO();
        public SqlDataReader HienThi()
        {
            return thucPhamDAO.HienThi();
        }
        public SqlDataReader TimKiem(string ma)
        {

            SqlDataReader read = thucPhamDAO.TimKiem(ma);
            if (read.HasRows)
            {
                return thucPhamDAO.TimKiem(ma);
            }
            else { return null;}
            
        }
        public SqlDataReader Sua(ThucPhamDTO ka)
        {
            SqlDataReader read = thucPhamDAO.TimKiem(ka.MaSP);
            if (read.HasRows)
            {
                return thucPhamDAO.Sua(ka); ;
            }
            else { return null; }
        }
        public SqlDataReader Them(ThucPhamDTO ka)
        {
            SqlDataReader read = thucPhamDAO.TimKiem(ka.MaSP);
            if (read.HasRows)
            {
                return null;
            }
            else { return thucPhamDAO.Them(ka); }

            
        }
        public SqlDataReader Xoa(string ma)
        {
            //return khachAnDAO.Xoa(ma);
            SqlDataReader read = thucPhamDAO.TimKiem(ma);
            if (read.HasRows)
            {
                return thucPhamDAO.Xoa(ma); 
            }
            else { return null; }
            
        }
        //public int KtraTaiKhoanTonTai(string sql)
        //{
        //    int i;
        //    Ketnoi();
        //    cmd = new SqlCommand(sql, conlec);
        //    i = (int)(cmd.ExecuteScalar());
        //    DongKetnoi();
        //    return i;
        //}
    }
}
