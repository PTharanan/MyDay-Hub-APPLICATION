using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Contorller
{
    internal class Login_DB
    {
        private SqlConnection connection;// connection string
        public Login_DB()
        {
            string conn = @"Data Source=ASUS\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;";
            connection = new SqlConnection(conn);
        }

        public bool Pushdata(string username, string password)
        {
            try
            {
                connection.Open();
                string sql = "insert into Users(Username,Password) values(@username,@password);";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();
                return true; //Sucess
            }

            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) // Unique constraint violation
                {
                    MessageBox.Show("This Username Already Hear. Please Choose Different Username");
                    return false;
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable Pulldata()
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                string sql = "select * from Users;";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public void Deletedata(string username)
        {
            try
            {
                connection.Open();
                string sql = "delete from Users where Username = @username;";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        public bool Updatedata(string username, string password, string currentUsername)
        {
            try
            {
                connection.Open();
                string sql = "update Users set Username = @username, Password = @password where Username = @currentUsername;";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@currentUsername", currentUsername);
                cmd.ExecuteNonQuery();
                return true; //Sucess
            }

            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) // Unique constraint violation
                {
                    MessageBox.Show("This Username Already Hear. Please Choose Different Username");
                    return false;
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
            finally
            {
                connection.Close();
            }
        }

        public bool CheckUsername(string username)
        {
            try
            {
                connection.Open();
                string sql = "SELECT COUNT(*) FROM Users WHERE Username = @username";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", username);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool ValidateUser(string username, string password)
        {
            try
            {
                connection.Open();
                string sql = "SELECT COUNT(*) FROM Users WHERE Username=@username AND Password=@password";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
