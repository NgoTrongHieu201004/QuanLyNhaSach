using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DAL
{
    public class HoaDonNS: DB
    {
        public HoaDonNS() : base()
        {

        }
        public DataTable getHoaDon()
        {
            DataTable result = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("getHoaDon", Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            adapter.Fill(result);
            Conn.Close();
            return result;

        }
        public DataTable comboBoxKhachHang()
        {
            DataTable result = new DataTable();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("comboKhachHang", Conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }

                adapter.Fill(result);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thực thi stored procedure: " + ex.Message);
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

        public DataTable gia_Sach(string maSach)
        {
            DataTable result = new DataTable();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("Gia_Sach", Conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@MaSach", maSach);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }

                adapter.Fill(result);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thực thi stored procedure: " + ex.Message);
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

        public DataTable comboBoxSach()
        {
            DataTable result = new DataTable();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("comboSach", Conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }

                adapter.Fill(result);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thực thi stored procedure: " + ex.Message);
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

        public int Insert_HoaDon(string maHD, string maKH, string maSach, int soLuong, float tong, int userId, DateTime ngay)
        {
            int result = -1;
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
                SqlCommand sqlCommand = new SqlCommand($"Insert_HoaDon", Conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@MaHD", maHD);
                sqlCommand.Parameters.AddWithValue("@MaKhachHang", maKH);
                sqlCommand.Parameters.AddWithValue("@MaSach", maSach);
                sqlCommand.Parameters.AddWithValue("@SoLuong", soLuong);
                sqlCommand.Parameters.AddWithValue("@TongTien", tong);
                sqlCommand.Parameters.AddWithValue("@UserId", userId);
                sqlCommand.Parameters.AddWithValue("@NgayLapHD", ngay);

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
        public int Update_HoaDon(string maHD, string maKH, string maSach, int soLuong, float tong, int userId, DateTime ngay)
        {
            int result = -1;
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("Update_HoaDon", Conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@MaHD", maHD);
                sqlCommand.Parameters.AddWithValue("@MaKhachHang", maKH);
                sqlCommand.Parameters.AddWithValue("@MaSach", maSach);
                sqlCommand.Parameters.AddWithValue("@SoLuong", soLuong);
                sqlCommand.Parameters.AddWithValue("@TongTien", tong);
                sqlCommand.Parameters.AddWithValue("@UserId", userId);
                sqlCommand.Parameters.AddWithValue("@NgayLapHD", ngay);

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
        public int Delete_HoaDon(string maHD)
        {
            int result = -1;
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("Delete_HoaDon", Conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@MaHD", maHD);

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

        public DataTable searchHoaDon(DateTime start, DateTime end)
        {
            DataTable result = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("searchHoaDon", Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Start", start);
            sqlCommand.Parameters.AddWithValue("@End", end);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            adapter.Fill(result);
            Conn.Close();
            return result;


        }
    }
}
