
namespace DOANWINDOWFORM
{
    partial class frmDoiMatKhau
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
            this.lblDoiMk = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTKDoi = new System.Windows.Forms.TextBox();
            this.txtMKDoiCu = new System.Windows.Forms.TextBox();
            this.txtMKDoiMoi = new System.Windows.Forms.TextBox();
            this.classButton1 = new DOANWINDOWFORM.ClassButton();
            this.btnXacNhan = new DOANWINDOWFORM.ClassButton();
            this.btnHuy = new DOANWINDOWFORM.ClassButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDoiMk
            // 
            this.lblDoiMk.AutoSize = true;
            this.lblDoiMk.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoiMk.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDoiMk.Image = global::DOANWINDOWFORM.Properties.Resources._1484686600_Profile012;
            this.lblDoiMk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDoiMk.Location = new System.Drawing.Point(98, 32);
            this.lblDoiMk.Name = "lblDoiMk";
            this.lblDoiMk.Size = new System.Drawing.Size(305, 36);
            this.lblDoiMk.TabIndex = 0;
            this.lblDoiMk.Text = "      ĐỔI MẬT KHẨU ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(155)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(28, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài Khoản :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(155)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(28, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật Khẩu Cũ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(155)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(28, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật Khẩu Mới :";
            // 
            // txtTKDoi
            // 
            this.txtTKDoi.Location = new System.Drawing.Point(219, 137);
            this.txtTKDoi.Name = "txtTKDoi";
            this.txtTKDoi.Size = new System.Drawing.Size(195, 22);
            this.txtTKDoi.TabIndex = 4;
            this.txtTKDoi.TextChanged += new System.EventHandler(this.txtTKDoi_TextChanged);
            // 
            // txtMKDoiCu
            // 
            this.txtMKDoiCu.Location = new System.Drawing.Point(219, 196);
            this.txtMKDoiCu.Name = "txtMKDoiCu";
            this.txtMKDoiCu.Size = new System.Drawing.Size(195, 22);
            this.txtMKDoiCu.TabIndex = 5;
            // 
            // txtMKDoiMoi
            // 
            this.txtMKDoiMoi.Location = new System.Drawing.Point(219, 262);
            this.txtMKDoiMoi.Name = "txtMKDoiMoi";
            this.txtMKDoiMoi.Size = new System.Drawing.Size(195, 22);
            this.txtMKDoiMoi.TabIndex = 6;
            // 
            // classButton1
            // 
            this.classButton1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.classButton1.BackgrondColor = System.Drawing.Color.MediumAquamarine;
            this.classButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.classButton1.BorderRadios = 40;
            this.classButton1.BorderSize = 0;
            this.classButton1.FlatAppearance.BorderSize = 0;
            this.classButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classButton1.ForeColor = System.Drawing.Color.White;
            this.classButton1.Location = new System.Drawing.Point(637, 200);
            this.classButton1.Name = "classButton1";
            this.classButton1.Size = new System.Drawing.Size(8, 8);
            this.classButton1.TabIndex = 9;
            this.classButton1.Text = "classButton1";
            this.classButton1.TextColor = System.Drawing.Color.White;
            this.classButton1.UseVisualStyleBackColor = false;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(155)))), ((int)(((byte)(240)))));
            this.btnXacNhan.BackgrondColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(155)))), ((int)(((byte)(240)))));
            this.btnXacNhan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXacNhan.BorderRadios = 20;
            this.btnXacNhan.BorderSize = 0;
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(134, 345);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(120, 40);
            this.btnXacNhan.TabIndex = 26;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.TextColor = System.Drawing.Color.White;
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(155)))), ((int)(((byte)(240)))));
            this.btnHuy.BackgrondColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(155)))), ((int)(((byte)(240)))));
            this.btnHuy.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHuy.BorderRadios = 20;
            this.btnHuy.BorderSize = 0;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(329, 345);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 40);
            this.btnHuy.TabIndex = 27;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextColor = System.Drawing.Color.White;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.lblDoiMk);
            this.panel1.Controls.Add(this.btnXacNhan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMKDoiMoi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMKDoiCu);
            this.panel1.Controls.Add(this.txtTKDoi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 450);
            this.panel1.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::DOANWINDOWFORM.Properties.Resources.iconXX_32;
            this.button1.Location = new System.Drawing.Point(552, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 35);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.classButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDoiMatKhau";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDoiMk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTKDoi;
        private System.Windows.Forms.TextBox txtMKDoiCu;
        private System.Windows.Forms.TextBox txtMKDoiMoi;
        private ClassButton classButton1;
        private ClassButton btnXacNhan;
        private ClassButton btnHuy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}