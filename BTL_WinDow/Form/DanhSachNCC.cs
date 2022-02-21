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
    public partial class DanhSachNCC : Form
    {
        Model1 db = new Model1();
        public DanhSachNCC()
        {
            InitializeComponent();
        }

        private void DanhSachNCC_Load(object sender, EventArgs e)
        {
            var n = db.XuongNhaps.ToList();
            LoadData(n);
            foreach (DataGridViewColumn col in dgvNCC.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Microsoft San Serif", 10, FontStyle.Bold);
            }
        }
        private void Clear()
        {
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            ActiveControl = txtTenNCC;
        }
        private void LoadData(List<XuongNhap> list)
        {
            dgvNCC.DataSource = null;
            dgvNCC.Rows.Clear();
            dgvNCC.Refresh();
            foreach (var n in list)
            {
                dgvNCC.Rows.Add(n.MaXN,n.TenXN,n.DiaChi,n.SDT);
            }
            lbSL.Text = (dgvNCC.Rows.Count - 1) + "";
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtDiaChi.Text))
                {
                    MessageBox.Show(this, "Tên nhà cung cấp không được để trống!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                XuongNhap x = new XuongNhap();
                x.TenXN = txtTenNCC.Text;
                x.DiaChi = txtDiaChi.Text;
                x.SDT = txtSDT.Text;
                db.XuongNhaps.Add(x);
                db.SaveChanges();
                MessageBox.Show(this, "Thêm thành công nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var n = db.XuongNhaps.ToList();
                LoadData(n);
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Có lỗi " + ex.Message + " xảy ra trong quá trình thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            var n = db.XuongNhaps.ToList();
            LoadData(n);
        }

        private void btnXoaNhapLieu_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TrangChu().ShowDialog();
            this.Close();
        }

        private void dgvNCC_SelectionChanged(object sender, EventArgs e)
        {
            txtTenNCC.Text = dgvNCC.CurrentRow.Cells["TenNCC"].FormattedValue.ToString();
            txtDiaChi.Text = dgvNCC.CurrentRow.Cells["DiaChi"].FormattedValue.ToString();
            txtSDT.Text = dgvNCC.CurrentRow.Cells["SDT"].FormattedValue.ToString();
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNCC.SelectedRows.Count == 0)
                {
                    MessageBox.Show(this, "Vui lòng chọn nhà cung cấp muốn sửa thông tin ở bảng!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(txtDiaChi.Text))
                {
                    MessageBox.Show(this, "Tên nhà cung cấp không được để trống!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                XuongNhap x = db.XuongNhaps.Find(Convert.ToInt32(dgvNCC.SelectedRows[0].Cells[0].Value));
                x.TenXN = txtTenNCC.Text;
                x.DiaChi = txtDiaChi.Text;
                x.SDT = txtSDT.Text;
                db.Entry(x).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show(this, "Sửa thành công nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var n = db.XuongNhaps.ToList();
                LoadData(n);
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Có lỗi " + ex.Message + " xảy ra trong quá trình thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = dgvNCC.SelectedRows;
                if (rows.Count > 0)
                {
                        var id = Convert.ToInt32(rows[0].Cells["MaNCC"].Value);
                        var ncc= db.XuongNhaps.FirstOrDefault(n => n.MaXN == id);
                    if (ncc ==null)
                    {
                        MessageBox.Show(this, "Vui lòng chọn bản ghi muốn xóa hợp lệ!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (MessageBox.Show(this, "Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (ncc.PhieuNhaps.Count > 0)
                        {
                            MessageBox.Show(this, "Không thể xóa nhà cung cấp này, Hãy xóa hết các phiếu nhập của nhà cung cấp này trước rồi thử lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        db.XuongNhaps.Remove(ncc);
                        db.SaveChanges();
                        MessageBox.Show(this, "Xóa nhà cung cấp khỏi cơ sở dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var n = db.XuongNhaps.ToList();
                        LoadData(n);
                        Clear();
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
                MessageBox.Show(this, "Có lỗi " + ex.Message + " xảy ra trong quá trình thực hiện!", "Thông báo");
                return;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string tenNCC = "";
                var ncc = db.XuongNhaps.AsQueryable();
                if (!string.IsNullOrEmpty(txtTenNCC.Text))
                {
                    tenNCC = txtTenNCC.Text;
                    ncc = ncc.Where(n => n.TenXN.Contains(txtTenNCC.Text));
                }
                
                if (string.IsNullOrEmpty(txtTenNCC.Text))
                {
                    MessageBox.Show(this, "Vui lòng nhập tên nhà cung cấp trước khi tìm kiếm!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var n1 = ncc.ToList();
                LoadData(n1);
                if (dgvNCC.Rows.Count == 1)
                {
                    MessageBox.Show(this, $"Không tìm thấy nhà cung cấp tương ứng với tên nhà cung cấp: {tenNCC}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show(this, $"Đã tìm thấy{dgvNCC.Rows.Count - 1} nhà cung cấp tương ứng với tên nhà cung cấp: {tenNCC}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                txtTenNCC.Text = tenNCC;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Có lỗi " + ex.Message + " xảy ra trong quá trình thực hiện!", "Thông báo");
                return;
            }
        }
    }
}
