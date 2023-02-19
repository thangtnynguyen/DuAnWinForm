
namespace DOANWINDOWFORM
{
    partial class frmDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtMatKhau2 = new DOANWINDOWFORM.UserControlTexBox();
            this.clsĐangKi = new DOANWINDOWFORM.ClassButton();
            this.txtTaiKhoan2 = new DOANWINDOWFORM.UserControlTexBox();
            this.clsDangNhap = new DOANWINDOWFORM.ClassButton();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lblDangNhapp = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.txtMatKhau2);
            this.panel1.Controls.Add(this.clsĐangKi);
            this.panel1.Controls.Add(this.txtTaiKhoan2);
            this.panel1.Controls.Add(this.clsDangNhap);
            this.panel1.Controls.Add(this.lblDangNhapp);
            this.panel1.Controls.Add(this.lblMatKhau);
            this.panel1.Controls.Add(this.lblTaiKhoan);
            this.panel1.Controls.Add(this.btnDangNhap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 450);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(209, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 19;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.Color.Blue;
            this.checkBox1.Location = new System.Drawing.Point(153, 286);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(147, 21);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Hiển Thị Mật Khẩu";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtMatKhau2
            // 
            this.txtMatKhau2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtMatKhau2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMatKhau2.BorderSize = 2;
            this.txtMatKhau2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau2.ForeColor = System.Drawing.Color.DimGray;
            this.txtMatKhau2.Location = new System.Drawing.Point(209, 204);
            this.txtMatKhau2.Multiline = false;
            this.txtMatKhau2.Name = "txtMatKhau2";
            this.txtMatKhau2.Padding = new System.Windows.Forms.Padding(7);
            this.txtMatKhau2.PasswordChar = true;
            this.txtMatKhau2.Size = new System.Drawing.Size(194, 33);
            this.txtMatKhau2.TabIndex = 1;
            this.txtMatKhau2.Texts = "";
            this.txtMatKhau2.UnderlineStyle = true;
            // 
            // clsĐangKi
            // 
            this.clsĐangKi.BackColor = System.Drawing.Color.RosyBrown;
            this.clsĐangKi.BackgrondColor = System.Drawing.Color.RosyBrown;
            this.clsĐangKi.BorderColor = System.Drawing.Color.Aqua;
            this.clsĐangKi.BorderRadios = 20;
            this.clsĐangKi.BorderSize = 100;
            this.clsĐangKi.FlatAppearance.BorderSize = 0;
            this.clsĐangKi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clsĐangKi.ForeColor = System.Drawing.Color.White;
            this.clsĐangKi.Location = new System.Drawing.Point(325, 348);
            this.clsĐangKi.Name = "clsĐangKi";
            this.clsĐangKi.Size = new System.Drawing.Size(94, 40);
            this.clsĐangKi.TabIndex = 4;
            this.clsĐangKi.Text = "Đăng Kí";
            this.clsĐangKi.TextColor = System.Drawing.Color.White;
            this.clsĐangKi.UseVisualStyleBackColor = false;
            this.clsĐangKi.Click += new System.EventHandler(this.clsĐangKi_Click_1);
            // 
            // txtTaiKhoan2
            // 
            this.txtTaiKhoan2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtTaiKhoan2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTaiKhoan2.BorderSize = 2;
            this.txtTaiKhoan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan2.ForeColor = System.Drawing.Color.DimGray;
            this.txtTaiKhoan2.Location = new System.Drawing.Point(209, 144);
            this.txtTaiKhoan2.Multiline = false;
            this.txtTaiKhoan2.Name = "txtTaiKhoan2";
            this.txtTaiKhoan2.Padding = new System.Windows.Forms.Padding(7);
            this.txtTaiKhoan2.PasswordChar = false;
            this.txtTaiKhoan2.Size = new System.Drawing.Size(194, 33);
            this.txtTaiKhoan2.TabIndex = 0;
            this.txtTaiKhoan2.Texts = "";
            this.txtTaiKhoan2.UnderlineStyle = true;
            this.txtTaiKhoan2._TextChanged += new System.EventHandler(this.txtTaiKhoan2__TextChanged);
            // 
            // clsDangNhap
            // 
            this.clsDangNhap.BackColor = System.Drawing.Color.RosyBrown;
            this.clsDangNhap.BackgrondColor = System.Drawing.Color.RosyBrown;
            this.clsDangNhap.BorderColor = System.Drawing.Color.RosyBrown;
            this.clsDangNhap.BorderRadios = 20;
            this.clsDangNhap.BorderSize = 10;
            this.clsDangNhap.FlatAppearance.BorderSize = 0;
            this.clsDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clsDangNhap.ForeColor = System.Drawing.Color.White;
            this.clsDangNhap.Location = new System.Drawing.Point(130, 348);
            this.clsDangNhap.Name = "clsDangNhap";
            this.clsDangNhap.Size = new System.Drawing.Size(93, 40);
            this.clsDangNhap.TabIndex = 3;
            this.clsDangNhap.Text = "Đăng Nhập";
            this.clsDangNhap.TextColor = System.Drawing.Color.White;
            this.clsDangNhap.UseVisualStyleBackColor = false;
            this.clsDangNhap.Click += new System.EventHandler(this.clsDangNhap_Click_1);
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lblMatKhau.ForeColor = System.Drawing.Color.Blue;
            this.lblMatKhau.Location = new System.Drawing.Point(92, 220);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(72, 17);
            this.lblMatKhau.TabIndex = 17;
            this.lblMatKhau.Text = "Mật Khẩu:";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lblTaiKhoan.ForeColor = System.Drawing.Color.Blue;
            this.lblTaiKhoan.Location = new System.Drawing.Point(95, 158);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(77, 17);
            this.lblTaiKhoan.TabIndex = 16;
            this.lblTaiKhoan.Text = "Tài Khoản:";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnDangNhap.ForeColor = System.Drawing.Color.Red;
            this.btnDangNhap.Location = new System.Drawing.Point(471, 0);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(53, 29);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "X";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // lblDangNhapp
            // 
            this.lblDangNhapp.AutoSize = true;
            this.lblDangNhapp.BackColor = System.Drawing.Color.Transparent;
            this.lblDangNhapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangNhapp.ForeColor = System.Drawing.Color.Blue;
            this.lblDangNhapp.Image = global::DOANWINDOWFORM.Properties.Resources.iconnguoi_32;
            this.lblDangNhapp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDangNhapp.Location = new System.Drawing.Point(148, 61);
            this.lblDangNhapp.Name = "lblDangNhapp";
            this.lblDangNhapp.Size = new System.Drawing.Size(271, 29);
            this.lblDangNhapp.TabIndex = 18;
            this.lblDangNhapp.Text = "    Đăng Nhập\\Đăng Kí";
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.clsDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.CheckBox checkBox1;
        private UserControlTexBox txtMatKhau2;
        private ClassButton clsĐangKi;
        private UserControlTexBox txtTaiKhoan2;
        private ClassButton clsDangNhap;
        private System.Windows.Forms.Label lblDangNhapp;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label label1;
    }
}