
namespace BTL_WinDow
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonTab3 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ribbonOrbMenuItem1 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItem2 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.rbtDoiMatKhau = new System.Windows.Forms.RibbonButton();
            this.rbtDangXuat = new System.Windows.Forms.RibbonButton();
            this.rbtThongTin = new System.Windows.Forms.RibbonButton();
            this.rbtQLSach = new System.Windows.Forms.RibbonButton();
            this.rbtQLTK = new System.Windows.Forms.RibbonButton();
            this.rbtNCC = new System.Windows.Forms.RibbonButton();
            this.rbtThongKe = new System.Windows.Forms.RibbonButton();
            this.rbtNhapKho = new System.Windows.Forms.RibbonButton();
            this.rbtDSPN = new System.Windows.Forms.RibbonButton();
            this.rbtBanLe = new System.Windows.Forms.RibbonButton();
            this.rbtDSPX = new System.Windows.Forms.RibbonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem1);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem2);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 160);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(1134, 135);
            this.ribbon1.TabIndex = 10;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.Tabs.Add(this.ribbonTab2);
            this.ribbon1.Tabs.Add(this.ribbonTab3);
            this.ribbon1.Text = "ribbon1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Text = "Hệ thống";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.rbtDoiMatKhau);
            this.ribbonPanel1.Items.Add(this.rbtDangXuat);
            this.ribbonPanel1.Items.Add(this.rbtThongTin);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "Hệ thống";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Panels.Add(this.ribbonPanel2);
            this.ribbonTab2.Text = "Danh mục";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.rbtQLSach);
            this.ribbonPanel2.Items.Add(this.rbtQLTK);
            this.ribbonPanel2.Items.Add(this.rbtNCC);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Text = "Quản lí";
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Panels.Add(this.ribbonPanel3);
            this.ribbonTab3.Text = "Chức năng";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.rbtThongKe);
            this.ribbonPanel3.Items.Add(this.rbtNhapKho);
            this.ribbonPanel3.Items.Add(this.rbtDSPN);
            this.ribbonPanel3.Items.Add(this.rbtBanLe);
            this.ribbonPanel3.Items.Add(this.rbtDSPX);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Text = "Nhập xuất";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Location = new System.Drawing.Point(0, 141);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1134, 435);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.Visible = false;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(124, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(861, 660);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // ribbonOrbMenuItem1
            // 
            this.ribbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.Image")));
            this.ribbonOrbMenuItem1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.LargeImage")));
            this.ribbonOrbMenuItem1.Name = "ribbonOrbMenuItem1";
            this.ribbonOrbMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.SmallImage")));
            this.ribbonOrbMenuItem1.Text = "ribbonOrbMenuItem1";
            // 
            // ribbonOrbMenuItem2
            // 
            this.ribbonOrbMenuItem2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.Image")));
            this.ribbonOrbMenuItem2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.LargeImage")));
            this.ribbonOrbMenuItem2.Name = "ribbonOrbMenuItem2";
            this.ribbonOrbMenuItem2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.SmallImage")));
            this.ribbonOrbMenuItem2.Text = "ribbonOrbMenuItem2";
            // 
            // rbtDoiMatKhau
            // 
            this.rbtDoiMatKhau.Image = ((System.Drawing.Image)(resources.GetObject("rbtDoiMatKhau.Image")));
            this.rbtDoiMatKhau.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtDoiMatKhau.LargeImage")));
            this.rbtDoiMatKhau.MaximumSize = new System.Drawing.Size(200, 0);
            this.rbtDoiMatKhau.MinimumSize = new System.Drawing.Size(100, 0);
            this.rbtDoiMatKhau.Name = "rbtDoiMatKhau";
            this.rbtDoiMatKhau.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtDoiMatKhau.SmallImage")));
            this.rbtDoiMatKhau.Text = "Đổi mật khẩu";
            this.rbtDoiMatKhau.Click += new System.EventHandler(this.rbtDoiMatKhau_Click);
            // 
            // rbtDangXuat
            // 
            this.rbtDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("rbtDangXuat.Image")));
            this.rbtDangXuat.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtDangXuat.LargeImage")));
            this.rbtDangXuat.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.rbtDangXuat.MinimumSize = new System.Drawing.Size(100, 0);
            this.rbtDangXuat.Name = "rbtDangXuat";
            this.rbtDangXuat.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtDangXuat.SmallImage")));
            this.rbtDangXuat.Text = "Đăng xuất";
            this.rbtDangXuat.Click += new System.EventHandler(this.rbtDangXuat_Click);
            // 
            // rbtThongTin
            // 
            this.rbtThongTin.Image = ((System.Drawing.Image)(resources.GetObject("rbtThongTin.Image")));
            this.rbtThongTin.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtThongTin.LargeImage")));
            this.rbtThongTin.MinimumSize = new System.Drawing.Size(150, 0);
            this.rbtThongTin.Name = "rbtThongTin";
            this.rbtThongTin.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtThongTin.SmallImage")));
            this.rbtThongTin.Text = "Thông tin tài khoản";
            this.rbtThongTin.Click += new System.EventHandler(this.rbtThongTin_Click);
            // 
            // rbtQLSach
            // 
            this.rbtQLSach.Image = ((System.Drawing.Image)(resources.GetObject("rbtQLSach.Image")));
            this.rbtQLSach.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtQLSach.LargeImage")));
            this.rbtQLSach.MinimumSize = new System.Drawing.Size(100, 0);
            this.rbtQLSach.Name = "rbtQLSach";
            this.rbtQLSach.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtQLSach.SmallImage")));
            this.rbtQLSach.Text = "Quản lí sách";
            this.rbtQLSach.Click += new System.EventHandler(this.rbtQLSach_Click);
            // 
            // rbtQLTK
            // 
            this.rbtQLTK.Image = ((System.Drawing.Image)(resources.GetObject("rbtQLTK.Image")));
            this.rbtQLTK.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtQLTK.LargeImage")));
            this.rbtQLTK.MinimumSize = new System.Drawing.Size(120, 0);
            this.rbtQLTK.Name = "rbtQLTK";
            this.rbtQLTK.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtQLTK.SmallImage")));
            this.rbtQLTK.Text = "Quản lí tài khoản";
            this.rbtQLTK.Click += new System.EventHandler(this.rbtQLTK_Click);
            // 
            // rbtNCC
            // 
            this.rbtNCC.Image = ((System.Drawing.Image)(resources.GetObject("rbtNCC.Image")));
            this.rbtNCC.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtNCC.LargeImage")));
            this.rbtNCC.MinimumSize = new System.Drawing.Size(150, 0);
            this.rbtNCC.Name = "rbtNCC";
            this.rbtNCC.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtNCC.SmallImage")));
            this.rbtNCC.Text = "Danh sách nhà cung cấp";
            this.rbtNCC.Click += new System.EventHandler(this.rbtNCC_Click);
            // 
            // rbtThongKe
            // 
            this.rbtThongKe.Image = ((System.Drawing.Image)(resources.GetObject("rbtThongKe.Image")));
            this.rbtThongKe.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtThongKe.LargeImage")));
            this.rbtThongKe.MinimumSize = new System.Drawing.Size(100, 0);
            this.rbtThongKe.Name = "rbtThongKe";
            this.rbtThongKe.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtThongKe.SmallImage")));
            this.rbtThongKe.Text = "Thống kê";
            this.rbtThongKe.Click += new System.EventHandler(this.rbtThongKe_Click);
            // 
            // rbtNhapKho
            // 
            this.rbtNhapKho.Image = ((System.Drawing.Image)(resources.GetObject("rbtNhapKho.Image")));
            this.rbtNhapKho.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtNhapKho.LargeImage")));
            this.rbtNhapKho.MinimumSize = new System.Drawing.Size(100, 0);
            this.rbtNhapKho.Name = "rbtNhapKho";
            this.rbtNhapKho.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtNhapKho.SmallImage")));
            this.rbtNhapKho.Text = "Nhập kho";
            this.rbtNhapKho.Click += new System.EventHandler(this.rbtNhapKho_Click);
            // 
            // rbtDSPN
            // 
            this.rbtDSPN.Image = ((System.Drawing.Image)(resources.GetObject("rbtDSPN.Image")));
            this.rbtDSPN.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtDSPN.LargeImage")));
            this.rbtDSPN.MinimumSize = new System.Drawing.Size(150, 0);
            this.rbtDSPN.Name = "rbtDSPN";
            this.rbtDSPN.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtDSPN.SmallImage")));
            this.rbtDSPN.Text = "Danh sách phiếu nhập";
            this.rbtDSPN.Click += new System.EventHandler(this.rbtDSPN_Click);
            // 
            // rbtBanLe
            // 
            this.rbtBanLe.Image = ((System.Drawing.Image)(resources.GetObject("rbtBanLe.Image")));
            this.rbtBanLe.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtBanLe.LargeImage")));
            this.rbtBanLe.MinimumSize = new System.Drawing.Size(120, 0);
            this.rbtBanLe.Name = "rbtBanLe";
            this.rbtBanLe.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtBanLe.SmallImage")));
            this.rbtBanLe.Text = "Xuất hóa đơn";
            this.rbtBanLe.Click += new System.EventHandler(this.rbtBanLe_Click);
            // 
            // rbtDSPX
            // 
            this.rbtDSPX.Image = ((System.Drawing.Image)(resources.GetObject("rbtDSPX.Image")));
            this.rbtDSPX.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtDSPX.LargeImage")));
            this.rbtDSPX.MinimumSize = new System.Drawing.Size(150, 0);
            this.rbtDSPX.Name = "rbtDSPX";
            this.rbtDSPX.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtDSPX.SmallImage")));
            this.rbtDSPX.Text = "Danh sách hóa đơn";
            this.rbtDSPX.Click += new System.EventHandler(this.rbtDSPX_Click);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1134, 623);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ribbon1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.TrangChu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonTab ribbonTab2;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonTab ribbonTab3;
        private System.Windows.Forms.RibbonButton rbtDoiMatKhau;
        private System.Windows.Forms.RibbonButton rbtDangXuat;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem1;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem2;
        private System.Windows.Forms.RibbonButton rbtQLSach;
        private System.Windows.Forms.RibbonButton rbtQLTK;
        private System.Windows.Forms.RibbonButton rbtNCC;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton rbtThongKe;
        private System.Windows.Forms.RibbonButton rbtNhapKho;
        private System.Windows.Forms.RibbonButton rbtDSPN;
        private System.Windows.Forms.RibbonButton rbtBanLe;
        private System.Windows.Forms.RibbonButton rbtDSPX;
        private System.Windows.Forms.RibbonButton rbtThongTin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}