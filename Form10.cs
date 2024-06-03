using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MJC_Foodproject
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            main main = new main();
            this.Visible = false;
            main.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("짜장면의 칼로리는 약 700~900kcal이며, 평균 가격은 약 6,000원입니다. 짜장면은 중국식 춘장 소스를 곁들인 한국식 면 요리입니다.", "짜장면", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("짬뽕의 칼로리는 약 700~900kcal이며, 평균 가격은 약 7,000원입니다. 짬뽕은 매콤한 국물에 다양한 해산물과 채소, 면을 넣어 끓인 한국식 중화요리입니다.\r\n", "짬뽕", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("간짜장의 칼로리는 약 800~1000kcal이며, 평균 가격은 약 7,000원입니다. 간짜장은 짜장 소스를 따로 볶아 면에 곁들여 먹는 한국식 중국 요리입니다.\r\n", "간짜장", MessageBoxButtons.OK);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("쟁반짜장의 칼로리는 약 900~1100kcal이며, 평균 가격은 약 10,000원입니다. 쟁반짜장은 넓은 쟁반에 짜장 소스와 다양한 채소, 고기를 넣어 볶아낸 한국식 중화요리입니다.\r\n\r\n", "쟁반짜장", MessageBoxButtons.OK);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("차돌짬뽕의 칼로리는 약 800~1000kcal이며, 평균 가격은 약 10,000원입니다. 차돌짬뽕은 매콤한 국물에 차돌박이와 다양한 해산물, 채소, 면을 넣어 끓인 한국식 중화요리입니다.", "차돌짬뽕", MessageBoxButtons.OK);
        }
    }
}
