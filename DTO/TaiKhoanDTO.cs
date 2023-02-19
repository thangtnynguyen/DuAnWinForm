using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANWINDOWFORM.DTO
{
    class TaiKhoanDTO
    {
        public string taikhoan;
        public string matkhau;
        public string matkhaumoi;
        public int per { get; set; }
        public TaiKhoanDTO()
        {
            this.taikhoan = "";
            this.matkhau = "";
            matkhaumoi = "";
            this.per = 3;
        }
    }
}
