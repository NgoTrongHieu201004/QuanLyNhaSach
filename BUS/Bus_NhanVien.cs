using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    public class Bus_NhanVien
    {
        public DataTable getNhanVien()
        {
            NhanVien nhanVien = new NhanVien();
            return nhanVien.getNhanVien();
        }

        public DataTable comboBoxUser()
        {
            NhanVien nhanVien = new NhanVien();
            return nhanVien.comboBoxUser();
        }

        public DataTable comboBoxUserThongTin()
        {
            NhanVien nhanVien = new NhanVien();
            return nhanVien.comboBoxUserThongTin();
        }

        public int Insert_NhanVien(int userId, string tenNhanVien, DateTime ngaySinh, string gioiTinh, string sdt, string diaChi, float luong)
        {
            NhanVien nhanVien = new NhanVien();
            return nhanVien.Insert_NhanVien(userId, tenNhanVien, ngaySinh, gioiTinh, sdt, diaChi, luong);
        }
        public int Update_NhanVien(int userId, string tenNhanVien, DateTime ngaySinh, string gioiTinh, string sdt, string diaChi, float luong)
        {
            NhanVien nhanVien = new NhanVien();
            return nhanVien.Update_NhanVien(userId, tenNhanVien, ngaySinh, gioiTinh, sdt, diaChi, luong);
        }
        public int Delete_NhanVien(int userId)
        {
            NhanVien nhanVien = new NhanVien();
            return nhanVien.Detele_NhanVien(userId);
        }
        public DataTable searchNhanVien(string maNV)
        {
            NhanVien nhanVien = new NhanVien();
            return nhanVien.searchNhanVien(maNV);
        }


    }
}
