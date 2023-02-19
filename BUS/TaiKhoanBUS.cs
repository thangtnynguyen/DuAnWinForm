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
    class TaiKhoanBUS
    {
        private readonly TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
        public SqlDataReader HienThi()
        {
            return taiKhoanDAO.HienThi();
        }
        public SqlDataReader TimKiem(string ma)
        {
            return taiKhoanDAO.TimKiem(ma);
        }
        public SqlDataReader TimKiemDoiMK(string ma,string matkhau)
        {
            return taiKhoanDAO.TimKiemDoiMK(ma,matkhau);
        }
        public SqlDataReader Sua(TaiKhoanDTO ka)
        {
            return taiKhoanDAO.Sua(ka);
        }
        public SqlDataReader Them(TaiKhoanDTO ka)
        {
            return taiKhoanDAO.Them(ka);
        }
        public SqlDataReader Xoa(string ma)
        {
            return taiKhoanDAO.Xoa(ma);
        }
    }
}
