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
    public partial class frmQLDoNhap : Form
    {
        ThucPhamBUS thucPhamBUS = new ThucPhamBUS();
        ThucPhamDTO thucPhamDTO = new ThucPhamDTO();
        ClassLoad cl = new ClassLoad();
        public frmQLDoNhap()
        {
            InitializeComponent();
        }

       
        void Loadd()
        {
            SqlDataReader read = thucPhamBUS.HienThi();
            while (read.Read())
            {
                //label1.Text = c.ToString();
                dgvDoNhap.Rows.Add(read[0], read[1], read[2], read[3], read[4], read[5]);
            }
        }
        void gan()
        {
            thucPhamDTO.MaSP = txtMaSP.Text;
            thucPhamDTO.TenSP = txtTenSanPham.Text;
            thucPhamDTO.MaLoai = cmbMaLoai.Text;
            thucPhamDTO.MoTa = txtMoTa.Text;
            thucPhamDTO.SoLuong = int.Parse(mskSoLuong.Text);
            thucPhamDTO.DonGia = int.Parse(mskGia.Text);
            thucPhamDTO.TongTien= int.Parse(mskSoLuong.Text)* int.Parse(mskGia.Text);
        }
      
        private void frmQLDoNhap_Load(object sender, EventArgs e)
        {
            Loadd();
        }

        private void dgvDoNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (dgvDoNhap.CurrentCell == null || dgvDoNhap.CurrentCell.Value == null )
            {
                i=-1 ;
            }   
            if (i  !=-1)
            {
                txtMaSP.Text = dgvDoNhap[0, i].Value.ToString();
                txtTenSanPham.Text = dgvDoNhap[1, i].Value.ToString();
                cmbMaLoai.Text = dgvDoNhap[2, i].Value.ToString();
                txtMoTa.Text = dgvDoNhap[3, i].Value.ToString();
                mskSoLuong.Text = dgvDoNhap[4, i].Value.ToString();
                mskGia.Text = dgvDoNhap[5, i].Value.ToString();
            }
            
        }

      
        private void mskSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mskSoLuong.Text.Length >= 10)
            {
                e.Handled = true;
            }
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void mskGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mskGia.Text.Length >= 10)
            {
                e.Handled = true;
            }
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnLamMoiSanPham_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in pnlDoNhap.Controls)
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
            txtMaSP.Enabled = true;
        }

        private void btnThemThucPham_Click(object sender, EventArgs e)
        {
            //thucPhamDTO.MaSP = txtMaSP.Text;
            //SqlDataReader read = thucPhamBUS.TimKiem(txtMaSP.Text);
            //if (read.HasRows)
            //{
            //    MessageBox.Show("Mã sản phẩm đã tồn tại ", "Thông báo");
            //}
            //else
            //{
            //    gan();
            //    thucPhamBUS.Them(thucPhamDTO);
            //    MessageBox.Show("Thành công", "thông báo ");
            //    dgvDoNhap.Rows.Clear();
            //    Loadd();
            //}
            if (cl.TextBoxRong(pnlDoNhap) >=5)
            {
                gan();
                thucPhamBUS.Them(thucPhamDTO);
                MessageBox.Show("Thêm Thành công", "thông báo ");
                dgvDoNhap.Rows.Clear();
                Loadd();
            }
            else
            {
                MessageBox.Show("Bạn Cần Nhập Đủ Thông Tin", "Thông Báo");
            }
        }

        private void btnSuaSanPham_Click(object sender, EventArgs e)
        {
            gan();
            SqlDataReader read = thucPhamBUS.Sua(thucPhamDTO);
            if (read == null)
            {
                MessageBox.Show("Không có Người dùng nào có mã Này ", "Thông Báo");
            }
            else
            {
                MessageBox.Show(" Thành Công ", "Thông Báo");
                dgvDoNhap.Rows.Clear();
                Loadd();
            }
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc muốn xóa thực  phẩm  có Mã là   " + txtMaSP.Text, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl == DialogResult.OK)
            {
                thucPhamDTO.MaSP = txtMaSP.Text;
                SqlDataReader read = thucPhamBUS.Xoa(thucPhamDTO.MaSP);
                if (read == null)
                {
                    MessageBox.Show("Thất Bại", "Thông Báo");
                }
                else
                {
                    MessageBox.Show(" Thành Công ", "Thông Báo");
                    dgvDoNhap.Rows.Clear();
                    Loadd();
                }
            }
        }

        private void btnTimKiemSanPham_Click(object sender, EventArgs e)
        {
            thucPhamDTO.MaSP = txtMaSP.Text;
            SqlDataReader read = thucPhamBUS.TimKiem(thucPhamDTO.MaSP);
            if (read == null)
            {
                MessageBox.Show("Thất Bại", "Thông Báo");
            }
            else
            {
                dgvDoNhap.Rows.Clear();
                while (read.Read())
                {
                    dgvDoNhap.Rows.Add(read[0], read[1], read[2], read[3], read[4], read[5]);
                }
            }
            

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
