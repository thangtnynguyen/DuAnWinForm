using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANWINDOWFORM.DAO
{
    class DataConnect
    {
        public SqlConnection conlec;
        public SqlCommand cmd;
        public SqlDataReader dr;
        public void Ketnoi()
        {
            try
            {
                conlec = new SqlConnection(@"Data Source=MSI\SQLEXPRESS01;Initial Catalog=QuanLyNhaHang;Integrated Security=True");
                conlec.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }
        //câu lệnh thực thi
        public SqlDataReader ThucThiSql(string sql)
        {
            Ketnoi();
            cmd = new SqlCommand(sql, conlec);
            //cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            //DongKetnoi();
            return dr;
        }
        public void ThucThiSql_ExecuteNonQuery(string sql)
        {
            Ketnoi();
            cmd = new SqlCommand(sql, conlec);
            cmd.ExecuteNonQuery();
            DongKetnoi();
        }
        public void DongKetnoi()
        {
            conlec.Close();
            conlec.Dispose();
            conlec = null;
        }
        //lay du lieu theo kiểu Adapter
        //public DataTable table(string g)
        //{
        //    SqlConnection conlec = new SqlConnection("Data Source=MSI\\SQLEXPRESS01;Initial Catalog=QuanLyNhaHang;Integrated Security=True");
        //    Ketnoi();
        //    SqlCommand conlecc = new SqlCommand(g, conlec);
        //    SqlDataAdapter dataadam = new SqlDataAdapter(conlecc);
        //    DataTable datatble = new DataTable();
        //    dataadam.Fill(datatble);
        //    DongKetnoi();
        //    return datatble;
        //}

    }
}
