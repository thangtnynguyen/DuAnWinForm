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
    class DatBanBUS
    {
        private readonly DatBanDAO datBanDAO = new DatBanDAO();
        public SqlDataReader HienThi()
        {
            return datBanDAO.HienThi();
        }
        public SqlDataReader TimKiem(string ma)
        {
            return datBanDAO.TimKiem(ma);
        }
        public SqlDataReader Sua(DatBanDTO ka)
        {
            return datBanDAO.Sua(ka);
        }
        public SqlDataReader Them(DatBanDTO ka)
        {
            return datBanDAO.Them(ka);
        }
        public SqlDataReader Xoa(string ma)
        {
            return datBanDAO.Xoa(ma);
        }
        public SqlDataReader XoaAll()
        {
            return datBanDAO.XoaAll();
        }
    }
}
