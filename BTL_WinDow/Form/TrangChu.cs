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
    public partial class TrangChu : Form
    {
        Image closeImage, closeImageAct;
        public TrangChu()
        {
            InitializeComponent();
            Size mysize = new System.Drawing.Size(16, 16); // co anh chen vao
            Bitmap bt = new Bitmap(Properties.Resources.close);
            // anh nay ban dau minh da them vao
            Bitmap btm = new Bitmap(bt, mysize);
            closeImageAct = btm;
            //
            //
            Bitmap bt2 = new Bitmap(Properties.Resources.closeBlack);
            // anh nay ban dau minh da them vao
            Bitmap btm2 = new Bitmap(bt2, mysize);
            closeImage = btm2;
            tabControl1.Padding = new Point(30);

        }

        private void TrangChu_Load(object sender, EventArgs e)
        {


        }



        private void rbtQLSach_Click(object sender, EventArgs e)
        {
            CreateNewTabControl("Quản lí sách", new SachForm(0));

        }


        private void rbtNhapKho_Click(object sender, EventArgs e)
        {
            new ThemPhieuNhap(-1).ShowDialog();
            //CreateNewTabControl("Thêm phiếu nhập", new ThemPhieuNhap());
        }

        private void rbtQLTK_Click(object sender, EventArgs e)
        {
            if (DangNhap.NguoiDangNhap.isAdmin == false)
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
                CreateNewTabControl("Danh sach nhan vien", new QuanLiTaiKhoan());
        }

        private void rbtBanLe_Click(object sender, EventArgs e)
        {
            new ThemHoaDon(-1).ShowDialog();
        }

        private void rbtDSPN_Click(object sender, EventArgs e)
        {
            CreateNewTabControl("Danh sách phiếu nhập", new QuanLyPhieuNhap());
        }

        private void rbtDSPX_Click(object sender, EventArgs e)
        {
            CreateNewTabControl("Danh sách hóa đơn", new QuanLiHoaDon());
        }
        private void rbtNCC_Click(object sender, EventArgs e)
        {
            if (DangNhap.NguoiDangNhap.isAdmin == false)
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            CreateNewTabControl("Danh sách nhà cung cấp", new DanhSachNCC());
        }

        private void rbtDoiMatKhau_Click(object sender, EventArgs e)
        {
            new DoiMatKhau().ShowDialog();
        }

        private void rbtThongTin_Click(object sender, EventArgs e)
        {
            new ThongTin().Show();
        }

        private void rbtThongKe_Click(object sender, EventArgs e)
        {
            CreateNewTabControl("Thống kê", new ThongKe());
        }

        private void rbtDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Hide();
                new DangNhap().ShowDialog();
                Close();
            }
            

        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Rectangle rect = tabControl1.GetTabRect(e.Index);
            Rectangle imageRec = new Rectangle(rect.Right - closeImage.Width,
                rect.Top + (rect.Height - closeImage.Height) / 2,
                closeImage.Width, closeImage.Height);
            // tang size rect
            rect.Size = new Size(rect.Width + 20, 38);

            Font f;
            Brush br = Brushes.Black;
            StringFormat strF = new StringFormat(StringFormat.GenericDefault);
            // neu tab dang duoc chon
            if (tabControl1.SelectedTab == tabControl1.TabPages[e.Index])
            {
                // hinh mau do, hinh nay them tu properti
                e.Graphics.DrawImage(closeImageAct, imageRec);
                f = new Font("Arial", 10, FontStyle.Bold);
                // Ten tabPage
                e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text,
                    f, br, rect, strF);
            }
            else
            {
                // Tap dang mo, nhung ko dc chon, hinh mau den
                e.Graphics.DrawImage(closeImage, imageRec);
                f = new Font("Arial", 9, FontStyle.Regular);
                // Ten tabPage
                e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text,
                    f, br, rect, strF);
            }




            //e.Graphics.DrawString("x", e.Font, Brushes.Red, e.Bounds.Right - 15, e.Bounds.Top + 4);
            //e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            //e.DrawFocusRectangle();
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void CreateNewTabControl(string title, Form f)
        {
            tabControl1.Visible = true;
            pictureBox1.Visible = false;
            TabPage myTabPage = new TabPage(title);


            if (!tabControl1.TabPages.ContainsKey(myTabPage.Text))
            {

                myTabPage.Name = title;

                tabControl1.TabPages.Add(myTabPage);

                TextBox tb = new TextBox();
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                f.Show();
                myTabPage.Controls.Add(f);


            }
            //else
            //{
            //    tabControl1.SelectedTab = tabControl1.TabPages[title];
            //}
            tabControl1.SelectedTab = tabControl1.TabPages[title];



        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabControl1.TabCount; i++)
            {
                // giong o DrawItem
                Rectangle rect = tabControl1.GetTabRect(i);
                Rectangle imageRec = new Rectangle(rect.Right - closeImage.Width,
                    rect.Top + (rect.Height - closeImage.Height) / 2,
                    closeImage.Width, closeImage.Height);

                if (imageRec.Contains(e.Location))
                {
                    tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                    if (CheckTabControl())
                    {
                        tabControl1.Visible = false;
                        pictureBox1.Visible = true;
                    }
                }

            }
        }

        private bool CheckTabControl()
        {

            return tabControl1.TabPages.Count == 0 ? true : false;
        }
    } 
}
