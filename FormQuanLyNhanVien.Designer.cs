
namespace DOANWINDOWFORM
{
    partial class frmQuanLyNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLichDiLam = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTangCa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.cmbCaLam = new System.Windows.Forms.ComboBox();
            this.cmbChucVu = new System.Windows.Forms.ComboBox();
            this.txtTang = new System.Windows.Forms.Label();
            this.mskSDTNhanVien = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new DOANWINDOWFORM.UserControlTexBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new DOANWINDOWFORM.ClassButton();
            this.btnLamMoi = new DOANWINDOWFORM.ClassButton();
            this.btnThem = new DOANWINDOWFORM.ClassButton();
            this.btnSua = new DOANWINDOWFORM.ClassButton();
            this.btnXoa = new DOANWINDOWFORM.ClassButton();
            this.txtMaNV = new DOANWINDOWFORM.UserControlTexBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichDiLam)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lịch Đi Làm Nhân Viên";
            // 
            // dgvLichDiLam
            // 
            this.dgvLichDiLam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichDiLam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvLichDiLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichDiLam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvLichDiLam.Location = new System.Drawing.Point(12, 299);
            this.dgvLichDiLam.Name = "dgvLichDiLam";
            this.dgvLichDiLam.RowHeadersWidth = 51;
            this.dgvLichDiLam.RowTemplate.Height = 24;
            this.dgvLichDiLam.Size = new System.Drawing.Size(751, 268);
            this.dgvLichDiLam.TabIndex = 1;
            this.dgvLichDiLam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichDiLam_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã NV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tên Nhân Viên";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Chức Vụ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giờ Làm";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số Điện Thoại ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTangCa);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpNgay);
            this.panel1.Controls.Add(this.cmbCaLam);
            this.panel1.Controls.Add(this.cmbChucVu);
            this.panel1.Controls.Add(this.txtTang);
            this.panel1.Controls.Add(this.mskSDTNhanVien);
            this.panel1.Controls.Add(this.txtTenNhanVien);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 229);
            this.panel1.TabIndex = 2;
            // 
            // txtTangCa
            // 
            this.txtTangCa.Location = new System.Drawing.Point(486, 39);
            this.txtTangCa.Name = "txtTangCa";
            this.txtTangCa.Size = new System.Drawing.Size(100, 22);
            this.txtTangCa.TabIndex = 24;
            this.txtTangCa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTangCa_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Sinh:";
            // 
            // dtpNgay
            // 
            this.dtpNgay.CustomFormat = "yyyy-MM-dd";
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(143, 182);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(108, 22);
            this.dtpNgay.TabIndex = 22;
            // 
            // cmbCaLam
            // 
            this.cmbCaLam.FormattingEnabled = true;
            this.cmbCaLam.Items.AddRange(new object[] {
            "Trưa",
            "Tối"});
            this.cmbCaLam.Location = new System.Drawing.Point(143, 108);
            this.cmbCaLam.Name = "cmbCaLam";
            this.cmbCaLam.Size = new System.Drawing.Size(108, 24);
            this.cmbCaLam.TabIndex = 20;
            // 
            // cmbChucVu
            // 
            this.cmbChucVu.FormattingEnabled = true;
            this.cmbChucVu.Location = new System.Drawing.Point(486, 111);
            this.cmbChucVu.Name = "cmbChucVu";
            this.cmbChucVu.Size = new System.Drawing.Size(108, 24);
            this.cmbChucVu.TabIndex = 19;
            // 
            // txtTang
            // 
            this.txtTang.AutoSize = true;
            this.txtTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTang.Location = new System.Drawing.Point(348, 44);
            this.txtTang.Name = "txtTang";
            this.txtTang.Size = new System.Drawing.Size(104, 17);
            this.txtTang.TabIndex = 18;
            this.txtTang.Text = "Giờ Tăng Ca:";
            // 
            // mskSDTNhanVien
            // 
            this.mskSDTNhanVien.BackColor = System.Drawing.Color.White;
            this.mskSDTNhanVien.Location = new System.Drawing.Point(486, 184);
            this.mskSDTNhanVien.MaxLength = 10;
            this.mskSDTNhanVien.Name = "mskSDTNhanVien";
            this.mskSDTNhanVien.Size = new System.Drawing.Size(108, 22);
            this.mskSDTNhanVien.TabIndex = 16;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtTenNhanVien.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTenNhanVien.BorderSize = 2;
            this.txtTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhanVien.ForeColor = System.Drawing.Color.Black;
            this.txtTenNhanVien.Location = new System.Drawing.Point(143, 28);
            this.txtTenNhanVien.Multiline = false;
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Padding = new System.Windows.Forms.Padding(7);
            this.txtTenNhanVien.PasswordChar = false;
            this.txtTenNhanVien.Size = new System.Drawing.Size(108, 33);
            this.txtTenNhanVien.TabIndex = 15;
            this.txtTenNhanVien.Texts = "";
            this.txtTenNhanVien.UnderlineStyle = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(348, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "SĐT :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chức Vụ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ca Làm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Nhân Viên :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mã NV :";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::DOANWINDOWFORM.Properties.Resources.iconhome_32;
            this.button1.Location = new System.Drawing.Point(-1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 46);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.btnLamMoi);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.txtMaNV);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(783, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 503);
            this.panel2.TabIndex = 23;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTimKiem.BackgrondColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTimKiem.BorderColor = System.Drawing.Color.Blue;
            this.btnTimKiem.BorderRadios = 2;
            this.btnTimKiem.BorderSize = 1;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Image = global::DOANWINDOWFORM.Properties.Resources.icontimkiem_32;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(18, 72);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(195, 45);
            this.btnTimKiem.TabIndex = 21;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextColor = System.Drawing.Color.Black;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLamMoi.BackgrondColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLamMoi.BorderColor = System.Drawing.Color.Blue;
            this.btnLamMoi.BorderRadios = 2;
            this.btnLamMoi.BorderSize = 1;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Image = global::DOANWINDOWFORM.Properties.Resources.iconrefresh_32;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(18, 161);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(195, 45);
            this.btnLamMoi.TabIndex = 20;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextColor = System.Drawing.Color.Black;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThem.BackgrondColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThem.BorderColor = System.Drawing.Color.Blue;
            this.btnThem.BorderRadios = 2;
            this.btnThem.BorderSize = 1;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = global::DOANWINDOWFORM.Properties.Resources.iconadd_32;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThem.Location = new System.Drawing.Point(18, 439);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(195, 50);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextColor = System.Drawing.Color.Black;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSua.BackgrondColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSua.BorderColor = System.Drawing.Color.Blue;
            this.btnSua.BorderRadios = 2;
            this.btnSua.BorderSize = 1;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = global::DOANWINDOWFORM.Properties.Resources.iconrefresh_32;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSua.Location = new System.Drawing.Point(18, 353);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(195, 49);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextColor = System.Drawing.Color.Black;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoa.BackgrondColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoa.BorderColor = System.Drawing.Color.Blue;
            this.btnXoa.BorderRadios = 2;
            this.btnXoa.BorderSize = 1;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = global::DOANWINDOWFORM.Properties.Resources.icondelete_32;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnXoa.Location = new System.Drawing.Point(18, 256);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(195, 49);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextColor = System.Drawing.Color.Black;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtMaNV.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMaNV.BorderSize = 2;
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.ForeColor = System.Drawing.Color.Black;
            this.txtMaNV.Location = new System.Drawing.Point(105, 14);
            this.txtMaNV.Multiline = false;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Padding = new System.Windows.Forms.Padding(7);
            this.txtMaNV.PasswordChar = false;
            this.txtMaNV.Size = new System.Drawing.Size(108, 33);
            this.txtMaNV.TabIndex = 14;
            this.txtMaNV.Texts = "";
            this.txtMaNV.UnderlineStyle = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::DOANWINDOWFORM.Properties.Resources.iconXX_32;
            this.button2.Location = new System.Drawing.Point(992, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 35);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1046, 623);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvLichDiLam);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuanLyNhanVien";
            this.Load += new System.EventHandler(this.frmQuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichDiLam)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLichDiLam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label6;
        private UserControlTexBox txtTenNhanVien;
        private UserControlTexBox txtMaNV;
        private ClassButton btnThem;
        private ClassButton btnSua;
        private ClassButton btnXoa;
        private System.Windows.Forms.TextBox mskSDTNhanVien;
        private ClassButton btnLamMoi;
        private ClassButton btnTimKiem;
        private System.Windows.Forms.Label txtTang;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.ComboBox cmbChucVu;
        private System.Windows.Forms.ComboBox cmbCaLam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTangCa;
    }
}