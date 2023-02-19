using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANWINDOWFORM.DTO
{
    class DatBanDTO
    {
        public string TenKhachHang;
        public double MucGia { get; set; }
        public double SoNguoiLon { get; set; }
        public double SoTreEm { get; set; }
        public string BanSo;
        public string SoDienThoai;
        public string NgayThangDat { get; set; }
        public string GioDat;

      
        public DatBanDTO()
        {
            this.TenKhachHang = "";
            this.MucGia = 100;
            this.SoNguoiLon = 1;
            this.SoTreEm = 1;
            this.BanSo = "";
            this.SoDienThoai = "0000000000";
            this.NgayThangDat = "11/11/2022";
            this.GioDat = "";
        }
    }
}
