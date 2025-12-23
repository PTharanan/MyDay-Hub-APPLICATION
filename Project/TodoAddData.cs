using Project.Contorller;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class TodoAddData : Form
    {
        public TodoAddData()
        {
            InitializeComponent();
        }

        public Todo mainForm;

        public TodoAddData(Todo todo)
        {
            InitializeComponent();
            mainForm = todo;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            mainForm.Visible = true;
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textTask.Clear();
            textTask.Focus();
        }
        

        private void addBtn_Click(object sender, EventArgs e)
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
                db.Pushdata(mainForm.logusername, task);
                DialogResult result = MessageBox.Show("Successfully Added");

                if (result == DialogResult.OK)
                {
                    mainForm.backload();
                    this.Visible = false;
                    mainForm.Visible = true;
                }
            }
        }
    }
}
