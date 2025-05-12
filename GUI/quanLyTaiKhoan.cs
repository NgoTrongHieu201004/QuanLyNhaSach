using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace GUI
{
    public partial class quanLyTaiKhoan : Form
    {
        TaiKhoan quanlyTaiKhoan;
        public quanLyTaiKhoan()
        {
            InitializeComponent();
            quanlyTaiKhoan = new TaiKhoan();
            dgvTaiKhoan.DataSource = quanlyTaiKhoan.getUsers();
        }
        public void load()
        {
            dgvTaiKhoan.DataSource = quanlyTaiKhoan.getUsers();
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtUserId.Text = dgvTaiKhoan[0, index].Value.ToString();
            txtUsername.Text = dgvTaiKhoan[1, index].Value.ToString();
            txtPassword.Text = dgvTaiKhoan[2, index].Value.ToString();

            int maQuyenHan = Convert.ToInt32(dgvTaiKhoan[3, index].Value);
            cmbQuyenHan.SelectedValue = maQuyenHan;

        }

        private void cmbQuyenHan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void quanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            cmbQuyenHan.DataSource = quanlyTaiKhoan.comboBoxQuyenHan();

            cmbQuyenHan.DisplayMember = "TenQuyenHan";
            cmbQuyenHan.ValueMember = "MaQuyenHan";
            cmbQuyenHan.SelectedIndex = -1; 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            cmbQuyenHan.Text = "";
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            cmbQuyenHan.Enabled = true;
            btnThem.Visible = false;
            btnLuuthem.Visible = true;
        }

        private void btnLuuthem_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            int quyenhan = Convert.ToInt32(cmbQuyenHan.SelectedValue);
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }


            quanlyTaiKhoan = new TaiKhoan();
            int kq = quanlyTaiKhoan.Insert_Users(username, password, quyenhan);
            if (kq > 0)
            {
                load();
                MessageBox.Show("Thêm tài khoản thành công!");
                txtUsername.Text = "";
                txtPassword.Text = "";
                cmbQuyenHan.SelectedIndex = -1;
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                cmbQuyenHan.Enabled = false;
                btnThem.Visible = true;
                btnLuuthem.Visible = false;

            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTaiKhoan.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn tài khoản cần sửa.");
                    return;
                }
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
                cmbQuyenHan.Enabled = true;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Visible = false;
                btnLuuSua.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chuẩn bị sửa tài khoản: " + ex.Message);
            }
        }

        private void btnLuuSua_Click(object sender, EventArgs e)
        {
            try
            {
                int userId = Convert.ToInt32(txtUserId.Text);

                string username = txtUsername.Text;
                string password = txtPassword.Text;
                int quyenhan = Convert.ToInt32(cmbQuyenHan.SelectedValue);

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }
                int kq = quanlyTaiKhoan.Update_Users(userId, username, password, quyenhan);
                if (kq > 0)
                {
                    load();
                    MessageBox.Show("Sửa thành công!");
                    txtUsername.Enabled = false;
                    txtPassword.Enabled = false;
                    cmbQuyenHan.Enabled = false;
                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    btnSua.Visible = true;
                    btnLuuSua.Visible = false;
                }
                else
                {
                    MessageBox.Show("Sửa tài khoản thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa tài khoản: " + ex.Message);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(txtUserId.Text);

            DialogResult rs = new DialogResult();
            rs = MessageBox.Show($"bạn có muốn xoá tài khoản này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                int kq = quanlyTaiKhoan.Delete_Users(userId);
                if (kq > 0)
                {
                    load();
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản thất bại!");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Control f = new Control();
            f.Show();
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
