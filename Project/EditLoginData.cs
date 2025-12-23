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
    public partial class EditLoginData : Form
    {
        public EditLoginData()
        {
            InitializeComponent();
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            Login lo = new Login();
            lo.Visible = true;
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textEdituser.Clear();
            textEditpassword.Clear();
            textEditpasswordre.Clear();
            textEdituser.Focus();
        }

        public string logusername;
        public string logpassword;
        public string user;

        public EditLoginData(string username, string password, string editor)
        {
            InitializeComponent();
            logusername = username;
            logpassword = password;
            user = editor;
        }

        private void EditLoginData_Load(object sender, EventArgs e)
        {
            textEdituser.Text = logusername;
            textEditpassword.Text = logpassword;
            textEditpasswordre.Text = logpassword;
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (textEditpassword.Text == textEditpasswordre.Text)
            {
                if (textEditpasswordre.Text.Length == 8)
                {
                    string username = textEdituser.Text;
                    string password = textEditpasswordre.Text;

                    if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                    {
                        DialogResult result = MessageBox.Show("cannot be empty!");

                        if (result == DialogResult.OK)
                        {
                            clearBtn.PerformClick();
                        }
                    }

                    else
                    {
                        Login_DB db = new Login_DB();
                        bool result = db.Updatedata(username, password, logusername);
                        textEdituser.Clear();
                        textEditpassword.Clear();
                        textEditpasswordre.Clear();
                        textEdituser.Focus();
                        if (result)// check database sucess
                        {
                            if (user == "admin")
                            {
                                MessageBox.Show("Susscesfully Saved");
                                Admindashboard admin = new Admindashboard();
                                admin.Visible = true;
                                this.Visible = false;
                            }

                            else
                            {
                                MessageBox.Show("Susscesfully Saved");
                                App app = new App(username, password);
                                app.Visible = true;
                                this.Visible = false;
                            }
                        }
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Enter Must 8 Digit Password");

                    if (result == DialogResult.OK)
                    {
                        textEditpassword.Clear();
                        textEditpasswordre.Clear();
                        textEditpassword.Focus();
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Enter Same Password");

                if (result == DialogResult.OK)
                {
                    textEditpassword.Clear();
                    textEditpasswordre.Clear();
                    textEditpassword.Focus();
                }
            }
        }

        private void MoveFocusOnEnter(KeyEventArgs e, Control nextControl)// move Focuse
        {
            if (e.KeyCode == Keys.Enter)
            {
                nextControl.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private void textEdituser_KeyDown(object sender, KeyEventArgs e)
        {
            MoveFocusOnEnter (e, textEditpassword);
        }

        private void textEditpassword_KeyDown(object sender, KeyEventArgs e)
        {
            MoveFocusOnEnter(e, textEditpasswordre);
        }

        private void textEditpasswordre_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                saveBtn.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
