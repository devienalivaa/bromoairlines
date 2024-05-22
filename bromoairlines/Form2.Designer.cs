namespace bromoairlines
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 40);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 0;
            label1.Text = "DAFTAR AKUN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 75);
            label2.Name = "label2";
            label2.Size = new Size(282, 15);
            label2.TabIndex = 1;
            label2.Text = "Daftarkan anda untuk menggunakan Bromo Airlines";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 118);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 23);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 154);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 4;
            label4.Text = "Nama";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(127, 151);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 23);
            textBox2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 190);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 6;
            label5.Text = "Tanggal Lahir";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(127, 184);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(207, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 222);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 8;
            label6.Text = "Nomor Telepon";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(127, 219);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(207, 23);
            textBox3.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 257);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 10;
            label7.Text = "Password";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(127, 254);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(207, 23);
            textBox4.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(248, 293);
            button1.Name = "button1";
            button1.Size = new Size(86, 27);
            button1.TabIndex = 12;
            button1.Text = "Daftar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_Rect___Without_Tagline___Without_Padding;
            pictureBox1.Location = new Point(407, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 349);
            label8.Name = "label8";
            label8.Size = new Size(110, 15);
            label8.TabIndex = 14;
            label8.Text = "Sudah punya akun?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(143, 349);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(37, 15);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 450);
            Controls.Add(linkLabel1);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "BromoAirline - Daftar Akun";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox4;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label8;
        private LinkLabel linkLabel1;
    }
}