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
    public partial class QuanLySach : Form
    {
        Bus_Sach sach = new Bus_Sach();
        public QuanLySach()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {
            grvSach.DataSource = sach.getSach();
            if (grvSach.RowCount > 1)
            {
                txtMaSach.Text = grvSach[0, 0].Value.ToString();
                txtTenSach.Text = grvSach[1, 0].Value.ToString();
                string tacgia = grvSach[2, 0].Value.ToString();
                cmbTacGia.SelectedValue = tacgia;

                string theloai = grvSach[3, 0].Value.ToString();
                cmbTheLoai.SelectedValue = theloai;

                string nxb = grvSach[4, 0].Value.ToString();
                cmbNXB.SelectedValue = nxb;

                string Kho = grvSach[5, 0].Value.ToString();
                cmbKho.SelectedValue = Kho;

                int nhanvien = Convert.ToInt32(grvSach[6, 0].Value);
                cmbNhanVien.SelectedValue = nhanvien;
                txtGia.Text = grvSach[7, 0].Value.ToString();
                
            }
            else
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                txtMaSach.Text = "";
                txtTenSach.Text = "";
                cmbTacGia.SelectedIndex = -1;
                cmbTheLoai.SelectedIndex = -1;
                cmbNXB.SelectedIndex = -1;
                cmbKho.SelectedIndex = -1;
                txtGia.Text = "";
                
            }
        }

        private void btnLuu1_Click(object sender, EventArgs e)
        {
            Bus_Sach sach = new Bus_Sach();
            string maSach = txtMaSach.Text.Trim();
            string tenSach  = txtTenSach.Text.Trim();
            string tacgia = cmbTacGia.SelectedValue.ToString();
            string theloai = cmbTheLoai.SelectedValue.ToString();
            string nxb = cmbNXB.SelectedValue.ToString();
            string kho = cmbKho.SelectedValue.ToString();
            float gia = float.Parse(txtGia.Text.Trim());


            int result = sach.Insert_Sach(maSach, tenSach, tacgia, theloai, nxb, kho, CurrentUser.Id, gia);

            if(result > 0)
            {
                MessageBox.Show("Thêm thông tin thành công!");
                btnLuu1.Visible = false;
                btnThem.Visible = true;
                txtMaSach.Enabled = false;
                txtTenSach.Enabled = false;
                cmbTacGia.Enabled = false;
                cmbTheLoai.Enabled = false;
                cmbNXB.Enabled = false;
                cmbKho.Enabled = false;
                txtGia.Enabled = false;


                btnLuu1.Visible = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                grvSach.Enabled = true;
            }
            else
            {
                MessageBox.Show("Thêm thông tin thất bại!");
            }
                load();
        }

        private void btnLuu2_Click(object sender, EventArgs e)
        {
            Bus_Sach sach = new Bus_Sach();
            string maSach = txtMaSach.Text.Trim();
            string tenSach = txtTenSach.Text.Trim();
            string tacgia = cmbTacGia.SelectedValue.ToString();
            string theloai = cmbTheLoai.SelectedValue.ToString();
            string nxb = cmbNXB.SelectedValue.ToString();
            string kho = cmbKho.SelectedValue.ToString();
            float gia = float.Parse(txtGia.Text.Trim());
            int result = sach.Update_Sach(maSach, tenSach, tacgia, theloai, nxb, kho, CurrentUser.Id, gia);

            if (result > 0)
            {
                MessageBox.Show("Sửa thông tin thành công!");
                txtMaSach.Enabled = false;
                txtTenSach.Enabled = false;
                cmbTacGia.Enabled = false;
                cmbTheLoai.Enabled = false;
                cmbNXB.Enabled = false;
                cmbKho.Enabled = false;
                txtGia.Enabled = false;

                btnLuu2.Visible = false;
                btnSua.Visible = true;
                btnLuu2.Visible = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                grvSach.Enabled = true;
            }
            else
            {
                MessageBox.Show("Sửa thông tin thất bại!");
            }
                load();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtGia.Text = "";
            txtMaSach.Enabled = true;
            txtTenSach.Enabled = true;
            txtGia.Enabled = true;
            cmbTacGia.Enabled = true;
            cmbTheLoai.Enabled = true;
            cmbNXB.Enabled = true;
            cmbKho.Enabled = true;
            cmbTacGia.SelectedIndex = -1;
            cmbTheLoai.SelectedIndex = -1;
            cmbNXB.SelectedIndex = -1;
            cmbKho.SelectedIndex = -1;
            cmbNhanVien.SelectedValue = CurrentUser.Id;

            btnLuu1.Visible = true;
            btnThem.Visible = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Visible = true;
            grvSach.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaSach.Enabled = true;
            txtTenSach.Enabled = true;
            txtGia.Enabled = true;
            cmbTacGia.Enabled = true;
            cmbTheLoai.Enabled = true;
            cmbNXB.Enabled = true;
            cmbKho.Enabled = true;
            cmbNhanVien.SelectedValue = CurrentUser.Id;


            btnLuu2.Visible = true;
            btnSua.Visible = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            grvSach.Enabled = false;
            btnHuy.Visible = true;
            btnHuy.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSach = txtMaSach.Text; //sai ở đây ???
            DialogResult rs = new DialogResult();
            rs = MessageBox.Show($"bạn có muốn xoá nhân viên {txtTenSach.Text}", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
               Bus_Sach sach = new Bus_Sach();
                int result =  sach.Delete_Sach(maSach);
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaSach.Enabled = false;
            txtTenSach.Enabled = false;
            cmbTacGia.Enabled = false;
            cmbTheLoai.Enabled = false;
            cmbNXB.Enabled = false;
            cmbKho.Enabled = false;
            txtGia.Enabled = false;


            btnLuu1.Visible = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnSua.Visible = true;
            btnXoa.Enabled = true;

            btnThem.Visible = true;
            btnLuu2.Visible = false;

            grvSach.Enabled = true;
            load();

        }

        private void grvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaSach.Text = grvSach[0, index].Value.ToString();
            txtTenSach.Text = grvSach[1, index].Value.ToString();
            string tacgia = grvSach[2, index].Value.ToString();
            cmbTacGia.SelectedValue = tacgia;

            string theloai = grvSach[3, index].Value.ToString();
            cmbTheLoai.SelectedValue = theloai;

            string nxb = grvSach[4, index].Value.ToString();
            cmbNXB.SelectedValue = nxb;

            string Kho = grvSach[5, index].Value.ToString();
            cmbKho.SelectedValue = Kho;

            int nhanvien = Convert.ToInt32(grvSach[6, index].Value);
            cmbNhanVien.SelectedValue = nhanvien;


            txtGia.Text = grvSach[7, index].Value.ToString();
          
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Bus_Sach sach = new Bus_Sach();
            grvSach.DataSource = sach.searchSach(txtKey.Text);
            if (grvSach.RowCount <= 1)
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

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            Bus_Sach sach = new Bus_Sach();
            cmbTheLoai.DataSource = sach.comboBoxTheLoai();

            cmbTheLoai.DisplayMember = "TenTheLoai";
            cmbTheLoai.ValueMember = "MaTheLoai";
            

            cmbTacGia.DataSource = sach.comboBoxTacGia();

            cmbTacGia.DisplayMember = "TenTacGia";
            cmbTacGia.ValueMember = "MaTacGia";
            

            cmbNXB.DataSource = sach.comboBoxNXB();

            cmbNXB.DisplayMember = "TenNhaXuatBan";
            cmbNXB.ValueMember = "MaNhaXuatBan";
            

            cmbKho.DataSource = sach.comboBoxKhoSach();

            cmbKho.DisplayMember = "TenKhoSach";
            cmbKho.ValueMember = "MaKhoSach";

            cmbNhanVien.DataSource = sach.comboBoxNhanVien();

            cmbNhanVien.DisplayMember = "TenNhanVien";
            cmbNhanVien.ValueMember = "UserId";
            load();

        }
    }
}
