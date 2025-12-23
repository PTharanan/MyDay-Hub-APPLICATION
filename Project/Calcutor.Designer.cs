namespace Project
{
    partial class Calcutor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox = new System.Windows.Forms.TextBox();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btndec = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.Btnequal = new System.Windows.Forms.Button();
            this.Btnpluse = new System.Windows.Forms.Button();
            this.Btnminus = new System.Windows.Forms.Button();
            this.Btnmulti = new System.Windows.Forms.Button();
            this.Btndiv = new System.Windows.Forms.Button();
            this.Btncls = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Red;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(526, 14);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(55, 51);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 159);
            this.panel1.TabIndex = 3;
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox.Location = new System.Drawing.Point(14, 71);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(567, 77);
            this.textBox.TabIndex = 3;
            this.textBox.TabStop = false;
            this.textBox.Text = "0";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox.UseWaitCursor = true;
            this.textBox.WordWrap = false;
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.Color.White;
            this.Btn9.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.Btn9.Location = new System.Drawing.Point(12, 162);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(185, 103);
            this.Btn9.TabIndex = 4;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.Color.White;
            this.Btn8.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.Btn8.Location = new System.Drawing.Point(203, 163);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(185, 103);
            this.Btn8.TabIndex = 8;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.Color.White;
            this.Btn7.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.Btn7.Location = new System.Drawing.Point(394, 163);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(185, 103);
            this.Btn7.TabIndex = 9;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.Color.White;
            this.Btn6.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.Btn6.Location = new System.Drawing.Point(12, 271);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(185, 103);
            this.Btn6.TabIndex = 4;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.Color.White;
            this.Btn5.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.Btn5.Location = new System.Drawing.Point(203, 272);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(185, 103);
            this.Btn5.TabIndex = 8;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.Color.White;
            this.Btn4.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.Btn4.Location = new System.Drawing.Point(394, 272);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(185, 103);
            this.Btn4.TabIndex = 9;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.White;
            this.Btn3.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.Btn3.Location = new System.Drawing.Point(12, 380);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(185, 103);
            this.Btn3.TabIndex = 4;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.White;
            this.Btn2.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.Btn2.Location = new System.Drawing.Point(203, 381);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(185, 103);
            this.Btn2.TabIndex = 8;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.White;
            this.Btn1.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.Btn1.Location = new System.Drawing.Point(394, 381);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(185, 103);
            this.Btn1.TabIndex = 9;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            // 
            // Btndec
            // 
            this.Btndec.BackColor = System.Drawing.Color.White;
            this.Btndec.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btndec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.Btndec.Location = new System.Drawing.Point(12, 489);
            this.Btndec.Name = "Btndec";
            this.Btndec.Size = new System.Drawing.Size(185, 103);
            this.Btndec.TabIndex = 4;
            this.Btndec.Text = ".";
            this.Btndec.UseVisualStyleBackColor = false;
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.Color.White;
            this.Btn0.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.Btn0.Location = new System.Drawing.Point(203, 490);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(185, 103);
            this.Btn0.TabIndex = 8;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            // 
            // Btnequal
            // 
            this.Btnequal.BackColor = System.Drawing.Color.Black;
            this.Btnequal.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnequal.ForeColor = System.Drawing.Color.White;
            this.Btnequal.Location = new System.Drawing.Point(394, 490);
            this.Btnequal.Name = "Btnequal";
            this.Btnequal.Size = new System.Drawing.Size(185, 141);
            this.Btnequal.TabIndex = 9;
            this.Btnequal.Text = "=";
            this.Btnequal.UseVisualStyleBackColor = false;
            // 
            // Btnpluse
            // 
            this.Btnpluse.BackColor = System.Drawing.Color.White;
            this.Btnpluse.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnpluse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.Btnpluse.Location = new System.Drawing.Point(12, 598);
            this.Btnpluse.Name = "Btnpluse";
            this.Btnpluse.Size = new System.Drawing.Size(185, 72);
            this.Btnpluse.TabIndex = 11;
            this.Btnpluse.Text = "+";
            this.Btnpluse.UseVisualStyleBackColor = false;
            // 
            // Btnminus
            // 
            this.Btnminus.BackColor = System.Drawing.Color.White;
            this.Btnminus.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnminus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.Btnminus.Location = new System.Drawing.Point(203, 599);
            this.Btnminus.Name = "Btnminus";
            this.Btnminus.Size = new System.Drawing.Size(185, 72);
            this.Btnminus.TabIndex = 12;
            this.Btnminus.Text = "-";
            this.Btnminus.UseVisualStyleBackColor = false;
            // 
            // Btnmulti
            // 
            this.Btnmulti.BackColor = System.Drawing.Color.White;
            this.Btnmulti.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnmulti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.Btnmulti.Location = new System.Drawing.Point(12, 676);
            this.Btnmulti.Name = "Btnmulti";
            this.Btnmulti.Size = new System.Drawing.Size(185, 72);
            this.Btnmulti.TabIndex = 13;
            this.Btnmulti.Text = "x";
            this.Btnmulti.UseVisualStyleBackColor = false;
            // 
            // Btndiv
            // 
            this.Btndiv.BackColor = System.Drawing.Color.White;
            this.Btndiv.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btndiv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.Btndiv.Location = new System.Drawing.Point(203, 677);
            this.Btndiv.Name = "Btndiv";
            this.Btndiv.Size = new System.Drawing.Size(185, 72);
            this.Btndiv.TabIndex = 14;
            this.Btndiv.Text = "/";
            this.Btndiv.UseVisualStyleBackColor = false;
            // 
            // Btncls
            // 
            this.Btncls.BackColor = System.Drawing.Color.DodgerBlue;
            this.Btncls.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btncls.ForeColor = System.Drawing.Color.Lavender;
            this.Btncls.Location = new System.Drawing.Point(394, 638);
            this.Btncls.Name = "Btncls";
            this.Btncls.Size = new System.Drawing.Size(185, 111);
            this.Btncls.TabIndex = 16;
            this.Btncls.Text = "Clear";
            this.Btncls.UseVisualStyleBackColor = false;
            this.Btncls.Click += new System.EventHandler(this.Btncls_Click);
            // 
            // Calcutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(591, 798);
            this.Controls.Add(this.Btncls);
            this.Controls.Add(this.Btndiv);
            this.Controls.Add(this.Btnmulti);
            this.Controls.Add(this.Btnminus);
            this.Controls.Add(this.Btnpluse);
            this.Controls.Add(this.Btnequal);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.Btndec);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calcutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcutor";
            this.Load += new System.EventHandler(this.Calcutor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btndec;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button Btnequal;
        private System.Windows.Forms.Button Btnpluse;
        private System.Windows.Forms.Button Btnminus;
        private System.Windows.Forms.Button Btnmulti;
        private System.Windows.Forms.Button Btndiv;
        private System.Windows.Forms.Button Btncls;
        private System.Windows.Forms.TextBox textBox;
    }
}