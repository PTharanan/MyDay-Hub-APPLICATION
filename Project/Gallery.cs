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
