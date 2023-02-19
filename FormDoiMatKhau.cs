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
    public partial class frmDoiMatKhau : Form
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO();
        private string taikhoan;
       // ClassConnect classnew = new ClassConnect();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        public frmDoiMatKhau(string tk)
        {
            InitializeComponent();
            this.taikhoan = tk;
        }
        void gan()
        {
            taiKhoanDTO.taikhoan = txtTKDoi.Text;
            taiKhoanDTO.matkhau = txtMKDoiCu.Text;
            taiKhoanDTO.matkhaumoi = txtMKDoiMoi.Text;
        }
        private void btnDoiMk_Click(object sender, EventArgs e)
        {
            

            //string sql = "SELECT * FROM [dbo.taikhoann] WHERE taikhoan ='" + txtTKDoi.Text+"'AND  matkhau='"+txtMKDoiCu.Text+"'";// 
            //classnew.dr = classnew.ThucThisqlKoDongKn(sql).ExecuteReader();
            //if (classnew.dr.HasRows != true)
            //{

            //    MessageBox.Show(" Thất Bại", "Thông Báo");
            //}
            //else
            //{
            //    string sua = "UPDATE [dbo.taikhoann] " + " SET " + " matkhau = '"+ txtMKDoiMoi.Text +"'" + " WHERE " + " taikhoan = '"+ txtTKDoi.Text+ "'";
            //    classnew.ThucThiSql(sua);
            //    MessageBox.Show("Thành công", "thông báo ");

            //}


        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTKDoi.Text = this.taikhoan;
        }

        private void txtTKDoi_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            gan();
            SqlDataReader read = taiKhoanBUS.TimKiemDoiMK(taiKhoanDTO.taikhoan, taiKhoanDTO.matkhau);
            if (read.HasRows != true ||txtMKDoiMoi.Text=="")
            {
                MessageBox.Show(" Thất Bại", "Thông Báo");
            }
            else
            {
                taiKhoanBUS.Sua(taiKhoanDTO);
                MessageBox.Show("Đổi Mật Khẩu Thành công", "thông báo ");
                frmChinh f = new frmChinh();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmChinh f = new frmChinh();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 
