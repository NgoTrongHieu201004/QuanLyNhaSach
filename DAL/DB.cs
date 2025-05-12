using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class DB
    {
        SqlConnection conn;
        public DB()
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=MSI\MSI;Initial Catalog=QuanlyNhaSach;Integrated Security=True;";
            try
            {
                conn.Open();
                Console.WriteLine("Ket noi thanh cong");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ket noi khong thanh cong");
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }

        public SqlConnection Conn
        {
            get
            {
                return conn;
            }

            set
            {
                conn = value;
            }
        }
    }
}
