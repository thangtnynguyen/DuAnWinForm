
namespace DOANWINDOWFORM
{
    partial class frmBill
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvBanChuaThanhToan = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvBanDaThanhToan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbBan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lableq = new System.Windows.Forms.Label();
            this.dtimeBill = new System.Windows.Forms.DateTimePicker();
            this.cryBiLLL = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHienThi = new DOANWINDOWFORM.ClassButton();
            this.btnXacNhanThanhToan = new DOANWINDOWFORM.ClassButton();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanChuaThanhToan)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanDaThanhToan)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHienThi);
            this.panel1.Controls.Add(this.btnXacNhanThanhToan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.cmbNhanVien);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.cmbBan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lableq);
            this.panel1.Controls.Add(this.dtimeBill);
            this.panel1.Location = new System.Drawing.Point(29, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 578);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chưa Thanh Toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Đã Thanh Toán";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvBanChuaThanhToan);
            this.panel4.Location = new System.Drawing.Point(186, 361);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(124, 219);
            this.panel4.TabIndex = 3;
            // 
            // dgvBanChuaThanhToan
            // 
            this.dgvBanChuaThanhToan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBanChuaThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanChuaThanhToan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.dgvBanChuaThanhToan.Location = new System.Drawing.Point(0, 0);
            this.dgvBanChuaThanhToan.Name = "dgvBanChuaThanhToan";
            this.dgvBanChuaThanhToan.RowHeadersWidth = 51;
            this.dgvBanChuaThanhToan.RowTemplate.Height = 24;
            this.dgvBanChuaThanhToan.Size = new System.Drawing.Size(124, 219);
            this.dgvBanChuaThanhToan.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Bàn";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(131, 104);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(160, 24);
            this.cmbNhanVien.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvBanDaThanhToan);
            this.panel3.Location = new System.Drawing.Point(27, 361);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(124, 219);
            this.panel3.TabIndex = 2;
            // 
            // dgvBanDaThanhToan
            // 
            this.dgvBanDaThanhToan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBanDaThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanDaThanhToan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvBanDaThanhToan.Location = new System.Drawing.Point(0, 0);
            this.dgvBanDaThanhToan.Name = "dgvBanDaThanhToan";
            this.dgvBanDaThanhToan.RowHeadersWidth = 51;
            this.dgvBanDaThanhToan.RowTemplate.Height = 24;
            this.dgvBanDaThanhToan.Size = new System.Drawing.Size(124, 219);
            this.dgvBanDaThanhToan.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Bàn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // cmbBan
            // 
            this.cmbBan.FormattingEnabled = true;
            this.cmbBan.Location = new System.Drawing.Point(131, 61);
            this.cmbBan.Name = "cmbBan";
            this.cmbBan.Size = new System.Drawing.Size(160, 24);
            this.cmbBan.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bàn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhân Viên:";
            // 
            // lableq
            // 
            this.lableq.AutoSize = true;
            this.lableq.Location = new System.Drawing.Point(4, 14);
            this.lableq.Name = "lableq";
            this.lableq.Size = new System.Drawing.Size(45, 17);
            this.lableq.TabIndex = 3;
            this.lableq.Text = "Ngày:";
            // 
            // dtimeBill
            // 
            this.dtimeBill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimeBill.Location = new System.Drawing.Point(131, 14);
            this.dtimeBill.Name = "dtimeBill";
            this.dtimeBill.Size = new System.Drawing.Size(160, 22);
            this.dtimeBill.TabIndex = 1;
            // 
            // cryBiLLL
            // 
            this.cryBiLLL.ActiveViewIndex = -1;
            this.cryBiLLL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryBiLLL.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryBiLLL.Location = new System.Drawing.Point(397, 27);
            this.cryBiLLL.Name = "cryBiLLL";
            this.cryBiLLL.Size = new System.Drawing.Size(603, 578);
            this.cryBiLLL.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.cryBiLLL);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 622);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Image = global::DOANWINDOWFORM.Properties.Resources.iconXX_32;
            this.button1.Location = new System.Drawing.Point(987, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 35);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHienThi.BackgrondColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHienThi.BorderColor = System.Drawing.Color.Blue;
            this.btnHienThi.BorderRadios = 2;
            this.btnHienThi.BorderSize = 1;
            this.btnHienThi.FlatAppearance.BorderSize = 0;
            this.btnHienThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienThi.ForeColor = System.Drawing.Color.Black;
            this.btnHienThi.Image = global::DOANWINDOWFORM.Properties.Resources.iconshow_32;
            this.btnHienThi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHienThi.Location = new System.Drawing.Point(105, 165);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(160, 40);
            this.btnHienThi.TabIndex = 31;
            this.btnHienThi.Text = "        Hiển Thị Bill";
            this.btnHienThi.TextColor = System.Drawing.Color.Black;
            this.btnHienThi.UseVisualStyleBackColor = false;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnXacNhanThanhToan
            // 
            this.btnXacNhanThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXacNhanThanhToan.BackgrondColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXacNhanThanhToan.BorderColor = System.Drawing.Color.Blue;
            this.btnXacNhanThanhToan.BorderRadios = 2;
            this.btnXacNhanThanhToan.BorderSize = 1;
            this.btnXacNhanThanhToan.FlatAppearance.BorderSize = 0;
            this.btnXacNhanThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhanThanhToan.ForeColor = System.Drawing.Color.Black;
            this.btnXacNhanThanhToan.Image = global::DOANWINDOWFORM.Properties.Resources.icontick_32;
            this.btnXacNhanThanhToan.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnXacNhanThanhToan.Location = new System.Drawing.Point(65, 237);
            this.btnXacNhanThanhToan.Name = "btnXacNhanThanhToan";
            this.btnXacNhanThanhToan.Size = new System.Drawing.Size(241, 40);
            this.btnXacNhanThanhToan.TabIndex = 30;
            this.btnXacNhanThanhToan.Text = "      Xác Nhận Thanh Toán";
            this.btnXacNhanThanhToan.TextColor = System.Drawing.Color.Black;
            this.btnXacNhanThanhToan.UseVisualStyleBackColor = false;
            this.btnXacNhanThanhToan.Click += new System.EventHandler(this.btnXacNhanThanhToan_Click);
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1038, 646);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBill";
            this.Load += new System.EventHandler(this.FormBill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanChuaThanhToan)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanDaThanhToan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lableq;
        private System.Windows.Forms.DateTimePicker dtimeBill;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private System.Windows.Forms.ComboBox cmbBan;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryBiLLL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvBanChuaThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvBanDaThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private ClassButton btnHienThi;
        private ClassButton btnXacNhanThanhToan;
        private System.Windows.Forms.Button button1;
    }
}