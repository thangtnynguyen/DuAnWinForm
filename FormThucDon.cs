using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOANWINDOWFORM.BUS;
namespace DOANWINDOWFORM
{
    public partial class frmCacMonAn : Form
    {
        MucGiaCBUS mucGiaBUS = new MucGiaCBUS();
        public frmCacMonAn()
        {
            InitializeComponent();
        }

      

        private void frmCacMonAn_Load(object sender, EventArgs e)
        {
            mucGiaBUS.loadcbb(cmbMucGia);
        }

        private void cmbMucGia_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            switch (cmbMucGia.SelectedIndex)
            {
                case 0:
                    {
                        listView1.Items[0].ImageIndex = 0;
                        listView1.Items[1].ImageIndex = 1;
                        listView1.Items[2].ImageIndex = 2;
                        listView1.Items[3].ImageIndex = 3;
                        listView1.Items[4].ImageIndex = 4;
                        listView1.Items[5].ImageIndex = 20;
                        listView1.Items[0].Text = "Bạch Tuộc";
                        listView1.Items[1].Text = "Mực  ";
                        listView1.Items[2].Text = "Ức Gà";
                        listView1.Items[3].Text = "Chân Gà";
                        listView1.Items[4].Text = "Ghẹ ";
                        listView1.Items[5].Text = "Cua ";
                        break;
                    }
                case 1:
                    {
                        listView1.Items[0].ImageIndex = 5;
                        listView1.Items[1].ImageIndex = 6;
                        listView1.Items[2].ImageIndex = 7;
                        listView1.Items[3].ImageIndex = 8;
                        listView1.Items[4].ImageIndex = 9;
                        listView1.Items[5].ImageIndex = 21;
                        listView1.Items[0].Text = "Tôm";
                        listView1.Items[1].Text = "Cá Chép   ";
                        listView1.Items[2].Text = "Cá Basa";
                        listView1.Items[3].Text = "Bò Base";
                        listView1.Items[4].Text = "Bò Cuộn ";
                        listView1.Items[5].Text = "Gầu Bò ";
                        label3.Text = "Và Bao Gồm Các Món Của Mức Giá Trước";
                        break;
                    }
                case 2:
                    {
                        listView1.Items[0].ImageIndex = 10;
                        listView1.Items[1].ImageIndex = 11;
                        listView1.Items[2].ImageIndex = 12;
                        listView1.Items[3].ImageIndex = 13;
                        listView1.Items[4].ImageIndex = 14;
                        listView1.Items[5].ImageIndex = 22;
                        listView1.Items[0].Text = "Hùa ";
                        listView1.Items[1].Text = "Bắp Bò  ";
                        listView1.Items[2].Text = "Nầm ";
                        listView1.Items[3].Text = " Sườn Non";
                        listView1.Items[4].Text = "Lạc Vai Lợn ";
                        listView1.Items[5].Text = "Cổ Lợn  ";
                        label3.Text = "Và Bao Gồm Các Món Của Mức Giá Trước";
                        break;
                    }
                case 3:
                    {
                        listView1.Items[0].ImageIndex = 15;
                        listView1.Items[1].ImageIndex = 16;
                        listView1.Items[2].ImageIndex = 17;
                        listView1.Items[3].ImageIndex = 18;
                        listView1.Items[4].ImageIndex = 19;
                        listView1.Items[5].ImageIndex = 23;
                        listView1.Items[0].Text = "Lưỡi Lợn ";
                        listView1.Items[1].Text = "Bắp Lợn  ";
                        listView1.Items[2].Text = "Gầu Lợn  ";
                        listView1.Items[3].Text = " Ngao ";
                        listView1.Items[4].Text = "Chim   ";
                        listView1.Items[5].Text = "Ghẹ  ";
                        label3.Text = "Và Bao Gồm Các Món Của Mức Giá Trước";
                        break;
                    }

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
