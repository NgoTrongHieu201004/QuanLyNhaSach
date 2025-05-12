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
    public class KhoSach : DB
    {
        public KhoSach() : base()
        {

        }
        public DataTable getKho()
        {
            DataTable result = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("getKho", Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            adapter.Fill(result);
            Conn.Close();
            return result;

        }

        public int Insert_KhoSach(string maKho, string soLuong)
        {
            int kq = -1;
            SqlCommand sqlCommand = new SqlCommand($"Insert_KhoSach", Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@MaKhoSach", maKho);
            sqlCommand.Parameters.AddWithValue("@TenKhoSach", soLuong);

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
        public int UpDate_Kho(string maKho, string soLuong)
        {
            int kq = -1;
            SqlCommand sqlCommand = new SqlCommand("UpDate_Kho", Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@MaKhoSach", maKho);
            sqlCommand.Parameters.AddWithValue("@TenKhoSach", soLuong);

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
        public int Delete_Kho(string maKho)
        {
            int kq = -1;
            SqlCommand sqlCommand = new SqlCommand("Delete_Kho", Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@MaKhoSach", maKho);
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




    }
}
