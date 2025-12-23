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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.Shown += (s, e) => textRegisteruser.Focus();// if form open auto focus text box
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textRegisteruser_KeyDown(object sender, KeyEventArgs e)
        {
            MoveFocusOnEnter(e, textRegisterpassword);
        }

        private void textRegisterpassword_KeyDown(object sender, KeyEventArgs e)
        {
            MoveFocusOnEnter(e, textRegisterpasswordre);
        }

        private void MoveFocusOnEnter(KeyEventArgs e, Control nextControl)// enter key to Focus move
        {
            if (e.KeyCode == Keys.Enter)
            {
                nextControl.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textRegisteruser.Clear();
            textRegisterpassword.Clear();
            textRegisterpasswordre.Clear();
            textRegisteruser.Focus();
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            Login lo = new Login();
            lo.Visible = true;
            this.Close();
        }

        private void textRegisteruser_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(textRegisterpassword.Text == textRegisterpasswordre.Text)
            {
                if (textRegisterpasswordre.Text.Length == 8)
                {
                    string username = textRegisteruser.Text.Trim();
                    string password = textRegisterpasswordre.Text.Trim();

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
                        Login_DB dB = new Login_DB();
                        bool result = dB.Pushdata(username, password);
                        textRegisteruser.Clear();
                        textRegisterpassword.Clear();
                        textRegisterpasswordre.Clear();
                        textRegisteruser.Focus();
                        if (result)// check database sucess
                        {
                            MessageBox.Show("Susscesfully Saved");
                            Login lo = new Login();
                            lo.Visible = true;
                            this.Visible = false;
                        }
                        else//now add code check it@@@@@@@
                        {
                            MessageBox.Show("Data Not Saved. Try again.");
                        }
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Enter Must 8 Digit Password");

                    if (result == DialogResult.OK)
                    {
                        textRegisterpassword.Clear();
                        textRegisterpasswordre.Clear();
                        textRegisterpassword.Focus();
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Enter Same Password");

                if (result == DialogResult.OK)
                {
                    textRegisterpassword.Clear();
                    textRegisterpasswordre.Clear();
                    textRegisterpassword.Focus();
                }
            }
        }

        private void textRegisterpasswordre_KeyDown(object sender, KeyEventArgs e)//triggers save button click
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveBtn.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void textRegisterpasswordre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
