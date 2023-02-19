using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANWINDOWFORM.DTO
{
    class ThucPhamDTO
    {
        public string TenSP;
        public string MaSP;
        public string MoTa;
        public double SoLuong { get; set; }
        public double DonGia { get; set; }
        public double TongTien { get; set; }
        public string MaLoai;
        public DateTime NgayThang;
        public ThucPhamDTO()
        {
            this.TenSP = "";
            this.MaSP = "";
            this.MoTa = "";
            this.SoLuong = 1;
            this.MaLoai = "";
            this.DonGia = 0;
            this.TongTien = 0;
        }
    }
}
