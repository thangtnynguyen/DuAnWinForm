using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOANWINDOWFORM.DAO;
using DOANWINDOWFORM.DTO;
namespace DOANWINDOWFORM.BUS
{
    class PhanHoiKhachHangBUS
    {
        private readonly PhanHoiKhachHangDAO phanHoiKhachHangDAO = new PhanHoiKhachHangDAO();
        public SqlDataReader HienThi()
        {
            return phanHoiKhachHangDAO.HienThi();
        }
        public SqlDataReader TimKiem(string ma)
        {
            return phanHoiKhachHangDAO.TimKiem(ma);
        }
        public SqlDataReader Sua(PhanHoiKhachHangDTO ka)
        {
            return phanHoiKhachHangDAO.Sua(ka);
        }
        public SqlDataReader Them(PhanHoiKhachHangDTO ka)
        {
            return phanHoiKhachHangDAO.Them(ka);
        }
        public SqlDataReader Xoa(string ma)
        {
            return phanHoiKhachHangDAO.Xoa(ma);
        }
        
    }
}
