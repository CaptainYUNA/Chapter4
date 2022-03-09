using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ClientSize = new Size(800, 800);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("이름을 입력하시오,", "Warning");
            }
            else
            {
                label2.Text = textBox1.Text + "님! 안녕하세요!";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var raffaello = "라파엘로 산치오, 이탈리아, 르네상스 3대 거장, 1483~1520";
            var schoolOfAthenes = @"라파엘로(Raphael, Raffaello Sanzio da Urbino)는
동시대의 대가인 미켈란젤로, 레오나르도 다빈치와 함께 르네상스 3대 거장으로 알려져 있습니다.
가장 유명한 작품은 <아테네학당(The School of Athens)>로
바티칸 궁(Apostolic Palace)에 있는 프레스코 벽화입니다.";

            label1.Text = raffaello;
            label3.Text = schoolOfAthenes;
        }
    }
}
