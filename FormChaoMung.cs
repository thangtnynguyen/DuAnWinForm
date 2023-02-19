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
    public partial class frmGioiThieu : Form
    {
        public frmGioiThieu()
        {
            InitializeComponent();
        }

        private void btnVaoHeThong_Click(object sender, EventArgs e)
        {
            frmDangNhap fr = new frmDangNhap();
            this.Hide();
            fr.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
