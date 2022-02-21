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
    public partial class ThongTinNhanVien : Form
    {
        private Model1 db = new Model1();
        private int id_nhanvien;
        public ThongTinNhanVien()
        {
            InitializeComponent();
            
                btnXoa.Enabled = false;
                btnLuu.Text = "Lưu";
            btnLuu.Enabled = false;
            txtMaNV.Enabled = false;
            
        }
        public ThongTinNhanVien(int id)
        {
            InitializeComponent();
           
                btnLuu.Text = "Sửa";
                btnThem.Enabled = false;
                id_nhanvien = id;
                var nv = db.NhanViens.Find(id);
                txtMaNV.Text = nv.MaNV.ToString();
                txtMaNV.Enabled = false;
                txtHoTen.Text = nv.HoTen;
                txtDiaChi.Text = nv.DiaChi;
                txtTuoi.Text = nv.Tuoi.ToString();
            txtTenDangNhap.Text = nv.TenDangNhap;
            txtTenDangNhap.Enabled = false;
        }
        public void Show(int id)
        {
            btnLuu.Text = "Sửa";
            btnThem.Enabled = false;
            id_nhanvien = id;
            var nv = db.NhanViens.Find(id);
            txtMaNV.Text = nv.MaNV.ToString();
            txtMaNV.Enabled = false;
            txtHoTen.Text = nv.HoTen;
            txtDiaChi.Text = nv.DiaChi;
            txtTuoi.Text = nv.Tuoi.ToString();
            txtTenDangNhap.Text = nv.TenDangNhap;
        }
        private void ThongTinNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.OK == (MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)))
                {
                    var nv = db.NhanViens.Find(int.Parse(txtMaNV.Text));
                    if(nv.isAdmin==true)
                    {
                        MessageBox.Show("Không thể xóa Admin", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        db.NhanViens.Remove(nv);
                        db.SaveChanges();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                        Close();
                    }
                   
                    
                }
            }
            catch {
                MessageBox.Show("Không thể xóa nhân viên này do có liên quan đến phiếu nhập hoặc xuất", "Thông báo", MessageBoxButtons.OK);
            }
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (txtTuoi.Text != string.Empty)
            {
                if (!int.TryParse(txtTuoi.Text, out a))
                {
                    MessageBox.Show("Tuổi không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTuoi.Focus();
                }
            }
            if (!CheckValid1()) { }
            else {
                NhanVien nv = db.NhanViens.Find(id_nhanvien);



                nv.HoTen = txtHoTen.Text;
                nv.Tuoi = a;
                nv.DiaChi = txtDiaChi.Text;
                nv.TenDangNhap = txtTenDangNhap.Text;
                nv.MatKhau = txtMatKhau.Text;


                db.Entry(nv).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show(id_nhanvien);
            }
            
        }

        private bool CheckUser(string user)
        {
            var res = db.NhanViens.Where(e => e.TenDangNhap == user).FirstOrDefault();
            if (res != null)
                return false;
            return true;
        }
        

      
        private void btnThem_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (txtTuoi.Text != string.Empty)
            {
                if (!int.TryParse(txtTuoi.Text, out a))
                {
                    MessageBox.Show("Tuổi không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTuoi.Focus();
                }
            }
            //while (!CheckValid()) ;
            if(!CheckValid())
            {
                //MessageBox.Show("Nhập đúng dữ liệu");
            }
            else
            {
                NhanVien nv = new NhanVien
                {

                    HoTen = txtHoTen.Text,
                    Tuoi = a,
                    DiaChi = txtDiaChi.Text,
                    TenDangNhap = txtTenDangNhap.Text,
                    MatKhau = txtMatKhau.Text,
                    isAdmin = false
                };
                db.NhanViens.Add(nv);
                db.SaveChanges();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private bool CheckValid()
        {
            if (txtHoTen.Text == string.Empty)
            {
                //this.errorProvider1.SetError(txtHoTen, "Không được để trống");
                MessageBox.Show("Họ tên không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return false;
            }

            if (txtTenDangNhap.Text == string.Empty)
            {
                //this.errorProvider1.SetError(txtTenDangNhap, "Không được để trống");
                MessageBox.Show("Tên đăng nhập không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
                return false;
            }
            if (!CheckUser(txtTenDangNhap.Text))
            {
                //this.errorProvider1.SetError(txtTenDangNhap, "Tên đăng nhập đã tồn tại");
                MessageBox.Show("Tên đăng nhập đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
                return false;
            }
            if (txtMatKhau.Text == string.Empty || txtXacNhan.Text == string.Empty)
            {
                //this.errorProvider1.SetError(txtXacNhan, "Không được để trống");
                MessageBox.Show("Mật khẩu không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtXacNhan.Focus();
                return false;
            }
            if (txtMatKhau.Text != txtXacNhan.Text)
            {
                //this.errorProvider1.SetError(txtXacNhan, "Mật khẩu xác nhận không khớp");
                MessageBox.Show("Mật khẩu xác nhận không khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtXacNhan.Focus();
                return false;
            }
            return true;
        }
        private bool CheckValid1()
        {
            if (txtHoTen.Text == string.Empty)
            {
                //this.errorProvider1.SetError(txtHoTen, "Không được để trống");
                MessageBox.Show("Họ tên không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return false;
            }

           
            if (txtMatKhau.Text == string.Empty || txtXacNhan.Text == string.Empty)
            {
                //this.errorProvider1.SetError(txtXacNhan, "Không được để trống");
                MessageBox.Show("Mật khẩu không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtXacNhan.Focus();
                return false;
            }
            if (txtMatKhau.Text != txtXacNhan.Text)
            {
                //this.errorProvider1.SetError(txtXacNhan, "Mật khẩu xác nhận không khớp");
                MessageBox.Show("Mật khẩu xác nhận không khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtXacNhan.Focus();
                return false;
            }
            return true;
        }



    }
}