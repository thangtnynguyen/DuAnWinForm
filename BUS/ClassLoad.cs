using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOANWINDOWFORM.DAO;

namespace DOANWINDOWFORM.BUS
{
    class ClassLoad
    {
        DataConnect dt = new DataConnect();
        SqlCommand cmd;
        SqlDataReader dr;
        public int KtraTaiKhoanTonTai(string sql)
        {
            int i;
            dt.Ketnoi();
            cmd = new SqlCommand(sql, dt.conlec);
            i = (int)(cmd.ExecuteScalar());
            dt.DongKetnoi();
            return i;
        }

        public void loadban(ComboBox cb, string sql, int i)
        {
            dt.Ketnoi();
            cmd = new SqlCommand(sql, dt.conlec);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr[i].ToString());
            }
            dt.DongKetnoi();
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
        public int TextBoxRong(Panel panel1)
        {
            int a = 0;
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is TextBox)
                {
                    if ((ctrl as TextBox).Text != "")
                    {
                        a++;
                    }
                }
                if (ctrl is ComboBox)
                {
                    if ((ctrl as ComboBox).Text != "")
                    {
                        a++;
                    }
                }
                if (ctrl is MaskedTextBox)
                {
                    if ((ctrl as MaskedTextBox).Text != "")
                    {
                        a++;
                    }
                }
                if (ctrl is UserControlTexBox)
                {
                    if ((ctrl as UserControlTexBox).Texts != "")
                    {
                        a++;
                    }
                }
            }
            return a;
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
        public string TongTien(string sql)
        {
            dt.Ketnoi();
            cmd = new SqlCommand(sql, dt.conlec);
            string cm = cmd.ExecuteScalar().ToString();
            return cm;
        }
        
    }
}
