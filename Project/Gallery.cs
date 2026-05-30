using Project.Contorller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Gallery : Form
    {
        public Gallery()
        {
            InitializeComponent();
        }

        Gallery_DB db = new Gallery_DB();

        public string logusername;
        public string logpassword;

        public Gallery(string username, string password)
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

        private void Gallery_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable data = db.Pulldata(logusername);
                dataOut.DataSource = data;

                // டேபிளை கிரிட் வியூவிற்குள் சரியாகப் பொருத்த (Fit)
                dataOut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // "Image" என்ற காலம் இருக்கிறதா மற்றும் அது இமேஜ் காலம் தானா என்று சரிபார்க்கிறோம்
                if (dataOut.Columns.Contains("Image") && dataOut.Columns["Image"] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataOut.Columns["Image"]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                }

                // டேபிளில் ரோக்கள் (Rows) இருக்கிறதா என்று சரிபார்த்து பட்டன்களைக் காட்டுதல்
                if (dataOut.Rows.Count > 0)
                {
                    deleteBtn.Visible = true;
                    editBtn.Visible = true;
                }
                else
                {
                    // ஒருவேளை தரவு இல்லை என்றால் பட்டன்களை மறைத்து வைப்பது நல்லது
                    deleteBtn.Visible = false;
                    editBtn.Visible = false;
                }
            }
            catch (Exception ex)
            {
                // கோடில் ஏதேனும் எதிர்பாராத எரர் வந்தால் சாஃப்ட்வேர் க்ராஷ் ஆகாமல் தடுத்து எரரைக் காட்டும்
                MessageBox.Show("Error loading gallery: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void backLoad()
        {
            DataTable data = db.Pulldata(logusername);
            dataOut.DataSource = data;
            dataOut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;// fit table on datagridview
            ((DataGridViewImageColumn)dataOut.Columns["Image"]).ImageLayout = DataGridViewImageCellLayout.Stretch;// fit image on coloum
            if (dataOut.Rows.Count != 0)
            {
                deleteBtn.Visible = true;
                editBtn.Visible = true;
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (dataOut.Rows.Count >0)
            {
                Image imagedata;
                string imagename = dataOut.CurrentRow.Cells["Imagename"].Value.ToString();
                int selectid = Convert.ToInt32(dataOut.CurrentRow.Cells["ID"].Value);

                byte[] imageBytes = (byte[])dataOut.CurrentRow.Cells["Image"].Value;
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    imagedata = Image.FromStream(ms);
                }

                EditGallery edit = new EditGallery(logusername, logpassword, imagename, imagedata, selectid);
                edit.Visible = true;
                this.Visible = false;
            }

            else
            {
                DialogResult result = MessageBox.Show("It Has not Dta please add");
                if (result == DialogResult.OK)
                {
                    editBtn.Visible = false;
                }
            }
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddGallery addGallery = new AddGallery(this);
            addGallery.Visible = true;
            this.Visible = false;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataOut.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Do you really want to delete this?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int selectid = Convert.ToInt32(dataOut.CurrentRow.Cells["ID"].Value);
                    Gallery_DB db = new Gallery_DB();
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
