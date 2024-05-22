namespace bromoairlines
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            masterBandaraToolStripMenuItem = new ToolStripMenuItem();
            masterMaskapaiToolStripMenuItem1 = new ToolStripMenuItem();
            masterJadwalPenerbanganToolStripMenuItem = new ToolStripMenuItem();
            masterKodePromoToolStripMenuItem = new ToolStripMenuItem();
            ubahStatusPenerbanganToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 64);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.HotTrack;
            button1.Image = Properties.Resources.menu_alt_724;
            button1.Location = new Point(3, 6);
            button1.Name = "button1";
            button1.Size = new Size(63, 48);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(60, 14);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 1;
            label1.Text = "Dashboard";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(menuStrip1);
            panel2.Location = new Point(1, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(188, 442);
            panel2.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonHighlight;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { masterBandaraToolStripMenuItem, masterMaskapaiToolStripMenuItem1, masterJadwalPenerbanganToolStripMenuItem, masterKodePromoToolStripMenuItem, ubahStatusPenerbanganToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(188, 442);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // masterBandaraToolStripMenuItem
            // 
            masterBandaraToolStripMenuItem.Image = Properties.Resources.map_unselected_721;
            masterBandaraToolStripMenuItem.Name = "masterBandaraToolStripMenuItem";
            masterBandaraToolStripMenuItem.Size = new Size(175, 20);
            masterBandaraToolStripMenuItem.Text = "Master Bandara";
            masterBandaraToolStripMenuItem.Click += masterBandaraToolStripMenuItem_Click;
            // 
            // masterMaskapaiToolStripMenuItem1
            // 
            masterMaskapaiToolStripMenuItem1.Image = Properties.Resources.plane_take_off_unselected_72;
            masterMaskapaiToolStripMenuItem1.Name = "masterMaskapaiToolStripMenuItem1";
            masterMaskapaiToolStripMenuItem1.Size = new Size(175, 20);
            masterMaskapaiToolStripMenuItem1.Text = "Master Maskapai";
            masterMaskapaiToolStripMenuItem1.Click += masterMaskapaiToolStripMenuItem1_Click;
            // 
            // masterJadwalPenerbanganToolStripMenuItem
            // 
            masterJadwalPenerbanganToolStripMenuItem.Image = (Image)resources.GetObject("masterJadwalPenerbanganToolStripMenuItem.Image");
            masterJadwalPenerbanganToolStripMenuItem.Name = "masterJadwalPenerbanganToolStripMenuItem";
            masterJadwalPenerbanganToolStripMenuItem.Size = new Size(175, 20);
            masterJadwalPenerbanganToolStripMenuItem.Text = "Master Jadwal Penerbangan";
            masterJadwalPenerbanganToolStripMenuItem.Click += masterJadwalPenerbanganToolStripMenuItem_Click;
            // 
            // masterKodePromoToolStripMenuItem
            // 
            masterKodePromoToolStripMenuItem.Image = Properties.Resources.purchase_tag_alt_unselected_72;
            masterKodePromoToolStripMenuItem.Name = "masterKodePromoToolStripMenuItem";
            masterKodePromoToolStripMenuItem.Size = new Size(175, 20);
            masterKodePromoToolStripMenuItem.Text = "Master Kode Promo";
            masterKodePromoToolStripMenuItem.Click += masterKodePromoToolStripMenuItem_Click;
            // 
            // ubahStatusPenerbanganToolStripMenuItem
            // 
            ubahStatusPenerbanganToolStripMenuItem.Image = (Image)resources.GetObject("ubahStatusPenerbanganToolStripMenuItem.Image");
            ubahStatusPenerbanganToolStripMenuItem.Name = "ubahStatusPenerbanganToolStripMenuItem";
            ubahStatusPenerbanganToolStripMenuItem.Size = new Size(175, 20);
            ubahStatusPenerbanganToolStripMenuItem.Text = "Ubah Status Penerbangan";
            ubahStatusPenerbanganToolStripMenuItem.Click += ubahStatusPenerbanganToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = Properties.Resources.log_out_unselected_72;
            pictureBox1.Location = new Point(11, 415);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.ForeColor = Color.Red;
            button4.Location = new Point(37, 415);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 52;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form4";
            Text = "BromoAirlines - Admin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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
        private Button button1;
        private PictureBox pictureBox1;
        private Button button4;
    }
}