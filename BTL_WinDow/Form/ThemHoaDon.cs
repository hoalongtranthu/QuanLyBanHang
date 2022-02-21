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
    public partial class ThemHoaDon : Form
    {
        private Model1 db = new Model1();
        List<NhanVien> nv;
        List<Sach> sach;
        int choice = -1;
        public ThemHoaDon(int choice)
        {
            InitializeComponent();
            nv = db.NhanViens.ToList();
            sach = db.Saches.ToList();
            if (choice < 0)
            {
                lbNguoiLap.Visible = false;
                lbNgayLap.Visible = false;
                lbTenKhachHang.Visible = false;
                lbDiaChi.Visible = false;
                lbSDT.Visible = false;
            }
            else
            {
                this.choice = choice;
                cbNguoiLap.Visible = false;
                dateTimePicker1.Visible = false;
                txtKhachHang.Visible = false;
                txtDiaChi.Visible = false;
                txtSDT.Visible = false;
                txtSL.Visible = false;
                cbTenSach.Visible = false;
                txtDonGia.Visible = false;
                lbTieuDeSach.Visible = false;
                lbSoLuong.Visible = false;
                lbDonGia.Visible = false;
                btnThemSachVaoHD.Visible = false;
                btnLuu.Visible = false;
                btnXoa.Visible = false;
                var dh = db.DonHangs.Find(choice);
                lbNguoiLap.Text = dh.NhanVien.HoTen;
                lbNgayLap.Text = dh.NgayLapDon.ToString();
                lbTenKhachHang.Text = dh.TenKhachHang;
                lbDiaChi.Text = dh.DiaChi;
                lbSDT.Text = dh.SDT;
                int? tongTien = 0;
                foreach (var l in dh.ChiTietDonHangs)
                {

                    dgvPhieuXuat.Rows.Add(l.MaSach, l.Sach.TieuDe, l.SoLuong, l.DonGia);
                    tongTien += l.SoLuong * l.DonGia;
                }
                lbTongTien.Text = tongTien + "";
                lbSoLuongSach.Text = dgvPhieuXuat.Rows.Count + "";

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        DonHang dh;
        private void SaveDonHang(int? id)
        {
            
            
            if (id == -1)
            {
                dh = new DonHang
                {
                    NgayLapDon = dateTimePicker1.Value,
                    TenKhachHang = txtKhachHang.Text,
                    SDT = txtSDT.Text,
                    DiaChi = txtDiaChi.Text,
                    MaNV = nv.Find(e1 => e1.HoTen == cbNguoiLap.Text).MaNV,

                };
                db.DonHangs.Add(dh);
                db.SaveChanges();
                foreach (var l in ctdh)
                {
                    l.MaDH = dh.MaDH;

                }
                db.ChiTietDonHangs.AddRange(ctdh);
                db.SaveChanges();
                
                MessageBox.Show("Tạo đơn hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dh = GetDonHang(id);
            }
            
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
           
            
                if (dgvPhieuXuat.RowCount - 1 == 0)
                {
                    MessageBox.Show("Cần ít nhất thêm 1 mặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    SaveDonHang(choice);
                    if (MessageBox.Show("Hóa đơn được tạo! Xuất hóa đơn ngay?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        PrintInvoice(dh.MaDH);
                    }
                    Close();
                }
               
            
           
        }
        private DonHang GetDonHang(int? id)
        {
            return db.DonHangs.Include("ChiTietDonHangs.Sach").FirstOrDefault(e => e.MaDH == id);
        }
        private void PrintInvoice(int id)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                new InHoaDon().PrintToFile(saveFileDialog1.FileName, GetDonHang(id));
                MessageBox.Show("Xuất hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool CheckValid()
        {
            int a;
            if (txtSL.Text != string.Empty)
            {
                if (!int.TryParse(txtSL.Text, out a)) {
                    MessageBox.Show("Vui lòng nhập đúng số lượng", "Thông báo", MessageBoxButtons.OK);
                    return false;

                }
               
            }
            if (!int.TryParse(txtDonGia.Text, out a))
            {
                MessageBox.Show("Vui lòng nhập đúng đơn giá", "Thông báo", MessageBoxButtons.OK);
                txtDonGia.Focus();
                return false;

            }
            if (txtSL.Text == string.Empty)
            {
                MessageBox.Show("Không được bỏ trống số lượng", "Thông báo", MessageBoxButtons.OK);
                txtSL.Focus();
                return false;
            }
            if (txtKhachHang.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống tên khách hàng", "Thông báo", MessageBoxButtons.OK);
                txtSL.Focus();
                return false;
            }
            if (cbTenSach.SelectedValue == null)
            {
                MessageBox.Show(this, "Vui lòng chọn sách đúng trong combobox!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (DateTime.Compare(dateTimePicker1.Value, DateTime.Now) > 0)
            {
                MessageBox.Show(this, "Ngày lập phiếu không được lớn hơn ngày hiện tại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

                return true;
        }
        List<ChiTietDonHang> ctdh = new List<ChiTietDonHang>();
        private void button1_Click(object sender, EventArgs e1)
        {
            dgvPhieuXuat.DataSource = null;
            dgvPhieuXuat.Rows.Clear();
            dgvPhieuXuat.Refresh();

            if (!CheckValid())
            {
            }
            else
            {
                int? tongTien = 0;
                //db.DonHangs()
                Sach s = (Sach)cbTenSach.SelectedItem;
                ChiTietDonHang ct = new ChiTietDonHang { MaSach = s.MaSach, SoLuong = int.Parse(txtSL.Text), DonGia = int.Parse(txtDonGia.Text) , Sach  = (Sach)cbTenSach.SelectedItem };
                if (ct.SoLuong > db.Saches.Find(ct.MaSach).SoLuongCo)
                {
                    
                    foreach (var l in ctdh)
                    {
                        dgvPhieuXuat.Rows.Add(l.MaSach, l.Sach.TieuDe, l.SoLuong, l.DonGia);
                        tongTien += l.SoLuong * l.DonGia;
                    }
                    lbTongTien.Text = tongTien.ToString();
                    lbSoLuongSach.Text = (dgvPhieuXuat.RowCount - 1).ToString();
                    MessageBox.Show(this, "Mặt hàng này trong kho đã hết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (ctdh.Count == 0)
                    {
                        ctdh.Add(ct);
                        db.Saches.Find(ct.MaSach).SoLuongCo -= ct.SoLuong;
                    }
                    else
                    {
                        Boolean k = true;
                        foreach (var i in ctdh)
                        {
                            if (ct.MaSach == i.MaSach)
                            {
                                i.SoLuong += ct.SoLuong;
                                k = false;
                            }
                        }
                        if (k)
                        {
                            ctdh.Add(ct);
                            db.Saches.Find(ct.MaSach).SoLuongCo -= ct.SoLuong;
                        }
                    }
                    foreach (var l in ctdh)
                    {

                        dgvPhieuXuat.Rows.Add(l.MaSach, l.Sach.TieuDe, l.SoLuong, l.DonGia);
                        tongTien += l.SoLuong * l.DonGia;
                    }
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    lbTongTien.Text = tongTien.ToString();
                    lbSoLuongSach.Text = (dgvPhieuXuat.RowCount - 1).ToString();
                }
                
            }
        }
        
        private void cbTenSach_SelectedValueChanged(object sender, EventArgs e)
        {
            
            Sach s = (Sach)cbTenSach.SelectedItem;
            txtDonGia.Text = sach.Where(e1 => e1.MaSach==s.MaSach).FirstOrDefault().GiaBan.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveDonHang(choice);
            PrintInvoice(dh.MaDH);
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = dgvPhieuXuat.SelectedRows;
                if (rows.Count > 0)
                {
                    string tieude = Convert.ToString(rows[0].Cells["TieuDe"].Value);
                    var sach = db.Saches.FirstOrDefault(s => s.TieuDe == tieude);
                    if (sach == null)
                    {
                        MessageBox.Show(this, "Vui lòng chọn bản ghi muốn xóa hợp lệ!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (MessageBox.Show(this, "Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataGridViewRow row;
                        int length;

                        length = dgvPhieuXuat.SelectedRows.Count;
                        for (int i = length - 1; i >= 0; i--)
                        {
                            row = dgvPhieuXuat.SelectedRows[i];
                            int maSach = int.Parse(row.Cells["MaSach"].Value.ToString());
                            var sach1 = ctdh.FirstOrDefault(s => s.MaSach == maSach);
                            ctdh.Remove(sach1);
                            db.Saches.Find(maSach).SoLuongCo += sach1.SoLuong;
                            dgvPhieuXuat.Rows.Remove(row);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng muốn xóa!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Có lỗi " + ex.Message + " xảy ra trong quá trình thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ThemHoaDon_Load(object sender, EventArgs e)
        {
            nv = db.NhanViens.ToList();
            sach = db.Saches.ToList();
            dateTimePicker1.Value = DateTime.Now;
            cbNguoiLap.DataSource = nv.ToList();
            cbNguoiLap.DisplayMember = "HoTen";
            cbNguoiLap.ValueMember = "MaNV";

            cbTenSach.DataSource = db.Saches.ToList();
            cbTenSach.DisplayMember = "TieuDe";
            cbTenSach.ValueMember = "MaSach";
            cbTenSach.SelectedIndex = 0;
            cbNguoiLap.SelectedValue = DangNhap.NguoiDangNhap.MaNV;
            foreach (DataGridViewColumn col in dgvPhieuXuat.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Microsoft San Serif", 8, FontStyle.Bold);
            }
            // TODO: This line of code loads data into the 'qLCuaHangSachDataSet.Sach' table. You can move, or remove it, as needed.

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
