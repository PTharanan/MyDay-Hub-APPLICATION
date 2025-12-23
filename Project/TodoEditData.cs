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
    public partial class TodoEditData : Form
    {
        public TodoEditData()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textTask.Clear();
            textTask.Focus();
        }

        public string logusername;
        public string logpassword;
        public int taskid;
        public string Taskname;
        public TodoEditData(string username, string password, int id, string taskname)
        {
            InitializeComponent();
            logusername = username;
            logpassword = password;
            taskid = id;
            Taskname = taskname;
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Todo todo = new Todo(logusername,logpassword);
            todo.Visible = true;
            this.Visible = false;
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            string task = textTask.Text.Trim();
            if (string.IsNullOrWhiteSpace(task))
            {
                DialogResult result = MessageBox.Show("cannot be empty!");

                if (result == DialogResult.OK)
                {
                    clearBtn.PerformClick();
                }
            }
            
            else
            {
                Todo_DB db = new Todo_DB();
                db.Editdata(taskid, logusername, task);
                DialogResult result = MessageBox.Show("Susscefully Saved");

                if (result == DialogResult.OK)
                {
                    this.Visible = false;
                    Todo todo = new Todo(logusername, logpassword);
                    todo.Visible = true;
                }
            }
        }

        private void TodoEditData_Load(object sender, EventArgs e)
        {
            textTask.Text = Taskname;
        }
    }
}
