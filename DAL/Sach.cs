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
    public class Sach : DB
    {
        public Sach() : base()
        {

        }
        public DataTable getSach()
        {
                DataTable result = new DataTable();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("getSach", Conn);
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


        public DataTable comboBoxTheLoai()
        {
            DataTable result = new DataTable();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("comboTheLoai", Conn);
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

        public DataTable comboBoxTacGia()
        {
            DataTable result = new DataTable();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("comboTacGia", Conn);
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

        public DataTable comboBoxNXB()
        {
            DataTable result = new DataTable();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("comboNhaXuatBan", Conn);
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

        public DataTable comboBoxKhoSach()
        {
            DataTable result = new DataTable();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("comboKhoSach", Conn);
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

        public DataTable comboBoxNhanVien()
        {
            DataTable result = new DataTable();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("comboNhanVien", Conn);
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

        public int Insert_Sach(string maSach, string tenSach, string maTG, string maTL, string maNXB, string maKho, int maNV, float gia)
        {
            int result = -1;
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("Insert_Sach", Conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@MaSach", maSach);
                sqlCommand.Parameters.AddWithValue("@TenSach", tenSach);
                sqlCommand.Parameters.AddWithValue("@MaTacGia", maTG);
                sqlCommand.Parameters.AddWithValue("@MaTheLoai", maTL);
                sqlCommand.Parameters.AddWithValue("@MaNhaXuatBan", maNXB);
                sqlCommand.Parameters.AddWithValue("@MaKhoSach", maKho);
                sqlCommand.Parameters.AddWithValue("@UserId", maNV);
                sqlCommand.Parameters.AddWithValue("@Gia", gia);

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
        public int Update_Sach(string maSach, string tenSach, string maTG, string maTL, string maNXB, string maKho, int maNV, float gia)
        {
            int result = -1;
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("Update_Sach", Conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@MaSach", maSach);
                sqlCommand.Parameters.AddWithValue("@TenSach", tenSach);
                sqlCommand.Parameters.AddWithValue("@MaTacGia", maTG);
                sqlCommand.Parameters.AddWithValue("@MaTheLoai", maTL);
                sqlCommand.Parameters.AddWithValue("@MaNhaXuatBan", maNXB);
                sqlCommand.Parameters.AddWithValue("@MaKhoSach", maKho);
                sqlCommand.Parameters.AddWithValue("@UserId", maNV);
                sqlCommand.Parameters.AddWithValue("@Gia", gia);

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
        public int Delete_Sach(string maSach)
        {
            int kq = -1;
            SqlCommand sqlCommand = new SqlCommand("Delete_Sach", Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@MaSach", maSach);
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

        public DataTable searchSach(string maSach)
        {
            DataTable result = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("searchSach", Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@MaSach", maSach);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            adapter.Fill(result);
            Conn.Close();
            return result;


        }


    }
}
