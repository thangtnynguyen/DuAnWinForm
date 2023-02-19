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
namespace DOANWINDOWFORM
{
    public partial class frmBaoCaoChiTieu : Form
    {
        ClassLoad cl = new ClassLoad();
        public frmBaoCaoChiTieu()
        {
            InitializeComponent();
            
        }
        private void frmBaoCaoChiTieu_Load(object sender, EventArgs e)
        {
            crVBaoCaoDoNhap.ReportSource = null;
        }
        private void btnHienThi_Click(object sender, EventArgs e)
        {

            CryBaoCaoChiTieu chitieu = new CryBaoCaoChiTieu();
            chitieu.Refresh();
            CryBaoCaoLuongKhach khachhang = new CryBaoCaoLuongKhach();
            khachhang.Refresh();
            ((TextObject)chitieu.ReportDefinition.ReportObjects["txtNguoiLap"]).Text = txtNhanVienNhap.Text;
            ((TextObject)chitieu.ReportDefinition.ReportObjects["txtTongTien"]).Text = cl.TongTien("SELECT SUM(TongTien) FROM ThucPham") + "VNĐ";
            ((TextObject)khachhang.ReportDefinition.ReportObjects["txtNguoiLap"]).Text = txtNhanVienNhap.Text;
            ((TextObject)khachhang.ReportDefinition.ReportObjects["txtTongThu"]).Text = cl.TongTien("SELECT SUM(TongTien) FROM KhachAn") + "VNĐ";
            //crVBaoCaoDoNhap.ReportSource = cr;
            crVBaoCaoDoNhap.RefreshReport();
            if (cmbBaoCao.SelectedIndex == 0)
            {
                crVBaoCaoDoNhap.Refresh();
                crVBaoCaoDoNhap.ReportSource = khachhang;
            }
            if (cmbBaoCao.SelectedIndex == 1)
            {
                crVBaoCaoDoNhap.Refresh();
                crVBaoCaoDoNhap.ReportSource = chitieu;
            } 
        }
    }
}
