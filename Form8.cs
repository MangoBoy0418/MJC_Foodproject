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
    public partial class Form8 : Form
    {
        public Form8()
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
            MessageBox.Show("일본의 전통적인 면 요리인 우동은 한 그릇의 칼로리가 약 300~500kcal이며, 평균 가격은 7,000원에서 10,000원입니다.", "우동", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("고기 육수 기반의 국물에 면과 다양한 재료를 넣어 만든 일본의 인기 있는 면 요리인 라멘은 한 그릇의 칼로리가 약 700~1000kcal이며, 평균 가격은 8,000원에서 12,000원입니다.", "라멘", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("메밀가루로 만든 면을 차가운 물에 담가 먹는 일본의 전통적인 면 요리인 메밀소바는 칼로리가 낮고, 평균 가격은 6,000원에서 8,000원입니다.", "메밀소바", MessageBoxButtons.OK);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("소바 면을 닭고기, 채소, 계란 등과 함께 볶아 만든 일본의 대표적인 길거리 음식인 야키소바는 한 그릇의 칼로리가 약 500~700kcal이며, 평균 가격은 5,000원에서 8,000원입니다.", "야키소바", MessageBoxButtons.OK);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("일본의 전통적인 면 요리인 마제소바는 미소 소스로 맛을 낸 소바 면을 뜨거운 물에 넣어 먹는데, 한 그릇의 칼로리는 약 300~400kcal이고, 평균 가격은 6,000원에서 9,000원입니다.", "마제소바", MessageBoxButtons.OK);
        }
    }
}
