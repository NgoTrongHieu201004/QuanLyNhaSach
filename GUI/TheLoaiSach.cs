using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TheLoaiSach : Form
    {
        TheLoai theLoaiSach;
        public TheLoaiSach()
        {
            InitializeComponent();
            theLoaiSach = new TheLoai();
            dgvTheLoai.DataSource = theLoaiSach.getTheLoai();
        }
        public void load()
        {
            dgvTheLoai.DataSource = theLoaiSach.getTheLoai();
        }

        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            theLoaiSach = new TheLoai();
            int kq = theLoaiSach.Insert_TheLoai(txtMaTheLoai.Text, txtTenTheLoai.Text);
            if (kq != -1)
            {
                MessageBox.Show("Thêm thành công!");
                load();
            }
        }

        private void btnXoaTheLoai_Click(object sender, EventArgs e)
        {
            string maTL = txtMaTheLoai.Text; //sai ở đây ???
            DialogResult rs = new DialogResult();
            rs = MessageBox.Show($"bạn có muốn xoá thể loại {txtTenTheLoai.Text}", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                theLoaiSach = new TheLoai();
                theLoaiSach.Delete_TheLoai(maTL);
                dgvTheLoai.DataSource = theLoaiSach.getTheLoai();
            }
            load();
        }

        private void btnSuaTheLoai_Click(object sender, EventArgs e)
        {
            theLoaiSach = new TheLoai();
            int result = theLoaiSach.Update_TheLoai(txtMaTheLoai.Text, txtTenTheLoai.Text);
            if (result >= 1)
            {
                load();
                MessageBox.Show("Sửa thành công!");
              
            }
            else
            {
                load();
                MessageBox.Show("Sửa thất bại!");
               
            }
        }

        private void dgvTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaTheLoai.Text = dgvTheLoai[0, index].Value.ToString();
            txtTenTheLoai.Text = dgvTheLoai[1, index].Value.ToString();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaTheLoai.Clear();
            txtTenTheLoai.Clear();
            txtMaTheLoai.Focus();
            txtMaTheLoai.Enabled = true;
        }

        private void TheLoaiSach_Load(object sender, EventArgs e)
        {

        }
    }
}
