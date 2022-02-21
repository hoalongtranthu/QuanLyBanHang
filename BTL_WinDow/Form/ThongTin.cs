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
    public partial class ThongTin : Form
    {
        private Model1 db = new Model1();
        public ThongTin()
        {
            InitializeComponent();
            var res = db.NhanViens.Find(DangNhap.NguoiDangNhap.MaNV);
            txtTen.Text = res.HoTen;
            txtTuoi.Text = res.Tuoi + "";
            txtDiachi.Text = res.DiaChi;
        }

        private void ThongTin_Load(object sender, EventArgs e)
        {

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            var res = db.NhanViens.Find(DangNhap.NguoiDangNhap.MaNV);
            if (txtTuoi.Text != "")
            {
                if (int.TryParse(txtTuoi.Text, out a))
                {
                    res.Tuoi = a;
                    
                }
                else
                {
                    MessageBox.Show("Tuổi phải là số nguyên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (res.isAdmin==false)
            {
                if (string.IsNullOrEmpty(txtTen.Text))
                {
                    MessageBox.Show("Họ tên không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }
            res.HoTen = txtTen.Text;
            res.DiaChi = txtDiachi.Text;
            db.Entry(res).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
