using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    public class Bus_Sach
    {
        public DataTable getSach()
        {
            Sach sach = new Sach();
            return sach.getSach();
        }
        public DataTable comboBoxTheLoai()
        {
            Sach sach = new Sach();
            return sach.comboBoxTheLoai();
        }

        public DataTable comboBoxTacGia()
        {
            Sach sach = new Sach();
            return sach.comboBoxTacGia();
        }

        public DataTable comboBoxNXB()
        {
            Sach sach = new Sach();
            return sach.comboBoxNXB();
        }

        public DataTable comboBoxKhoSach()
        {
            Sach sach = new Sach();
            return sach.comboBoxKhoSach();
        }
        public DataTable comboBoxNhanVien()
        {
            Sach sach = new Sach();
            return sach.comboBoxNhanVien();
        }


        public int Insert_Sach(string maSach, string tenSach,string maTG, string maTL, string maNXB, string maKho, int maNV, float gia)
        {
            Sach sach = new Sach();
            return sach.Insert_Sach(maSach,tenSach,maTG,maTL, maNXB, maKho, maNV, gia);
        }
        public int Update_Sach(string maSach, string tenSach, string maTG, string maTL, string maNXB, string maKho, int maNV, float gia)
        {
            Sach sach = new Sach();
            return sach.Update_Sach (maSach, tenSach, maTG, maTL, maNXB, maKho, maNV, gia);
        }
        public int Delete_Sach(string maSach)
        {
            Sach sach = new Sach();
            return sach.Delete_Sach(maSach);
        }
        public DataTable searchSach(string maSach)
        {
            Sach sach = new Sach();
            return sach.searchSach(maSach);
        }


    }
}
