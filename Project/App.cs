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
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Visible = true;
            this.Visible = false;
        }

        private void greetName_Click(object sender, EventArgs e)
        {

        }

        private void App_Load(object sender, EventArgs e)
        {
            string greet = SetGreeting();
            greetName.Text = $"{greet} {logusername}";
        }

        private string SetGreeting()// set greet eg 8am show morning
        {
            int hour = DateTime.Now.Hour;// get current time
            string greet;

            if (hour >= 5 && hour < 12)
                greet = "Good Morning";
            else if (hour >= 12 && hour < 17)
                greet = "Good Afternoon";
            else if (hour >= 17 && hour < 21)
                greet = "Good Evening";
            else
                greet = "Good Night";

            return greet;
        }
        //private string logusername;
        //private string logpassword;
        //public void Getusernamepassword(string username, string password)
        //{
        //    logusername = username;
        //    logpassword = password;
        //    string greet = SetGreeting();
        //    greetName.Text = $"{greet} {logusername}";
        //}
        public string logusername;
        public string logpassword;
        public App(string username, string password)
        {
            InitializeComponent();
            logusername = username;
            logpassword = password;
        }
        

        private void editBtn_Click(object sender, EventArgs e)
        {

            EditLoginData edit = new EditLoginData(logusername,logpassword, null);
            edit.Visible = true;
            this.Visible = false;
        }

        private void todoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Todo todo = new Todo(logusername, logpassword);
            todo.Visible = true;
            this.Visible = false;
        }

        private void galleryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gallery gallery = new Gallery(logusername, logpassword);
            gallery.Visible = true;
            this.Visible = false;
        }

        private void calcutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calcutor calcutor = new Calcutor(this);
            calcutor.Visible = true;
            this.Visible = false;
        }
    }
}
