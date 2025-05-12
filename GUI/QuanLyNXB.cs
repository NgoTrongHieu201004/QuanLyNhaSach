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
    public partial class QuanLyNXB : Form
    {
        NhaXuatBan nxb;
        public QuanLyNXB()
        {
            InitializeComponent();
            nxb = new NhaXuatBan();
            dgvNXB.DataSource = nxb.getNXB();
        }
        public void load()
        {
            dgvNXB.DataSource = nxb.getNXB();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            nxb = new NhaXuatBan();
            int kq = nxb.Insert_NXB(txtMaNhaXuatBan.Text, txtTenNhaXuatBan.Text, txtDiaChiNXB.Text,txtSDT.Text);
            if (kq != -1)
            {
                MessageBox.Show("Thêm thành công!");
                load();
            }
        }

        private void bntReSet_Click(object sender, EventArgs e)
        {
            txtMaNhaXuatBan.Clear();
            txtTenNhaXuatBan.Clear();
            txtDiaChiNXB.Clear();
            txtSDT.Clear();
            txtMaNhaXuatBan.Focus();
            txtMaNhaXuatBan.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maTG = txtMaNhaXuatBan.Text; //sai ở đây ???
            DialogResult rs = new DialogResult();
            rs = MessageBox.Show($"bạn có muốn xoá thể loại {txtTenNhaXuatBan.Text}", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                nxb = new NhaXuatBan();
                nxb.Delete_NXB(maTG);
                dgvNXB.DataSource = nxb.getNXB();
            }
            load();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            nxb = new NhaXuatBan();
            int kq = nxb.Update_NXB(txtMaNhaXuatBan.Text, txtTenNhaXuatBan.Text, txtDiaChiNXB.Text, txtSDT.Text);
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

        private void dgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaNhaXuatBan.Text = dgvNXB[0,index].Value.ToString();
            txtTenNhaXuatBan.Text = dgvNXB[1, index].Value.ToString();
            txtDiaChiNXB.Text = dgvNXB[2, index].Value.ToString();
            txtSDT.Text = dgvNXB[3, index].Value.ToString();
        }
    }
}
