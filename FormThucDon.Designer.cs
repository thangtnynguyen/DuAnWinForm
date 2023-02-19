
namespace DOANWINDOWFORM
{
    partial class frmCacMonAn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCacMonAn));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmbMucGia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Bạch Tuộc.jpg");
            this.imageList1.Images.SetKeyName(1, "mực.png");
            this.imageList1.Images.SetKeyName(2, "Ức Gà.jpg");
            this.imageList1.Images.SetKeyName(3, "Chân gà.jpg");
            this.imageList1.Images.SetKeyName(4, "Ghẹ.jpg");
            this.imageList1.Images.SetKeyName(5, "Cua.jpg");
            this.imageList1.Images.SetKeyName(6, "Tôm.jpg");
            this.imageList1.Images.SetKeyName(7, "Cá Chép.jpg");
            this.imageList1.Images.SetKeyName(8, "Cá Basa.jpg");
            this.imageList1.Images.SetKeyName(9, "Bò baxa.png");
            this.imageList1.Images.SetKeyName(10, "Bò Cuộn.jpg");
            this.imageList1.Images.SetKeyName(11, "Gầu Bò.jpg");
            this.imageList1.Images.SetKeyName(12, "Bắp Bò.jpg");
            this.imageList1.Images.SetKeyName(13, "Nầm.png");
            this.imageList1.Images.SetKeyName(14, "Sờn Non.jpg");
            this.imageList1.Images.SetKeyName(15, "Lạc Vai Lợn.png");
            this.imageList1.Images.SetKeyName(16, "Cổ Lợn.jpg");
            this.imageList1.Images.SetKeyName(17, "Lưỡi Lợn.jpg");
            this.imageList1.Images.SetKeyName(18, "Bắp Lợn.png");
            this.imageList1.Images.SetKeyName(19, "Gầu lợn.jpg");
            this.imageList1.Images.SetKeyName(20, "Ngao.jpg");
            this.imageList1.Images.SetKeyName(21, "Chim.jpg");
            this.imageList1.Images.SetKeyName(22, "Ghẹ (2).jpg");
            this.imageList1.Images.SetKeyName(23, "Hàu.jpg");
            // 
            // cmbMucGia
            // 
            this.cmbMucGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmbMucGia.FormattingEnabled = true;
            this.cmbMucGia.Location = new System.Drawing.Point(174, 101);
            this.cmbMucGia.Name = "cmbMucGia";
            this.cmbMucGia.Size = new System.Drawing.Size(121, 24);
            this.cmbMucGia.TabIndex = 1;
            this.cmbMucGia.SelectedIndexChanged += new System.EventHandler(this.cmbMucGia_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mức Giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thực Đơn Món Ăn";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.listView1.Location = new System.Drawing.Point(0, 200);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(948, 347);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(96, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 5;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Bạch Tuộc.jpg");
            this.imageList2.Images.SetKeyName(1, "mực.png");
            this.imageList2.Images.SetKeyName(2, "Ức Gà.jpg");
            this.imageList2.Images.SetKeyName(3, "Chân gà.jpg");
            this.imageList2.Images.SetKeyName(4, "Ghẹ.jpg");
            this.imageList2.Images.SetKeyName(5, "Cua.jpg");
            this.imageList2.Images.SetKeyName(6, "Tôm.jpg");
            this.imageList2.Images.SetKeyName(7, "Cá Chép.jpg");
            this.imageList2.Images.SetKeyName(8, "Cá Basa.jpg");
            this.imageList2.Images.SetKeyName(9, "Bò baxa.png");
            this.imageList2.Images.SetKeyName(10, "Bò Cuộn.jpg");
            this.imageList2.Images.SetKeyName(11, "Gầu Bò.jpg");
            this.imageList2.Images.SetKeyName(12, "Bắp Bò.jpg");
            this.imageList2.Images.SetKeyName(13, "Nầm.png");
            this.imageList2.Images.SetKeyName(14, "Sờn Non.jpg");
            this.imageList2.Images.SetKeyName(15, "Lạc Vai Lợn.png");
            this.imageList2.Images.SetKeyName(16, "Cổ Lợn.jpg");
            this.imageList2.Images.SetKeyName(17, "Lưỡi Lợn.jpg");
            this.imageList2.Images.SetKeyName(18, "Bắp Lợn.png");
            this.imageList2.Images.SetKeyName(19, "Gầu lợn.jpg");
            this.imageList2.Images.SetKeyName(20, "Ngao.jpg");
            this.imageList2.Images.SetKeyName(21, "Chim.jpg");
            this.imageList2.Images.SetKeyName(22, "Ghẹ (2).jpg");
            this.imageList2.Images.SetKeyName(23, "Hàu.jpg");
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::DOANWINDOWFORM.Properties.Resources.iconhome_32;
            this.button1.Location = new System.Drawing.Point(0, -4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 46);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::DOANWINDOWFORM.Properties.Resources.iconXX_32;
            this.button2.Location = new System.Drawing.Point(894, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 35);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmCacMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(948, 547);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMucGia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCacMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThucDon";
            this.Load += new System.EventHandler(this.frmCacMonAn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cmbMucGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}