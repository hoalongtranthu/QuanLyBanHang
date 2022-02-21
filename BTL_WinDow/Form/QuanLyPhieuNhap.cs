using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BTL_WinDow
{
    public partial class QuanLyPhieuNhap : Form
    {
        Model1 db = new Model1();
        public QuanLyPhieuNhap()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DangNhap.NguoiDangNhap.isAdmin == false)
            {
                MessageBox.Show(this, "Bạn không phải admin nên không có quyền thực hiện chức năng này!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var rows = dgvPhieuNhap.SelectedRows;
                if (rows.Count > 0)
                {
                    var phieuNhaps = new List<PhieuNhap>();
                    for (int i = 0; i < rows.Count; i++)
                    {
                        var id = Convert.ToInt32(rows[i].Cells["SoPN"].Value);
                        phieuNhaps.Add(db.PhieuNhaps.FirstOrDefault(p => p.SoPN == id));
                        
                    }
                    if (phieuNhaps.Count == 0)
                    {
                        MessageBox.Show(this, "Vui lòng chọn bản ghi muốn xóa hợp lệ!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (MessageBox.Show(this, "Khi xóa đi phiếu nhập này sẽ đồng thời xóa hết dữ liệu chi tiết phiếu nhập, bạn chắc chắn vẫn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach(var p in phieuNhaps)
                        {
                            var ct = db.ChiTietPhieuNhaps.Where(c=>c.SoPN==p.SoPN).ToList();
                            foreach(var i in ct){
                                db.Saches.Find(i.MaSach).SoLuongCo = db.Saches.Find(i.MaSach).SoLuongCo - i.SoLuong;
                            } 
                            db.ChiTietPhieuNhaps.RemoveRange(ct);
                            db.SaveChanges();
                        }
                        db.PhieuNhaps.RemoveRange(phieuNhaps);
                        db.SaveChanges();
                        MessageBox.Show(this, "Xóa phiếu nhập khỏi cơ sở dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var phieunhap = db.PhieuNhaps.ToList();
                        LoadData(phieunhap);
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TrangChu().ShowDialog();
            this.Close();
        }

        private void QuanLyPhieuNhap_Load(object sender, EventArgs e)
        {
            var phieuNhap = db.PhieuNhaps.ToList();
            var NCC = db.XuongNhaps.ToList();
           
            foreach (DataGridViewColumn col in dgvPhieuNhap.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Microsoft San Serif", 10, FontStyle.Bold);
            }
            LoadData(phieuNhap);
        }
        private void Clear()
        {
            
        }
        private void LoadData(List<PhieuNhap> phieuNhaps)
        {
            dgvPhieuNhap.DataSource = null;
            dgvPhieuNhap.Rows.Clear();
            dgvPhieuNhap.Refresh();
            
            foreach (var p in phieuNhaps)
            {
                string s = "";
                if (p.NhanVien.HoTen == null)
                {
                    s = p.NhanVien.TenDangNhap;
                }
                else
                {
                    s= p.NhanVien.HoTen;
                }
                dgvPhieuNhap.Rows.Add(p.SoPN, s, p.XuongNhap.TenXN, p.NgayNhap, p.GhiChu);
            }
            lbSL.Text = (dgvPhieuNhap.Rows.Count - 1) + "";
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                //PhieuNhap phieuNhap = new PhieuNhap();
                //phieuNhap.MaNV = DangNhap.NguoiDangNhap.MaNV;
                
                //db.PhieuNhaps.Add(phieuNhap);
                //db.SaveChanges();
                //MessageBox.Show(this, "Thêm phiếu nhập thành công, vui lòng nhập chi tiết...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //var phieuNhaps = db.PhieuNhaps.Include("NhanVien").ToList();
                //int id = db.PhieuNhaps.Max(p => p.SoPN);
                
                //new CapNhatChiTietPhieuNhap(id).ShowDialog();
                new ThemPhieuNhap(-1).Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Có lỗi " + ex.Message + " xảy ra trong quá trình thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dgvPhieuNhap_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSuaChiTiet_Click(object sender, EventArgs e)
        {
                
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            var rows = dgvPhieuNhap.SelectedRows;
            if (rows.Count <= 0)
            {
                MessageBox.Show(this, "Vui lòng chọn phiếu nhập bạn muốn thao tác!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(rows[0].Cells[0].Value == null)
            {
                MessageBox.Show(this, "Vui lòng chọn phiếu nhập hợp lệ!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            new ThemPhieuNhap(Convert.ToInt32(rows[0].Cells[0].Value)).ShowDialog();
           
        }
    }
}
