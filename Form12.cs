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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

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
            MessageBox.Show("고기를 구워서 소스와 함께 먹는 스테이크는 한 조각의 칼로리가 고기 종류와 크기에 따라 다양하며, 평균 가격은 20,000원에서 50,000원입니다.", "스테이크", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("매운 소스로 튀긴 닭 날개인 버팔로윙은 6조각의 칼로리가 약 400~600kcal이며, 평균 가격은 10,000원에서 15,000원입니다.\r\n", "버팔로윙", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("닭의 다양한 부위와 소스로 맛을 낸 치킨은 칼로리와 가격이 다양하며, 대체로 100g 기준으로 약 200~400kcal이고, 평균 가격은 15,000원에서 25,000원입니다.", "치킨", MessageBoxButtons.OK);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("고기나 채소를 꼬치에 꿴 후 구워 먹는 중동의 대표적인 음식인 케밥은 다양한 종류와 소스로 즐길 수 있으며, 칼로리는 약 500~800kcal이고, 평균 가격은 8,000원에서 15,000원입니다.", "케밥", MessageBoxButtons.OK);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("파스타 시트에 소스와 치즈를 발라 구워 만든 이탈리아의 대표적인 요리인 라자냐는 한 조각의 칼로리가 약 300~500kcal이며, 평균 가격은 15,000원에서 25,000원입니다.", "라자냐", MessageBoxButtons.OK);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("다양한 재료를 넣어 만든 햄버거는 한 개의 칼로리와 가격이 다양하며, 평균 가격은 4,000원에서 10,000원 사이입니다.", "햄버거", MessageBoxButtons.OK);
        }
    }
}
