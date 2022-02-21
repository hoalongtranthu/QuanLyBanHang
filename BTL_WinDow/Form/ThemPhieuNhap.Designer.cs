
namespace BTL_WinDow
{
    partial class ThemPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemPhieuNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.cbNguoiLap = new System.Windows.Forms.ComboBox();
            this.DTNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.dgvCTPN = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbNCC = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.cbbTenSach = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTenSach = new System.Windows.Forms.Label();
            this.lbSL = new System.Windows.Forms.Label();
            this.lbDG = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbthemsach = new System.Windows.Forms.Label();
            this.lbNguoiLap = new System.Windows.Forms.Label();
            this.lbNCC = new System.Windows.Forms.Label();
            this.btnThemSachVaoPhieuNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoaSachKhoiPhieuNhap = new System.Windows.Forms.Button();
            this.btnLuuPhieuNhap = new System.Windows.Forms.Button();
            this.btnThemSachCSDL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Người lập";
            // 
            // cbNguoiLap
            // 
            this.cbNguoiLap.FormattingEnabled = true;
            this.cbNguoiLap.Location = new System.Drawing.Point(115, 26);
            this.cbNguoiLap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNguoiLap.Name = "cbNguoiLap";
            this.cbNguoiLap.Size = new System.Drawing.Size(160, 24);
            this.cbNguoiLap.TabIndex = 36;
            this.cbNguoiLap.Text = "System.Data.DataViewManagerListItemTypeDescriptor";
            // 
            // DTNgayLap
            // 
            this.DTNgayLap.CustomFormat = "dd/MM/yyyy";
            this.DTNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTNgayLap.Location = new System.Drawing.Point(1016, 26);
            this.DTNgayLap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTNgayLap.Name = "DTNgayLap";
            this.DTNgayLap.Size = new System.Drawing.Size(133, 22);
            this.DTNgayLap.TabIndex = 37;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(101, 79);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(1048, 83);
            this.txtGhiChu.TabIndex = 38;
            // 
            // dgvCTPN
            // 
            this.dgvCTPN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TieuDe,
            this.SoLuong,
            this.DonGia});
            this.dgvCTPN.Location = new System.Drawing.Point(15, 281);
            this.dgvCTPN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCTPN.Name = "dgvCTPN";
            this.dgvCTPN.RowHeadersWidth = 51;
            this.dgvCTPN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTPN.Size = new System.Drawing.Size(1133, 185);
            this.dgvCTPN.TabIndex = 39;
            // 
            // MaSach
            // 
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
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            // 
            // cbbNCC
            // 
            this.cbbNCC.FormattingEnabled = true;
            this.cbbNCC.Location = new System.Drawing.Point(467, 25);
            this.cbbNCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbNCC.Name = "cbbNCC";
            this.cbbNCC.Size = new System.Drawing.Size(405, 24);
            this.cbbNCC.TabIndex = 40;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(419, 198);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(147, 22);
            this.txtSoLuong.TabIndex = 41;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(719, 198);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(132, 22);
            this.txtDonGia.TabIndex = 42;
            this.txtDonGia.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cbbTenSach
            // 
            this.cbbTenSach.FormattingEnabled = true;
            this.cbbTenSach.Location = new System.Drawing.Point(115, 198);
            this.cbbTenSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbTenSach.Name = "cbbTenSach";
            this.cbbTenSach.Size = new System.Drawing.Size(160, 24);
            this.cbbTenSach.TabIndex = 43;
            this.cbbTenSach.SelectedValueChanged += new System.EventHandler(this.cbbTenSach_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Ghi chú:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(300, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Nhà cung cấp:";
            // 
            // lbTenSach
            // 
            this.lbTenSach.AutoSize = true;
            this.lbTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSach.ForeColor = System.Drawing.Color.Blue;
            this.lbTenSach.Location = new System.Drawing.Point(13, 199);
            this.lbTenSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenSach.Name = "lbTenSach";
            this.lbTenSach.Size = new System.Drawing.Size(83, 20);
            this.lbTenSach.TabIndex = 46;
            this.lbTenSach.Text = "Tên sách:";
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSL.ForeColor = System.Drawing.Color.Blue;
            this.lbSL.Location = new System.Drawing.Point(309, 199);
            this.lbSL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(79, 20);
            this.lbSL.TabIndex = 47;
            this.lbSL.Text = "Số lượng:";
            // 
            // lbDG
            // 
            this.lbDG.AutoSize = true;
            this.lbDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDG.ForeColor = System.Drawing.Color.Blue;
            this.lbDG.Location = new System.Drawing.Point(623, 199);
            this.lbDG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDG.Name = "lbDG";
            this.lbDG.Size = new System.Drawing.Size(71, 20);
            this.lbDG.TabIndex = 48;
            this.lbDG.Text = "Đơn giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(15, 482);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Tổng tiền:";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.ForeColor = System.Drawing.Color.Blue;
            this.lbTongTien.Location = new System.Drawing.Point(111, 482);
            this.lbTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(18, 20);
            this.lbTongTien.TabIndex = 50;
            this.lbTongTien.Text = "0";
            this.lbTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.ForeColor = System.Drawing.Color.Blue;
            this.lbSoLuong.Location = new System.Drawing.Point(1053, 256);
            this.lbSoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(18, 20);
            this.lbSoLuong.TabIndex = 52;
            this.lbSoLuong.Text = "0";
            this.lbSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(933, 256);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 51;
            this.label10.Text = "Số lượng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(891, 26);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 53;
            this.label11.Text = "Ngày lập:";
            // 
            // lbthemsach
            // 
            this.lbthemsach.AutoSize = true;
            this.lbthemsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbthemsach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbthemsach.Location = new System.Drawing.Point(13, 238);
            this.lbthemsach.Name = "lbthemsach";
            this.lbthemsach.Size = new System.Drawing.Size(296, 20);
            this.lbthemsach.TabIndex = 55;
            this.lbthemsach.Text = "Chưa có sách mới trong cơ sở dữ liệu?";
            // 
            // lbNguoiLap
            // 
            this.lbNguoiLap.AutoSize = true;
            this.lbNguoiLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNguoiLap.ForeColor = System.Drawing.Color.Blue;
            this.lbNguoiLap.Location = new System.Drawing.Point(129, 26);
            this.lbNguoiLap.Name = "lbNguoiLap";
            this.lbNguoiLap.Size = new System.Drawing.Size(53, 20);
            this.lbNguoiLap.TabIndex = 56;
            this.lbNguoiLap.Text = "label8";
            // 
            // lbNCC
            // 
            this.lbNCC.AutoSize = true;
            this.lbNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNCC.ForeColor = System.Drawing.Color.Blue;
            this.lbNCC.Location = new System.Drawing.Point(437, 25);
            this.lbNCC.Name = "lbNCC";
            this.lbNCC.Size = new System.Drawing.Size(53, 20);
            this.lbNCC.TabIndex = 57;
            this.lbNCC.Text = "label8";
            // 
            // btnThemSachVaoPhieuNhap
            // 
            this.btnThemSachVaoPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSachVaoPhieuNhap.ForeColor = System.Drawing.Color.Blue;
            this.btnThemSachVaoPhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSachVaoPhieuNhap.Image")));
            this.btnThemSachVaoPhieuNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSachVaoPhieuNhap.Location = new System.Drawing.Point(864, 185);
            this.btnThemSachVaoPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemSachVaoPhieuNhap.Name = "btnThemSachVaoPhieuNhap";
            this.btnThemSachVaoPhieuNhap.Size = new System.Drawing.Size(285, 41);
            this.btnThemSachVaoPhieuNhap.TabIndex = 54;
            this.btnThemSachVaoPhieuNhap.Text = "Thêm sách vào phiếu nhập";
            this.btnThemSachVaoPhieuNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemSachVaoPhieuNhap.UseVisualStyleBackColor = true;
            this.btnThemSachVaoPhieuNhap.Click += new System.EventHandler(this.btnThemSachVaoPhieuNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Blue;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(1024, 532);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(125, 62);
            this.btnThoat.TabIndex = 32;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaSachKhoiPhieuNhap
            // 
            this.btnXoaSachKhoiPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSachKhoiPhieuNhap.ForeColor = System.Drawing.Color.Blue;
            this.btnXoaSachKhoiPhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaSachKhoiPhieuNhap.Image")));
            this.btnXoaSachKhoiPhieuNhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoaSachKhoiPhieuNhap.Location = new System.Drawing.Point(19, 532);
            this.btnXoaSachKhoiPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaSachKhoiPhieuNhap.Name = "btnXoaSachKhoiPhieuNhap";
            this.btnXoaSachKhoiPhieuNhap.Size = new System.Drawing.Size(256, 62);
            this.btnXoaSachKhoiPhieuNhap.TabIndex = 31;
            this.btnXoaSachKhoiPhieuNhap.Text = "Xóa sách khỏi phiếu nhập";
            this.btnXoaSachKhoiPhieuNhap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoaSachKhoiPhieuNhap.UseVisualStyleBackColor = true;
            this.btnXoaSachKhoiPhieuNhap.Click += new System.EventHandler(this.btnXoaSachKhoiPhieuNhap_Click);
            // 
            // btnLuuPhieuNhap
            // 
            this.btnLuuPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuPhieuNhap.ForeColor = System.Drawing.Color.Blue;
            this.btnLuuPhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuPhieuNhap.Image")));
            this.btnLuuPhieuNhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuuPhieuNhap.Location = new System.Drawing.Point(864, 532);
            this.btnLuuPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuuPhieuNhap.Name = "btnLuuPhieuNhap";
            this.btnLuuPhieuNhap.Size = new System.Drawing.Size(125, 62);
            this.btnLuuPhieuNhap.TabIndex = 30;
            this.btnLuuPhieuNhap.Text = "Lưu";
            this.btnLuuPhieuNhap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuuPhieuNhap.UseVisualStyleBackColor = true;
            this.btnLuuPhieuNhap.Click += new System.EventHandler(this.btnLuuPhieuNhap_Click);
            // 
            // btnThemSachCSDL
            // 
            this.btnThemSachCSDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSachCSDL.ForeColor = System.Drawing.Color.Blue;
            this.btnThemSachCSDL.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSachCSDL.Image")));
            this.btnThemSachCSDL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSachCSDL.Location = new System.Drawing.Point(357, 228);
            this.btnThemSachCSDL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemSachCSDL.Name = "btnThemSachCSDL";
            this.btnThemSachCSDL.Size = new System.Drawing.Size(325, 41);
            this.btnThemSachCSDL.TabIndex = 29;
            this.btnThemSachCSDL.Text = "Thêm sách mới vào cơ sở dữ liệu";
            this.btnThemSachCSDL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemSachCSDL.UseVisualStyleBackColor = true;
            this.btnThemSachCSDL.Click += new System.EventHandler(this.btnThemSachCSDL_Click);
            // 
            // ThemPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1163, 607);
            this.ControlBox = false;
            this.Controls.Add(this.lbNCC);
            this.Controls.Add(this.lbNguoiLap);
            this.Controls.Add(this.lbthemsach);
            this.Controls.Add(this.btnThemSachVaoPhieuNhap);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbDG);
            this.Controls.Add(this.lbSL);
            this.Controls.Add(this.lbTenSach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbTenSach);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.cbbNCC);
            this.Controls.Add(this.dgvCTPN);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.DTNgayLap);
            this.Controls.Add(this.cbNguoiLap);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaSachKhoiPhieuNhap);
            this.Controls.Add(this.btnLuuPhieuNhap);
            this.Controls.Add(this.btnThemSachCSDL);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu nhập";
            this.Load += new System.EventHandler(this.ThemPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoaSachKhoiPhieuNhap;
        private System.Windows.Forms.Button btnLuuPhieuNhap;
        private System.Windows.Forms.Button btnThemSachCSDL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNguoiLap;
        private System.Windows.Forms.DateTimePicker DTNgayLap;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.DataGridView dgvCTPN;
        private System.Windows.Forms.ComboBox cbbNCC;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.ComboBox cbbTenSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTenSach;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.Label lbDG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnThemSachVaoPhieuNhap;
        private System.Windows.Forms.Label lbthemsach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.Label lbNguoiLap;
        private System.Windows.Forms.Label lbNCC;
    }
}