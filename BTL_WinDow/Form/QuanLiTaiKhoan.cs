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
    public partial class QuanLiTaiKhoan : Form
    {
        private Model1 db = new Model1();
        public QuanLiTaiKhoan()
        {
            InitializeComponent();
            Show();
        }

        private void btn_LamMoi(object sender, EventArgs e)
        {
            Show();
        }

        private void btn_Them(object sender, EventArgs e)
        {
            Form themNV = new ThongTinNhanVien();
            themNV.Show();
        }

        private void btn_Sua(object sender, EventArgs e)
        {
            int cellValue = 0;
            if (dgvNhanVien.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvNhanVien.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvNhanVien.Rows[selectedrowindex];
                cellValue = int.Parse(selectedRow.Cells["MNV"].Value.ToString());
            }
            Form suaNV = new ThongTinNhanVien(cellValue);
            suaNV.Show();
        }

        private void btn_Xoa(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvNhanVien.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvNhanVien.Rows[selectedrowindex];
                int cellValue = int.Parse(selectedRow.Cells["MNV"].Value.ToString());
                try {
                    if(DialogResult.OK== MessageBox.Show("Bạn có muốn xóa nhân viên này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                    {
                        var res = db.NhanViens.Find(cellValue);
                        if(res.isAdmin==true)
                        {
                            MessageBox.Show("Không thể xóa Admin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            db.NhanViens.Remove(res);
                            db.SaveChanges();
                            Show();
                        }
                        
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void QuanLiTaiKhoan_Load(object sender, EventArgs e)
        {
            
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var res = db.NhanViens.Where(e1 => e1.HoTen.Contains(txtTimKiem.Text) || e1.TenDangNhap.Contains(txtTimKiem.Text)).Select(e1=>new{ e1.MaNV, e1.HoTen, e1.TenDangNhap, e1.Tuoi, e1.DiaChi}).ToList();
            dgvNhanVien.DataSource = res;
        }
        private void Show()
        {
            var ds = db.NhanViens.Select(p => new { p.MaNV, p.HoTen, p.Tuoi, p.DiaChi, p.TenDangNhap }).ToList();
            dgvNhanVien.DataSource = ds;
            foreach (DataGridViewColumn col in dgvNhanVien.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Microsoft San Serif", 10, FontStyle.Bold);
            }

            lbSl.Text = dgvNhanVien.Rows.Count.ToString();
        }
    }
}
