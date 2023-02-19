using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANWINDOWFORM.DTO
{
    class LichLamDTO
    {
        public string MaNV;
        public string TenNhanVien;
        public string ChucVu;
        public string SoDienThoai;
        public string GioLam;
        public string TangCa;
        public double Luong;
        public DateTime NgayThang;
        public LichLamDTO()
        {
            this.MaNV = "";
            this.TenNhanVien = "";
            this.ChucVu = "";
            this.SoDienThoai = "";
            this.GioLam = "";
            this.TangCa = "0";
            this.Luong = 0;
            //this.NgayThang =
        }
    }
}
