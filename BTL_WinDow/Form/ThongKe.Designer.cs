
namespace BTL_WinDow
{
    partial class ThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            this.chartTK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DTThongKe = new System.Windows.Forms.DateTimePicker();
            this.lbSLDonHang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnNhap = new System.Windows.Forms.RadioButton();
            this.rbtnXuat = new System.Windows.Forms.RadioButton();
            this.lbSLSanPham = new System.Windows.Forms.Label();
            this.lbGTGiaoDich = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartTK)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTK
            // 
            this.chartTK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartTK.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTK.Legends.Add(legend1);
            this.chartTK.Location = new System.Drawing.Point(229, 63);
            this.chartTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartTK.Name = "chartTK";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Số lượng sản phẩm";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.Red;
            series2.Name = "Số lượng hóa đơn";
            this.chartTK.Series.Add(series1);
            this.chartTK.Series.Add(series2);
            this.chartTK.Size = new System.Drawing.Size(1127, 430);
            this.chartTK.TabIndex = 0;
            this.chartTK.Text = "Thống kê";
            // 
            // DTThongKe
            // 
            this.DTThongKe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTThongKe.Location = new System.Drawing.Point(115, 63);
            this.DTThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTThongKe.Name = "DTThongKe";
            this.DTThongKe.Size = new System.Drawing.Size(109, 22);
            this.DTThongKe.TabIndex = 3;
            this.DTThongKe.ValueChanged += new System.EventHandler(this.DTThongKe_ValueChanged);
            // 
            // lbSLDonHang
            // 
            this.lbSLDonHang.AutoSize = true;
            this.lbSLDonHang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSLDonHang.ForeColor = System.Drawing.Color.Blue;
            this.lbSLDonHang.Location = new System.Drawing.Point(16, 175);
            this.lbSLDonHang.Name = "lbSLDonHang";
            this.lbSLDonHang.Size = new System.Drawing.Size(175, 50);
            this.lbSLDonHang.TabIndex = 4;
            this.lbSLDonHang.Text = "Tổng số lượng hóa \r\nđơn trong tháng:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(688, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bảng thống kê";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(16, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thời gian:";
            // 
            // rbtnNhap
            // 
            this.rbtnNhap.AutoSize = true;
            this.rbtnNhap.Checked = true;
            this.rbtnNhap.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNhap.ForeColor = System.Drawing.Color.Blue;
            this.rbtnNhap.Location = new System.Drawing.Point(16, 103);
            this.rbtnNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnNhap.Name = "rbtnNhap";
            this.rbtnNhap.Size = new System.Drawing.Size(127, 29);
            this.rbtnNhap.TabIndex = 8;
            this.rbtnNhap.TabStop = true;
            this.rbtnNhap.Text = "Nhập hàng";
            this.rbtnNhap.UseVisualStyleBackColor = true;
            this.rbtnNhap.CheckedChanged += new System.EventHandler(this.rbtnNhap_CheckedChanged);
            // 
            // rbtnXuat
            // 
            this.rbtnXuat.AutoSize = true;
            this.rbtnXuat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnXuat.Location = new System.Drawing.Point(16, 133);
            this.rbtnXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnXuat.Name = "rbtnXuat";
            this.rbtnXuat.Size = new System.Drawing.Size(113, 29);
            this.rbtnXuat.TabIndex = 9;
            this.rbtnXuat.Text = "Bán hàng";
            this.rbtnXuat.UseVisualStyleBackColor = true;
            this.rbtnXuat.CheckedChanged += new System.EventHandler(this.rbtnXuat_CheckedChanged);
            // 
            // lbSLSanPham
            // 
            this.lbSLSanPham.AutoSize = true;
            this.lbSLSanPham.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSLSanPham.ForeColor = System.Drawing.Color.Blue;
            this.lbSLSanPham.Location = new System.Drawing.Point(16, 242);
            this.lbSLSanPham.Name = "lbSLSanPham";
            this.lbSLSanPham.Size = new System.Drawing.Size(162, 75);
            this.lbSLSanPham.TabIndex = 10;
            this.lbSLSanPham.Text = "Tổng số lượng\r\nsản phẩm đã bán \r\ntrong tháng:";
            // 
            // lbGTGiaoDich
            // 
            this.lbGTGiaoDich.AutoSize = true;
            this.lbGTGiaoDich.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGTGiaoDich.ForeColor = System.Drawing.Color.Blue;
            this.lbGTGiaoDich.Location = new System.Drawing.Point(16, 336);
            this.lbGTGiaoDich.Name = "lbGTGiaoDich";
            this.lbGTGiaoDich.Size = new System.Drawing.Size(146, 75);
            this.lbGTGiaoDich.TabIndex = 13;
            this.lbGTGiaoDich.Text = "Tổng giá trị \r\ngiao dịch trong \r\ntháng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "0";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 534);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGTGiaoDich);
            this.Controls.Add(this.lbSLSanPham);
            this.Controls.Add(this.rbtnXuat);
            this.Controls.Add(this.rbtnNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSLDonHang);
            this.Controls.Add(this.DTThongKe);
            this.Controls.Add(this.chartTK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThongKe";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTK;
        private System.Windows.Forms.DateTimePicker DTThongKe;
        private System.Windows.Forms.Label lbSLDonHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnNhap;
        private System.Windows.Forms.RadioButton rbtnXuat;
        private System.Windows.Forms.Label lbSLSanPham;
        private System.Windows.Forms.Label lbGTGiaoDich;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}