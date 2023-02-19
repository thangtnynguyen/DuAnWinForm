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
    class MucGiaCBUS
    {
        private readonly MucGiaCDAO mucGiaCDAO = new MucGiaCDAO();
        public SqlDataReader HienThi()
        {
            return mucGiaCDAO.HienThi();
        }
        public SqlDataReader TimKiem(string ma)
        {
            return mucGiaCDAO.TimKiem(ma);
        }
        public SqlDataReader Sua(MucGiaCDTO ka)
        {
            return mucGiaCDAO.Sua(ka);
        }
        public SqlDataReader Them(MucGiaCDTO ka)
        {
            return mucGiaCDAO.Them(ka);
        }
        public SqlDataReader Xoa(string ma)
        {
            return mucGiaCDAO.Xoa(ma);
        }
        public void loadcbb(ComboBox cb)
        {
            SqlDataReader read=  mucGiaCDAO.HienThi();
            while (read.Read())
            {
                cb.Items.Add(read[0].ToString());
            }
        }
    }
}
