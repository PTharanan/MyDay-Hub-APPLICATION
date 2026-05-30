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
            // கிரிட்வியூவில் தரவு மற்றும் ரோ தேர்ந்தெடுக்கப்பட்டுள்ளதா என உறுதி செய்தல்
            if (dataView.Rows.Count > 0 && dataView.CurrentRow != null)
            {
                string username = dataView.CurrentRow.Cells["Username"].Value.ToString();

                // பாதுகாப்பு விதி: முதன்மை 'admin' கணக்கை யாரையும் டெலீட் செய்ய அனுமதிக்கக் கூடாது
                if (username.ToLower() == "admin")
                {
                    MessageBox.Show("Security Restriction: The primary 'admin' account cannot be deleted!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                // டெலீட் செய்ய அனுமதி கேட்டல்
                DialogResult result = MessageBox.Show($"Do you really want to delete user '{username}' and all their gallery images?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // 1. டேட்டாபேஸில் இருந்து பயனரின் தரவை நீக்குதல் 
                        // (குறிப்பு: உங்கள் 'db.Deletedata' மெத்தடுக்குள் முதலில் Image டேபிளையும், பின் Users டேபிளையும் அழிக்க வேண்டும்)
                        db.Deletedata(username);

                        MessageBox.Show("Successfully Deleted Everything!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 2. கிரிட்வியூவை புதுப்பிக்க (Refresh) தரவை மீண்டும் லோடு செய்தல்
                        DataTable data = db.Pulldata();
                        dataView.DataSource = data;

                        // டேட்டா இல்லை என்றால் பட்டன்களை மறைத்தல்
                        if (dataView.Rows.Count == 0)
                        {
                            deleteBtn.Visible = false;
                            editBtn.Visible = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Foreign Key அல்லது வேறு ஏதேனும் எரர் வந்தால் சாஃப்ட்வேர் க்ராஷ் ஆகாமல் தடுத்து மெசேஜ் காட்டும்
                        MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Table doesn't have any data.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                deleteBtn.Visible = false;
                editBtn.Visible = false;
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
