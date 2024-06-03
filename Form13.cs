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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("신선한 토마토와 향신료로 만든 토마토 스파게티는 한 그릇의 칼로리가 약 500~700kcal이며, 평균 가격은 10,000원에서 20,000원 사이이다.", "토마토 스파게티", MessageBoxButtons.OK);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            main main = new main();
            this.Visible = false;
            main.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("부드러운 크림 소스로 만든 파스타 요리인 크림 스파게티는 한 그릇의 칼로리가 약 700~1000kcal이며, 평균 가격은 12,000원에서 20,000원입니다.", "크림 스파게티", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("크림 소스와 토마토 소스를 혼합하여 만든 파스타 요리인 로제 파스타는 한 그릇의 칼로리가 약 600~900kcal이며, 평균 가격은 12,000원에서 20,000원입니다.", "로제 파스타", MessageBoxButtons.OK);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("올리브 오일과 마늘, 페페론치노로 맛을 낸 간단한 이탈리아 전통 파스타 요리인 알리오 올리오는 한 그릇의 칼로리가 약 400~600kcal이며, 평균 가격은 10,000원에서 15,000원입니다.", "알리오 올리오", MessageBoxButtons.OK);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("오징어 먹물 소스를 사용한 이탈리아의 독특한 파스타 요리인 먹물 파스타는 한 그릇의 칼로리가 약 500~700kcal이며, 평균 가격은 15,000원에서 25,000원입니다.", "먹물 파스타", MessageBoxButtons.OK);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("신선한 해산물과 토마토 또는 크림 소스로 만든 해물 스파게티는 한 그릇의 칼로리가 약 600~800kcal이며, 평균 가격은 15,000원에서 25,000원입니다.", "해물 스파게티", MessageBoxButtons.OK);
        }
    }
}
