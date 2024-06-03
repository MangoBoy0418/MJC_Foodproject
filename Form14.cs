using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MJC_Foodproject
{
    public partial class Form14 : Form
    {
        private string[] imgPath = new string[]
        {@"C:\Users\USER\Desktop\음식\한식\밥\국밥1.jpg",
         @"C:\Users\USER\Desktop\음식\한식\밥\제육.jpg",
         @"C:\Users\USER\Desktop\음식\한식\밥\순두부찌개.jpg",
         @"C:\Users\USER\Desktop\음식\한식\밥\부대찌개.jpg",
         @"C:\Users\USER\Desktop\음식\한식\밥\불고기.jpg",
         @"C:\Users\USER\Desktop\음식\한식\밥\뼈해장국.jpg",
         @"C:\Users\USER\Desktop\음식\한식\밥\돌솓비빔밥.jpg",
         @"C:\Users\USER\Desktop\음식\한식\면\콩국수.jpg",
         @"C:\Users\USER\Desktop\음식\한식\면\라면.jpg",
         @"C:\Users\USER\Desktop\음식\한식\면\비빔국수.jpg",
         @"C:\Users\USER\Desktop\음식\한식\면\잔치국수.jpg",
         @"C:\Users\USER\Desktop\음식\한식\면\불냉면.jpg",
         @"C:\Users\USER\Desktop\음식\한식\면\칼국수.jpg",
         @"C:\Users\USER\Desktop\음식\한식\면\막국수.jpg",
         //한식 끝














        };//이미지 넣는 경로
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            string[] kr = { "국밥", "제육", "순두부찌개", "부재찌개", "불고기", "뼈해장국", "돌솥 비빔밥",
                                "콩국수","라면", "비빔국수", "잔치국", "냉면", "칼국수", "막국수" };
            string[] jp = { "돈가스", "장어덮밥", "초밥", "카레라이스", "규동", "가츠동", "연어덮밥", "우동", "라멘", "메밀소바", "야키소바",
                            "마제소바" };

            string[] ch = { "계란볶음밥", "짜장밥", "마파두부", "짬봉밥", "잡탕밥", "차오판", "잡채밥" , "짜장면", "짬뽕", "간짜장", "쟁반짜장",
                            "차돌짬뽕" };

            string[] am = { "샌드위치", "햄버거", "피자", "토스트", "빵" , "스테이크", "버팔로윙", "치킨", "케밥", "라자냐", "햄버거",
                            "토마토", "스파게티", "크림", "스파게티", "로제" , "파스타", "알리오 올리오", "먹물 파스타", "해물 스파게티"};

            Random random = new Random();
            int a = random.Next(0, 4); //0<=x<4

            if (a == 0)
            {
                Random randoms = new Random();
                int b = randoms.Next(0, 15);
                label1.Text = kr[b];
                pictureBox1.Image = Image.FromFile(imgPath[b]);
            }

            else if (a == 1)
            {
                Random randoms = new Random();
                int b = randoms.Next(0, 3);
                label1.Text = jp[b];
            }

            else if (a == 2)
            {
                Random randoms = new Random();
                int b = randoms.Next(0, 3);
                label1.Text = ch[b];
            }

            else
            {
                Random randoms = new Random();
                int b = randoms.Next(0, 2);
                label1.Text = am[b];
            }
        }
    }
}
