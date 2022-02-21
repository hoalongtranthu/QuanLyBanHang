
namespace BTL_WinDow
{
    partial class ThemHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemHoaDon));
            this.btnThemSachVaoHD = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbTieuDeSach = new System.Windows.Forms.Label();
            this.cbTenSach = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.dgvPhieuXuat = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbNguoiLap = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.lbSoLuongSach = new System.Windows.Forms.Label();
            this.lbDiaChi1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.lbSDT1 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lbNguoiLap = new System.Windows.Forms.Label();
            this.lbNgayLap = new System.Windows.Forms.Label();
            this.lbTenKhachHang = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemSachVaoHD
            // 
            this.btnThemSachVaoHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSachVaoHD.ForeColor = System.Drawing.Color.Blue;
            this.btnThemSachVaoHD.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSachVaoHD.Image")));
            this.btnThemSachVaoHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSachVaoHD.Location = new System.Drawing.Point(957, 112);
            this.btnThemSachVaoHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemSachVaoHD.Name = "btnThemSachVaoHD";
            this.btnThemSachVaoHD.Size = new System.Drawing.Size(217, 44);
            this.btnThemSachVaoHD.TabIndex = 77;
            this.btnThemSachVaoHD.Text = "Thêm vào hóa đơn";
            this.btnThemSachVaoHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemSachVaoHD.UseVisualStyleBackColor = true;
            this.btnThemSachVaoHD.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(445, 36);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 76;
            this.label11.Text = "Ngày lập:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(37, 174);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(227, 20);
            this.label10.TabIndex = 75;
            this.label10.Text = "Số lượng sách trong hóa đơn:";
            // 
            // lbTongTien
            // 
            this.lbTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.ForeColor = System.Drawing.Color.Blue;
            this.lbTongTien.Location = new System.Drawing.Point(149, 396);
            this.lbTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(18, 20);
            this.lbTongTien.TabIndex = 74;
            this.lbTongTien.Text = "0";
            this.lbTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(33, 396);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 73;
            this.label7.Text = "Tổng tiền:";
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonGia.ForeColor = System.Drawing.Color.Blue;
            this.lbDonGia.Location = new System.Drawing.Point(683, 121);
            this.lbDonGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(71, 20);
            this.lbDonGia.TabIndex = 72;
            this.lbDonGia.Text = "Đơn giá:";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.ForeColor = System.Drawing.Color.Blue;
            this.lbSoLuong.Location = new System.Drawing.Point(392, 122);
            this.lbSoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(79, 20);
            this.lbSoLuong.TabIndex = 71;
            this.lbSoLuong.Text = "Số lượng:";
            // 
            // lbTieuDeSach
            // 
            this.lbTieuDeSach.AutoSize = true;
            this.lbTieuDeSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDeSach.ForeColor = System.Drawing.Color.Blue;
            this.lbTieuDeSach.Location = new System.Drawing.Point(32, 122);
            this.lbTieuDeSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTieuDeSach.Name = "lbTieuDeSach";
            this.lbTieuDeSach.Size = new System.Drawing.Size(110, 20);
            this.lbTieuDeSach.TabIndex = 70;
            this.lbTieuDeSach.Text = "Tiêu đề sách:";
            // 
            // cbTenSach
            // 
            this.cbTenSach.DisplayMember = "MaSach";
            this.cbTenSach.FormattingEnabled = true;
            this.cbTenSach.Location = new System.Drawing.Point(179, 121);
            this.cbTenSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTenSach.Name = "cbTenSach";
            this.cbTenSach.Size = new System.Drawing.Size(160, 24);
            this.cbTenSach.TabIndex = 67;
            this.cbTenSach.ValueMember = "MaSach";
            this.cbTenSach.SelectedValueChanged += new System.EventHandler(this.cbTenSach_SelectedValueChanged);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(780, 121);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(132, 22);
            this.txtDonGia.TabIndex = 66;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(490, 122);
            this.txtSL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(132, 22);
            this.txtSL.TabIndex = 65;
            // 
            // dgvPhieuXuat
            // 
            this.dgvPhieuXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhieuXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TieuDe,
            this.SoLuong,
            this.DonGia});
            this.dgvPhieuXuat.Location = new System.Drawing.Point(36, 197);
            this.dgvPhieuXuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPhieuXuat.Name = "dgvPhieuXuat";
            this.dgvPhieuXuat.RowHeadersWidth = 51;
            this.dgvPhieuXuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuXuat.Size = new System.Drawing.Size(1139, 176);
            this.dgvPhieuXuat.TabIndex = 63;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            // 
            // TieuDe
            // 
            this.TieuDe.HeaderText = "Tiêu đề";
            this.TieuDe.MinimumWidth = 6;
            this.TieuDe.Name = "TieuDe";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(567, 34);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 22);
            this.dateTimePicker1.TabIndex = 61;
            // 
            // cbNguoiLap
            // 
            this.cbNguoiLap.FormattingEnabled = true;
            this.cbNguoiLap.Location = new System.Drawing.Point(143, 36);
            this.cbNguoiLap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNguoiLap.Name = "cbNguoiLap";
            this.cbNguoiLap.Size = new System.Drawing.Size(160, 24);
            this.cbNguoiLap.TabIndex = 60;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Blue;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(1019, 496);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(125, 62);
            this.btnThoat.TabIndex = 59;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Blue;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(179, 496);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(237, 62);
            this.btnXoa.TabIndex = 58;
            this.btnXoa.Text = "Xóa hàng khỏi hóa đơn";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Blue;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuu.Location = new System.Drawing.Point(819, 496);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(161, 62);
            this.btnLuu.TabIndex = 57;
            this.btnLuu.Text = "Lưu vào CSDL";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Người lập:";
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.ForeColor = System.Drawing.Color.Blue;
            this.btnInHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnInHoaDon.Image")));
            this.btnInHoaDon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInHoaDon.Location = new System.Drawing.Point(43, 496);
            this.btnInHoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(125, 62);
            this.btnInHoaDon.TabIndex = 78;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbSoLuongSach
            // 
            this.lbSoLuongSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSoLuongSach.AutoSize = true;
            this.lbSoLuongSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuongSach.ForeColor = System.Drawing.Color.Blue;
            this.lbSoLuongSach.Location = new System.Drawing.Point(285, 174);
            this.lbSoLuongSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoLuongSach.Name = "lbSoLuongSach";
            this.lbSoLuongSach.Size = new System.Drawing.Size(18, 20);
            this.lbSoLuongSach.TabIndex = 79;
            this.lbSoLuongSach.Text = "0";
            this.lbSoLuongSach.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbDiaChi1
            // 
            this.lbDiaChi1.AutoSize = true;
            this.lbDiaChi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi1.ForeColor = System.Drawing.Color.Blue;
            this.lbDiaChi1.Location = new System.Drawing.Point(473, 76);
            this.lbDiaChi1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDiaChi1.Name = "lbDiaChi1";
            this.lbDiaChi1.Size = new System.Drawing.Size(66, 20);
            this.lbDiaChi1.TabIndex = 83;
            this.lbDiaChi1.Text = "Địa chỉ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(32, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 20);
            this.label9.TabIndex = 82;
            this.label9.Text = "Tên khách hàng:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(555, 74);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(199, 22);
            this.txtDiaChi.TabIndex = 81;
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(203, 76);
            this.txtKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(199, 22);
            this.txtKhachHang.TabIndex = 80;
            // 
            // lbSDT1
            // 
            this.lbSDT1.AutoSize = true;
            this.lbSDT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT1.ForeColor = System.Drawing.Color.Blue;
            this.lbSDT1.Location = new System.Drawing.Point(971, 76);
            this.lbSDT1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSDT1.Name = "lbSDT1";
            this.lbSDT1.Size = new System.Drawing.Size(47, 20);
            this.lbSDT1.TabIndex = 85;
            this.lbSDT1.Text = "SĐT:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(1043, 74);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(132, 22);
            this.txtSDT.TabIndex = 84;
            // 
            // lbNguoiLap
            // 
            this.lbNguoiLap.AutoSize = true;
            this.lbNguoiLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNguoiLap.ForeColor = System.Drawing.Color.Blue;
            this.lbNguoiLap.Location = new System.Drawing.Point(149, 36);
            this.lbNguoiLap.Name = "lbNguoiLap";
            this.lbNguoiLap.Size = new System.Drawing.Size(93, 20);
            this.lbNguoiLap.TabIndex = 86;
            this.lbNguoiLap.Text = "lbNguoiLap";
            // 
            // lbNgayLap
            // 
            this.lbNgayLap.AutoSize = true;
            this.lbNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayLap.ForeColor = System.Drawing.Color.Blue;
            this.lbNgayLap.Location = new System.Drawing.Point(572, 34);
            this.lbNgayLap.Name = "lbNgayLap";
            this.lbNgayLap.Size = new System.Drawing.Size(88, 20);
            this.lbNgayLap.TabIndex = 87;
            this.lbNgayLap.Text = "lbNgayLap";
            // 
            // lbTenKhachHang
            // 
            this.lbTenKhachHang.AutoSize = true;
            this.lbTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKhachHang.ForeColor = System.Drawing.Color.Blue;
            this.lbTenKhachHang.Location = new System.Drawing.Point(199, 76);
            this.lbTenKhachHang.Name = "lbTenKhachHang";
            this.lbTenKhachHang.Size = new System.Drawing.Size(137, 20);
            this.lbTenKhachHang.TabIndex = 88;
            this.lbTenKhachHang.Text = "lbTenKhachHang";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.ForeColor = System.Drawing.Color.Blue;
            this.lbDiaChi.Location = new System.Drawing.Point(557, 74);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(0, 20);
            this.lbDiaChi.TabIndex = 89;
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.ForeColor = System.Drawing.Color.Blue;
            this.lbSDT.Location = new System.Drawing.Point(1039, 76);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(0, 20);
            this.lbSDT.TabIndex = 90;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.AddExtension = false;
            this.saveFileDialog1.DefaultExt = "pdf";
            // 
            // ThemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 572);
            this.ControlBox = false;
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbTenKhachHang);
            this.Controls.Add(this.lbNgayLap);
            this.Controls.Add(this.lbNguoiLap);
            this.Controls.Add(this.lbSDT1);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lbDiaChi1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtKhachHang);
            this.Controls.Add(this.lbSoLuongSach);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnThemSachVaoHD);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbDonGia);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.lbTieuDeSach);
            this.Controls.Add(this.cbTenSach);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.dgvPhieuXuat);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbNguoiLap);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ThemHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm hóa đơn mới";
            this.Load += new System.EventHandler(this.ThemHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemSachVaoHD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbTieuDeSach;
        private System.Windows.Forms.ComboBox cbTenSach;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.DataGridView dgvPhieuXuat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbNguoiLap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Label lbSoLuongSach;
        private System.Windows.Forms.Label lbDiaChi1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.Label lbSDT1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.Label lbNguoiLap;
        private System.Windows.Forms.Label lbNgayLap;
        private System.Windows.Forms.Label lbTenKhachHang;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}