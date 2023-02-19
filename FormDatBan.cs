using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOANWINDOWFORM.BUS;
using DOANWINDOWFORM.DTO;
namespace DOANWINDOWFORM
{
    public partial class frmDatBan : Form
    {
        DatBanBUS datBanBUS = new DatBanBUS();
        DatBanDTO datBanDTO = new DatBanDTO();
        ClassLoad cl = new ClassLoad();
        public ClassConnect classnew = new ClassConnect();
        public frmDatBan()
        {
            InitializeComponent();
        }
        private void frmDatBan_Load(object sender, EventArgs e)
        {
            cl.loadban(cmbMucGia, "Select * from MucGiaC",0);
            cl.loadban(cmbBan, "Select * from Ban",1);
            load();
        }
        void gan()
        {
            datBanDTO.TenKhachHang = txtTenKhachHang.Text;
            datBanDTO.MucGia = int.Parse(cmbMucGia.SelectedItem.ToString());
            datBanDTO.SoNguoiLon = int.Parse(txtSoNguoiLon.Text);
            datBanDTO.SoTreEm = int.Parse(txtSoTreEm.Text);
            datBanDTO.BanSo = cmbBan.SelectedItem.ToString();
            datBanDTO.SoDienThoai = mktDienThoai.Text;
            datBanDTO.NgayThangDat = mktNgay.Text;
            datBanDTO.GioDat = mktGio.Text;

        }
        void load()
        {
            SqlDataReader read = datBanBUS.HienThi();
            while (read.Read())
            {
                dgvTTKhachHang.Rows.Add(read[0], read[1], read[2], read[3], read[4], read[5], read[6], read[7]);
            }
        }      
        private void btnDatHang_Click_1(object sender, EventArgs e)
        {
            if (cl.TextBoxRong(panel1)==8)
            {
                gan();
                datBanBUS.Them(datBanDTO);
                MessageBox.Show("Đặt Bàn Thành Công", "Thông Báo");
                dgvTTKhachHang.Rows.Clear();
                load();           
            }
            else { MessageBox.Show("Bạn Cần Nhập Đủ Thông Tin", "Thông Báo"); }
          
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //frmChinh fr = new frmChinh();
            //fr.ShowDialog();
            this.Close();
        }

        private void mktDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
        
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoNguoiLon_KeyPress_1(object sender, KeyPressEventArgs e)
        {
         
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTenKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (mktDienThoai.Text.Length >= 10)
            //{
            //    e.Handled = true;
            //}
            //if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            //    e.Handled = true;
        }

        private void txtSoTreEm_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
