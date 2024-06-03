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
    public partial class Form9 : Form
    {
        public Form9()
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
            MessageBox.Show("계란볶음밥의 칼로리는 약 500~700kcal이며, 평균 가격은 약 6,000원입니다. 계란볶음밥은 밥을 계란과 함께 볶아 간장이나 소금으로 간을 맞춘 간단하고 맛있는 요리입니다.", "계란볶음밥", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("짜장밥의 칼로리는 약 600~800kcal이며, 평균 가격은 약 6,000원 정도입니다. 짜장밥은 짜장소스를 곁들인 밥 요리로, 간단하면서도 풍부한 맛을 즐길 수 있는 중국식 요리입니다.", "짜장밥", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("마파두부의 칼로리는 약 300~500kcal이며, 평균 가격은 약 8,000원 정도입니다. 마파두부는 중국의 유명한 볶음 요리로, 두부를 매운 양념과 함께 볶아내어 고소하고 매콤한 맛이 일품입니다.", "마파두부", MessageBoxButtons.OK);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("짬뽕밥은 고칼로리이며, 평균적으로 800-1000 칼로리 정도이며, 한 그릇에 약 8000-10000원 정도의 평균가격이다. 짜고 매운 맛이 특징인 중국 요리의 한 종류로, 해물과 채소가 풍부하게 들어가 맛과 영양이 풍부하다고 할 수 있어요.", "짬봉밥", MessageBoxButtons.OK);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("잡탕밥의 칼로리는 약 700~900kcal이며, 평균 가격은 약 8,000원 정도입니다. 잡탕밥은 다양한 고기와 채소를 넣어 볶은 중화요리로, 푸짐한 양과 다채로운 맛이 특징입", "잡탕밥", MessageBoxButtons.OK);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("새우볶음밥의 칼로리는 약 600~800kcal이며, 평균 가격은 약 8,000원 정도입니다. 새우볶음밥은 새우와 채소를 넣어 볶은 볶음밥으로, 고소한 맛과 식감이 일품인 중화요리입니다.", "새우볶음밥", MessageBoxButtons.OK);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("잡채밥의 칼로리는 약 600~800kcal이며, 평균 가격은 약 8,000원 정도입니다. 잡채밥은 당면과 채소, 고기를 함께 볶아 만든 중화요리로, 달콤하고 고소한 맛이 특징입니다.", "잡채밥", MessageBoxButtons.OK);
        }
    }
}
