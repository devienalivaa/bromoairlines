namespace bromoairlines
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            masterBandaraToolStripMenuItem = new ToolStripMenuItem();
            masterMaskapaiToolStripMenuItem1 = new ToolStripMenuItem();
            masterJadwalPenerbanganToolStripMenuItem = new ToolStripMenuItem();
            masterKodePromoToolStripMenuItem = new ToolStripMenuItem();
            ubahStatusPenerbanganToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.ForeColor = Color.Red;
            button2.Location = new Point(40, 293);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = Properties.Resources.log_out_unselected_72;
            pictureBox1.Location = new Point(12, 294);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(205, 96);
            label3.Name = "label3";
            label3.Size = new Size(298, 15);
            label3.TabIndex = 31;
            label3.Text = "Anda bisa mengubah status jadwal penerbangan di sini";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(menuStrip1);
            panel2.Location = new Point(-1, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(188, 429);
            panel2.TabIndex = 29;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonHighlight;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { masterBandaraToolStripMenuItem, masterMaskapaiToolStripMenuItem1, masterJadwalPenerbanganToolStripMenuItem, masterKodePromoToolStripMenuItem, ubahStatusPenerbanganToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(188, 429);
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
            masterKodePromoToolStripMenuItem.ForeColor = SystemColors.ButtonShadow;
            masterKodePromoToolStripMenuItem.Image = (Image)resources.GetObject("masterKodePromoToolStripMenuItem.Image");
            masterKodePromoToolStripMenuItem.Name = "masterKodePromoToolStripMenuItem";
            masterKodePromoToolStripMenuItem.Size = new Size(175, 20);
            masterKodePromoToolStripMenuItem.Text = "Master Kode Promo";
            masterKodePromoToolStripMenuItem.Click += masterKodePromoToolStripMenuItem_Click;
            // 
            // ubahStatusPenerbanganToolStripMenuItem
            // 
            ubahStatusPenerbanganToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            ubahStatusPenerbanganToolStripMenuItem.Image = (Image)resources.GetObject("ubahStatusPenerbanganToolStripMenuItem.Image");
            ubahStatusPenerbanganToolStripMenuItem.Name = "ubahStatusPenerbanganToolStripMenuItem";
            ubahStatusPenerbanganToolStripMenuItem.Size = new Size(175, 20);
            ubahStatusPenerbanganToolStripMenuItem.Text = "Ubah Status Penerbangan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(205, 73);
            label2.Name = "label2";
            label2.Size = new Size(232, 21);
            label2.TabIndex = 30;
            label2.Text = "UBAH STATUS PENERBANGAN";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 58);
            panel1.TabIndex = 28;
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
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, Column6, Column7 });
            dataGridView2.Location = new Point(205, 126);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(791, 150);
            dataGridView2.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Kode Penerbangan";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Bandara Keberangatan";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Bandara Tujuan";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Maskapai";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Tanggal Keberangkatan";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Waktu Keberangkatan";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Durasi Penerbangan";
            Column7.Name = "Column7";
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 331);
            Controls.Add(dataGridView2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form9";
            Text = "Form9";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private PictureBox pictureBox1;
        private Label label3;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem masterBandaraToolStripMenuItem;
        private ToolStripMenuItem masterMaskapaiToolStripMenuItem1;
        private ToolStripMenuItem masterJadwalPenerbanganToolStripMenuItem;
        private ToolStripMenuItem masterKodePromoToolStripMenuItem;
        private ToolStripMenuItem ubahStatusPenerbanganToolStripMenuItem;
        private Label label2;
        private Panel panel1;
        private Button button1;
        private Label label1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}