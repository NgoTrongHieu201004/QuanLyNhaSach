using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    public class Bus_KhachHang
    {
        public DataTable getKhachHang()
        {
            KhachHang khachHang = new KhachHang();
            return khachHang.getKhachHang();
        }
        public DataTable comboBoxNhanVien()
        {
            Sach khachHang = new Sach();
            return khachHang.comboBoxNhanVien();
        }
        public int Insert_khachHang(string maKH, string tenKH, string gioiTinh, DateTime tuoi, string email, string sdt, int maNV)
        {
            KhachHang khachHang = new KhachHang();
            return khachHang.Insert_khachHang(maKH, tenKH, gioiTinh, tuoi, email, sdt, maNV);
        }
        public int Update_KhachHang(string maKH, string tenKH, string gioiTinh, DateTime tuoi, string email, string sdt, int maNV)
        {
            KhachHang khachHang = new KhachHang();
            return khachHang.Update_KhachHang(maKH, tenKH, gioiTinh, tuoi, email, sdt, maNV);
        }
        public int Delete_KhachHang(string maNV)
        {
            KhachHang khachHang = new KhachHang();
            return khachHang.Delete_KhachHang(maNV);
        }
        public DataTable searchKhachHang(string maNV)
        {
            KhachHang khachHang = new KhachHang();
            return khachHang.searchKhachHang(maNV);
        }


    }
}
