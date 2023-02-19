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
    public partial class frmQuanLyNhanVien : Form
    {
        LichLamBUS lichLamBUS = new LichLamBUS();
        LichLamDTO lichLamDTO = new LichLamDTO();
        ClassLoad cl = new ClassLoad();
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }
        void gan()
        {
            lichLamDTO.MaNV = txtMaNV.Texts;
            lichLamDTO.GioLam = cmbCaLam.Text;
            lichLamDTO.SoDienThoai = mskSDTNhanVien.Text;
            lichLamDTO.TenNhanVien = txtTenNhanVien.Texts;
            lichLamDTO.ChucVu = cmbChucVu.Text;
            lichLamDTO.TangCa = txtTangCa.Text;
            lichLamDTO.Luong = 0;
            //lichLamDTO.NgayThang= DateTime.Parse(dtpNgay.Value.ToShortDateString());
            //lichLamDTO.NgayThang = DateTime.Parse(dtpNgay.Value.Date.ToString("yyyy-MM-dd"));//
            lichLamDTO.NgayThang = dtpNgay.Value.Date;
        }
       
        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            label1.Text = dtpNgay.Value.Date.ToString("dd-MM-yyyy");
            loadNhanVien();
            cl.loadban(cmbChucVu, "SELECT * FROM ChucVu ", 0);
        }
        public void loadNhanVien()
        {
            SqlDataReader read = lichLamBUS.HienThi();
            while (read.Read())
            {
                dgvLichDiLam.Rows.Add(read[0], read[1], read[2], read[3], read[4],read[5],read[6]);
            }
        }
      

        private void dgvLichDiLam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (dgvLichDiLam.CurrentCell == null || dgvLichDiLam.CurrentCell.Value == null)
            {
                i = -1;
            }
            if (i != -1)
            {
                txtMaNV.Texts = dgvLichDiLam[0, i].Value.ToString();
                txtTenNhanVien.Texts = dgvLichDiLam[1, i].Value.ToString();
                cmbChucVu.Text = dgvLichDiLam[2, i].Value.ToString();
                cmbCaLam.Text = dgvLichDiLam[3, i].Value.ToString();
                mskSDTNhanVien.Text = dgvLichDiLam[4, i].Value.ToString();
            }

        }

        
        private void btnThem_Click(object sender, EventArgs e)
        {
            //lichLamDTO.MaNV = txtMaNV.Texts;
            //SqlDataReader read = lichLamBUS.TimKiem(lichLamDTO.MaNV);
            //if (read.HasRows == true)
            //{
            //    MessageBox.Show(" Thất Bại Có Mã Nhân Viên Tồn Tại ", "Thông Báo");
            //}
            //else
            //{
            //    gan();
            //    lichLamBUS.Them(lichLamDTO);
            //    MessageBox.Show("Thành công", "thông báo ");
            //    dgvLichDiLam.Rows.Clear();
            //    loadNhanVien();
            //}
            if (cl.TextBoxRong(panel1)>=5)
            {
                gan();
                lichLamBUS.Them(lichLamDTO);
                MessageBox.Show("Thêm Thành công", "thông báo ");
                dgvLichDiLam.Rows.Clear();
                loadNhanVien();
            }
            else
            {
                MessageBox.Show("Bạn Cần Nhập Đủ Thông Tin", "Thông Báo");
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            gan();
            SqlDataReader read = lichLamBUS.Sua(lichLamDTO);
            if (read == null)
            {
                MessageBox.Show("Không có Người dùng nào có mã Này ", "Thông Báo");
            }
            else
            {
                MessageBox.Show(" Thành Công ", "Thông Báo");
                dgvLichDiLam.Rows.Clear();
                loadNhanVien();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc muốn xóa nhân viên có Mã là   " + txtMaNV.Texts, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl == DialogResult.OK)
            {
                lichLamDTO.MaNV = txtMaNV.Texts;
                lichLamDTO.TenNhanVien = txtTenNhanVien.Texts;
                SqlDataReader read = lichLamBUS.Xoa(lichLamDTO.MaNV,lichLamDTO.TenNhanVien);
                if (read == null)
                {
                    MessageBox.Show("Thất Bại", "Thông Báo");
                }
                else
                {
                    MessageBox.Show(" Thành Công ", "Thông Báo");
                    dgvLichDiLam.Rows.Clear();  
                    loadNhanVien();
                }
            }
        }

        private void mskSDTNhanVien_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskSDTNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Enabled = true;
            txtMaNV.Texts = "";
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
                if (ctrl is UserControlTexBox)
                {
                    (ctrl as UserControlTexBox).Text = "";
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlDataReader read = lichLamBUS.TimKiem(txtMaNV.Texts,txtTenNhanVien.Texts);
            dgvLichDiLam.Rows.Clear();
            while (read.Read())
            {
                dgvLichDiLam.Rows.Add(read[0], read[1], read[2], read[3], read[4], read[5], read[6]);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTangCa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
