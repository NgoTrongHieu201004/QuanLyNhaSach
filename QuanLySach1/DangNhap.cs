using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace QuanLySach1
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=MSI\\MSI;Initial Catalog=QuanlyNhaSach;Integrated Security=True;";

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT UserId,MaQuyenHan FROM Users WHERE Username = @Username AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    int userId = reader.GetInt32(0);
                    string quyenHan = reader.GetInt32(1).ToString();


                    CurrentUser.Username = username;
                    CurrentUser.QuyenHan = quyenHan;
                    CurrentUser.Id = userId;

                    MessageBox.Show("Đăng nhập thành công!");
                    ConTrol control = new ConTrol();
                    control.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                }
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
