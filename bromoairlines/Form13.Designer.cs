namespace bromoairlines
{
    partial class Form13
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
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(58, 54);
            label2.Name = "label2";
            label2.Size = new Size(260, 15);
            label2.TabIndex = 5;
            label2.Text = "Semua Tiket Anda yang aktif akan muncul disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 22);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 4;
            label1.Text = "TIKET SAYA";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Control;
            button1.Image = Properties.Resources.chevron_left_solid_72;
            button1.Location = new Point(17, 13);
            button1.Name = "button1";
            button1.Size = new Size(26, 39);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(17, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(771, 150);
            dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.HeaderText = "KodePenerbangan";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Maskapai";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "BandaraKeberangkatan";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "BandaraTujuan";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "TanggalPenerbangan";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "WaktuPenerbangan";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "StatusTerakhir";
            Column7.Name = "Column7";
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 259);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form13";
            Text = "Form13";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}