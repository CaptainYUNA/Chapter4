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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Handler_Form3Load(object sender, EventArgs e)
        {
            var timer2 = new Timer();
            timer2.Interval = 100;
            timer2.Tick += Handler_Timer2Tick;

            trackBar1.Minimum = 0;
            trackBar1.Maximum = 100;
            trackBar1.Value = 0;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            timer1.Interval = 1000; //1초
            timer1.Tick += Handler_Timer1Tick;
            timer1.Start();

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            var JITRoot = new TreeNode("JIT Solution");

            var CEO = new TreeNode("대표이사");
            var departmentHead = new TreeNode("부장");
            var researcher = new TreeNode("연구원");
            var @operator = new TreeNode("항법 운영");
            var cutie = new TreeNode("cutie");

            CEO.Nodes.Add("장석래");

            departmentHead.Nodes.Add("박성철");
            departmentHead.Nodes.Add("황승희");

            researcher.Nodes.Add("송영재");
            researcher.Nodes.Add("김바울");
            researcher.Nodes.Add("최윤아");

            cutie.Nodes.Add("우주");
            cutie.Nodes.Add("여름");
            cutie.Nodes.Add("순덕");
            cutie.Nodes.Add("사월");
            cutie.Nodes.Add("골골");
            cutie.Nodes.Add("회색");

            JITRoot.Nodes.Add(CEO);
            JITRoot.Nodes.Add(departmentHead);
            JITRoot.Nodes.Add(researcher);
            JITRoot.Nodes.Add(@operator);
            JITRoot.Nodes.Add(cutie);

            treeView1.Nodes.Add(JITRoot);
            treeView1.ExpandAll();
        }

        private void Handler_TreeView1AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "우주")
            {
                pictureBox1.Image = Image.FromFile("../../Images/1.jpg");
                textBox1.Text = "귀여워";
            }
            else if (e.Node.Text == "순덕")
            {
                pictureBox1.Image = Image.FromFile("../../Images/2.jpg");
                textBox1.Text = "겸댕이";
            }
        }

        private void Handler_Timer1Tick(object sender, EventArgs e)
        {
            timeLabel.Location = new Point(6, 20);
            timeLabel.Font = new Font("맑은 고딕", 10, FontStyle.Bold);
            timeLabel.Text = DateTime.Now.ToString();
        }

        private void Handler_StartButtonClick(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void Handler_Timer2Tick(object sender, EventArgs e)
        {
            if (trackBar1.Value < 100)
            {
                trackBar1.Value++;
                progressBar1.Value++;

                trackLabel.Text = trackBar1.Value.ToString();
                progressLabel.Text = progressBar1.Value.ToString();
            }
            else
            {
                timer2.Stop();
            }
        }

        private void Handler_StopButtonClick(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void Handler_DateTimePicker1ValueChanged(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            var selectedDay = dateTimePicker1.Value;

            timeSpanText.Text = today.Subtract(selectedDay).TotalDays.ToString("0");
        }
    }
}
