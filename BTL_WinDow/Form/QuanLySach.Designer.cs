
namespace BTL_WinDow
{
    partial class SachForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SachForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.txtNhaPH = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbSL = new System.Windows.Forms.Label();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.maSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTNgayPH = new System.Windows.Forms.DateTimePicker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnThemMoi = new System.Windows.Forms.ToolStripButton();
            this.btnSuaThongTin = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(22, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiêu đề:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(22, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhà phát hành:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(22, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày phát hành:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(489, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tác giả:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(489, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giá bán:";
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Location = new System.Drawing.Point(178, 51);
            this.txtTieuDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(199, 22);
            this.txtTieuDe.TabIndex = 7;
            // 
            // txtNhaPH
            // 
            this.txtNhaPH.Location = new System.Drawing.Point(178, 92);
            this.txtNhaPH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNhaPH.Name = "txtNhaPH";
            this.txtNhaPH.Size = new System.Drawing.Size(199, 22);
            this.txtNhaPH.TabIndex = 8;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTacGia.Location = new System.Drawing.Point(596, 47);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(189, 22);
            this.txtTacGia.TabIndex = 10;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaBan.Location = new System.Drawing.Point(596, 88);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(189, 22);
            this.txtGiaBan.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(23, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Số lượng sách:";
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.ForeColor = System.Drawing.Color.Blue;
            this.lbSL.Location = new System.Drawing.Point(159, 177);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(16, 17);
            this.lbSL.TabIndex = 22;
            this.lbSL.Text = "0";
            // 
            // dgvSach
            // 
            this.dgvSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSach,
            this.tieuDe,
            this.NhaPH,
            this.NgayPH,
            this.tacGia,
            this.giaBan,
            this.SLC});
            this.dgvSach.Location = new System.Drawing.Point(26, 206);
            this.dgvSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.RowTemplate.Height = 24;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(980, 176);
            this.dgvSach.TabIndex = 23;
            this.dgvSach.SelectionChanged += new System.EventHandler(this.dgvSach_SelectionChanged);
            // 
            // maSach
            // 
            this.maSach.HeaderText = "Mã sách";
            this.maSach.MinimumWidth = 6;
            this.maSach.Name = "maSach";
            // 
            // tieuDe
            // 
            this.tieuDe.HeaderText = "Tiêu đề";
            this.tieuDe.MinimumWidth = 6;
            this.tieuDe.Name = "tieuDe";
            // 
            // NhaPH
            // 
            this.NhaPH.HeaderText = "Nhà phát hành";
            this.NhaPH.MinimumWidth = 6;
            this.NhaPH.Name = "NhaPH";
            // 
            // NgayPH
            // 
            this.NgayPH.HeaderText = "Ngày phát hành";
            this.NgayPH.MinimumWidth = 6;
            this.NgayPH.Name = "NgayPH";
            // 
            // tacGia
            // 
            this.tacGia.HeaderText = "Tác giả";
            this.tacGia.MinimumWidth = 6;
            this.tacGia.Name = "tacGia";
            // 
            // giaBan
            // 
            this.giaBan.HeaderText = "Giá Bán";
            this.giaBan.MinimumWidth = 6;
            this.giaBan.Name = "giaBan";
            // 
            // SLC
            // 
            this.SLC.HeaderText = "Số lượng có";
            this.SLC.MinimumWidth = 6;
            this.SLC.Name = "SLC";
            // 
            // DTNgayPH
            // 
            this.DTNgayPH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTNgayPH.Location = new System.Drawing.Point(178, 129);
            this.DTNgayPH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTNgayPH.Name = "DTNgayPH";
            this.DTNgayPH.Size = new System.Drawing.Size(199, 22);
            this.DTNgayPH.TabIndex = 24;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Blue;
            this.btnThoat.Image = global::BTL_WinDow.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_go_next;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(898, 47);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 57);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnThemMoi,
            this.btnSuaThongTin,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1024, 27);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(91, 24);
            this.toolStripButton1.Text = "Làm mới";
            this.toolStripButton1.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.Image")));
            this.btnThemMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(70, 24);
            this.btnThemMoi.Text = "Thêm";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSuaThongTin
            // 
            this.btnSuaThongTin.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaThongTin.Image")));
            this.btnSuaThongTin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuaThongTin.Name = "btnSuaThongTin";
            this.btnSuaThongTin.Size = new System.Drawing.Size(58, 24);
            this.btnSuaThongTin.Text = "Sửa";
            this.btnSuaThongTin.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(59, 24);
            this.toolStripButton2.Text = "Xóa";
            this.toolStripButton2.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(94, 24);
            this.toolStripButton3.Text = "Tìm kiếm";
            this.toolStripButton3.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(98, 24);
            this.toolStripButton4.Text = "Xóa trắng";
            this.toolStripButton4.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // SachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1024, 447);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.DTNgayPH);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.lbSL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.txtNhaPH);
            this.Controls.Add(this.txtTieuDe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SachForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.SachForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.TextBox txtNhaPH;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.DateTimePicker DTNgayPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLC;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnThemMoi;
        private System.Windows.Forms.ToolStripButton btnSuaThongTin;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}

