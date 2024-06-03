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
    public partial class Form7 : Form
    {
        public Form7()
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
            MessageBox.Show("돼지고기를 빵가루와 달걀을 입혀 튀겨 만든 일본식 가정 요리인 돈가스는 한 조각의 칼로리가 약 300~400kcal이며, 평균 가격은 8,000원에서 12,000원입니다.", "돈가스", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("장어를 구워 양념에 비벼 먹는 일본의 전통 음식인 장어덮밥은 한 그릇의 칼로리가 약 600~800kcal이며, 평균 가격은 15,000원에서 20,000원입니다.", "장어덮밥", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("신선한 회초밥을 다양한 종류와 함께 일본식 소스와 함께 즐기는 초밥은 한 조각의 칼로리가 약 40~80kcal이며, 평균 가격은 2,000원에서 5,000원입니다.", "초밥", MessageBoxButtons.OK);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("카레 소스를 밥 위에 올려 고기나 채소와 함께 먹는 일본의 전통 요리인 카레라이스는 한 그릇의 칼로리가 약 600~800kcal이며, 평균 가격은 7,000원에서 10,000원입니다.", "카레라이스", MessageBoxButtons.OK);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("소고기를 간장 기반의 양념으로 볶아 고기 위에 밥을 얹은 일본의 전통 음식인 규동은 한 그릇의 칼로리가 약 600~800kcal이며, 평균 가격은 8,000원에서 12,000원입니다.", "규동", MessageBoxButtons.OK);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("돼지고기 혹은 소고기를 빵가루와 달걀을 입혀 튀겨 고기 위에 밥을 얹은 일본의 전통 음식인 가츠동은 한 그릇의 칼로리가 약 800~1000kcal이며, 평균 가격은 8,000원에서 12,000원입니다.", "가츠동", MessageBoxButtons.OK);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("신선한 연어를 간장과 설탕으로 양념하여 밥 위에 올려 먹는 일본의 전통 음식인 연어덮밥은 한 그릇의 칼로리가 약 600~800kcal이며, 평균 가격은 15,000원에서 20,000원입니다.", "연어덮밥", MessageBoxButtons.OK);
        }
    }
}
