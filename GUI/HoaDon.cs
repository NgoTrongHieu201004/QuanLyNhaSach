using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
using QuanLySach1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class HoaDon : Form
    {
        HoaDonNS hd = new HoaDonNS();
        public HoaDon()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            dgvHoaDon.DataSource = hd.getHoaDon();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            Bus_Sach sach = new Bus_Sach();
            cmbKhachHang.DataSource = hd.comboBoxKhachHang();
            cmbKhachHang.DisplayMember = "HoTen";
            cmbKhachHang.ValueMember = "MaKhachHang";
            cmbKhachHang.SelectedIndex = -1;

            cmbSach.DataSource = hd.comboBoxSach();
            cmbSach.DisplayMember = "TenSach";
            cmbSach.ValueMember = "MaSach";
            cmbSach.SelectedIndex = -1;

            cmbNhanVien.DataSource = sach.comboBoxNhanVien();

            cmbNhanVien.DisplayMember = "TenNhanVien";
            cmbNhanVien.ValueMember = "UserId";
            cmbNhanVien.SelectedIndex = -1;


        }

        private void lblSDT_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtMa.Enabled = true;
            cmbKhachHang.SelectedIndex = -1;
            cmbKhachHang.Enabled = true; 
            cmbSach.SelectedIndex = -1;
            cmbSach.Enabled = true;
            npdSoLuong.Value = 0;
            npdSoLuong.Enabled = true;
            txtTong.Text = "";
            dtpNgaySinh.Value = DateTime.Now;

            btnThem.Visible = false;
            btnLuu1.Visible = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cmbKhachHang.Enabled = true;
            cmbSach.Enabled = true;
            npdSoLuong.Enabled = true;

            btnSua.Visible = false;
            btnLuu2.Visible = true;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            dgvHoaDon.Enabled = false;

        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMa.Text = dgvHoaDon[0,index].Value.ToString();

            string khachhang = dgvHoaDon[1,index].Value.ToString();
            cmbKhachHang.SelectedValue = khachhang;

            string sach = dgvHoaDon[2, index].Value.ToString();
            cmbSach.SelectedValue = sach;

            npdSoLuong.Text= dgvHoaDon[3,index].Value.ToString();
            txtTong.Text = dgvHoaDon[4,index].Value.ToString();

            int nhanvien = Convert.ToInt32(dgvHoaDon[5, index].Value);
            cmbNhanVien.SelectedValue = nhanvien;
            dtpNgaySinh.Value = DateTime.TryParse(dgvHoaDon[6, index].Value?.ToString(), out DateTime parsedDate) ? parsedDate : DateTime.Now;
        }

        private void btnLuu1_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text.Trim();
            string khachhang = cmbKhachHang.SelectedValue.ToString();
            string sach = cmbSach.SelectedValue.ToString();
            int soluong = int.Parse(npdSoLuong.Text.Trim());
            float tong = float.Parse(txtTong.Text.Trim());
            DateTime ngay = dtpNgaySinh.Value;
            int result = hd.Insert_HoaDon(ma, khachhang, sach, soluong, tong, CurrentUser.Id, ngay);

            if (result > 0)
            {
                MessageBox.Show("Thêm thông tin thành công!");
                txtMa.Text = "";
                txtMa.Enabled = false;
                cmbKhachHang.SelectedIndex = -1;
                cmbKhachHang.Enabled = false;
                cmbSach.SelectedIndex = -1;
                cmbSach.Enabled = false;
                npdSoLuong.Value = 0;
                npdSoLuong.Enabled = false;
                txtTong.Text = "";
                dtpNgaySinh.Value = DateTime.Now;

                btnThem.Visible = true;
                btnLuu1.Visible = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
            else
            {
                MessageBox.Show("Thêm thông tin thất bại!");
            }
            load();

        }

        private void txtTong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(txtTong.Text, out float gia) &&
                int.TryParse(npdSoLuong.Text, out int soLuong))
            {
                float tongTien = gia * soLuong;
                txtTong.Text = tongTien.ToString(); 
            }
            else
            {
                txtTong.Text = "0";
            }

        }

        private void cmbSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void npdSoLuong_ValueChanged(object sender, EventArgs e)
        {
            if (cmbSach.SelectedValue != null)
            {
                string maSach = cmbSach.SelectedValue.ToString();
                DataTable result = hd.gia_Sach(maSach);
                if (result.Rows.Count > 0)
                {
                    float gia = Convert.ToSingle(result.Rows[0][0]);
                    int soLuong = (int)npdSoLuong.Value;

                    float tongtien = gia * soLuong;
                    txtTong.Text = tongtien.ToString();
                }
            }
            else
            {
                txtTong.Text = "0";
            }
        }

        private void btnLuu2_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text.Trim();
            string khachhang = cmbKhachHang.SelectedValue.ToString();
            string sach = cmbSach.SelectedValue.ToString();
            int soluong = int.Parse(npdSoLuong.Text.Trim());
            float tong = float.Parse(txtTong.Text.Trim());
            DateTime ngay = dtpNgaySinh.Value;
            int result = hd.Update_HoaDon(ma, khachhang, sach, soluong, tong, CurrentUser.Id, ngay);

            if (result > 0)
            {
                MessageBox.Show("Sửa thông tin thành công!");
                txtMa.Text = "";
                txtMa.Enabled = false;
                cmbKhachHang.SelectedIndex = -1;
                cmbKhachHang.Enabled = false;
                cmbSach.SelectedIndex = -1;
                cmbSach.Enabled = false;
                npdSoLuong.Value = 0;
                npdSoLuong.Enabled = false;
                txtTong.Text = "";
                dtpNgaySinh.Value = DateTime.Now;

                btnLuu2.Visible = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                dgvHoaDon.Enabled = true;
            }
            else
            {
                MessageBox.Show("Sửa thông tin thất bại!");
            }
            load();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            DialogResult rs = new DialogResult();
            rs = MessageBox.Show($"bạn có muốn xoá hóa đơn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                int result = hd.Delete_HoaDon(ma);
                if (result > 0)
                {
                    MessageBox.Show("Xóa thông tin thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa thông tin thất bại!");
                }
                load();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DateTime start = dtpStart.Value;
            DateTime end = dtpEnd.Value;

            DataTable result = hd.searchHoaDon(start, end);

           dgvHoaDon.DataSource = result;
        }
    }
}
