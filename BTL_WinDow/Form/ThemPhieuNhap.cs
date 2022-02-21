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
    public partial class ThemPhieuNhap : Form
    {
        Model1 db = new Model1();
        List<ChiTietPhieuNhap> ctpn = new List<ChiTietPhieuNhap>();
        int choice;
        public ThemPhieuNhap(int c)
        {
            InitializeComponent();
            ctpn.Clear();
            choice = c;
            if (choice < 0)
            {
                lbNguoiLap.Visible = false;
                lbNCC.Visible = false;
            }
            else
            {
                cbNguoiLap.Visible = false;
                cbbNCC.Visible = false;
                btnLuuPhieuNhap.Visible = false;
                btnThemSachCSDL.Visible = false;
                btnXoaSachKhoiPhieuNhap.Visible = false;
                btnThemSachVaoPhieuNhap.Visible = false;
                lbthemsach.Visible = false;
                lbTenSach.Visible = false;
                lbSL.Visible = false;
                lbDG.Visible = false;
                cbbTenSach.Visible = false;
                txtDonGia.Visible = false;
                txtSoLuong.Visible = false;
                var phieunhaps = db.PhieuNhaps.Find(choice);
                int? tongTien = 0;
                foreach (var l in phieunhaps.ChiTietPhieuNhaps)
                {

                    dgvCTPN.Rows.Add(l.MaSach, l.Sach.TieuDe, l.SoLuong, l.DonGia);
                    tongTien += l.SoLuong * l.DonGia;
                }
                lbTongTien.Text = tongTien + "";
                lbNguoiLap.Text = phieunhaps.NhanVien.HoTen;
                lbNCC.Text = phieunhaps.XuongNhap.TenXN;
                lbSoLuong.Text = dgvCTPN.Rows.Count + "";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ThemPhieuNhap_Load(object sender, EventArgs e)
        {
            
            var nvs = db.NhanViens.ToList();
            var sachs = db.Saches.ToList();
            var nccs = db.XuongNhaps.ToList();
            DTNgayLap.Value = DateTime.Now;
            cbNguoiLap.DataSource = nvs;
            cbNguoiLap.DisplayMember = "HoTen";
            cbNguoiLap.ValueMember = "MaNV";

            cbbTenSach.DataSource = sachs;
            cbbTenSach.DisplayMember = "TieuDe";
            cbbTenSach.ValueMember = "MaSach";

            cbbNCC.DataSource = nccs;
            cbbNCC.DisplayMember = "TenXN";
            cbbNCC.ValueMember = "MaXN";
            cbbNCC.SelectedIndex = 0;
            cbbTenSach.SelectedIndex = 0;
            cbNguoiLap.SelectedValue = DangNhap.NguoiDangNhap.MaNV;
            foreach (DataGridViewColumn col in dgvCTPN.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Microsoft San Serif", 10, FontStyle.Bold);
            }
        }

            private void btnThemSachCSDL_Click(object sender, EventArgs e)
        {
            new SachForm(1).ShowDialog();
        }

        private void btnThemSachVaoPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                int a;
                dgvCTPN.DataSource = null;
                dgvCTPN.Rows.Clear();
                dgvCTPN.Refresh();

                if (cbbTenSach.SelectedValue == null)
                {
                    MessageBox.Show(this, "Vui lòng chọn sách đúng trong combobox!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtSoLuong.Text))
                {
                    MessageBox.Show(this, "Vui lòng nhập số lượng sách!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtDonGia.Text))
                {
                    MessageBox.Show(this, "Vui lòng nhập đơn giá!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(txtSoLuong.Text, out a))
                {
                    MessageBox.Show("Vui lòng nhập đúng số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoLuong.Focus();
                    return;

                }
                if (!int.TryParse(txtDonGia.Text, out a))
                {
                    MessageBox.Show("Vui lòng nhập đúng đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDonGia.Focus();
                    return;
                }
                int? tongTien = 0;
                int masach = int.Parse(cbbTenSach.SelectedValue.ToString());
                ChiTietPhieuNhap ct = new ChiTietPhieuNhap { MaSach = masach, SoLuong = int.Parse(txtSoLuong.Text), DonGia = int.Parse(txtDonGia.Text), Sach = (Sach)cbbTenSach.SelectedItem };
                if (ctpn.Count == 0)
                {
                    ctpn.Add(ct);
                }
                else
                {
                    Boolean k = true;
                    foreach (var i in ctpn)
                    {
                        if (ct.MaSach == i.MaSach)
                        {
                            i.SoLuong += ct.SoLuong;
                            k = false;
                        }
                    }
                    if (k)
                    {
                        ctpn.Add(ct);
                    }
                }

                foreach (var l in ctpn)
                {

                    dgvCTPN.Rows.Add(l.MaSach, l.Sach.TieuDe, l.SoLuong, l.DonGia);
                    tongTien += l.SoLuong * l.DonGia;
                }
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbTongTien.Text = tongTien.ToString();
                lbSoLuong.Text = (dgvCTPN.RowCount - 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Có lỗi " + ex.Message + " xảy ra trong quá trình thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void cbbTenSach_SelectedValueChanged(object sender, EventArgs e)
        {
            var sachs = db.Saches.AsQueryable();
            Sach s = (Sach)cbbTenSach.SelectedItem;
            txtDonGia.Text = sachs.Where(e1 => e1.MaSach == s.MaSach).FirstOrDefault().GiaBan.ToString();
        }

        private void btnLuuPhieuNhap_Click(object sender, EventArgs e)
        {
            if (cbNguoiLap.SelectedValue == null)
            {
                MessageBox.Show(this, "Vui lòng chọn người lập đơn đúng trong combobox!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbbNCC.SelectedValue == null)
            {
                MessageBox.Show(this, "Vui lòng chọn nhà cung cấp đúng trong combobox!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DateTime.Compare(DTNgayLap.Value, DateTime.Now) > 0)
            {
                MessageBox.Show(this, "Ngày lập phiếu không được lớn hơn ngày hiện tại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvCTPN.RowCount - 1 == 0)
            {
                MessageBox.Show("Cần ít nhất thêm 1 mặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int mancc = int.Parse(cbbNCC.SelectedValue.ToString());
                int manv = int.Parse(cbNguoiLap.SelectedValue.ToString());
                PhieuNhap pn = new PhieuNhap
                {
                    NgayNhap = DTNgayLap.Value,
                    MaXN = mancc,
                    GhiChu = txtGhiChu.Text,
                    MaNV=manv
                };
                db.PhieuNhaps.Add(pn);
                db.SaveChanges();
                foreach (var l in ctpn)
                {
                    l.SoPN = pn.SoPN;
                    db.Saches.Find(l.MaSach).SoLuongCo += l.SoLuong;

                }
                db.ChiTietPhieuNhaps.AddRange(ctpn);
                db.SaveChanges();
                MessageBox.Show("Tạo phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoaSachKhoiPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = dgvCTPN.SelectedRows;
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

                        length = dgvCTPN.SelectedRows.Count;
                        for (int i = length - 1; i >= 0; i--)
                        {
                            
                            row = dgvCTPN.SelectedRows[i];
                            int maSach = int.Parse(row.Cells["MaSach"].Value.ToString());
                            var sach1 = ctpn.FirstOrDefault(s=>s.MaSach==maSach);
                            ctpn.Remove(sach1);
                            dgvCTPN.Rows.Remove(row);
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
    }
}
