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
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports.Engine.Migration;
using DOANWINDOWFORM.BUS;
using DOANWINDOWFORM.DTO;
namespace DOANWINDOWFORM
{
    public partial class frmBill : Form
    {
        KhachAnBUS khachAnBUS = new KhachAnBUS();
        ClassLoad cl = new ClassLoad();
        BanBUS banBUS = new BanBUS();
        BanDTO banDTO = new BanDTO();
        public frmBill()
        {
            InitializeComponent();
        }

 
        public void load()
        {
            SqlDataReader read = khachAnBUS.TimKiemBanThanhToan("ChuaThanhToan");
            while (read.Read())
            {
                dgvBanChuaThanhToan.Rows.Add(read[0]);
            }
            SqlDataReader readd = khachAnBUS.TimKiemBanThanhToan("DaThanhToan");
            while (readd.Read())
            {
                dgvBanDaThanhToan.Rows.Add(readd[0]);
            }
        }
        private void FormBill_Load(object sender, EventArgs e)
        {
            load();
            cl.loadban(cmbBan, "Select * from Ban",1);
            cl.loadban(cmbNhanVien, "Select * from LichLamDung",1);
        }
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            SqlDataReader read = khachAnBUS.TimKiemBan(cmbBan.Text);
            if (read.HasRows != true)
            {

                MessageBox.Show(" Không Có Khách Tại Bàn ", "Thông Báo");
            }
            else
            {
                double TienLon = double.Parse(cl.TongTien("SELECT SoNguoiLon FROM KhachAn WHERE BanSo like '%" + cmbBan.Text + "%'"));
                double Gia = double.Parse(cl.TongTien("SELECT MucGia FROM KhachAn WHERE BanSo like '%" + cmbBan.Text + "%'"));
                double TienNho = double.Parse(cl.TongTien("SELECT SoTreEm FROM KhachAn WHERE BanSo like '%" + cmbBan.Text + "%'"));
                CryBill bill = new CryBill();
                cryBiLLL.ReportSource = bill;
                //textBox1.Text = TongTien("SELECT TenKhachHang FROM KhachAn WHERE BanSo like '%" + cmbBan.Text + "%'");
                ((TextObject)bill.ReportDefinition.ReportObjects["txtTenKhach"]).Text = cl.TongTien("SELECT TenKhachHang FROM KhachAn WHERE BanSo like '%" + cmbBan.Text + "%'");
                ((TextObject)bill.ReportDefinition.ReportObjects["txtMucGia"]).Text = cl.TongTien("SELECT MucGia FROM KhachAn WHERE BanSo like '%" + cmbBan.Text + "%'");
                ((TextObject)bill.ReportDefinition.ReportObjects["txtLon"]).Text = cl.TongTien("SELECT SoNguoiLon FROM KhachAn WHERE BanSo like '%" + cmbBan.Text + "%'");
                ((TextObject)bill.ReportDefinition.ReportObjects["txtNho"]).Text = cl.TongTien("SELECT SoTreEm FROM KhachAn WHERE BanSo like '%" + cmbBan.Text + "%'");
                ((TextObject)bill.ReportDefinition.ReportObjects["txtBan"]).Text = cl.TongTien("SELECT BanSo FROM KhachAn WHERE BanSo like '%" + cmbBan.Text + "%'");
                ((TextObject)bill.ReportDefinition.ReportObjects["txtTienLon"]).Text = (TienLon * Gia).ToString();
                ((TextObject)bill.ReportDefinition.ReportObjects["txtTienNho"]).Text = (TienNho * Gia * 0.3).ToString();
                ((TextObject)bill.ReportDefinition.ReportObjects["txtTongTien"]).Text = (TienNho * Gia * 0.3 + TienLon * Gia).ToString() + "K VNĐ";
                ((TextObject)bill.ReportDefinition.ReportObjects["txtNhanVien"]).Text = cmbNhanVien.Text;
            }
        }

        private void btnXacNhanThanhToan_Click(object sender, EventArgs e)
        {
            SqlDataReader read = khachAnBUS.TimKiemBan(cmbBan.Text);
            if (read.HasRows)
            {
                SqlDataReader readdd = khachAnBUS.ChotThanhToan(cmbBan.Text);
                banDTO.BanKin = "no";
                banDTO.BanSo = cmbBan.Text;
                banBUS.Sua(banDTO);
                MessageBox.Show("Đã xác Nhận Thanh Toán Bàn " + cmbBan.Text);

            }
            else
            {
                MessageBox.Show("Bàn này đã thanh toán rồi");
            }
            dgvBanChuaThanhToan.Rows.Clear();
            dgvBanDaThanhToan.Rows.Clear();
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
