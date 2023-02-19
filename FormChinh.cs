using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANWINDOWFORM
{
    public partial class frmChinh : Form
    {
        static bool buttonshowHeThong = false;



        private string tk;
        private int code;
        public frmChinh()
        {
            InitializeComponent();
        }
        public frmChinh(string TK,int code)
        {
            InitializeComponent();
            this.tk = TK;
            this.code = code;
        }
        private void frmChinh_Load(object sender, EventArgs e)
        {
            anButtonAdmin();
            AnButton();
            PhanQuyen();
        }
        private void AnButton()
        {
            classButtonHTThoat.Visible = false;
            classButtonHTDoiMk.Visible = false;
            classButtonTDCacMonAn.Visible = false;
            classButtonDBDatBan.Visible = false;
            classButtonDGVietDanhGia.Visible = false;
            classButtonTGTuVanKhachHang.Visible = false;
            classButtonTGBaoLoi.Visible = false;
            //AnMat(pnlNguoiDung);
            //AnMat(pnlTacVuNguoiDung);


        }
        private void classButton21_Click(object sender, EventArgs e)
        {
            if (!buttonshowHeThong)
            {
                classButtonHTThoat.Visible = true;
                classButtonHTDoiMk.Visible = true;
                buttonshowHeThong = !buttonshowHeThong;
            }
            else
            {
                buttonshowHeThong = !buttonshowHeThong;
                classButtonHTThoat.Visible = false;
                classButtonHTDoiMk.Visible = false;
            }
        }

        

        private void classButtonThucDon_Click(object sender, EventArgs e)
        {
            AnButton();
            //showquanly
            if (!buttonshowHeThong)
            {
                classButtonTDCacMonAn.Visible = true;
                buttonshowHeThong = !buttonshowHeThong;
            }
            else
            {
                buttonshowHeThong = !buttonshowHeThong;
                classButtonTDCacMonAn.Visible = false;
            }
        }

        private void classButton111_Click(object sender, EventArgs e)
        {
            AnButton();
            //showquanly
            if (!buttonshowHeThong)
            {
                classButtonDBDatBan.Visible = true;
                buttonshowHeThong = !buttonshowHeThong;
            }
            else
            {
                buttonshowHeThong = !buttonshowHeThong;
                classButtonDBDatBan.Visible = false;
            }
        }

        private void classButtonDanhGia_Click(object sender, EventArgs e)
        {
            AnButton();
            //showquanly
            if (!buttonshowHeThong)
            {
                classButtonDGVietDanhGia.Visible = true;
                buttonshowHeThong = !buttonshowHeThong;
            }
            else
            {
                buttonshowHeThong = !buttonshowHeThong;
                classButtonDGVietDanhGia.Visible = false;
            }
        }

        private void classButtonTroGiup_Click(object sender, EventArgs e)
        {
            AnButton();
            //showquanly
            if (!buttonshowHeThong)
            {
                classButtonTGTuVanKhachHang.Visible = true;
                classButtonTGBaoLoi.Visible = true;
                buttonshowHeThong = !buttonshowHeThong;
            }
            else
            {
                buttonshowHeThong = !buttonshowHeThong;
                classButtonTGTuVanKhachHang.Visible = false;
                classButtonTGBaoLoi.Visible = false;
            }
        }
        private void anButtonAdmin()
        {
            classButtonHThongDMK.Visible = false;
            classButtonHTThoatAdmin.Visible = false;
            classButtonQLBanDat.Visible = false;
            classButtonQLNhanVien.Visible = false;
            classButtonQLThucPham.Visible = false;
            classButtonQLKhach.Visible = false;
            classButtonHDBillThanhToan.Visible = false;
            classButtonHDHoaDonThanhToan.Visible = false;
            classButtonPHDanhGiaCuaKhach.Visible = false;
            classButtonPHChamSocKhach.Visible = false;
            classButtonThongKeChiTieu.Visible = false;
            //AnMat(pnlTacVuAdmin);
            //AnMat(pnlAdmin);
        }
        private void classButtonHoaDon_Click(object sender, EventArgs e)
        {
            anButtonAdmin();
            if (!buttonshowHeThong)
            {
                classButtonHDBillThanhToan.Visible = true;
                classButtonHDHoaDonThanhToan.Visible = true;
                buttonshowHeThong = !buttonshowHeThong;
            }
            else
            {
                buttonshowHeThong = !buttonshowHeThong;
                classButtonHDBillThanhToan.Visible = false;
                classButtonHDHoaDonThanhToan.Visible = false;
            }
        }

        private void classButtonBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            anButtonAdmin();
            if (!buttonshowHeThong)
            {
                classButtonThongKeChiTieu.Visible = true;
                buttonshowHeThong = !buttonshowHeThong;
            }
            else
            {
                buttonshowHeThong = !buttonshowHeThong;
                classButtonThongKeChiTieu.Visible = false;
            }
        }

        private void classButtonPhanHoiKhachHang_Click(object sender, EventArgs e)
        {
            anButtonAdmin();
            if (!buttonshowHeThong)
            {
                classButtonPHDanhGiaCuaKhach.Visible = true;
                classButtonPHChamSocKhach.Visible = true;
                buttonshowHeThong = !buttonshowHeThong;
            }
            else
            {
                buttonshowHeThong = !buttonshowHeThong;
                classButtonPHDanhGiaCuaKhach.Visible = false;
                classButtonPHChamSocKhach.Visible = false;
            }
        }

        private void classButtonQL_Click(object sender, EventArgs e)
        {
            //anhethong
            anButtonAdmin();
            //showquanly
            if (!buttonshowHeThong)
            {
                classButtonQLBanDat.Visible = true;
                classButtonQLNhanVien.Visible = true;
                classButtonQLThucPham.Visible = true;
                classButtonQLKhach.Visible = true;
                buttonshowHeThong = !buttonshowHeThong;
            }
            else
            {
                buttonshowHeThong = !buttonshowHeThong;
                classButtonQLBanDat.Visible = false;
                classButtonQLNhanVien.Visible = false;
                classButtonQLThucPham.Visible = false;
                classButtonQLKhach.Visible = false;
            }     
        }
        private void classButtonHeThongAdmin_Click(object sender, EventArgs e)
        {
            anButtonAdmin();
            if (!buttonshowHeThong)
            {
                classButtonHThongDMK.Visible = true;
                classButtonHTThoatAdmin.Visible = true;
                buttonshowHeThong = !buttonshowHeThong;
            }
            else
            {
                buttonshowHeThong = !buttonshowHeThong;
                classButtonHThongDMK.Visible = false;
                classButtonHTThoatAdmin.Visible = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pnlNguoiDung.Visible = false;
            AnMat(pnlNguoiDung);
            pnlAdmin.Dock = DockStyle.Left;
        }
        private void PhanQuyen()
        {
            //nguoidung
            if (this.code == 0)
            {
                pnlAdmin.Visible = false;
                pnlTacVuAdmin.Visible = false;
                AnMat(pnlTacVuAdmin);
                AnMat(pnlAdmin);
            }
            //admin
            else
            {
                if (this.code == 1)
                {
                    pnlNguoiDung.Visible = false;
                    pnlTacVuNguoiDung.Visible = false;
                    AnMat(pnlNguoiDung);
                    AnMat(pnlTacVuNguoiDung);
                    pnlAdmin.Dock = DockStyle.Left;
                    pnlTacVuAdmin.Dock = DockStyle.Left;

                }
            }
        }
        private void AnMat(Control ctr)
        {
            foreach (Control ctrl in ctr.Controls)
            {
                if (ctrl is ClassButton)
                {
                    (ctrl as ClassButton).Visible = false;
                }
            }
        }
        private void An(Control ctr)
        {
            foreach (Control ctrl in ctr.Controls)
            {
                if (ctrl is ClassButton)
                {
                    (ctrl as ClassButton).Enabled = false;
                }
            }
        }
        private void Hien(Control ctr)
        {
            foreach (Control ctrl in ctr.Controls)
            {
                if (ctrl is ClassButton)
                {
                    (ctrl as ClassButton).Visible = true;
                }
            }
        }
        private void classButtonHTThoat_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau fr = new frmDoiMatKhau(tk);
            this.Hide();
            fr.ShowDialog();
            this.Show();

        }


        private void classButtonHTDoiMk_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void classButtonDBDatBan_Click(object sender, EventArgs e)
        {
            frmDatBan fr = new frmDatBan();
            this.Hide();
            fr.ShowDialog();
            this.Show(); ;
        }
        private void classButtonDGVietDanhGia_Click(object sender, EventArgs e)
        {
            frmDanhGia fr = new frmDanhGia();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }

        private void classButtonTDCacMonAn_Click(object sender, EventArgs e)
        {
            frmCacMonAn fr = new frmCacMonAn();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }
        private void classButtonTGBaoLoi_Click(object sender, EventArgs e)
        {
            frmBaoLoi fr = new frmBaoLoi();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }

        private void classButtonHThongDMK_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau fr = new frmDoiMatKhau(tk);
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }

        private void classButtonHTThoatAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void classButtonQLKhach_Click(object sender, EventArgs e)
        {
            frmKhachAn fr = new frmKhachAn();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }

        private void classButtonQLBanDat_Click(object sender, EventArgs e)
        {
            frmKhachDat fr = new frmKhachDat();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }

        private void classButtonQLNhanVien_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien fr = new frmQuanLyNhanVien();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }
        private void classButtonQLThucPham_Click(object sender, EventArgs e)
        {
            frmQLDoNhap fr = new frmQLDoNhap();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }

        private void classButtonHDBillThanhToan_Click(object sender, EventArgs e)
        {
            frmBill fr = new frmBill();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }

        private void classButtonThongKeChiTieu_Click(object sender, EventArgs e)
        {
            frmBaoCaoChiTieu fr = new frmBaoCaoChiTieu();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }

        private void classButtonPHDanhGiaCuaKhach_Click(object sender, EventArgs e)
        {
            frmDanhGiaCuaKhachHang fr = new frmDanhGiaCuaKhachHang();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }

        private void classButtonTGTuVanKhachHang_Click(object sender, EventArgs e)
        {
            frmTuVanKhachHang fr = new frmTuVanKhachHang();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        /*if (this.code == 0)
   {
       quảnLýToolStripMenuItem.Visible = false;
       hóaĐơnToolStripMenuItem.Visible = false;
       tìmKiếmKháchHàngToolStripMenuItem.Visible = false;
       báoCáoThốngKêToolStripMenuItem.Visible = false;
       trợGiúpToolStripMenuItem.Visible = false;
   }
   //admin
   else
   {
       if (this.code == 1)
       {
           thựcĐơnToolStripMenuItem.Visible = false;
           đánhGiáPhảnHồiToolStripMenuItem.Visible = false;
           đặtBànToolStripMenuItem.Visible = false;
           trợGiúppToolStripMenuItem1.Visible = false;

       }
   }*/

    }
}
