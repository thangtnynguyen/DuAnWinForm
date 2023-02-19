using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DOANWINDOWFORM.BUS;
using DOANWINDOWFORM.DTO;
namespace DOANWINDOWFORM
{
    public partial class frmDanhGiaCuaKhachHang : Form
    {
        private readonly PhanHoiKhachHangBUS phanHoiKhachHangBUS = new PhanHoiKhachHangBUS();
        public frmDanhGiaCuaKhachHang()
        {
            InitializeComponent();
        }

 
        private void frmDanhGiaCuaKhachHang_Load(object sender, EventArgs e)
        {
            SqlDataReader read = phanHoiKhachHangBUS.HienThi();
            while (read.Read())
            {
                dgvPhanHoiCuaKhach.Rows.Add(read[0], read[1], read[2]);
            }
            ////Theo Kiểu COmmand
            //ClassConnect classnew = new ClassConnect();
            //classnew.Ketnoi();
            //string sql = "SELECT * FROM PhanHoiKhachHang ";// 
            //SqlCommand conn = new SqlCommand(sql, classnew.conlec);
            //classnew.dr = conn.ExecuteReader();
            //while (classnew.dr.Read())
            //{
            //    //label1.Text = c.ToString();
            //    dgvPhanHoiCuaKhach.Rows.Add(classnew.dr[0], classnew.dr[1],classnew.dr[2]);
            //}
            //classnew.DongKetnoi();
            ////Theo Kiểu Adapter
            ////ClassModify classmody = new ClassModify();
            ////classmody.LoadSanpham(dgvPhanHoiCuaKhach, "Select * from PhanHoiKhachHang");

        }
        
    }
}
