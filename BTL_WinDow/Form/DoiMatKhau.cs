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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(117, 120,251), ButtonBorderStyle.Solid);
        }
        private void DoiMatKhau_Load(object sender, EventArgs e)
        {

        }
        private Model1 db = new Model1();
        private void button1_Click(object sender, EventArgs e)
        {

            if(txtCu.Text == DangNhap.NguoiDangNhap.MatKhau.TrimEnd())
            {
                if(txtMoi.Text == txtXacNhan.Text)
                {
                    var res = db.NhanViens.Find(DangNhap.NguoiDangNhap.MaNV).MatKhau = txtMoi.Text;
                    DangNhap.NguoiDangNhap.MatKhau = txtMoi.Text;
                    db.SaveChanges();
                    MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới không khớp với xác nhận", "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
                
            
            else
            {
                MessageBox.Show("Mật khẩu cũ không chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCu.Clear();
            txtMoi.Clear();
            txtXacNhan.Clear();
            txtCu.Focus();
        }
    }
}
