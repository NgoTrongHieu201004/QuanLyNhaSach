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
    
    public partial class QuanLyTacGia : Form
    {
        TacGia quanLyTacGia;
        public QuanLyTacGia()
        {
            InitializeComponent();
            quanLyTacGia = new TacGia();
            dgvTacGia.DataSource = quanLyTacGia.getTacGia();
        }
        public void load()
        {
            dgvTacGia.DataSource = quanLyTacGia.getTacGia();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            quanLyTacGia = new TacGia();
            int kq = quanLyTacGia.Insert_TacGia(txtMaTacGia.Text, txtTenTacGia.Text, txtGioiTinh.Text, pkTuoi.Value, txtTieuSu.Text);
            if (kq != -1)
            {
                load();
                MessageBox.Show("Thêm thành công!");

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maTL = txtMaTacGia.Text; //sai ở đây ???
            DialogResult rs = new DialogResult();
            rs = MessageBox.Show($"bạn có muốn xoá thể loại {txtTenTacGia.Text}", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                quanLyTacGia = new TacGia();
                quanLyTacGia.Delete_TacGia(maTL);
                dgvTacGia.DataSource = quanLyTacGia.getTacGia();
            }
            load();
        }

        private void dgvTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaTacGia.Text = dgvTacGia[0, index].Value.ToString();
            txtTenTacGia.Text = dgvTacGia[1, index].Value.ToString();
            txtGioiTinh.Text = dgvTacGia[2, index].Value.ToString();
            pkTuoi.Value = Convert.ToDateTime(dgvTacGia[3, index].Value);
            txtTieuSu.Text = dgvTacGia[4, index].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            quanLyTacGia = new TacGia();
            int kq = quanLyTacGia.UpDate_TacGia(txtMaTacGia.Text, txtTenTacGia.Text, txtGioiTinh.Text, pkTuoi.Value, txtTieuSu.Text);
            if (kq >= 1)
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaTacGia.Clear();
            txtTenTacGia.Clear();
            txtTieuSu.Clear();
            txtGioiTinh.Clear();
            txtMaTacGia.Focus();
            txtMaTacGia.Enabled = true;
        }

        private void dgvTacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuanLyTacGia_Load(object sender, EventArgs e)
        {

        }
    }
}
