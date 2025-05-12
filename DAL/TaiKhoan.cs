using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoan : DB 
    {
        public TaiKhoan() : base()
        {

        }

        public DataTable getUsers()
        {
            DataTable result = new DataTable();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("getUsers", Conn);
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

        public DataTable comboBoxQuyenHan()
        {
            DataTable result = new DataTable();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("comboQuyenHan", Conn);
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

        public int Insert_Users(string username, string password, int maQuyenHan)
        {
            int result = -1;
            try
            {
                SqlCommand sqlCommand = new SqlCommand("Insert_Users", Conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@Username", username);
                sqlCommand.Parameters.AddWithValue("@Password", password);
                sqlCommand.Parameters.AddWithValue("@MaQuyenHan", maQuyenHan);

                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }

                result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    result = 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Thêm tài khoản thất bại: " + ex.Message);
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

        public int Update_Users(int userId,string username, string password, int maQuyenHan)
        {
            int result = -1;
            try
            {
                SqlCommand cmd = new SqlCommand("update_Users", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@MaQuyenHan", maQuyenHan);

                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }

                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi sửa: " + ex.Message);
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

        public int Delete_Users(int userId)
        {
            int result = -1;
            try
            {
                SqlCommand cmd = new SqlCommand("delete_Users", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", userId);

                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }

                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa: " + ex.Message);
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
    }
}
