
namespace DOANWINDOWFORM
{
    partial class frmQLDoNhap
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
            this.pnlDoNhap = new System.Windows.Forms.Panel();
            this.mskGia = new System.Windows.Forms.MaskedTextBox();
            this.mskSoLuong = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMaLoai = new System.Windows.Forms.ComboBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblMaNv = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiemSanPham = new DOANWINDOWFORM.ClassButton();
            this.btnXoaSanPham = new DOANWINDOWFORM.ClassButton();
            this.btnLamMoiSanPham = new DOANWINDOWFORM.ClassButton();
            this.btnThemThucPham = new DOANWINDOWFORM.ClassButton();
            this.btnSuaSanPham = new DOANWINDOWFORM.ClassButton();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDoNhap = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlDoNhap.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDoNhap
            // 
            this.pnlDoNhap.Controls.Add(this.mskGia);
            this.pnlDoNhap.Controls.Add(this.mskSoLuong);
            this.pnlDoNhap.Controls.Add(this.label9);
            this.pnlDoNhap.Controls.Add(this.label8);
            this.pnlDoNhap.Controls.Add(this.label7);
            this.pnlDoNhap.Controls.Add(this.label6);
            this.pnlDoNhap.Controls.Add(this.label3);
            this.pnlDoNhap.Controls.Add(this.cmbMaLoai);
            this.pnlDoNhap.Controls.Add(this.txtMoTa);
            this.pnlDoNhap.Controls.Add(this.txtTenSanPham);
            this.pnlDoNhap.ForeColor = System.Drawing.Color.Black;
            this.pnlDoNhap.Location = new System.Drawing.Point(12, 67);
            this.pnlDoNhap.Name = "pnlDoNhap";
            this.pnlDoNhap.Size = new System.Drawing.Size(814, 218);
            this.pnlDoNhap.TabIndex = 1;
            // 
            // mskGia
            // 
            this.mskGia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mskGia.Location = new System.Drawing.Point(465, 100);
            this.mskGia.Name = "mskGia";
            this.mskGia.Size = new System.Drawing.Size(121, 22);
            this.mskGia.TabIndex = 18;
            this.mskGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskGia_KeyPress);
            // 
            // mskSoLuong
            // 
            this.mskSoLuong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mskSoLuong.Location = new System.Drawing.Point(319, 157);
            this.mskSoLuong.Name = "mskSoLuong";
            this.mskSoLuong.Size = new System.Drawing.Size(100, 22);
            this.mskSoLuong.TabIndex = 17;
            this.mskSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskSoLuong_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(26, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Mô Tả:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(26, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tên SP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(231, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Số Lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(349, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã Loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(347, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Đơn Giá:";
            // 
            // cmbMaLoai
            // 
            this.cmbMaLoai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbMaLoai.FormattingEnabled = true;
            this.cmbMaLoai.Items.AddRange(new object[] {
            "ThitLon",
            "ThitBo",
            "HaiSanNuocNgot",
            "HaiSanNuocMan",
            "RauCu",
            "Qua",
            "NuocNgot",
            "Bia",
            "Rieu"});
            this.cmbMaLoai.Location = new System.Drawing.Point(465, 25);
            this.cmbMaLoai.Name = "cmbMaLoai";
            this.cmbMaLoai.Size = new System.Drawing.Size(121, 24);
            this.cmbMaLoai.TabIndex = 3;
            // 
            // txtMoTa
            // 
            this.txtMoTa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMoTa.Location = new System.Drawing.Point(124, 98);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(100, 22);
            this.txtMoTa.TabIndex = 2;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenSanPham.Location = new System.Drawing.Point(124, 22);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(100, 22);
            this.txtTenSanPham.TabIndex = 1;
            // 
            // txtMaSP
            // 
            this.txtMaSP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMaSP.Location = new System.Drawing.Point(98, 22);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(100, 22);
            this.txtMaSP.TabIndex = 16;
            // 
            // lblMaNv
            // 
            this.lblMaNv.AutoSize = true;
            this.lblMaNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMaNv.Location = new System.Drawing.Point(19, 25);
            this.lblMaNv.Name = "lblMaNv";
            this.lblMaNv.Size = new System.Drawing.Size(59, 17);
            this.lblMaNv.TabIndex = 4;
            this.lblMaNv.Text = "Mã SP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(386, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(334, 38);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quản Lý Thực Phẩm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiemSanPham);
            this.panel1.Controls.Add(this.btnXoaSanPham);
            this.panel1.Controls.Add(this.txtMaSP);
            this.panel1.Controls.Add(this.btnLamMoiSanPham);
            this.panel1.Controls.Add(this.btnThemThucPham);
            this.panel1.Controls.Add(this.btnSuaSanPham);
            this.panel1.Controls.Add(this.lblMaNv);
            this.panel1.Location = new System.Drawing.Point(841, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 564);
            this.panel1.TabIndex = 12;
            // 
            // btnTimKiemSanPham
            // 
            this.btnTimKiemSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTimKiemSanPham.BackgrondColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTimKiemSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTimKiemSanPham.BorderColor = System.Drawing.Color.Blue;
            this.btnTimKiemSanPham.BorderRadios = 2;
            this.btnTimKiemSanPham.BorderSize = 1;
            this.btnTimKiemSanPham.FlatAppearance.BorderSize = 0;
            this.btnTimKiemSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemSanPham.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiemSanPham.Image = global::DOANWINDOWFORM.Properties.Resources.icontimkiem_32;
            this.btnTimKiemSanPham.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTimKiemSanPham.Location = new System.Drawing.Point(22, 89);
            this.btnTimKiemSanPham.Name = "btnTimKiemSanPham";
            this.btnTimKiemSanPham.Size = new System.Drawing.Size(185, 50);
            this.btnTimKiemSanPham.TabIndex = 33;
            this.btnTimKiemSanPham.Text = "Tìm Kiếm";
            this.btnTimKiemSanPham.TextColor = System.Drawing.Color.Black;
            this.btnTimKiemSanPham.UseVisualStyleBackColor = false;
            this.btnTimKiemSanPham.Click += new System.EventHandler(this.btnTimKiemSanPham_Click);
            // 
            // btnXoaSanPham
            // 
            this.btnXoaSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoaSanPham.BackgrondColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoaSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoaSanPham.BorderColor = System.Drawing.Color.Blue;
            this.btnXoaSanPham.BorderRadios = 2;
            this.btnXoaSanPham.BorderSize = 1;
            this.btnXoaSanPham.FlatAppearance.BorderSize = 0;
            this.btnXoaSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSanPham.ForeColor = System.Drawing.Color.Black;
            this.btnXoaSanPham.Image = global::DOANWINDOWFORM.Properties.Resources.icondelete_32;
            this.btnXoaSanPham.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnXoaSanPham.Location = new System.Drawing.Point(22, 494);
            this.btnXoaSanPham.Name = "btnXoaSanPham";
            this.btnXoaSanPham.Size = new System.Drawing.Size(185, 48);
            this.btnXoaSanPham.TabIndex = 32;
            this.btnXoaSanPham.Text = "Xóa";
            this.btnXoaSanPham.TextColor = System.Drawing.Color.Black;
            this.btnXoaSanPham.UseVisualStyleBackColor = false;
            this.btnXoaSanPham.Click += new System.EventHandler(this.btnXoaSanPham_Click);
            // 
            // btnLamMoiSanPham
            // 
            this.btnLamMoiSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLamMoiSanPham.BackgrondColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLamMoiSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLamMoiSanPham.BorderColor = System.Drawing.Color.Blue;
            this.btnLamMoiSanPham.BorderRadios = 2;
            this.btnLamMoiSanPham.BorderSize = 1;
            this.btnLamMoiSanPham.FlatAppearance.BorderSize = 0;
            this.btnLamMoiSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiSanPham.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoiSanPham.Image = global::DOANWINDOWFORM.Properties.Resources.iconrefresh_32;
            this.btnLamMoiSanPham.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLamMoiSanPham.Location = new System.Drawing.Point(22, 283);
            this.btnLamMoiSanPham.Name = "btnLamMoiSanPham";
            this.btnLamMoiSanPham.Size = new System.Drawing.Size(185, 51);
            this.btnLamMoiSanPham.TabIndex = 31;
            this.btnLamMoiSanPham.Text = "Làm Mới";
            this.btnLamMoiSanPham.TextColor = System.Drawing.Color.Black;
            this.btnLamMoiSanPham.UseVisualStyleBackColor = false;
            this.btnLamMoiSanPham.Click += new System.EventHandler(this.btnLamMoiSanPham_Click);
            // 
            // btnThemThucPham
            // 
            this.btnThemThucPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThemThucPham.BackgrondColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThemThucPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemThucPham.BorderColor = System.Drawing.Color.Blue;
            this.btnThemThucPham.BorderRadios = 2;
            this.btnThemThucPham.BorderSize = 1;
            this.btnThemThucPham.FlatAppearance.BorderSize = 0;
            this.btnThemThucPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemThucPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemThucPham.ForeColor = System.Drawing.Color.Black;
            this.btnThemThucPham.Image = global::DOANWINDOWFORM.Properties.Resources.iconadd_32;
            this.btnThemThucPham.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThemThucPham.Location = new System.Drawing.Point(22, 180);
            this.btnThemThucPham.Name = "btnThemThucPham";
            this.btnThemThucPham.Size = new System.Drawing.Size(185, 52);
            this.btnThemThucPham.TabIndex = 30;
            this.btnThemThucPham.Text = "Thêm";
            this.btnThemThucPham.TextColor = System.Drawing.Color.Black;
            this.btnThemThucPham.UseVisualStyleBackColor = false;
            this.btnThemThucPham.Click += new System.EventHandler(this.btnThemThucPham_Click);
            // 
            // btnSuaSanPham
            // 
            this.btnSuaSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSuaSanPham.BackgrondColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSuaSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSuaSanPham.BorderColor = System.Drawing.Color.Blue;
            this.btnSuaSanPham.BorderRadios = 2;
            this.btnSuaSanPham.BorderSize = 1;
            this.btnSuaSanPham.FlatAppearance.BorderSize = 0;
            this.btnSuaSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaSanPham.ForeColor = System.Drawing.Color.Black;
            this.btnSuaSanPham.Image = global::DOANWINDOWFORM.Properties.Resources.iconrefresh_32;
            this.btnSuaSanPham.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSuaSanPham.Location = new System.Drawing.Point(22, 386);
            this.btnSuaSanPham.Name = "btnSuaSanPham";
            this.btnSuaSanPham.Size = new System.Drawing.Size(185, 52);
            this.btnSuaSanPham.TabIndex = 29;
            this.btnSuaSanPham.Text = "Sửa";
            this.btnSuaSanPham.TextColor = System.Drawing.Color.Black;
            this.btnSuaSanPham.UseVisualStyleBackColor = false;
            this.btnSuaSanPham.Click += new System.EventHandler(this.btnSuaSanPham_Click);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Đơn Giá ";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số Lượng ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mô Tả";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã Loại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên SP";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã SP";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // dgvDoNhap
            // 
            this.dgvDoNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoNhap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvDoNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvDoNhap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvDoNhap.Location = new System.Drawing.Point(12, 309);
            this.dgvDoNhap.Name = "dgvDoNhap";
            this.dgvDoNhap.RowHeadersWidth = 51;
            this.dgvDoNhap.RowTemplate.Height = 24;
            this.dgvDoNhap.Size = new System.Drawing.Size(814, 322);
            this.dgvDoNhap.TabIndex = 2;
            this.dgvDoNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoNhap_CellClick);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::DOANWINDOWFORM.Properties.Resources.iconhome_32;
            this.button1.Location = new System.Drawing.Point(0, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 49);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::DOANWINDOWFORM.Properties.Resources.iconXX_32;
            this.button2.Location = new System.Drawing.Point(1019, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 35);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmQLDoNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1076, 654);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDoNhap);
            this.Controls.Add(this.pnlDoNhap);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLDoNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQLDoNhap";
            this.Load += new System.EventHandler(this.frmQLDoNhap_Load);
            this.pnlDoNhap.ResumeLayout(false);
            this.pnlDoNhap.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlDoNhap;
        private System.Windows.Forms.Label lblMaNv;
        private System.Windows.Forms.ComboBox cmbMaLoai;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskGia;
        private System.Windows.Forms.MaskedTextBox mskSoLuong;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgvDoNhap;
        private ClassButton btnTimKiemSanPham;
        private ClassButton btnXoaSanPham;
        private ClassButton btnLamMoiSanPham;
        private ClassButton btnThemThucPham;
        private ClassButton btnSuaSanPham;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}