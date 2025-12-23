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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Shown += (s, e) => textUsername.Focus();// if form open auto focus text box
        }

        private void textUsername_KeyDown(object sender, KeyEventArgs e)// if i click enter butn auto focus txtbox
        {
            if (e.KeyCode == Keys.Enter)
            {
                textUserpassword.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textUserpassword.PasswordChar = '●'; // hides typed text
        }

        private void clearLabel_Click(object sender, EventArgs e)
        {
            textUsername.Clear();
            textUserpassword.Clear();
            textUsername.Focus();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            Register re = new Register();
            re.Show();
            this.Visible = false; 
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text.Trim();
            string password = textUserpassword.Text.Trim();
            
            Login_DB db = new Login_DB();

            //App app = new App();// send username and password
            //app.Getusernamepassword(username, password);


            if (db.CheckUsername(username) && username == "admin")
            {
                // Admin login
                if (db.ValidateUser(username, password) && password == "admin")
                {
                    Admindashboard admindashboard = new Admindashboard();
                    admindashboard.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Invalid Password!");
                    textUserpassword.Clear();
                    textUserpassword.Focus();
                }
            }
            else if (db.CheckUsername(username))
            {
                // User Form
                if (db.ValidateUser(username, password))
                {
                    App app = new App(username,password);
                    app.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Invalid Password!");
                    textUserpassword.Clear();
                    textUserpassword.Focus();
                }

            }
            else
            {
                MessageBox.Show("Invalid Username And Password!\n Please Register");
                textUsername.Clear();
                textUserpassword.Clear();
                textUsername.Focus();
            }

        }

        private void textUserpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void textUserpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
