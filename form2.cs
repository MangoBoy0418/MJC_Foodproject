﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace MJC_Foodproject
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newform1 = new Form1();
            this.Visible = false;
            newform1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 newform6 = new Form6();
            this.Visible = false;
            newform6.ShowDialog();
        }
    }
}
