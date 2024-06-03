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
    public partial class Form11 : Form
    {
        public Form11()
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
            MessageBox.Show("다양한 재료를 식빵으로 싸서 만든 샌드위치는 한 개의 칼로리가 재료와 크기에 따라 다양하며, 평균 가격은 5,000원에서 10,000원입니다.", "샌드위치", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("다양한 재료를 넣어 만든 햄버거는 한 개의 칼로리와 가격이 다양하며, 평균 가격은 4,000원에서 10,000원 사이입니다.", "햄버거", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("다양한 토핑과 크기로 구성된 피자는 한 판의 칼로리와 가격이 다양하며, 평균 가격은 15,000원에서 30,000원 사이입니다.", "피자", MessageBoxButtons.OK);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("식빵을 구워 견과류, 잼, 버터 등과 함께 먹는 간편한 아침 식사인 토스트는 한 조각의 칼로리가 약 100~200kcal이며, 평균 가격은 2,000원에서 5,000원입니다.", "토스트", MessageBoxButtons.OK);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("빵은 다양한 종류와 크기가 있어 칼로리와 가격이 다양합니다. 보통 식빵 한 조각의 칼로리는 약 70~100kcal 정도이며, 평균 가격은 1,000원에서 5,000원 사이입니다. 종류에 따라 다르니 성분표를 참고하는 게 좋아요.", "빵", MessageBoxButtons.OK);
        }
    }
}
