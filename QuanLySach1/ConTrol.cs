using BUS;
using DAL;
using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach1
{
    public partial class ConTrol : Form
    {
        public ConTrol()
        {
            InitializeComponent();
        }

        private void quanLySachToolStripMenuItem_Click(object sender, EventArgs e)
        {
           QuanLySach quanLySach = new QuanLySach();
            quanLySach.MdiParent = this;
            quanLySach.Show();
        }

        private void quanLyKhoSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKhoSach quanLyKho = new QuanLyKhoSach();
            quanLyKho.MdiParent = this;
            quanLyKho.Show();
        }

        private void theLoaiSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
           TheLoaiSach theLoai = new TheLoaiSach(); 
           theLoai.MdiParent = this;
           theLoai.Show();
        }

        private void quanLyTacGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTacGia quanLyTacGia = new QuanLyTacGia();
            quanLyTacGia.MdiParent = this;
            quanLyTacGia.Show();
        }

        private void quanLyNXBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNXB quanLyNXB = new QuanLyNXB();
            quanLyNXB.MdiParent = this;
            quanLyNXB.Show();
        }

        private void quanLyKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang quanLyKhachHang = new QuanLyKhachHang();
            quanLyKhachHang.MdiParent = this;
            quanLyKhachHang.Show();
        }

        private void quanLyNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConTrol_Load(object sender, EventArgs e)
        {
            if (CurrentUser.QuyenHan != "1")
            {
                tàiToolStripMenuItem.Visible = false;
            }

            if (CurrentUser.QuyenHan != "1" && CurrentUser.QuyenHan != "2")
            {
                quanLyNhanVienToolStripMenuItem.Visible = false;
                sachToolStripMenuItem.Visible = false;
                quanLyKhachHangToolStripMenuItem.Visible = false;
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentUser.Username = null;
            CurrentUser.QuyenHan = null;
            this.Hide();

            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
        }

        private void tàiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form taikhoan = new quanLyTaiKhoan();
            taikhoan.MdiParent = this;
            taikhoan.Show();
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien quanLyNhanVien = new QuanLyNhanVien();
            quanLyNhanVien.MdiParent = this;
            quanLyNhanVien.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.MdiParent = this;
            hoaDon.Show();
        }
    }
}
