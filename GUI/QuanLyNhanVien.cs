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
using BUS;
using System.Reflection;
using QuanLySach1;

namespace GUI
{
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
            load();
            Bus_NhanVien nhanVien = new Bus_NhanVien();
        }

        private void load()
        {
            Bus_NhanVien nhanVien = new Bus_NhanVien();
            grv.DataSource = nhanVien.getNhanVien();
            if (grv.RowCount > 1)
            {
                int userId = Convert.ToInt32(grv[0, 0].Value);
                cmbUser.SelectedValue = userId;
                txtTen.Text = grv[1, 0].Value.ToString();
                dtpNgaySinh.Value = DateTime.TryParse(grv[2, 0].Value?.ToString(), out DateTime parsedDate) ? parsedDate : DateTime.Now;
                string gioitinh = grv[3, 0].Value.ToString();
                if (gioitinh == "Nam")
                {
                    rdbNam.Checked = true;
                }
                else if (gioitinh == "Nữ")
                {
                    rdbNu.Checked = true;
                }
                txtSDT.Text = grv[4, 0].Value.ToString();
                txtDiaChi.Text = grv[5, 0].Value.ToString();
                txtLuong.Text = grv[6, 0].Value.ToString();
            }
            else
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                txtTen.Text = "";
                txtSDT.Text = "";
                txtSDT.Text = "";
                txtDiaChi.Text = "";
                txtLuong.Text = "";
            }
        }
        private void View_Employee_Load(object sender, EventArgs e)
        {
            load();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Bus_NhanVien nhanVien = new Bus_NhanVien();
            cmbUser.DataSource = nhanVien.comboBoxUserThongTin();

            cmbUser.DisplayMember = "Username";
            cmbUser.ValueMember = "UserId";

            cmbUser.SelectedIndex = -1;
            txtTen.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtLuong.Text = "";
            cmbUser.Enabled = true;
            txtTen.Enabled = true;
            dtpNgaySinh.Enabled = true;
            rdbNam.Enabled = true;
            rdbNu.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
            txtLuong.Enabled = true;
            btnLuu1.Visible = true;
            btnThem.Visible = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Visible = true;
            grv.Enabled = false;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            
            txtTen.Enabled = false;
            //txtGioiTinh.Enabled = false;
            txtSDT.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled=false;
            txtLuong.Enabled = false;

            btnLuu1.Visible = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnSua.Visible = true;
            btnXoa.Enabled = true;
 
            btnThem.Visible = true;
            btnLuu2.Visible = false;

            grv.Enabled = true;
            load();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cmbUser.Enabled = false;
            txtTen.Enabled = true;
            dtpNgaySinh.Enabled = true;
            rdbNam.Enabled = true;
            rdbNu.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
            txtLuong.Enabled = true;
            btnLuu2.Visible = true;
            btnSua.Visible = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Visible = true;
            grv.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Bus_NhanVien nhanVien = new Bus_NhanVien();
            int userId = Convert.ToInt32(cmbUser.SelectedValue);

            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin người dùng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rs == DialogResult.Yes)
            {
                int result = nhanVien.Delete_NhanVien(userId);

                if (result > 0)
                {
                    MessageBox.Show("Xóa thông tin thành công!");
                    load();
                }
                else
                {
                    MessageBox.Show("Xóa thông tin thất bại!");
                }
            }
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            Bus_NhanVien nhanVien = new Bus_NhanVien();
            cmbUser.DataSource = nhanVien.comboBoxUser();

            cmbUser.DisplayMember = "Username";
            cmbUser.ValueMember = "UserId";
            cmbUser.SelectedIndex = -1;

            if(CurrentUser.QuyenHan != "1")
            {
                btnThem.Visible = false;
                btnSua.Visible = false;
                btnXoa.Visible = false;
                btnHuy.Visible = false;

            }
        }

        private void btnLuu1_Click(object sender, EventArgs e)
        {
            Bus_NhanVien nhanVien = new Bus_NhanVien();
            int userId = Convert.ToInt32(cmbUser.SelectedValue);
            string tenNhanVien = txtTen.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string gioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
            string sdt = txtSDT.Text;
            string diaChi = txtDiaChi.Text;
            float luong = float.Parse(txtLuong.Text);

            int result = nhanVien.Insert_NhanVien(userId, tenNhanVien, ngaySinh, gioiTinh, sdt, diaChi, luong);
            if (result > 0)
            {
                MessageBox.Show("Thêm thông tin thành công!");
                load();
                cmbUser.Enabled = false;
                txtTen.Enabled = false;
                dtpNgaySinh.Enabled = false;
                rdbNam.Enabled = false;
                rdbNu.Enabled = false;
                txtSDT.Enabled = false;
                txtDiaChi.Enabled = false;
                txtLuong.Enabled = false;
                btnLuu1.Visible = false;
                btnThem.Visible = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnHuy.Visible = false;
                grv.Enabled = true;
            }
            else
            {
                MessageBox.Show("Thêm thông tin thất bại!");
            }
            load();
        }

        private void btnLuu2_Click(object sender, EventArgs e)
        {

            Bus_NhanVien nhanVien = new Bus_NhanVien();
            int userId = Convert.ToInt32(cmbUser.SelectedValue);
            string tenNhanVien = txtTen.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string gioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
            string sdt = txtSDT.Text;
            string diaChi = txtDiaChi.Text;
            float luong = float.Parse(txtLuong.Text);

            // Sửa thông tin người dùng
            int result = nhanVien.Update_NhanVien(userId, tenNhanVien, ngaySinh, gioiTinh, sdt, diaChi, luong);

            if (result > 0)
            {
                MessageBox.Show("Sửa thông tin thành công!");
                load();
                txtTen.Enabled = false;
                dtpNgaySinh.Enabled = false;
                rdbNam.Enabled = false;
                rdbNu.Enabled = false;
                txtSDT.Enabled = false;
                txtDiaChi.Enabled = false;
                txtLuong.Enabled = false;
                btnLuu2.Visible = false;
                btnSua.Visible = true;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnHuy.Visible = false;
                grv.Enabled = true;
            }
            else
            {
                MessageBox.Show("Sửa thông tin thất bại!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Bus_NhanVien nhanVien = new Bus_NhanVien();
            grv.DataSource = nhanVien.searchNhanVien(txtKey.Text);
            if (grv.RowCount <= 1)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }





        private void grv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int userId = Convert.ToInt32(grv[0, index].Value);
            cmbUser.SelectedValue = userId;
            txtTen.Text = grv[1, index].Value.ToString();
            dtpNgaySinh.Value = DateTime.TryParse(grv[2, index].Value?.ToString(), out DateTime parsedDate) ? parsedDate : DateTime.Now;
            string gioitinh = grv[3, index].Value.ToString();
            if(gioitinh == "Nam")
            {
                rdbNam.Checked = true;
            }
            else if(gioitinh == "Nữ")
            {
                rdbNu.Checked = true;
            }
            txtSDT.Text = grv[4, index].Value.ToString();
            txtDiaChi.Text = grv[5, index].Value.ToString();
            txtLuong.Text = grv[6, index].Value.ToString();
        }
    }
}
