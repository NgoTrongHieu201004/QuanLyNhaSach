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
    public partial class QuanLyKhoSach : Form
    {
        KhoSach khoSach;
        public QuanLyKhoSach()
        {

            InitializeComponent();
            khoSach = new KhoSach();
            dgvkhoSach.DataSource = khoSach.getKho();
        }
        public void load()
        {
            dgvkhoSach.DataSource = khoSach.getKho();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            khoSach = new KhoSach();
            int kq = khoSach.Insert_KhoSach(txtMaKhoSach.Text, txtSoLuongTrongKho.Text);
            if (kq != -1)
            {
                MessageBox.Show("Thêm thành công!");
                load();
            }
        }


        private void dgvkhoSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaKhoSach.Text = dgvkhoSach[0, index].Value.ToString();
            txtSoLuongTrongKho.Text = dgvkhoSach[1, index].Value.ToString();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaKhoSach.Clear();
            txtSoLuongTrongKho.Clear();
            txtMaKhoSach.Focus();
            txtMaKhoSach.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            DialogResult rs = new DialogResult();
            rs = MessageBox.Show($"bạn có muốn xoá mã kho {txtMaKhoSach.Text}", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                khoSach = new KhoSach();
                khoSach.Delete_Kho(txtMaKhoSach.Text);
                dgvkhoSach.DataSource = khoSach.getKho();
            }
            load();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            khoSach = new KhoSach();
            int result = khoSach.UpDate_Kho(txtMaKhoSach.Text, txtSoLuongTrongKho.Text);
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

        private void QuanLyKhoSach_Load(object sender, EventArgs e)
        {

        }
    }


}
