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
    public partial class Calcutor : Form
    {
        public Calcutor()
        {
            InitializeComponent();
            this.Shown += (s, e) => textBox.Focus();// if form open auto focus text box
        }

        public App mainform;

        public Calcutor (App app)
        {
            InitializeComponent();
            mainform = app;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            mainform.Visible = true;
            this.Visible = false;
        }
        private void Btncls_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            textBox.Text = "0";
            textBox.Focus();
        }
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            string clickedNumber = btn.Text;

            if (textBox.Text == "0")
                textBox.Text = clickedNumber;
            else
                textBox.Text += clickedNumber;
        }

        private void Calcutor_Load(object sender, EventArgs e)
        {
            Btn0.Click += NumberButton_Click;
            Btn1.Click += NumberButton_Click;
            Btn2.Click += NumberButton_Click;
            Btn3.Click += NumberButton_Click;
            Btn4.Click += NumberButton_Click;
            Btn5.Click += NumberButton_Click;
            Btn6.Click += NumberButton_Click;
            Btn7.Click += NumberButton_Click;
            Btn8.Click += NumberButton_Click;
            Btn9.Click += NumberButton_Click;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {

        }
    }
}
