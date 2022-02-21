using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_WinDow
{
    public partial class ThongKe : Form
    {
        Model1 db = new Model1();
        public ThongKe()
        {
            InitializeComponent();
            DTThongKe.Format = DateTimePickerFormat.Custom;
            DTThongKe.CustomFormat = "MM/yyyy";
            DTThongKe.ShowUpDown = true;
            chartTK.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
            chartTK.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng";
            chartTK.ChartAreas["ChartArea1"].AxisX.Interval = 1;
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            Nhap();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DTThongKe_ValueChanged(object sender, EventArgs e)
        {
            Nhap();
            Xuat();
        }

        private void rbtnNhap_CheckedChanged(object sender, EventArgs e)
        {
            Nhap();
        }

        private void rbtnXuat_CheckedChanged(object sender, EventArgs e)
        {
            Xuat();
        }
        private void Nhap()
        {
            if (rbtnNhap.Checked)
            {
                chartTK.Series[0].Points.Clear();
                chartTK.Series[1].Points.Clear();
                var nhap = db.PhieuNhaps.AsQueryable();
                int month = Convert.ToInt32(DTThongKe.Value.Month);
                int year = Convert.ToInt32(DTThongKe.Value.Year);
                int ngay = DateTime.DaysInMonth(year, month);
                List<int> ngays=new List<int>();
                    for (int i=1; i <= ngay; i++)
                {
                    var slhd = db.PhieuNhaps.Count(p => p.NgayNhap.Value.Day == i && p.NgayNhap.Value.Month == month && p.NgayNhap.Value.Year == year);
                        chartTK.Series[1].Points.AddXY(i, slhd);
                    int? slsp = 0;
                    var phieunhaps = db.PhieuNhaps.Where(p => p.NgayNhap.Value.Day == i && p.NgayNhap.Value.Month == month && p.NgayNhap.Value.Year == year).ToList();
                    foreach(var p in phieunhaps)
                    {
                        foreach(var ct in p.ChiTietPhieuNhaps)
                        {
                            slsp = slsp + ct.SoLuong;
                        }
                    }
                        chartTK.Series[0].Points.AddXY(i, slsp);
                    
                }
                var hd= db.PhieuNhaps.Count(p=>p.NgayNhap.Value.Month == month && p.NgayNhap.Value.Year == year);
                label1.Text =hd+"";
                int? sp = 0;
                int? tongtien = 0;
                var phieunhapss = db.PhieuNhaps.Where(p =>p.NgayNhap.Value.Month == month && p.NgayNhap.Value.Year == year).ToList();
                foreach (var p in phieunhapss)
                {
                    foreach (var ct in p.ChiTietPhieuNhaps)
                    {
                        sp = sp + ct.SoLuong;
                        tongtien = tongtien + (ct.SoLuong * ct.DonGia);
                    }
                }
                label5.Text =sp+"";
                label6.Text =tongtien+"";



            }
        }
        private void Xuat()
        {
            if (rbtnXuat.Checked)
            {
                chartTK.Series[1].Points.Clear();
                chartTK.Series[0].Points.Clear();
                var nhap = db.PhieuNhaps.AsQueryable();
                int month = Convert.ToInt32(DTThongKe.Value.Month);
                int year = Convert.ToInt32(DTThongKe.Value.Year);
                int ngay = DateTime.DaysInMonth(year, month);
                List<int> ngays = new List<int>();
                for (int i = 1; i <= ngay; i++)
                {
                    var slhd = db.DonHangs.Count(d => d.NgayLapDon.Day == i && d.NgayLapDon.Month == month && d.NgayLapDon.Year == year);
                    chartTK.Series[1].Points.AddXY(i, slhd);
                    int? slsp = 0;
                    var donhangs = db.DonHangs.Where(d => d.NgayLapDon.Day == i && d.NgayLapDon.Month == month && d.NgayLapDon.Year == year).ToList();
                    foreach (var d in donhangs)
                    {
                        foreach (var ct in d.ChiTietDonHangs)
                        {
                            slsp = slsp + ct.SoLuong;
                        }
                    }
                    chartTK.Series[0].Points.AddXY(i, slsp);
                }
                var hd = db.DonHangs.Count(p => p.NgayLapDon.Month == month && p.NgayLapDon.Year == year);
                label1.Text =hd+"";
                int? sp = 0;
                int? tongtien = 0;
                var donhangss = db.DonHangs.Where(d => d.NgayLapDon.Month == month && d.NgayLapDon.Year == year).ToList();
                foreach (var d in donhangss)
                {
                    foreach (var ct in d.ChiTietDonHangs)
                    {
                        sp = sp + ct.SoLuong;
                        tongtien = tongtien + (ct.DonGia * ct.SoLuong);
                    }
                }
                label5.Text =sp+"";
                label6.Text =tongtien+"";

            }
        }

        private void lbSLHoaDon_Click(object sender, EventArgs e)
        {

        }
    }
}
