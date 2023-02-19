
namespace DOANWINDOWFORM
{
    partial class frmBaoLoi
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
            this.cmbLoi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoi = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quý Khách Vui Lòng Cho Biết Lỗi :";
            // 
            // cmbLoi
            // 
            this.cmbLoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbLoi.FormattingEnabled = true;
            this.cmbLoi.Items.AddRange(new object[] {
            "Không Đặt Được Bàn.",
            "Hệ Thống Lỗi.",
            "Không Đổi Được Mật Khẩu."});
            this.cmbLoi.Location = new System.Drawing.Point(397, 202);
            this.cmbLoi.Name = "cmbLoi";
            this.cmbLoi.Size = new System.Drawing.Size(187, 24);
            this.cmbLoi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lỗi Khác :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(117, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(554, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quý Khách Vui Lòng Cho Biết Lỗi :";
            // 
            // txtLoi
            // 
            this.txtLoi.Location = new System.Drawing.Point(397, 313);
            this.txtLoi.Multiline = true;
            this.txtLoi.Name = "txtLoi";
            this.txtLoi.Size = new System.Drawing.Size(187, 22);
            this.txtLoi.TabIndex = 5;
            // 
            // btnThoat
            // 
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Image = global::DOANWINDOWFORM.Properties.Resources.iconhome_32;
            this.btnThoat.Location = new System.Drawing.Point(-3, -2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(60, 45);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // button1
            // 
            this.button1.Image = global::DOANWINDOWFORM.Properties.Resources.iconXX_32;
            this.button1.Location = new System.Drawing.Point(744, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 35);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBaoLoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtLoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbLoi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaoLoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBaoLoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button button1;
    }
}