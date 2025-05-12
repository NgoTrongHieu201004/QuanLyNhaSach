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
    public class KhachHang : DB
    {
        public KhachHang() : base()
        {

        }
        public DataTable getKhachHang()
        {
            DataTable result = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("getKhachHang", Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            adapter.Fill(result);
            Conn.Close();
            return result;

        }

       
        public int Insert_khachHang(string maKH, string tenKH, string gioiTinh, DateTime tuoi, string email, string sdt, int maNV)
        {
            int result = -1;
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
                SqlCommand sqlCommand = new SqlCommand($"Insert_khachHang", Conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@MaKhachHang", maKH);
                sqlCommand.Parameters.AddWithValue("@HoTen", tenKH);
                sqlCommand.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                sqlCommand.Parameters.AddWithValue("@Tuoi", tuoi);
                sqlCommand.Parameters.AddWithValue("@Email", email);
                sqlCommand.Parameters.AddWithValue("@Sdt", sdt);
                sqlCommand.Parameters.AddWithValue("@UserId", maNV);

                result = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm thông tin: " + ex.Message);
            }
            finally
            {
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
            return result;


        }
        public int Update_KhachHang(string maKH, string tenKH, string gioiTinh, DateTime tuoi, string email, string sdt, int maNV)
        {
            int result = -1;
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("Update_KhachHang", Conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@MaKhachHang", maKH);
                sqlCommand.Parameters.AddWithValue("@HoTen", tenKH);
                sqlCommand.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                sqlCommand.Parameters.AddWithValue("@Tuoi", tuoi);
                sqlCommand.Parameters.AddWithValue("@Email", email);
                sqlCommand.Parameters.AddWithValue("@Sdt", sdt);
                sqlCommand.Parameters.AddWithValue("@UserId", maNV);

            result = sqlCommand.ExecuteNonQuery();
        }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi sửa thông tin người dùng: " + ex.Message);
            }
            finally
            {
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
            return result;

        }
        public int Delete_KhachHang(string maKH)
        {
            int result = -1;
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("Delete_KhachHang", Conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@maKhachHang", maKH);

            result = sqlCommand.ExecuteNonQuery();
        }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi Xoá thông tin người dùng: " + ex.Message);
            }
            finally
            {
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
            return result;


        }

        public DataTable searchKhachHang(string maKH)
        {
            DataTable result = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("searchKhachHang", Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@MaKhachHang", maKH);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            adapter.Fill(result);
            Conn.Close();
            return result;


        }

        
    }
}
