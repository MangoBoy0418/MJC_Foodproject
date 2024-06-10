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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //버튼을 누루면 다음 폼으로
        {   
            this.Visible = false; //폼창에 속성을 보이지 않게 바꿈
            form2 newform2 = new form2(); //폼2 생성 
            newform2.ShowDialog(); //폼2 보여주기
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form3 newform3 = new form3();
            newform3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form4 newform4 = new form4();
            newform4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form5 newform5 = new form5();
            newform5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form14 newform14 = new Form14();
            this.Visible = false;
            newform14.ShowDialog();
            
        }
    }
}
