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
    public partial class form3 : Form
    {
        public form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 newform7 = new Form7();
            newform7.ShowDialog();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 newform8 = new Form8();
            this.Visible = false;
            newform8.ShowDialog();
        }
    }
}
