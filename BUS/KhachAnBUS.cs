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
    class KhachAnBUS
    {
        private readonly KhachAnDAO khachAnDAO = new KhachAnDAO();
        public SqlDataReader HienThi()
        {
            return khachAnDAO.HienThi();
        }
        public SqlDataReader TimKiem(string ma,string ten)
        {
            return khachAnDAO.TimKiem(ma,ten);
        }
        public SqlDataReader TimKiemBan(string ma)
        {
            return khachAnDAO.TimKiemBan(ma);
        }
        public SqlDataReader TimKiemBanThanhToan(string ma)
        {
            return khachAnDAO.TimKiemBanThanhToan(ma);
        }
        public SqlDataReader Sua(KhachAnDTO ka)
        {
            SqlDataReader read = khachAnDAO.TimKiem(ka.MaKhach,ka.TenKhachHang);
            if (read.HasRows)
            {
                return khachAnDAO.Sua(ka);
            }
            else { return null; }
            
        }
        public SqlDataReader ChotThanhToan(string ka)
        {
            return khachAnDAO.ChotThanhToan(ka);
        }
        public SqlDataReader Them(KhachAnDTO ka)
        {
            SqlDataReader read = khachAnDAO.TimKiemBan(ka.BanSo);
            if (read.HasRows)
            {
                return null;
            }
            else { return khachAnDAO.Them(ka); }
            
        }
        public SqlDataReader Xoa(string ma,string ten)
        {
            //return khachAnDAO.Xoa(ma);
            SqlDataReader read = khachAnDAO.TimKiem(ma,ten);
            if (read.HasRows)
            {
                return khachAnDAO.Xoa(ma,ten);
            }
            else { return null; }
        }
    }
}
