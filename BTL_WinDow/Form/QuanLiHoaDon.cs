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
    public partial class QuanLiHoaDon : Form
    {
        private Model1 db = new Model1();
        public QuanLiHoaDon()
        {
            InitializeComponent();
            Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuanLiHoaDon_Load(object sender, EventArgs e1)
        {
            foreach (DataGridViewColumn col in dgvPhieuXuat.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Microsoft San Serif", 8, FontStyle.Bold);
            }
            //var res = db.DonHangs.Select(e => new { e.MaDH, e.TenKhachHang, e.SDT, e.DiaChi, e.NhanVien.HoTen,e.NgayLapDon }).ToList();
            //dataGridView1.DataSource = res;

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            Form hd = new ThemHoaDon(-1);
            hd.Show();
            hd.ControlBox = true;
            
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            var rows = dgvPhieuXuat.SelectedRows;
            if (rows.Count <= 0)
            {
                MessageBox.Show(this, "Vui lòng chọn hóa đơn bạn muốn thao tác!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rows[0].Cells[0].Value == null)
            {
                MessageBox.Show(this, "Vui lòng chọn hóa đơn hợp lệ!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            new ThemHoaDon(Convert.ToInt32(rows[0].Cells[0].Value)).ShowDialog();
        }
        private void Show()
        {
            var res = db.DonHangs.Select(e => new { e.MaDH, e.TenKhachHang, e.SDT, e.DiaChi, e.NhanVien.HoTen, e.NgayLapDon }).ToList();
            dgvPhieuXuat.DataSource = res;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DangNhap.NguoiDangNhap.isAdmin == false)
            {
                MessageBox.Show(this, "Bạn không phải admin nên không có quyền thực hiện chức năng này!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var rows = dgvPhieuXuat.SelectedRows;
                if (rows.Count > 0)
                {
                    var DonHang = new List<DonHang>();
                    for (int i = 0; i < rows.Count; i++)
                    {
                        var id = Convert.ToInt32(rows[i].Cells["MaDH"].Value);
                        DonHang.Add(db.DonHangs.FirstOrDefault(p => p.MaDH == id));

                    }
                    if (DonHang.Count == 0)
                    {
                        MessageBox.Show(this, "Vui lòng chọn bản ghi muốn xóa hợp lệ!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (MessageBox.Show(this, "Khi xóa đi phiếu nhập này sẽ đồng thời xóa hết dữ liệu chi tiết phiếu nhập, bạn chắc chắn vẫn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (var p in DonHang)
                        {
                            var ct = db.ChiTietDonHangs.Where(c => c.MaDH == p.MaDH).ToList();
                           
                            db.ChiTietDonHangs.RemoveRange(ct);
                            db.SaveChanges();
                        }
                        db.DonHangs.RemoveRange(DonHang);
                        db.SaveChanges();
                        MessageBox.Show(this, "Xóa đơn hàng khỏi cơ sở dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var phieunhap = db.DonHangs.ToList();
                        Show();
                        
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
    }
}
