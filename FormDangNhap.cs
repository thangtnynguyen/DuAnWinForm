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
using DOANWINDOWFORM.DAO;

namespace DOANWINDOWFORM
{

    public partial class frmDangNhap : Form
    {
        DataConnect dt = new DataConnect();
        ClassLoad cl = new ClassLoad();
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
       
        

        private void clsDangNhap_Click_1(object sender, EventArgs e)
        {
            if (txtTaiKhoan2.Texts == "")
            {
                label1.Text = "Hãy Nhập Tài Khoản";
            }
            else
            {
                dt.Ketnoi();
                //kiemtra
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AuthoLogin";
                cmd.Parameters.AddWithValue("@UserName", txtTaiKhoan2.Texts);
                cmd.Parameters.AddWithValue("@Password", txtMatKhau2.Texts);
                cmd.Connection = dt.conlec;
                object kq = cmd.ExecuteScalar();
                int code = Convert.ToInt32(kq);
                if (code == 0)
                {
                    frmChinh fr = new frmChinh(txtTaiKhoan2.Texts, code);

                    fr.ShowDialog();
                }
                else if (code == 1)
                {
                    frmChinh fr = new frmChinh(txtTaiKhoan2.Texts, code);
                    fr.ShowDialog();

                }
                else if (code == 2)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatKhau2.Texts = "";
                    txtTaiKhoan2.Texts = "";
                    txtTaiKhoan2.Focus();
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatKhau2.Texts = "";
                    txtTaiKhoan2.Texts = "";
                    txtTaiKhoan2.Focus();
                }
                dt.DongKetnoi();

            }

            #region cach2
            /*if (chkDangNhapAdmin.Checked != true)
            {
                string sql = "SELECT * FROM TaiKhoanN WHERE TaiKhoan ='" + tk + "'AND  MatKhau='" + mk + "'";
                SqlCommand conn = new SqlCommand(sql, classnew.conlec);
                SqlDataReader dta = conn.ExecuteReader();
                if (dta.Read() != true)
                {

                    MessageBox.Show("Đăng Nhập Thất Bại", "Thông Báo");
                }
                else
                {
                    frmChinh fr = new frmChinh();
                    fr.ShowDialog();

                }
            }
            else
            {
                string sql = "SELECT * FROM TaiKhoanAdmin WHERE TaiKhoanAdmin ='" + tk + "'AND  MatKhaiAdmin='" + mk + "'";// 
                SqlCommand conn = new SqlCommand(sql, classnew.conlec);
                SqlDataReader dta = conn.ExecuteReader();
                if (dta.Read() != true)
                {

                    MessageBox.Show("Đăng Nhập Thất Bại", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                }
                else
                {
                    frmChinh fr = new frmChinh();
                    fr.ShowDialog();

                }
            }

            classnew.DongKetnoi();
        }*/
            #endregion
        }

        private void clsĐangKi_Click_1(object sender, EventArgs e)
        {
            taiKhoanDTO.taikhoan = txtTaiKhoan2.Texts;
            taiKhoanDTO.matkhau = txtMatKhau2.Texts;
            taiKhoanDTO.per = 0;
            //int h = 0;
            //string sql = " Insert into [dbo].[dbo.taikhoann] values ('" + tk + "', '" + mk + "', '" +h+"')";
            //if (cl.KtraTaiKhoanTonTai("Select count(*) from [dbo].[dbo.taikhoann] where taikhoan='" + txtTaiKhoan2.Texts + "'") == 1)
            //{
            //    MessageBox.Show("Tài Khoản đã tồn tại, bạn hãy nhập lại mã khác!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    dt.ThucThiSql(sql);
            //    MessageBox.Show("Bạn đã đăng kí thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            SqlDataReader read = taiKhoanBUS.TimKiem(txtTaiKhoan2.Texts);
            if (read.HasRows)
            {
                MessageBox.Show("Tài Khoản đã tồn tại, bạn hãy nhập lại mã khác!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            else
            {
                taiKhoanBUS.Them(taiKhoanDTO);
                MessageBox.Show("Bạn đã đăng kí thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                txtMatKhau2.PasswordChar = false;
            else
                txtMatKhau2.PasswordChar = true;
        }

        private void txtTaiKhoan2__TextChanged(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }       
}           
            