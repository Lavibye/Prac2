﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void одновимірніМасивиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void двовимірніМасивиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }

        private void unitTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnitTest f = new UnitTest();
            f.Show();
            this.Hide();
        }

        private void файлиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File f = new File();
            f.Show();
            this.Hide();
        }
    }
}
