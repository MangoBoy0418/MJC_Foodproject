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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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
            MessageBox.Show("국밥은 고기와 채소를 넣은 국에 밥을 말아 먹는 한국의 전통 음식으로, 한 그릇의 칼로리는 약 400~600kcal이며, 평균 가격은 7,000원에서 10,000원입니다.", "국밥", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("제육볶음은 돼지고기와 채소를 고추장 양념으로 볶아 만든 한국 요리로, 한 접시의 칼로리는 약 600~800kcal이며, 평균 가격은 8,000원에서 12,000원입니다.", "제육", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("순두부찌개는 부드러운 두부와 해산물 또는 고기를 매운 양념에 끓여 만든 한국 전통 찌개로, 한 그릇의 칼로리는 약 400~600kcal이며, 평균 가격은 7,000원에서 10,000원입니다.", "순두부찌개", MessageBoxButtons.OK);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("부대찌개는 햄, 소시지, 두부, 라면, 채소 등을 고추장 국물에 끓여 먹는 한국의 퓨전 찌개 요리로, 한 그릇의 칼로리는 약 600~800kcal이며, 평균 가격은 8,000원에서 12,000원입니다.", "부대찌개", MessageBoxButtons.OK);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("불고기는 얇게 썬 쇠고기를 간장 양념에 재워 구워 먹는 한국 전통 요리로, 한 접시의 칼로리는 약 400~600kcal이며, 평균 가격은 12,000원에서 20,000원입니다.", "불고기", MessageBoxButtons.OK);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("뼈해장국은 돼지 뼈와 우거지, 콩나물 등을 고추장 국물에 끓여 먹는 한국 전통 해장국으로, 한 그릇의 칼로리는 약 500~700kcal이며, 평균 가격은 7,000원에서 10,000원입니다.", "뼈해장국", MessageBoxButtons.OK);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("돌솥 비빔밥은 돌솥에 밥과 다양한 재료를 넣고 고추장으로 비벼 먹는 한국의 전통 음식으로, 한 그릇의 칼로리는 약 600~800kcal이며, 평균 가격은 8,000원에서 12,000원입니다.", "돌솥비빔밥", MessageBoxButtons.OK);
        }
    }
}
