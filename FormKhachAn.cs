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
    public partial class frmKhachAn : Form
    {
        KhachAnDTO khachAnDTO = new KhachAnDTO();
        KhachAnBUS khachAnBUS = new KhachAnBUS();
        BanBUS banBUS = new BanBUS();
        BanDTO banDTO = new BanDTO();
        ClassLoad cl = new ClassLoad();
        public ClassConnect classnew = new ClassConnect();
        public frmKhachAn()
        {
            InitializeComponent();
        }
        private void Gan()
        {
            khachAnDTO.TenKhachHang = txtTenKhachHang.Text;
            khachAnDTO.BanSo = cmbBan.Text;
            khachAnDTO.MucGia = int.Parse(cmbMucGia.Text);
            khachAnDTO.MaKhach = txtMaKhachHang.Text;
            khachAnDTO.SoNguoiLon = int.Parse(txtSoNguoiLon.Text);
            khachAnDTO.SoTreEm = int.Parse(txtSoTreEm.Text);
            khachAnDTO.SoDienThoai = mktDienThoai.Text;
            khachAnDTO.NgayThangDat = dateTimePicker1.Value;
            khachAnDTO.TongTien = int.Parse(txtSoNguoiLon.Text) * int.Parse(cmbMucGia.Text) + int.Parse(txtSoTreEm.Text) * 0.3 * int.Parse(cmbMucGia.Text);
            khachAnDTO.ThanhToan = "ChuaThanhToan";
            banDTO.BanSo = cmbBan.Text;
            banDTO.BanKin = "fill";
        }

        public void load()
        {
            cl.loadban(cmbMucGia, "Select * from MucGiaC", 0);
            cl.loadban(cmbBan, "SELECT * FROM Ban WHERE BanKin='" + "no" + "'", 1);
            SqlDataReader read = khachAnBUS.HienThi();
            while (read.Read())
            {
                dgvTTKhachHang.Rows.Add(read[0], read[1], read[2], read[3], read[4], read[5], read[6], read[7], read[8],read[9]);
            }
        }
        private void frmKhachAn_Load(object sender, EventArgs e)
        {
            load();
           
        }

        private void dgvTTKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (dgvTTKhachHang.CurrentCell == null || dgvTTKhachHang.CurrentCell.Value == null)
            {
                i = -1;
            }
            if (i != -1)
            {
                txtTenKhachHang.Text = dgvTTKhachHang[0, i].Value.ToString();
                cmbMucGia.Text = dgvTTKhachHang[1, i].Value.ToString();//truy vấn đến ô dữ liệu
                txtSoNguoiLon.Text = dgvTTKhachHang[2, i].Value.ToString();
                txtSoTreEm.Text = dgvTTKhachHang[3, i].Value.ToString();
                cmbBan.Text = dgvTTKhachHang[4, i].Value.ToString();
                mktDienThoai.Text = dgvTTKhachHang[5, i].Value.ToString();
                dateTimePicker1.Text = dgvTTKhachHang[6, i].Value.ToString();
                txtMaKhachHang.Text = dgvTTKhachHang[7, i].Value.ToString();
            }

        }

        private void txtSoNguoiLon_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void mktDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
     
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoTreEm_KeyPress(object sender, KeyPressEventArgs e)
        {
    
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }


        private void btnSuaKh_Click(object sender, EventArgs e)
        {
            Gan();
            SqlDataReader read = khachAnBUS.Sua(khachAnDTO);
            if (read == null)
            {
                MessageBox.Show("Không có Người dùng nào có mã Này ", "Thông Báo");
            }
            else
            {
                MessageBox.Show(" Thành Công ", "Thông Báo");
                dgvTTKhachHang.Rows.Clear();
                banDTO.BanKin = "no";
                banDTO.BanSo = cmbBan.Text;
                banBUS.Sua(banDTO);
                load();
            }
        }

        private void btnChotKhach_Click(object sender, EventArgs e)
        {
            if (cl.TextBoxRong(panel1)==6)
            {
                Gan();
                SqlDataReader read = khachAnBUS.Them(khachAnDTO);
                if (read == null)
                {
                    MessageBox.Show("Thất Bại Sai Thông Tin Bàn ", "Thông Báo");
                }
                else
                {
                    MessageBox.Show("Chốt bàn thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    banDTO.BanKin = "fill";
                    banDTO.BanSo = cmbBan.Text;
                    banBUS.Sua(banDTO);
                    dgvTTKhachHang.Rows.Clear();
                    cmbBan.Items.Clear();
                    cmbMucGia.Items.Clear();
                    load();
                    
                }
            }
            else
            {
                MessageBox.Show("Bạn Cần Nhập Đủ Thông Tin", "Thông Báo");
            }
           

        }

        private void btnXoaKh_Click(object sender, EventArgs e)
        {

         
            DialogResult dl = MessageBox.Show("Bạn có chắc muốn xóa bàn này khôngg ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl==DialogResult.OK)
            {
                khachAnDTO.MaKhach = txtMaKhachHang.Text;
                khachAnDTO.TenKhachHang = txtTenKhachHang.Text;
                SqlDataReader read = khachAnBUS.Xoa(khachAnDTO.MaKhach,khachAnDTO.TenKhachHang);
                if (read == null)
                {
                    MessageBox.Show("Thất Bại", "Thông Báo");
                }
                else
                {
                    MessageBox.Show(" Xóa Thành Công ", "Thông Báo");
                    banDTO.BanKin = "no";
                    banDTO.BanSo = cmbBan.Text;
                    banBUS.Sua(banDTO);
                    dgvTTKhachHang.Rows.Clear();
                    cmbBan.Items.Clear();
                    cmbMucGia.Items.Clear();
                    load();
                    btnLamMoiKh_Click(null, null);
                }
            }
            
        }

        private void btnTimKiemKh_Click(object sender, EventArgs e)
        {
            txtMaKhachHang.Enabled = true;
            khachAnDTO.MaKhach = txtMaKhachHang.Text;
            khachAnDTO.TenKhachHang = txtTenKhachHang.Text;
            SqlDataReader read = khachAnBUS.TimKiem(khachAnDTO.MaKhach,khachAnDTO.TenKhachHang);
            dgvTTKhachHang.Rows.Clear();
            while (read.Read())
            {
                dgvTTKhachHang.Rows.Add(read[0], read[1], read[2], read[3], read[4], read[5], read[6], read[7], read[8]);
            }
        }

        
        private void btnLamMoiKh_Click(object sender, EventArgs e)
        {
            txtMaKhachHang.Enabled = true;
            txtMaKhachHang.Text = "";
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Text = "";
                }
                if (ctrl is ComboBox)
                {
                    (ctrl as ComboBox).Text = "";
                }
                if (ctrl is MaskedTextBox)
                {
                    (ctrl as MaskedTextBox).Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
