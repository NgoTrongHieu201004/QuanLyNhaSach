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
    public class TacGia : DB
    {
        public TacGia() : base()
        {

        }
        public DataTable getTacGia()
        {
            DataTable result = new DataTable();
            SqlCommand sqlCommand = new SqlCommand("getTacGia", Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            adapter.Fill(result);
            Conn.Close();
            return result;

        }

        public int Insert_TacGia(string maTG, string tenTG, string gioiTinh, DateTime tuoi, string tieuSu)
        {
            int kq = -1;
            SqlCommand sqlCommand = new SqlCommand($"Insert_TacGia", Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@MaTacGia", maTG);
            sqlCommand.Parameters.AddWithValue("@TenTacGia", tenTG);
            sqlCommand.Parameters.AddWithValue("@GioiTinh", gioiTinh);
            sqlCommand.Parameters.AddWithValue("@TuoiTacGia", tuoi);
            sqlCommand.Parameters.AddWithValue("@TieuSu", tieuSu);

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
        public int UpDate_TacGia(string maTG, string tenTG, string gioiTinh, DateTime tuoi, string tieuSu)
        {
            int kq = -1;
            SqlCommand sqlCommand = new SqlCommand("UpDate_TacGia", Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@MaTacGia", maTG);
            sqlCommand.Parameters.AddWithValue("@TenTacGia", tenTG);
            sqlCommand.Parameters.AddWithValue("@GioiTinh", gioiTinh);
            sqlCommand.Parameters.AddWithValue("@TuoiTacGia", tuoi);
            sqlCommand.Parameters.AddWithValue("@TieuSu", tieuSu);

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
        public int Delete_TacGia(string maTheLoai)
        {
            int kq = -1;
            SqlCommand sqlCommand = new SqlCommand("Delete_TacGia", Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@MaTacGia", maTheLoai);
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
