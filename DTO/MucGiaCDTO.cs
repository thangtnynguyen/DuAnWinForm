using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANWINDOWFORM.DTO
{
    class MucGiaCDTO
    {
        public int MucGia { get; set; }
        public int SoMon { get; set; }
        public string GomCo;
        public MucGiaCDTO()
        {
            this.MucGia = 0;
            this.SoMon = 0;
            this.GomCo = "";
        }
    }
}
