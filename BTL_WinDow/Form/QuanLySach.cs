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
    public partial class SachForm : Form
    {
        Model1 db = new Model1();
        int choice;
        public SachForm(int c)
        {
            InitializeComponent();
            choice = c;
            if (c == 0)
            {
                btnThoat.Visible = false;
            }
            else
            {
                btnThoat.Visible = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadData(List<Sach> sachs)
        {
            dgvSach.DataSource = null;
            dgvSach.Rows.Clear();
            dgvSach.Refresh();
            foreach (var s in sachs)
            {
                dgvSach.Rows.Add(s.MaSach, s.TieuDe, s.NhaPhatHanh, s.NgayPhatHanh, s.TacGia, s.GiaBan, s.SoLuongCo);
            }
            lbSL.Text = (dgvSach.Rows.Count -1) + "";
        }
        private void Clear()
        {
            txtTieuDe.Text = "";
            txtNhaPH.Text = "";
            DTNgayPH.Value = DateTime.Now;
            txtTacGia.Text = "";
            txtGiaBan.Text = "";
            //txtSLC.Text = "";
            ActiveControl = txtTieuDe;

        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            var sachs = db.Saches.ToList();
            LoadData(sachs);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Sach s = new Sach();
                if (txtTieuDe.Text == "")
                {
                    MessageBox.Show(this, "Vui lòng nhập tiêu đề sách!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtGiaBan.Text == "")
                {
                    MessageBox.Show(this, "Vui lòng nhập giá bán!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                s.TieuDe = txtTieuDe.Text;
                s.NhaPhatHanh = txtNhaPH.Text;
                try
                {
                    s.NgayPhatHanh = DTNgayPH.Value;
                }
                catch
                {
                    MessageBox.Show(this, "Vui lòng nhập đúng định dạng ngày tháng(yyyy/MM/dd)!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                s.TacGia = txtTacGia.Text;
                try
                {
                    s.GiaBan = int.Parse(txtGiaBan.Text);
                   // s.SoLuongCo = int.Parse(txtSLC.Text);
                }
                catch
                {
                    MessageBox.Show(this, "Vui lòng nhập đúng định dạng giá bán hoặc số lượng có!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                db.Saches.Add(s);
                db.SaveChanges();
                MessageBox.Show(this, "Thêm sách vào cơ sở dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                var sachs = db.Saches.ToList();
                LoadData(sachs);
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Có lỗi " + ex.Message + " xảy ra trong quá trình thực hiện!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }

        private void SachForm_Load(object sender, EventArgs e)
        {
            var sachs = db.Saches.ToList();
            LoadData(sachs);
            foreach (DataGridViewColumn col in dgvSach.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Microsoft San Serif", 10, FontStyle.Bold);
            }
        }

        private void dgvSach_SelectionChanged(object sender, EventArgs e)
        {
            
            txtTieuDe.Text = dgvSach.CurrentRow.Cells["tieuDe"].FormattedValue.ToString();
            txtNhaPH.Text = dgvSach.CurrentRow.Cells["NhaPH"].FormattedValue.ToString();
            DTNgayPH.Text = dgvSach.CurrentRow.Cells["NgayPH"].FormattedValue.ToString();
            txtTacGia.Text = dgvSach.CurrentRow.Cells["tacGia"].FormattedValue.ToString();
            txtGiaBan.Text = dgvSach.CurrentRow.Cells["giaBan"].FormattedValue.ToString();
           // txtSLC.Text = dgvSach.CurrentRow.Cells["SLC"].FormattedValue.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = dgvSach.SelectedRows;
                if(rows.Count == 1)
                {
                    Sach s = db.Saches.Find(Convert.ToInt32(rows[0].Cells["maSach"].Value));
                    if (txtTieuDe.Text == "")
                    {
                        MessageBox.Show(this, "Vui lòng nhập tiêu đề sách!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (txtGiaBan.Text == "")
                    {
                        MessageBox.Show(this, "Vui lòng nhập giá bán!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    s.TieuDe = txtTieuDe.Text;
                    s.NhaPhatHanh = txtNhaPH.Text;
                    try
                    {
                        s.NgayPhatHanh = DTNgayPH.Value;
                    }
                    catch
                    {
                        MessageBox.Show(this, "Vui lòng nhập đúng định dạng ngày tháng(yyyy/MM/dd)!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    s.TacGia = txtTacGia.Text;
                    try
                    {
                        s.GiaBan = int.Parse(txtGiaBan.Text);
                       // s.SoLuongCo = int.Parse(txtSLC.Text);
                    }
                    catch
                    {
                        MessageBox.Show(this, "Vui lòng nhập đúng định dạng giá bán hoặc số lượng có!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    db.Entry(s).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show(this, "Sửa sách vào cơ sở dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var sachs = db.Saches.ToList();
                    LoadData(sachs);
                    Clear();
                }
                else
                {
                    MessageBox.Show(this, "Vui lòng chọn và chỉ chọn 1 hàng để sửa", "Chú ý", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, "Có lỗi " + ex.Message + " xảy ra trong quá trình thực hiện!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = dgvSach.SelectedRows;
                if (rows.Count > 0)
                {
                        var sachs = new List<Sach>();
                        for (int i = 0; i < rows.Count; i++)
                        {
                            var id = Convert.ToInt32(rows[i].Cells["maSach"].Value);
                            sachs.Add(db.Saches.FirstOrDefault(s => s.MaSach == id));
                        }
                    if (sachs.Count == 0)
                    {
                        MessageBox.Show(this, "Vui lòng chọn bản ghi muốn xóa hợp lệ!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (MessageBox.Show(this, "Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                        try
                        {
                            db.Saches.RemoveRange(sachs);
                            db.SaveChanges();
                        }
                        catch
                        {
                            MessageBox.Show("Không thể xóa sách này vì sách đăng được lưu trong hóa đơn hoặc phiếu nhập!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                            return;
                        }
                            
                            MessageBox.Show(this, "Xóa sách khỏi cơ sở dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            var sachs1 = db.Saches.ToList();
                            LoadData(sachs1);
                            Clear();
                        }
                    }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng muốn xóa!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
                string tk = "";
                string tieuDe = "";
                string tacGia = "";
                var sachs = db.Saches.AsQueryable();
                if (!string.IsNullOrEmpty(txtTieuDe.Text))
                {
                    tieuDe = txtTieuDe.Text;
                    sachs = sachs.Where(s => s.TieuDe.Contains(txtTieuDe.Text));
                    tk = tk + "tiêu đề";
                }
                if (!string.IsNullOrEmpty(txtTacGia.Text))
                {
                    tacGia = txtTacGia.Text;
                    sachs = sachs.Where(s => s.TacGia.Contains(txtTacGia.Text));
                    tk = tk + "tác giả";
                }
                if(string.IsNullOrEmpty(txtTieuDe.Text) && string.IsNullOrEmpty(txtTacGia.Text))
                {
                    MessageBox.Show(this, "Vui lòng nhập tiêu đề sách hoặc tác giả trước khi tìm kiếm!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var sachs1 = sachs.ToList();
                LoadData(sachs1);
                if (dgvSach.Rows.Count == 1)
                {
                    MessageBox.Show(this, $"Không tìm thấy sách tương ứng với tiêu đề: {tieuDe} và tác giả: {tacGia}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show(this, $"Đã tìm thấy{dgvSach.Rows.Count-1} sách tương ứng với tiêu đề: {tieuDe} và tác giả: {tacGia}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                txtTacGia.Text = tacGia;
                txtTieuDe.Text = tieuDe;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Có lỗi " + ex.Message + " xảy ra trong quá trình thực hiện!", "Thông báo");
                return;
            }
        }
    }
}
