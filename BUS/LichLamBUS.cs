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
    class LichLamBUS
    {
        private readonly LichLamDAO lichLamDAO = new LichLamDAO();
        public SqlDataReader HienThi()
        {
            return lichLamDAO.HienThi();
        }
        public SqlDataReader TimKiem(string ma,string ten)
        {
            return lichLamDAO.TimKiem(ma,ten);
        }
        public SqlDataReader Sua(LichLamDTO ka)
        {
            SqlDataReader read = lichLamDAO.TimKiem(ka.MaNV,ka.TenNhanVien);
            if (read.HasRows)
            {
                return lichLamDAO.Sua(ka);
            }
            else { return null;}

            
        }
        public SqlDataReader Them(LichLamDTO ka)
        {
            return lichLamDAO.Them(ka);
        }
        public SqlDataReader Xoa(string ma,string ten)
        {
            SqlDataReader read = lichLamDAO.TimKiem(ma,ten);
            if (read.HasRows)
            {
                return lichLamDAO.Xoa(ma,ten);
            }
            else { return null; }
            
        }
    }
}
