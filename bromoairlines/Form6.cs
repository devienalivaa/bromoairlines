﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bromoairlines
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void masterMaskapaiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void masterBandaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.ShowDialog();
        }

        private void masterJadwalPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.ShowDialog();
        }

        private void masterKodePromoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.ShowDialog();
        }

        private void ubahStatusPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            form.ShowDialog();
        }
    }
}
