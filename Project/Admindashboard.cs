using Project.Contorller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Admindashboard : Form
    {
        public Admindashboard()
        {
            InitializeComponent();
        }

        Login_DB db = new Login_DB();

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Admindashboard_Load(object sender, EventArgs e)
        {
            DataTable data = db.Pulldata();
            dataView.DataSource = data;
            dataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dataView.Rows.Count != 0 )
            {
                deleteBtn.Visible = true;
                editBtn.Visible = true;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataView.Rows.Count > 0)
            {
                string username = dataView.CurrentRow.Cells["Username"].Value.ToString();
                if (username == "admin" && dataView.CurrentRow.Cells["Password"].Value.ToString() == "admin")
                {
                    DialogResult result = MessageBox.Show("Do you really want to delete this?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        db.Deletedata(username);
                        dataView.Rows.RemoveAt(dataView.SelectedRows[0].Index);
                        MessageBox.Show("Sucessfully Deleted");
                    }
                }
                else
                {
                 
                    db.Deletedata(username);
                    dataView.Rows.RemoveAt(dataView.SelectedRows[0].Index);
                    MessageBox.Show("Sucessfully Deleted");
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Table Haven't Data");

                if (result == DialogResult.OK)
                {
                    deleteBtn.Visible = false;
                    editBtn.Visible = false;
                }
            }
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Visible = true;
            this.Visible = false;
        }
       
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (dataView.Rows.Count > 0)
            {
                string logusername = dataView.CurrentRow.Cells["Username"].Value.ToString();
                string logpassword = dataView.CurrentRow.Cells["Password"].Value.ToString();
                string editor = "admin"; // send admin user
                EditLoginData edit = new EditLoginData(logusername, logpassword, editor);
                edit.Visible = true;
                this.Visible = false;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Visible = true;
            this.Visible = false;
        }
    }
}
