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
    class BanBUS
    {

        private readonly BanDAO banDAO = new BanDAO();
        public SqlDataReader HienThi()
        {
            return banDAO.HienThi();
        }
        public SqlDataReader TimKiem(string ma)
        {
            return banDAO.TimKiem(ma);
        }
        public SqlDataReader Sua(BanDTO ka)
        {
            return banDAO.Sua(ka);
        }
        public SqlDataReader Them(BanDTO ka)
        {
            return banDAO.Them(ka);
        }
        public SqlDataReader Xoa(string ma)
        {
            return banDAO.Xoa(ma);
        }
    }
}
