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
using System.Runtime.Serialization.Formatters;
using QuanLySach1;

namespace GUI
{
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            Bus_KhachHang nhanVien = new Bus_KhachHang();
            grv.DataSource = nhanVien.getKhachHang();
            if (grv.RowCount > 1)
            {
                txtMaKH.Text = grv[0, 0].Value.ToString();
                txtTen.Text = grv[1, 0].Value.ToString();
                string gioitinh = grv[2, 0].Value.ToString();
                if (gioitinh == "Nam")
                {
                    rdbNam.Checked = true;
                }
                else if (gioitinh == "Nữ")
                {
                    rdbNu.Checked = true;
                }
                pkTuoi.Value = DateTime.TryParse(grv[3, 0].Value?.ToString(), out DateTime parsedDate) ? parsedDate : DateTime.Now;
                txtEmail.Text = grv[4, 0].Value.ToString();
                txtSDT.Text = grv[5, 0].Value.ToString();
                int nhanvien = Convert.ToInt32(grv[6, 0].Value);
                cmbNhanVien.SelectedValue = nhanvien;


            }
            else
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                txtMaKH.Text = "";
                txtTen.Text = "";
                rdbNam.Checked = false;
                rdbNu.Checked = false;
                pkTuoi.Text = "";
                txtEmail.Text = "";
                txtSDT.Text = "";

            }
        }
        private void View_Employee_Load(object sender, EventArgs e)
        {
            load();

        }



        private void btnHuy_Click(object sender, EventArgs e)
        {
           
            txtTen.Enabled = false;
            rdbNam.Checked = false;
            rdbNam.Enabled = false;
            rdbNu.Checked=false;
            rdbNu.Enabled = false;
            pkTuoi.Enabled = false;
            txtEmail.Enabled = false;
            txtSDT.Enabled = false;

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
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTen.Text = "";
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            pkTuoi.Value = DateTime.Now;
            txtEmail.Text = "";
            txtSDT.Text = "";
            cmbNhanVien.SelectedValue = CurrentUser.Id;

            txtMaKH.Enabled = true;
            txtTen.Enabled = true;
            rdbNam.Enabled=true;
            rdbNu.Enabled=true;
            pkTuoi.Enabled = true;
            txtEmail.Enabled = true;
            txtSDT.Enabled = true;

            btnLuu1.Visible = true;
            btnThem.Visible = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Visible = true;
            grv.Enabled = false;
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaKH.Enabled = true;
            txtTen.Enabled = true;
            rdbNam.Enabled = true;
            rdbNu.Enabled = true;
            pkTuoi.Enabled = true;
            txtEmail.Enabled = true;
            txtSDT.Enabled = true;

            btnLuu2.Visible = true;
            btnSua.Visible = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnHuy.Visible = true;
            grv.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text; //sai ở đây ???
            DialogResult rs = new DialogResult();
            rs = MessageBox.Show($"bạn có muốn xoá khách hàng {txtTen.Text}", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                Bus_KhachHang khachHang = new Bus_KhachHang();
                khachHang.Delete_KhachHang(maKH);
                grv.DataSource = khachHang.getKhachHang();
            }
            load();
        }

     
        private void btnLuu1_Click(object sender, EventArgs e)
        {
            Bus_KhachHang khachHang = new Bus_KhachHang();
            string maKh = txtMaKH.Text;
            string ten = txtTen.Text;
            DateTime ngaySinh = pkTuoi.Value;
            string gioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
            string email = txtEmail.Text;
            string sdt = txtSDT.Text;

            int result = khachHang.Insert_khachHang(maKh, ten, gioiTinh, ngaySinh, email, sdt, CurrentUser.Id);

            if (result > 0)
            {
                MessageBox.Show("Thêm thông tin thành công!");
                btnLuu1.Visible = false;
                btnThem.Visible = true;

                txtMaKH.Enabled = false;
                txtTen.Enabled = false;
                rdbNam.Enabled = false;
                rdbNu.Enabled = false;
                pkTuoi.Enabled = false;
                txtEmail.Enabled = false;
                txtSDT.Enabled = false;

                btnLuu1.Visible = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
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

            Bus_KhachHang khachHang = new Bus_KhachHang();
            string maKh = txtMaKH.Text;
            string ten = txtTen.Text;
            DateTime ngaySinh = pkTuoi.Value;
            string gioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
            string email = txtEmail.Text;
            string sdt = txtSDT.Text;
            int result = khachHang.Update_KhachHang(maKh, ten, gioiTinh, ngaySinh, email, sdt, CurrentUser.Id);
            if (result > 0) 
            {
                MessageBox.Show("Sửa thông tin thành công!");
                btnLuu2.Visible = false;
                btnSua.Visible = true;

                txtMaKH.Enabled = false;
                txtTen.Enabled = false;
                rdbNam.Enabled = false;
                rdbNu.Enabled = false;
                pkTuoi.Enabled = false;
                txtEmail.Enabled = false;
                txtSDT.Enabled = false;

                btnLuu2.Visible = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                grv.Enabled = true;
            }
            else
            {
                MessageBox.Show("Sửa thông tin thất bại!");
            }
            load();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Bus_KhachHang khachHang = new Bus_KhachHang();
            grv.DataSource = khachHang.searchKhachHang(txtKey.Text);
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
            txtMaKH.Text = grv[0, index].Value.ToString();
            txtTen.Text = grv[1, index].Value.ToString();
            string gioitinh = grv[2, index].Value.ToString();
            if (gioitinh == "Nam")
            {
                rdbNam.Checked = true;
            }
            else if (gioitinh == "Nữ")
            {
                rdbNu.Checked = true;
            }
            pkTuoi.Value = DateTime.TryParse(grv[3, index].Value?.ToString(), out DateTime parsedDate) ? parsedDate : DateTime.Now;
            txtEmail.Text = grv[4, index].Value.ToString();
            txtSDT.Text = grv[5, index].Value.ToString();
            int nhanvien = Convert.ToInt32(grv[6, index].Value);
            cmbNhanVien.SelectedValue = nhanvien;


        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            Bus_KhachHang khachHang = new Bus_KhachHang();
            cmbNhanVien.DataSource = khachHang.comboBoxNhanVien();

            cmbNhanVien.DisplayMember = "TenNhanVien";
            cmbNhanVien.ValueMember = "UserId";
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

