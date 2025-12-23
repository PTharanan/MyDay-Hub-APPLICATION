using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Contorller
{
    internal class Todo_DB
    {
        private SqlConnection connection;
        public Todo_DB()
        {
            string conn = @"Data Source=ASUS\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;";
            connection = new SqlConnection(conn);
        }

        public bool Pushdata(string username, string task)
        {
            try
            {
                connection.Open();
                string sql = "insert into Tasks(Username,TaskName) values(@username,@task);";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@task", task);
                cmd.ExecuteNonQuery();
                return true; //Sucess
            }

            catch (SqlException ex)
            {
                if (ex.Message.Contains("cannot be null"))
                {
                    MessageBox.Show("Task name is required. Please enter a value.");
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public DataTable Pulldata(string username)
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                string sql = "SELECT Users.Username,Tasks.TaskName, Tasks.TaskID FROM Users JOIN Tasks ON Users.Username = Tasks.Username WHERE Users.Username = @username;";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", username);
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

        public DataTable Searchval(string username, string searchtext)
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                string sql = "SELECT Users.Username,Tasks.TaskName, Tasks.TaskID FROM Users JOIN Tasks ON Users.Username = Tasks.Username WHERE Users.Username = @username AND TaskName LIKE @search;";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@search", searchtext + "%");
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

        public bool Editdata(int id, string username, string task)
        {
            try
            {
                connection.Open();
                string sql = "update Tasks set Username = @username, TaskName = @task where TaskID = @id;";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@task", task);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                return true; //Sucess
            }

            catch (SqlException ex)
            {
                if (ex.Message.Contains("cannot be null"))
                {
                    MessageBox.Show("Task name is required. Please enter a value.");
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

        public bool Deletedata(int id)
        {
            try
            {
                connection.Open();
                string sql = "delete from Tasks where TaskID = @id;";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                return true; //Sucess
            }

            catch (SqlException ex)
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
