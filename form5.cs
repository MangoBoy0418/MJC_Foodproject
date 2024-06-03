using System;
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
    public partial class form5 : Form
    {
        public form5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form13 newform13 = new Form13();
            newform13.ShowDialog();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 newform11 = new Form11();
            this.Visible = false; 
            newform11.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 newform12 = new Form12();
            this.Visible = false;
            newform12.ShowDialog();
        }
    }
}
