namespace bromoairlines
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            masterBandaraToolStripMenuItem = new ToolStripMenuItem();
            masterMaskapaiToolStripMenuItem1 = new ToolStripMenuItem();
            masterJadwalPenerbanganToolStripMenuItem = new ToolStripMenuItem();
            masterKodePromoToolStripMenuItem = new ToolStripMenuItem();
            ubahStatusPenerbanganToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            domainUpDown1 = new DomainUpDown();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button3 = new Button();
            button4 = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            domainUpDown2 = new DomainUpDown();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(menuStrip1);
            panel2.Location = new Point(1, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(188, 422);
            panel2.TabIndex = 23;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonHighlight;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { masterBandaraToolStripMenuItem, masterMaskapaiToolStripMenuItem1, masterJadwalPenerbanganToolStripMenuItem, masterKodePromoToolStripMenuItem, ubahStatusPenerbanganToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(188, 422);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // masterBandaraToolStripMenuItem
            // 
            masterBandaraToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            masterBandaraToolStripMenuItem.ForeColor = SystemColors.ButtonShadow;
            masterBandaraToolStripMenuItem.Image = (Image)resources.GetObject("masterBandaraToolStripMenuItem.Image");
            masterBandaraToolStripMenuItem.Name = "masterBandaraToolStripMenuItem";
            masterBandaraToolStripMenuItem.Size = new Size(175, 20);
            masterBandaraToolStripMenuItem.Text = "Master Bandara";
            masterBandaraToolStripMenuItem.Click += masterBandaraToolStripMenuItem_Click;
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
            masterKodePromoToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            masterKodePromoToolStripMenuItem.Image = (Image)resources.GetObject("masterKodePromoToolStripMenuItem.Image");
            masterKodePromoToolStripMenuItem.Name = "masterKodePromoToolStripMenuItem";
            masterKodePromoToolStripMenuItem.Size = new Size(175, 20);
            masterKodePromoToolStripMenuItem.Text = "Master Kode Promo";
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
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 58);
            panel1.TabIndex = 22;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.HotTrack;
            button1.Image = Properties.Resources.menu_alt_72;
            button1.Location = new Point(11, 7);
            button1.Name = "button1";
            button1.Size = new Size(57, 41);
            button1.TabIndex = 24;
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(70, 15);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(207, 73);
            label2.Name = "label2";
            label2.Size = new Size(178, 21);
            label2.TabIndex = 24;
            label2.Text = "MASTER KODE PROMO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 96);
            label3.Name = "label3";
            label3.Size = new Size(298, 15);
            label3.TabIndex = 25;
            label3.Text = "Anda bisa mengubah status jadwal penerbangan di sini";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(207, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(708, 150);
            dataGridView1.TabIndex = 26;
            // 
            // Column1
            // 
            Column1.HeaderText = "Kode";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Presentase Diskon";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Maksimun Diskon";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Berlaku Sampai";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Deskripsi";
            Column5.Name = "Column5";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = Properties.Resources.log_out_unselected_72;
            pictureBox1.Location = new Point(12, 438);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.ForeColor = Color.Red;
            button2.Location = new Point(39, 438);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(319, 397);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(212, 23);
            domainUpDown1.TabIndex = 64;
            domainUpDown1.Text = "1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(634, 297);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(281, 123);
            textBox2.TabIndex = 62;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(319, 332);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(212, 23);
            dateTimePicker1.TabIndex = 61;
            // 
            // button3
            // 
            button3.Location = new Point(822, 438);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 56;
            button3.Text = "Simpan";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(720, 438);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 55;
            button4.Text = "Batal";
            button4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(562, 300);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 53;
            label8.Text = "Deskripsi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(206, 399);
            label7.Name = "label7";
            label7.Size = new Size(107, 15);
            label7.TabIndex = 51;
            label7.Text = "Masksimun Diskon";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(206, 365);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 50;
            label6.Text = "Persentase Diskon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(206, 332);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 49;
            label5.Text = "Berlaku Sampai";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(319, 297);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 23);
            textBox1.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(206, 300);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 47;
            label4.Text = "Kode Promo";
            // 
            // domainUpDown2
            // 
            domainUpDown2.Location = new Point(319, 363);
            domainUpDown2.Name = "domainUpDown2";
            domainUpDown2.Size = new Size(212, 23);
            domainUpDown2.TabIndex = 65;
            domainUpDown2.Text = "1";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 476);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(domainUpDown2);
            Controls.Add(domainUpDown1);
            Controls.Add(textBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form8";
            Text = "BromoAirlines - Admin";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem masterBandaraToolStripMenuItem;
        private ToolStripMenuItem masterMaskapaiToolStripMenuItem1;
        private ToolStripMenuItem masterJadwalPenerbanganToolStripMenuItem;
        private ToolStripMenuItem masterKodePromoToolStripMenuItem;
        private ToolStripMenuItem ubahStatusPenerbanganToolStripMenuItem;
        private Panel panel1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Button button2;
        private DomainUpDown domainUpDown1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private Button button3;
        private Button button4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBox1;
        private Label label4;
        private DomainUpDown domainUpDown2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}