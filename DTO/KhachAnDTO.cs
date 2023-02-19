using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANWINDOWFORM.DTO
{
    class KhachAnDTO
    {
        public string TenKhachHang;
        public string MaKhach;
        public double MucGia { get; set; }
        public double SoNguoiLon { get; set; }
        public double SoTreEm { get; set; }
        public string BanSo;
        public string SoDienThoai;
        public DateTime NgayThangDat { get; set; }
        public double TongTien { get; set; }
        public string ThanhToan;

        public KhachAnDTO(string TenKhachHang, double MucGia, double SoNguoiLon, double SoTreEm, string BanSo, string SoDienThoai, DateTime NgayThangDat, double TongTien, string MaKhach)
        {
            this.TenKhachHang = TenKhachHang;
            this.MucGia = MucGia;
            this.SoNguoiLon = SoNguoiLon;
            this.SoTreEm = SoTreEm;
            this.BanSo = BanSo;
            this.SoDienThoai = SoDienThoai;
            this.NgayThangDat = NgayThangDat;
            this.TongTien = TongTien;
            this.MaKhach = MaKhach;
        }
        public KhachAnDTO()
        {
            this.TenKhachHang = "";
            this.MucGia = 100;
            this.SoNguoiLon = 1;
            this.SoTreEm = 1;
            this.BanSo = "A1";
            this.SoDienThoai = "0988888888";
            //this.NgayThangDat = {11-11-2022''};
            this.TongTien = 0;
            this.MaKhach = "MK00";
            this.ThanhToan = "chua";
        }
    }
}

