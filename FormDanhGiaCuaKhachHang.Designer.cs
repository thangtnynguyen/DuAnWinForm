
namespace DOANWINDOWFORM
{
    partial class frmDanhGiaCuaKhachHang
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
            this.dgvPhanHoiCuaKhach = new System.Windows.Forms.DataGridView();
            this.ClPhucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChatLunh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanHoiCuaKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Image = global::DOANWINDOWFORM.Properties.Resources.if_gtk_refresh_48111;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(705, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "  Bảng Thống Kê Đánh Giá Của Khách Hàng";
            // 
            // dgvPhanHoiCuaKhach
            // 
            this.dgvPhanHoiCuaKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhanHoiCuaKhach.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvPhanHoiCuaKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanHoiCuaKhach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClPhucVu,
            this.CLTinh,
            this.ChatLunh});
            this.dgvPhanHoiCuaKhach.Location = new System.Drawing.Point(45, 150);
            this.dgvPhanHoiCuaKhach.Name = "dgvPhanHoiCuaKhach";
            this.dgvPhanHoiCuaKhach.RowHeadersWidth = 51;
            this.dgvPhanHoiCuaKhach.RowTemplate.Height = 24;
            this.dgvPhanHoiCuaKhach.Size = new System.Drawing.Size(715, 253);
            this.dgvPhanHoiCuaKhach.TabIndex = 1;
            // 
            // ClPhucVu
            // 
            this.ClPhucVu.HeaderText = "Chất Lượng Phục Vụ";
            this.ClPhucVu.MinimumWidth = 6;
            this.ClPhucVu.Name = "ClPhucVu";
            // 
            // CLTinh
            // 
            this.CLTinh.HeaderText = "Chất Lượng Món Ăn";
            this.CLTinh.MinimumWidth = 6;
            this.CLTinh.Name = "CLTinh";
            // 
            // ChatLunh
            // 
            this.ChatLunh.HeaderText = "Ghi Chú";
            this.ChatLunh.MinimumWidth = 6;
            this.ChatLunh.Name = "ChatLunh";
            // 
            // frmDanhGiaCuaKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPhanHoiCuaKhach);
            this.Controls.Add(this.label1);
            this.Name = "frmDanhGiaCuaKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDanhGiaCuaKhachHang";
            this.Load += new System.EventHandler(this.frmDanhGiaCuaKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanHoiCuaKhach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhanHoiCuaKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClPhucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChatLunh;
    }
}