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
    public partial class frmDanhGia : Form
    {
        private readonly PhanHoiKhachHangBUS phanHoiKhachHangBUS = new PhanHoiKhachHangBUS();
        ClassLoad cl = new ClassLoad();
        private readonly PhanHoiKhachHangDTO phanHoiKhachHangDTO = new PhanHoiKhachHangDTO();
        public frmDanhGia()
        {
            InitializeComponent();
        }
        void gan()
        {
            phanHoiKhachHangDTO.ChatLuongMonAn = cl.KiemTraRadio(rdoRatTot, rdoTot, rdoTe, rdoRatTe);
            phanHoiKhachHangDTO.ChatLuongPhucVu = cl.KiemTraRadio(rdoRTot, rdoTott, rdoTee, rdoRTe);
            phanHoiKhachHangDTO.PhanHoi = txtDanhGia.Text;
        }
        private void btnGuiPhanHoi_Click(object sender, EventArgs e)
        {
           
            gan();
            SqlDataReader read = phanHoiKhachHangBUS.Them(phanHoiKhachHangDTO);
            MessageBox.Show("Bạn đã gửi phản hồi thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void frmDanhGia_Load(object sender, EventArgs e)
        {

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
