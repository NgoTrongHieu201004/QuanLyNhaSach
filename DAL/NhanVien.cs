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
    public class NhanVien : DB
    {
        public NhanVien() : base()
        {

        }
        public DataTable getNhanVien()
        {
            DataTable result = new DataTable();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("getThongTinUser", Conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                // Mở kết nối nếu chưa mở
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }

                // Thực thi và điền dữ liệu vào DataTable
                adapter.Fill(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thực thi stored procedure: " + ex.Message);
            }
            finally
            {
                // Đảm bảo kết nối được đóng
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
            return result;

        }

        public DataTable comboBoxUser()
        {
            DataTable result = new DataTable();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("comboUser", Conn);
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

        public DataTable comboBoxUserThongTin()
        {
            DataTable result = new DataTable();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("GetUsersWithoutThongTin", Conn);
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

        public int Insert_NhanVien(int userId, string tenNhanVien, DateTime ngaySinh, string gioiTinh, string sdt, string diaChi, float luong)
        {
            int result = -1;
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("insert_ThongTinUser", Conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@UserId", userId);
                sqlCommand.Parameters.AddWithValue("@TenNhanVien", tenNhanVien);
                sqlCommand.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                sqlCommand.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                sqlCommand.Parameters.AddWithValue("@Sdt", sdt);
                sqlCommand.Parameters.AddWithValue("@DiaChi", diaChi);
                sqlCommand.Parameters.AddWithValue("@Luong", luong);

                result = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm thông tin người dùng: " + ex.Message);
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
        public int Update_NhanVien(int userId, string tenNhanVien, DateTime ngaySinh, string gioiTinh, string sdt, string diaChi, float luong)
        {
            int result = -1;
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("update_ThongTinUser", Conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@UserId", userId);
                sqlCommand.Parameters.AddWithValue("@TenNhanVien", tenNhanVien);
                sqlCommand.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                sqlCommand.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                sqlCommand.Parameters.AddWithValue("@Sdt", sdt);
                sqlCommand.Parameters.AddWithValue("@DiaChi", diaChi);
                sqlCommand.Parameters.AddWithValue("@Luong", luong);

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
        public int Detele_NhanVien(int userId)
        {
            int result = -1;
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("delete_ThongTinUser", Conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@UserId", userId);

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

        public DataTable searchNhanVien(string maNV)
        {
            DataTable result = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("searchNhanVien", Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@MaNhanVien", maNV);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            adapter.Fill(result);
            Conn.Close();
            return result;


        }


    }
}
