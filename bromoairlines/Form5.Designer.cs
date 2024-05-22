namespace bromoairlines
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            panel1 = new Panel();
            button3 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            masterBandaraToolStripMenuItem = new ToolStripMenuItem();
            masterMaskapaiToolStripMenuItem1 = new ToolStripMenuItem();
            masterJadwalPenerbanganToolStripMenuItem = new ToolStripMenuItem();
            masterKodePromoToolStripMenuItem = new ToolStripMenuItem();
            ubahStatusPenerbanganToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label8 = new Label();
            domainUpDown1 = new DomainUpDown();
            label9 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1003, 58);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.HotTrack;
            button3.Image = Properties.Resources.menu_alt_723;
            button3.Location = new Point(0, 5);
            button3.Name = "button3";
            button3.Size = new Size(77, 48);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(74, 17);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(menuStrip1);
            panel2.Location = new Point(1, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(188, 438);
            panel2.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonHighlight;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { masterBandaraToolStripMenuItem, masterMaskapaiToolStripMenuItem1, masterJadwalPenerbanganToolStripMenuItem, masterKodePromoToolStripMenuItem, ubahStatusPenerbanganToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(188, 438);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // masterBandaraToolStripMenuItem
            // 
            masterBandaraToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            masterBandaraToolStripMenuItem.Image = (Image)resources.GetObject("masterBandaraToolStripMenuItem.Image");
            masterBandaraToolStripMenuItem.Name = "masterBandaraToolStripMenuItem";
            masterBandaraToolStripMenuItem.Size = new Size(175, 20);
            masterBandaraToolStripMenuItem.Text = "Master Bandara";
            masterBandaraToolStripMenuItem.Click += masterBandaraToolStripMenuItem_Click_1;
            // 
            // masterMaskapaiToolStripMenuItem1
            // 
            masterMaskapaiToolStripMenuItem1.ForeColor = SystemColors.AppWorkspace;
            masterMaskapaiToolStripMenuItem1.Image = Properties.Resources.plane_take_off_unselected_72;
            masterMaskapaiToolStripMenuItem1.Name = "masterMaskapaiToolStripMenuItem1";
            masterMaskapaiToolStripMenuItem1.Size = new Size(175, 20);
            masterMaskapaiToolStripMenuItem1.Text = "Master Maskapai";
            masterMaskapaiToolStripMenuItem1.Click += masterMaskapaiToolStripMenuItem1_Click;
            // 
            // masterJadwalPenerbanganToolStripMenuItem
            // 
            masterJadwalPenerbanganToolStripMenuItem.ForeColor = SystemColors.ButtonShadow;
            masterJadwalPenerbanganToolStripMenuItem.Image = (Image)resources.GetObject("masterJadwalPenerbanganToolStripMenuItem.Image");
            masterJadwalPenerbanganToolStripMenuItem.Name = "masterJadwalPenerbanganToolStripMenuItem";
            masterJadwalPenerbanganToolStripMenuItem.Size = new Size(175, 20);
            masterJadwalPenerbanganToolStripMenuItem.Text = "Master Jadwal Penerbangan";
            masterJadwalPenerbanganToolStripMenuItem.Click += masterJadwalPenerbanganToolStripMenuItem_Click;
            // 
            // masterKodePromoToolStripMenuItem
            // 
            masterKodePromoToolStripMenuItem.ForeColor = SystemColors.ButtonShadow;
            masterKodePromoToolStripMenuItem.Image = Properties.Resources.purchase_tag_alt_unselected_72;
            masterKodePromoToolStripMenuItem.Name = "masterKodePromoToolStripMenuItem";
            masterKodePromoToolStripMenuItem.Size = new Size(175, 20);
            masterKodePromoToolStripMenuItem.Text = "Master Kode Promo";
            masterKodePromoToolStripMenuItem.Click += masterKodePromoToolStripMenuItem_Click;
            // 
            // ubahStatusPenerbanganToolStripMenuItem
            // 
            ubahStatusPenerbanganToolStripMenuItem.ForeColor = SystemColors.ButtonShadow;
            ubahStatusPenerbanganToolStripMenuItem.Image = (Image)resources.GetObject("ubahStatusPenerbanganToolStripMenuItem.Image");
            ubahStatusPenerbanganToolStripMenuItem.Name = "ubahStatusPenerbanganToolStripMenuItem";
            ubahStatusPenerbanganToolStripMenuItem.Size = new Size(175, 20);
            ubahStatusPenerbanganToolStripMenuItem.Text = "Ubah Status Penerbangan";
            ubahStatusPenerbanganToolStripMenuItem.Click += ubahStatusPenerbanganToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(208, 71);
            label2.Name = "label2";
            label2.Size = new Size(164, 30);
            label2.TabIndex = 3;
            label2.Text = "Master Bandara";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 102);
            label3.Name = "label3";
            label3.Size = new Size(272, 15);
            label3.TabIndex = 4;
            label3.Text = "Semua bandara yang terdaftar akan muncul di sini";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(211, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(695, 150);
            dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nama";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Kode IATA";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Kota ";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Negara";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Jumlah Terminal";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Alamat";
            Column6.Name = "Column6";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(211, 313);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 6;
            label4.Text = "Nama";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(288, 310);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 23);
            textBox1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(211, 345);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 8;
            label5.Text = "Kode IATA";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(288, 342);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(195, 23);
            textBox2.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(211, 378);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 10;
            label6.Text = "Kota";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(288, 375);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(195, 23);
            textBox3.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(211, 412);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 12;
            label7.Text = "Negara";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(288, 409);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(195, 23);
            comboBox1.TabIndex = 13;
            comboBox1.Text = "Afganistan";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(567, 313);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 14;
            label8.Text = "Jumlah Terminal";
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(675, 310);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(231, 23);
            domainUpDown1.TabIndex = 15;
            domainUpDown1.Text = "1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(567, 345);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 16;
            label9.Text = "Alamat";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(675, 342);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(231, 85);
            textBox4.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(702, 442);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(800, 442);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 19;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = Properties.Resources.log_out_unselected_72;
            pictureBox1.Location = new Point(12, 440);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.ForeColor = Color.Red;
            button4.Location = new Point(38, 440);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 52;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 473);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label9);
            Controls.Add(domainUpDown1);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form5";
            Text = "BromoAirlines - Admin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem masterBandaraToolStripMenuItem;
        private ToolStripMenuItem masterMaskapaiToolStripMenuItem1;
        private ToolStripMenuItem masterJadwalPenerbanganToolStripMenuItem;
        private ToolStripMenuItem masterKodePromoToolStripMenuItem;
        private ToolStripMenuItem ubahStatusPenerbanganToolStripMenuItem;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private ComboBox comboBox1;
        private Label label8;
        private DomainUpDown domainUpDown1;
        private Label label9;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private Button button4;
    }
}