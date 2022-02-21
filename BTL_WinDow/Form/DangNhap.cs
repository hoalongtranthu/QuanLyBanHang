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
    public partial class DangNhap : Form
    {
        Model1 db = new Model1();
        public static NhanVien NguoiDangNhap;
        
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThiMatKhau.Checked)
                txtMatKhau.UseSystemPasswordChar = false;
            else
                txtMatKhau.UseSystemPasswordChar = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string tenDangNhap = txtTenDangNhap.Text;
                string matKhau = txtMatKhau.Text;
                if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
                {
                    MessageBox.Show(this, "Vui lòng nhập đủ tên đăng nhập và mật khẩu!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var taiKhoan = db.NhanViens.FirstOrDefault(n => n.TenDangNhap == tenDangNhap);
                
                if (taiKhoan != null)
                {
                    if (!(matKhau==(taiKhoan.MatKhau.TrimEnd())))
                    {
                        MessageBox.Show(this, "Mật khẩu không chính xác!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    this.Hide();
                    DangNhap.NguoiDangNhap = taiKhoan;
                    new TrangChu().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "Tên đăng nhập không chính xác!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
