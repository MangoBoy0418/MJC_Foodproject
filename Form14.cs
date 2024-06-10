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
        private (Bitmap Image, string Text)[] resources; //리소스의 배열을 생성
        public Form14()
        {
            InitializeComponent();
            this.Controls.Add(pictureBox1); //도구상자에서 pictureBox를 추가
            this.Controls.Add(label1);  //도구상자에서 label1을 추가
            LoadResources();            //리소스를 로드하는 역할
            ShowRandomResource();       //로드된 리소스들 중 하나를 무작위로 선택하여 화면에 표시하는 역할

        }

        private void LoadResources()
        {
            resources = new (Bitmap, string)[]
            {
            (Properties.Resources.ganjjazang, Properties.Resources.간짜장), 
            (Properties.Resources.gookbob, Properties.Resources.국밥), 
            (Properties.Resources.kyudong, Properties.Resources.규동),
            (Properties.Resources.jabtangbob, Properties.Resources.잡탕밥),
            (Properties.Resources.hamberger, Properties.Resources.햄버거),
            (Properties.Resources.steak, Properties.Resources.스테이크),
            (Properties.Resources.bread, Properties.Resources.빵),
            (Properties.Resources.sandwich, Properties.Resources.샌드위치),
            (Properties.Resources.isaac, Properties.Resources.토스트),
            (Properties.Resources.iceage, Properties.Resources.냉면),
            (Properties.Resources.knifenoodle, Properties.Resources.칼국수),
            (Properties.Resources.bibimnoodle, Properties.Resources.비빔국수),
            (Properties.Resources.bibimbob, Properties.Resources.돌솥비빔밥),
            (Properties.Resources.janchinoodle, Properties.Resources.잔치국수),
            (Properties.Resources.maknoodle, Properties.Resources.막국수),
            (Properties.Resources.jaeyook, Properties.Resources.제육볶음),
            (Properties.Resources.bulgogi, Properties.Resources.불고기),
            (Properties.Resources.bonehangover, Properties.Resources.뼈해장국),
            (Properties.Resources.armysoup, Properties.Resources.부대찌개),
            (Properties.Resources.donkatsu, Properties.Resources.돈까스),
            (Properties.Resources.katsudon, Properties.Resources.가츠동),
            (Properties.Resources.eelrice, Properties.Resources.장어덮밥),
            (Properties.Resources.creampasta, Properties.Resources.크림파스타),
            (Properties.Resources.tomatoe, Properties.Resources.토마토스파게티),
            (Properties.Resources.pizza, Properties.Resources.피자),
            (Properties.Resources.ramen, Properties.Resources.라멘),
            (Properties.Resources.ramyun, Properties.Resources.라면),
            (Properties.Resources.lasagna, Properties.Resources.라자냐),
            (Properties.Resources.rosepasta, Properties.Resources.로제파스타),
            (Properties.Resources.seafoodpasta, Properties.Resources.해물파스타),
            (Properties.Resources.majesoba, Properties.Resources.마제소바),
            (Properties.Resources.mapatofu, Properties.Resources.마파두부),
            (Properties.Resources.inkpasta, Properties.Resources.먹물파스타),
            (Properties.Resources.soba, Properties.Resources.메밀소바),
            (Properties.Resources.buffalowings, Properties.Resources.버팔로윙),
            (Properties.Resources.friedrice, Properties.Resources.계란볶음밥),
            (Properties.Resources.sakedon, Properties.Resources.연어덮밥),
            (Properties.Resources.shrimpfriedrice, Properties.Resources.새우볶음밥),
            (Properties.Resources.softtofu, Properties.Resources.순두부찌개),
            (Properties.Resources.aliooilo, Properties.Resources.알리오_올리오),
            (Properties.Resources.yakisoba, Properties.Resources.야키소바),
            (Properties.Resources.udon, Properties.Resources.우동),
            (Properties.Resources.japchaebob, Properties.Resources.잡채밥),
            (Properties.Resources.jaengbanjjazang, Properties.Resources.쟁반짜장),
            (Properties.Resources.jjazang, Properties.Resources.짜장면),
            (Properties.Resources.jjazangbob, Properties.Resources.짜장밥),
            (Properties.Resources.jjambbong, Properties.Resources.짬뽕),
            (Properties.Resources.jjambbongbob, Properties.Resources.짬뽕밥),
            (Properties.Resources.meatjjambbong, Properties.Resources.차돌짬뽕),
            (Properties.Resources.sushi, Properties.Resources.초밥),
            (Properties.Resources.friedchicken, Properties.Resources.치킨),
            (Properties.Resources.curryrice, Properties.Resources.카레라이스),
            (Properties.Resources.kebob, Properties.Resources.케밥),
            (Properties.Resources.beannoodle, Properties.Resources.콩국수)
           
                // 추가한 리소스를 여기에 나열
            };
        }

        private void ShowRandomResource()  //사진들 중 무작위로 선택하여 화면에 표시
        {
            Random random = new Random(); //랜덤 클래스 생성
            int index = random.Next(resources.Length); //배열의 길이만큼의 정수 생성하고 랜덤 변수 생성
            pictureBox1.Image = resources[index].Image; //리소스 배열에 랜덤 변수를 넣어 나오는 이미지를 pictureBox1에 삽입
            label1.Text = resources[index].Text;        //리소스 배열에 랜덤 변수를 넣어 나오는 텍스트를 label1에 삽입
        }
        private void Form14_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e) //버튼 클릭시 종료
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e) //다음 폼으로 넘어가기
        {
            main main = new main();
            this.Visible = false;
            main.ShowDialog();
        }
    }
}
