
namespace DOANWINDOWFORM
{
    partial class frmKhachDat
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
            this.label2 = new System.Windows.Forms.Label();
            this.mskChonNgay = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHienThiAll = new DOANWINDOWFORM.ClassButton();
            this.btnXoaDonNgay = new DOANWINDOWFORM.ClassButton();
            this.btnXoaDuLieu = new DOANWINDOWFORM.ClassButton();
            this.btnHienThiTheoNgay = new DOANWINDOWFORM.ClassButton();
            this.dgvThongTinKhachDat = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinKhachDat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(358, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Khách Đặt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chọn Ngày Tháng:";
            // 
            // mskChonNgay
            // 
            this.mskChonNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskChonNgay.Location = new System.Drawing.Point(203, 56);
            this.mskChonNgay.Mask = "00/00/0000";
            this.mskChonNgay.Name = "mskChonNgay";
            this.mskChonNgay.Size = new System.Drawing.Size(100, 22);
            this.mskChonNgay.TabIndex = 5;
            this.mskChonNgay.ValidatingType = typeof(System.DateTime);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHienThiAll);
            this.panel1.Controls.Add(this.btnXoaDonNgay);
            this.panel1.Controls.Add(this.btnXoaDuLieu);
            this.panel1.Controls.Add(this.btnHienThiTheoNgay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mskChonNgay);
            this.panel1.Location = new System.Drawing.Point(12, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 196);
            this.panel1.TabIndex = 7;
            // 
            // btnHienThiAll
            // 
            this.btnHienThiAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHienThiAll.BackgrondColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHienThiAll.BorderColor = System.Drawing.Color.Blue;
            this.btnHienThiAll.BorderRadios = 2;
            this.btnHienThiAll.BorderSize = 1;
            this.btnHienThiAll.FlatAppearance.BorderSize = 0;
            this.btnHienThiAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienThiAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiAll.ForeColor = System.Drawing.Color.Black;
            this.btnHienThiAll.Image = global::DOANWINDOWFORM.Properties.Resources.iconshow_32;
            this.btnHienThiAll.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHienThiAll.Location = new System.Drawing.Point(721, 130);
            this.btnHienThiAll.Name = "btnHienThiAll";
            this.btnHienThiAll.Size = new System.Drawing.Size(195, 40);
            this.btnHienThiAll.TabIndex = 12;
            this.btnHienThiAll.Text = "      Hiển Thị All";
            this.btnHienThiAll.TextColor = System.Drawing.Color.Black;
            this.btnHienThiAll.UseVisualStyleBackColor = false;
            this.btnHienThiAll.Click += new System.EventHandler(this.btnHienThiAll_Click);
            // 
            // btnXoaDonNgay
            // 
            this.btnXoaDonNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoaDonNgay.BackgrondColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoaDonNgay.BorderColor = System.Drawing.Color.Blue;
            this.btnXoaDonNgay.BorderRadios = 2;
            this.btnXoaDonNgay.BorderSize = 1;
            this.btnXoaDonNgay.FlatAppearance.BorderSize = 0;
            this.btnXoaDonNgay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDonNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDonNgay.ForeColor = System.Drawing.Color.Black;
            this.btnXoaDonNgay.Image = global::DOANWINDOWFORM.Properties.Resources.icondelete_32;
            this.btnXoaDonNgay.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnXoaDonNgay.Location = new System.Drawing.Point(414, 130);
            this.btnXoaDonNgay.Name = "btnXoaDonNgay";
            this.btnXoaDonNgay.Size = new System.Drawing.Size(195, 40);
            this.btnXoaDonNgay.TabIndex = 11;
            this.btnXoaDonNgay.Text = "       Xóa Theo Ngày";
            this.btnXoaDonNgay.TextColor = System.Drawing.Color.Black;
            this.btnXoaDonNgay.UseVisualStyleBackColor = false;
            this.btnXoaDonNgay.Click += new System.EventHandler(this.btnXoaDonNgay_Click_1);
            // 
            // btnXoaDuLieu
            // 
            this.btnXoaDuLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoaDuLieu.BackgrondColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoaDuLieu.BorderColor = System.Drawing.Color.Blue;
            this.btnXoaDuLieu.BorderRadios = 2;
            this.btnXoaDuLieu.BorderSize = 1;
            this.btnXoaDuLieu.FlatAppearance.BorderSize = 0;
            this.btnXoaDuLieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDuLieu.ForeColor = System.Drawing.Color.Black;
            this.btnXoaDuLieu.Image = global::DOANWINDOWFORM.Properties.Resources.icondelete_32;
            this.btnXoaDuLieu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnXoaDuLieu.Location = new System.Drawing.Point(721, 19);
            this.btnXoaDuLieu.Name = "btnXoaDuLieu";
            this.btnXoaDuLieu.Size = new System.Drawing.Size(195, 40);
            this.btnXoaDuLieu.TabIndex = 10;
            this.btnXoaDuLieu.Text = "Xóa Hết";
            this.btnXoaDuLieu.TextColor = System.Drawing.Color.Black;
            this.btnXoaDuLieu.UseVisualStyleBackColor = false;
            this.btnXoaDuLieu.Click += new System.EventHandler(this.btnXoaDuLieu_Click_1);
            // 
            // btnHienThiTheoNgay
            // 
            this.btnHienThiTheoNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHienThiTheoNgay.BackgrondColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHienThiTheoNgay.BorderColor = System.Drawing.Color.Blue;
            this.btnHienThiTheoNgay.BorderRadios = 2;
            this.btnHienThiTheoNgay.BorderSize = 1;
            this.btnHienThiTheoNgay.FlatAppearance.BorderSize = 0;
            this.btnHienThiTheoNgay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienThiTheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiTheoNgay.ForeColor = System.Drawing.Color.Black;
            this.btnHienThiTheoNgay.Image = global::DOANWINDOWFORM.Properties.Resources.iconshow_32;
            this.btnHienThiTheoNgay.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHienThiTheoNgay.Location = new System.Drawing.Point(414, 19);
            this.btnHienThiTheoNgay.Name = "btnHienThiTheoNgay";
            this.btnHienThiTheoNgay.Size = new System.Drawing.Size(195, 40);
            this.btnHienThiTheoNgay.TabIndex = 9;
            this.btnHienThiTheoNgay.Text = "      Hiển Thị Đơn Ngày";
            this.btnHienThiTheoNgay.TextColor = System.Drawing.Color.Black;
            this.btnHienThiTheoNgay.UseVisualStyleBackColor = false;
            this.btnHienThiTheoNgay.Click += new System.EventHandler(this.btnHienThiTheoNgay_Click);
            // 
            // dgvThongTinKhachDat
            // 
            this.dgvThongTinKhachDat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinKhachDat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvThongTinKhachDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinKhachDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvThongTinKhachDat.GridColor = System.Drawing.Color.White;
            this.dgvThongTinKhachDat.Location = new System.Drawing.Point(12, 69);
            this.dgvThongTinKhachDat.Name = "dgvThongTinKhachDat";
            this.dgvThongTinKhachDat.RowHeadersWidth = 51;
            this.dgvThongTinKhachDat.RowTemplate.Height = 24;
            this.dgvThongTinKhachDat.Size = new System.Drawing.Size(1006, 225);
            this.dgvThongTinKhachDat.TabIndex = 9;
            this.dgvThongTinKhachDat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinKhachDat_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên Khách Hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mức Giá";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số Người Lớn";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số Trẻ EM";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Bàn ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Số Điện Thoại";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ngày Tháng";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Giờ";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::DOANWINDOWFORM.Properties.Resources.iconXX_32;
            this.button2.Location = new System.Drawing.Point(983, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 35);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::DOANWINDOWFORM.Properties.Resources.iconhome_32;
            this.button1.Location = new System.Drawing.Point(0, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 49);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmKhachDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1037, 639);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvThongTinKhachDat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKhachDat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKhachDat";
            this.Load += new System.EventHandler(this.FormKhachDat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinKhachDat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskChonNgay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvThongTinKhachDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private ClassButton btnHienThiAll;
        private ClassButton btnXoaDonNgay;
        private ClassButton btnXoaDuLieu;
        private ClassButton btnHienThiTheoNgay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}