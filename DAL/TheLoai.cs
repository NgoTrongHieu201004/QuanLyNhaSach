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
    public class TheLoai : DB
    {
        public TheLoai() : base()
        {

        }
        public DataTable getTheLoai()
        {
            DataTable result = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("getTheLoai", Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            adapter.Fill(result);
            Conn.Close();
            return result;

        }

        public int Insert_TheLoai(string maTheLoai, string tenTheLoai)
        {
            int kq = -1;
            SqlCommand sqlCommand = new SqlCommand($"Insert_TheLoai", Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@MaTheLoai", maTheLoai);
            sqlCommand.Parameters.AddWithValue("@TenTheLoai", tenTheLoai);
            
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
      
            return kq;


        }
        public int Update_TheLoai(string maTheLoai, string tenTenLoai)
        {
            int kq = -1;
            SqlCommand sqlCommand = new SqlCommand("Update_TheLoai", Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@MaTheLoai", maTheLoai);
            sqlCommand.Parameters.AddWithValue("@TenTheLoai", tenTenLoai);
            
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
        public int Delete_TheLoai(string maTheLoai)
        {
            int kq = -1;
            SqlCommand sqlCommand = new SqlCommand("Delete_TheLoai", Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@MaTheLoai", maTheLoai);
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
