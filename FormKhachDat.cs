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
    public partial class frmKhachDat : Form
    {
        DatBanBUS datBanBUS = new DatBanBUS();
        DatBanDTO datBanDTO = new DatBanDTO();
        public frmKhachDat()
        {
            InitializeComponent();
        }

        
        private void FormKhachDat_Load(object sender, EventArgs e)
        {   
            load();
        }
        public void load()
        {
            SqlDataReader read = datBanBUS.HienThi();
            while (read.Read())
            {
                dgvThongTinKhachDat.Rows.Add(read[0], read[1], read[2], read[3], read[4], read[5], read[6], read[7]);
            }
        }
        void gan()
        {
            datBanDTO.NgayThangDat = mskChonNgay.Text;
        }


        private void btnHienThiTheoNgay_Click(object sender, EventArgs e)
        {
            gan();
            SqlDataReader read = datBanBUS.TimKiem(datBanDTO.NgayThangDat);
            if (read.HasRows != true)
            {

                MessageBox.Show(" Thất Bại", "Thông Báo");
            }
            else
            {
                SqlDataReader readd = datBanBUS.TimKiem(datBanDTO.NgayThangDat);
                dgvThongTinKhachDat.Rows.Clear();
                while (readd.Read())
                {
                    dgvThongTinKhachDat.Rows.Add(readd[0], readd[1], readd[2], readd[3], readd[4], readd[5], readd[6], readd[7]);
                }
               
                
            }
        }

        private void btnXoaDonNgay_Click_1(object sender, EventArgs e)
        {
            DialogResult  dl = MessageBox.Show("Bạn có chắc muốn xóa đơn đặt ngày  " + mskChonNgay.Text, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl ==DialogResult.OK)
            {
                gan();
                SqlDataReader read = datBanBUS.TimKiem(datBanDTO.NgayThangDat);
                if (read.HasRows != true)
                {

                    MessageBox.Show(" Thất Bại", "Thông Báo");
                }
                else
                {
                    datBanBUS.Xoa(datBanDTO.NgayThangDat);
                    MessageBox.Show("Xóa Thành công", "thông báo ");
                    dgvThongTinKhachDat.Rows.Clear();
                    load();
                }
            }   
        }

        private void btnXoaDuLieu_Click_1(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn chắc muốn xóa ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            switch (DialogResult)
            {
                case DialogResult.OK:
                    datBanBUS.XoaAll();
                    MessageBox.Show("Thành công", "thông báo ");
                    dgvThongTinKhachDat.Rows.Clear();
                    load();
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void btnHienThiAll_Click(object sender, EventArgs e)
        {
            load();
        }

        private void dgvThongTinKhachDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (dgvThongTinKhachDat.CurrentCell == null || dgvThongTinKhachDat.CurrentCell.Value == null)
            {
                i = -1;
            }
            if (i != -1)
            {
                mskChonNgay.Text = dgvThongTinKhachDat[6, i].Value.ToString();
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
