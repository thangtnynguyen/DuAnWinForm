using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DOANWINDOWFORM
{
    public class ClassConnect
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
                MessageBox.Show("o mở đc tệp", "thông báo ");
            }
        }
        //câu lệnh thực thi
        public void ThucThiSql(string sql)
        {
            Ketnoi();
            cmd = new SqlCommand(sql, conlec);
            cmd.ExecuteNonQuery();
            DongKetnoi();
        }
        public SqlCommand ThucThisqlKoDongKn(string sql)
        {
            Ketnoi();
            cmd = new SqlCommand(sql, conlec);
            cmd.ExecuteNonQuery();
            //DongKetnoi();
            return cmd;
        }
        //public void AddData(DataGridView dgv ,int i, SqlDataReader dr)
        //{
        //    while (dr.Read())
        //    {
        //        for (int j = 0; j < i; j++)
        //        {
        //            dgv;
        //        }
        //    }
        //}
        //lay du lieu theo kiểu Adapter
        public DataTable table(string g)
        {
            SqlConnection conlec = new SqlConnection("Data Source=MSI\\SQLEXPRESS01;Initial Catalog=QuanLyNhaHang;Integrated Security=True");
            Ketnoi();
            SqlCommand conlecc = new SqlCommand(g, conlec);
            SqlDataAdapter dataadam = new SqlDataAdapter(conlecc);
            DataTable datatble = new DataTable();
            dataadam.Fill(datatble);
            DongKetnoi();
            return datatble;
        }
        public int KtraTaiKhoanTonTai(string sql)
        {
            int i;
            Ketnoi();
            cmd = new SqlCommand(sql, conlec);
            i = (int)(cmd.ExecuteScalar());
            DongKetnoi();
            return i;
        }
        public void DongKetnoi()
        {
            conlec.Close();
            conlec.Dispose();
            conlec = null;

        }
        public void loadcbb(ComboBox cb)
        {
            Ketnoi();
            cmd = new SqlCommand("Select * from MucGiaC", conlec);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr[0].ToString());
            }
            DongKetnoi();
        }
        public void loadban(ComboBox cb,string sql,int i)
        {
            Ketnoi();
            cmd = new SqlCommand(sql, conlec);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr[i].ToString());
            }
            DongKetnoi();
        }
        public void LoadSanpham(Control ctrl, string g)
        {
            if (ctrl is DataGridView)
            {
                DataTable tableSanPham = new DataTable();
                ClassConnect classnew = new ClassConnect();
                tableSanPham = classnew.table(g);
                (ctrl as DataGridView).DataSource = tableSanPham;
            }
        }
        public bool KtraString(string kt)
        {
            if (kt == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public string KiemTraTextRadioButton(RadioButton rd)
        {
            string text = "";
            if (rd.Checked == true)
            {
                text = rd.Text;
            }
            return text;
        }
        public String KiemTraRadio(RadioButton a, RadioButton b, RadioButton c, RadioButton d)
        {
            string tg = "";
            if (a.Checked == true) { tg = "Rất Tốt"; }
            if (b.Checked == true) { tg = "Tốt"; }
            if (c.Checked == true) { tg = "Tệ"; }
            if (d.Checked == true) { tg = "Rất Tệ"; }
            return tg;
        }
    }
}
