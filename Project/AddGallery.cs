using Project.Contorller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AddGallery : Form
    {
        public AddGallery()
        {
            InitializeComponent();
        }

        public Gallery mainForm;

        public AddGallery(Gallery gallery)
        {
            InitializeComponent();
            mainForm = gallery;
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            string imagename = imagenameBox.Text.Trim();
            string username = mainForm.logusername;
            if(string.IsNullOrEmpty(imagename) )
            {
                MessageBox.Show("You Must Enter Imagename Please");
                imagenameBox.Focus();
            }

            else
            {
                byte[] imageData;// pictureBox to Byte data
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
                    imageData = ms.ToArray();
                }

                Gallery_DB db = new Gallery_DB();
                db.Pushdata(username, imagename, imageData);
                DialogResult result = MessageBox.Show("Successfully Saved");

                if (result == DialogResult.OK)
                {
                    mainForm.backLoad();
                    closeBtn.PerformClick();
                }
            }
            

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            mainForm.Visible = true;
            this.Visible = false;
        }

        public string filePath;
        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog form = new OpenFileDialog();
            form.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

            if (form.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(form.FileName);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                filePath = form.FileName;
                if (pictureBox.Image != null)
                {
                    saveBtn.Visible = true;
                    browseBtn.Visible = false;
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            imagenameBox.Clear();
            saveBtn.Visible = false;
            browseBtn.Visible = true;
        }

        private void AddGallery_Load(object sender, EventArgs e)
        {
        }
    }
}
