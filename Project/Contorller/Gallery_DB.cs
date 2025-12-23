using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project.Contorller
{
    internal class Gallery_DB
    {
        public SqlConnection connection;

        public Gallery_DB()
        {
            string conn = @"Data Source=ASUS\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;";
            connection = new SqlConnection(conn);
        }

        public bool Pushdata(string username, string imagename, Byte[] image)
        {
            try
            {
                connection.Open();
                string sql = @"insert into Image (Username,Imagename, Image) values(@username,@imagename,@imagedata);";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@imagename", imagename);
                cmd.Parameters.AddWithValue("@imagedata", image);
                cmd.ExecuteNonQuery();
                return true;//sucess
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable Pulldata(string username)
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                string sql = "SELECT Image.ID, Image.Username, Image.Imagename, Image.Image FROM Image JOIN Users ON Users.Username = Image.Username WHERE Users.Username = @username;";
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

        public bool Editdata(int id, string username, string imagename, Byte[] imagedata)
        {
            try
            {
                connection.Open();
                string sql = "update Image set Username = @username, Imagename = @imagename, Image = @imagedata  where ID = @id;";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@imagename", imagename);
                cmd.Parameters.AddWithValue("@imagedata", imagedata);
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
                string sql = "delete from Image where ID = @id;";
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
