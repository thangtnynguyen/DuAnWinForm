
namespace DOANWINDOWFORM
{
    partial class frmBaoCaoChiTieu
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
            this.lblDuLieuMuonIn = new System.Windows.Forms.Label();
            this.cmbBaoCao = new System.Windows.Forms.ComboBox();
            this.txtNhanVienNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.crVBaoCaoDoNhap = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CryBaoCaoLuongKhach3 = new DOANWINDOWFORM.CryBaoCaoLuongKhach();
            this.CryBaoCaoLuongKhach2 = new DOANWINDOWFORM.CryBaoCaoLuongKhach();
            this.CryBaoCaoLuongKhach1 = new DOANWINDOWFORM.CryBaoCaoLuongKhach();
            this.CryBaoCaoChiTieu1 = new DOANWINDOWFORM.CryBaoCaoChiTieu();
            this.CryBaoCaoChiTieu2 = new DOANWINDOWFORM.CryBaoCaoChiTieu();
            this.CryBaoCaoChiTieu3 = new DOANWINDOWFORM.CryBaoCaoChiTieu();
            this.CryBaoCaoChiTieu4 = new DOANWINDOWFORM.CryBaoCaoChiTieu();
            this.CryBaoCaoChiTieu5 = new DOANWINDOWFORM.CryBaoCaoChiTieu();
            this.btnHienThi = new DOANWINDOWFORM.ClassButton();
            this.SuspendLayout();
            // 
            // lblDuLieuMuonIn
            // 
            this.lblDuLieuMuonIn.AutoSize = true;
            this.lblDuLieuMuonIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuLieuMuonIn.ForeColor = System.Drawing.Color.Black;
            this.lblDuLieuMuonIn.Location = new System.Drawing.Point(703, 97);
            this.lblDuLieuMuonIn.Name = "lblDuLieuMuonIn";
            this.lblDuLieuMuonIn.Size = new System.Drawing.Size(121, 20);
            this.lblDuLieuMuonIn.TabIndex = 2;
            this.lblDuLieuMuonIn.Text = "Báo Cáo Về :";
            // 
            // cmbBaoCao
            // 
            this.cmbBaoCao.ForeColor = System.Drawing.Color.Black;
            this.cmbBaoCao.FormattingEnabled = true;
            this.cmbBaoCao.Items.AddRange(new object[] {
            "Báo Cáo Thu Nhập",
            "Báo Cáo Chi Tiêu"});
            this.cmbBaoCao.Location = new System.Drawing.Point(846, 93);
            this.cmbBaoCao.Name = "cmbBaoCao";
            this.cmbBaoCao.Size = new System.Drawing.Size(121, 24);
            this.cmbBaoCao.TabIndex = 3;
            // 
            // txtNhanVienNhap
            // 
            this.txtNhanVienNhap.ForeColor = System.Drawing.Color.Black;
            this.txtNhanVienNhap.Location = new System.Drawing.Point(846, 218);
            this.txtNhanVienNhap.Name = "txtNhanVienNhap";
            this.txtNhanVienNhap.Size = new System.Drawing.Size(121, 22);
            this.txtNhanVienNhap.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(703, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhân Viên :";
            // 
            // crVBaoCaoDoNhap
            // 
            this.crVBaoCaoDoNhap.ActiveViewIndex = 0;
            this.crVBaoCaoDoNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.crVBaoCaoDoNhap.AutoScroll = true;
            this.crVBaoCaoDoNhap.Cursor = System.Windows.Forms.Cursors.Default;
            this.crVBaoCaoDoNhap.Location = new System.Drawing.Point(12, 12);
            this.crVBaoCaoDoNhap.Name = "crVBaoCaoDoNhap";
            this.crVBaoCaoDoNhap.ReportSource = this.CryBaoCaoLuongKhach3;
            this.crVBaoCaoDoNhap.Size = new System.Drawing.Size(607, 558);
            this.crVBaoCaoDoNhap.TabIndex = 4;
            // 
            // btnHienThi
            // 
            this.btnHienThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHienThi.BackgrondColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHienThi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHienThi.BorderColor = System.Drawing.Color.Blue;
            this.btnHienThi.BorderRadios = 2;
            this.btnHienThi.BorderSize = 1;
            this.btnHienThi.FlatAppearance.BorderSize = 0;
            this.btnHienThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienThi.ForeColor = System.Drawing.Color.Black;
            this.btnHienThi.Image = global::DOANWINDOWFORM.Properties.Resources.icontimkiem_32;
            this.btnHienThi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHienThi.Location = new System.Drawing.Point(707, 344);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(260, 40);
            this.btnHienThi.TabIndex = 29;
            this.btnHienThi.Text = "Hiển Thị";
            this.btnHienThi.TextColor = System.Drawing.Color.Black;
            this.btnHienThi.UseVisualStyleBackColor = false;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // frmBaoCaoChiTieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1050, 582);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNhanVienNhap);
            this.Controls.Add(this.crVBaoCaoDoNhap);
            this.Controls.Add(this.cmbBaoCao);
            this.Controls.Add(this.lblDuLieuMuonIn);
            this.Name = "frmBaoCaoChiTieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBaoCaoChiTieu";
            this.Load += new System.EventHandler(this.frmBaoCaoChiTieu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDuLieuMuonIn;
        private System.Windows.Forms.ComboBox cmbBaoCao;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crVBaoCaoDoNhap;
        private CryBaoCaoChiTieu CryBaoCaoChiTieu1;
        private System.Windows.Forms.TextBox txtNhanVienNhap;
        private System.Windows.Forms.Label label1;
        private CryBaoCaoLuongKhach CryBaoCaoLuongKhach1;
        private CryBaoCaoChiTieu CryBaoCaoChiTieu2;
        private CryBaoCaoChiTieu CryBaoCaoChiTieu3;
        private CryBaoCaoLuongKhach CryBaoCaoLuongKhach2;
        private CryBaoCaoChiTieu CryBaoCaoChiTieu4;
        private CryBaoCaoLuongKhach CryBaoCaoLuongKhach3;
        private CryBaoCaoChiTieu CryBaoCaoChiTieu5;
        private ClassButton btnHienThi;
    }
}