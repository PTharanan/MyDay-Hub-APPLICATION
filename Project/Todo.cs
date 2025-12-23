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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project
{
    public partial class Todo : Form
    {
        public Todo()
        {
            InitializeComponent();
        }

        public string logusername;
        public string logpassword;
        public Todo(string username, string password)
        {
            InitializeComponent();
            logusername = username;
            logpassword = password;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            App app = new App(logusername, logpassword);
            app.Visible = true;
            this.Visible = false;
        }
        /// <summary>
        /// 
        /// </summary>
        public void backload()
        {
            Login login = new Login();
            Todo_DB db = new Todo_DB();
            DataTable data = db.Pulldata(logusername);
            dataOut.DataSource = data;
            dataOut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dataOut.Rows.Count != 0)
            {
                deleteBtn.Visible = true;
                editBtn.Visible = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Todo_Load(object sender, EventArgs e)// datagrid load
        {
            Login login = new Login(); 
            Todo_DB db = new Todo_DB();
            DataTable data = db.Pulldata(logusername);
            dataOut.DataSource = data;
            dataOut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dataOut.Rows.Count != 0)
            {
                deleteBtn.Visible = true;
                editBtn.Visible = true;
            }
        }

        public void backLoad()
        {
            Login login = new Login();
            Todo_DB db = new Todo_DB();
            DataTable data = db.Pulldata(logusername);
            dataOut.DataSource = data;
            dataOut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dataOut.Rows.Count != 0)
            {
                deleteBtn.Visible = true;
                editBtn.Visible = true;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            TodoAddData data = new TodoAddData(this);
            data.Visible = true;
            this.Visible = false;
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            int selectid = Convert.ToInt32(dataOut.CurrentRow.Cells["TaskId"].Value);
            string Taskname = dataOut.CurrentRow.Cells["TaskName"].Value.ToString();
            TodoEditData edata = new TodoEditData(logusername, logpassword, selectid, Taskname);
            edata.Visible = true;
            this.Visible = false;
        }

        private void seartchBtn_Click(object sender, EventArgs e)
        {
            Todo_DB db = new Todo_DB();
            string searchtxt = textSeartch.Text;
            DataTable data = db.Searchval(logusername, searchtxt);
            dataOut.DataSource = data;
            dataOut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataOut.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Do you really want to delete this?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int selectid = Convert.ToInt32(dataOut.CurrentRow.Cells["TaskId"].Value);
                    Todo_DB db = new Todo_DB();
                    db.Deletedata(selectid);
                    dataOut.Rows.RemoveAt(dataOut.SelectedRows[0].Index);
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
    }
}
