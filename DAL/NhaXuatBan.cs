using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

namespace DAL
{
    public class NhaXuatBan : DB
    {
        public NhaXuatBan() : base()
        {

        }
        public DataTable getNXB()
        {
            DataTable result = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("getNXB", Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            adapter.Fill(result);
            Conn.Close();
            return result;

        }

        public int Insert_NXB(string maNXB, string tenNXB, string diaChi, string sdt)
        {
            int kq = -1;
            SqlCommand sqlCommand = new SqlCommand($"Insert_NXB", Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@MaNhaXuatBan", maNXB);
            sqlCommand.Parameters.AddWithValue("@TenNhaXuatBan", tenNXB);
            sqlCommand.Parameters.AddWithValue("@DiaChiNhaXuatBan", diaChi);
            sqlCommand.Parameters.AddWithValue("@SdtNhaXuatBan", sdt);
            

            try
            {
                kq = sqlCommand.ExecuteNonQuery();
                if (kq >= 1)
                {
                    kq = 1;
                }
            }
            catch (Exception e)
            {
                Console.Write("Thêm thất bại " + e.ToString());
            }
            Conn.Close();
            return kq;


        }
        public int Update_NXB(string maNXB, string tenNXB, string diaChi, string sdt)
        {
            int kq = -1;
            SqlCommand sqlCommand = new SqlCommand("Update_NXB", Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@MaNhaXuatBan", maNXB);
            sqlCommand.Parameters.AddWithValue("@TenNhaXuatBan", tenNXB);
            sqlCommand.Parameters.AddWithValue("@DiaChiNhaXuatBan", diaChi);
            sqlCommand.Parameters.AddWithValue("@SdtNhaXuatBan", sdt);

            try
            {
                kq = sqlCommand.ExecuteNonQuery();
                if (kq >= 1)
                {
                    kq = 1;
                }
            }
            catch (Exception e)
            {

                Console.Write("Sửa thất bại " + e.ToString());
            }
            Conn.Close();
            return kq;


        }
        public int Delete_NXB(string maNXB)
        {
            int kq = -1;
            SqlCommand sqlCommand = new SqlCommand("Delete_NXB", Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@MaNhaXuatBan", maNXB);
            try
            {
                kq = sqlCommand.ExecuteNonQuery();
                if (kq >= 1)
                {
                    kq = 1;
                }
            }
            catch (Exception e)
            {

                Console.Write("Xóa thất bại " + e.ToString());
            }
            Conn.Close();
            return kq;


        }

       
        public DataTable searchTheLoai(string maNV)
        {
            DataTable result = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("searchTheLoai", Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@MaTheLoai", maNV);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            adapter.Fill(result);
            Conn.Close();
            return result;


        }
    }
}
