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
    public partial class Form6 : Form
    {
        public Form6()
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
            MessageBox.Show("콩국수는 콩가루로 만든 면을 시원한 육수에 담고 채소와 함께 먹는 한국의 전통적인 면 요리로, 한 그릇의 칼로리는 약 300~400kcal이며, 평균 가격은 7,000원에서 10,000원입니다.", "콩국수", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("라면은 간편하게 끓인 물에 면과 스프를 넣어 먹는 한국의 대표적인 인스턴트 면 요리로, 한 그릇의 칼로리는 약 350~500kcal이며, 평균 가격은 1,000원에서 2,000원입니다.", "라면", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("비빔국수는 면을 삶아 찬물에 헹구고, 다양한 야채와 고추장 또는 간장으로 비벼 먹는 한국의 전통 면요리로, 한 그릇의 칼로리는 약 400~600kcal이며, 평균 가격은 7,000원에서 10,000원입니다.", "비빔국수", MessageBoxButtons.OK);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("잔치국수는 가는 면과 다양한 채소를 시원한 육수에 넣어 먹는 한국의 전통적인 면요리로, 한 그릇의 칼로리는 약 400~600kcal이며, 평균 가격은 7,000원에서 10,000원입니다.", "잔치 국수", MessageBoxButtons.OK);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("냉면은 시원한 육수에 삶은 면과 양념장을 함께 차갑게 먹는 한국의 전통 여름 음식으로, 한 그릇의 칼로리는 약 300~500kcal이며, 평균 가격은 8,000원에서 12,000원입니다.", "냉면", MessageBoxButtons.OK);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("얇고 넓은 면을 국물과 함께 끓여 만든 한국의 전통적인 면요리로, 한 그릇의 칼로리는 약 300~400kcal이며, 평균 가격은 7,000원에서 10,000원입니다.", "칼국수", MessageBoxButtons.OK);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("메밀,밀가루를 반죽하여 삶은 면을 냉수에 식혀 양념장과 함께 먹는 전통적인 한국의 면요리로, 한 그릇의 칼로리는 약 300~400kcal이며, 평균 가격은 7,000원에서 10,000원입니다.", "막국수", MessageBoxButtons.OK);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
