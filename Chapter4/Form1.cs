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
    public partial class Form1 : Form
    {
        //private bool flag;
        private RadioButton _checkedRB;

        private const int SCROLL_MAX_VALUE = 255;

        public Form1()
        {
            InitializeComponent();

            //ClientSize = new Size(500, 500);

            //Form2 form2 = new Form2();
            //AddOwnedForm(form2);

            //form2.Show();

            BackColor = Color.LightSteelBlue;
            colorPanel.BackColor = Color.FromArgb(0, 0, 0);
            redBar.LargeChange = 1;
            greenBar.LargeChange = 1;
            blueBar.LargeChange = 1;

            redBar.Maximum = SCROLL_MAX_VALUE;
            greenBar.Maximum = SCROLL_MAX_VALUE;
            blueBar.Maximum = SCROLL_MAX_VALUE;
        }

        private void Handler_button1Click(object sender, EventArgs e)
        {
            //if (flag)
            //{
            //    label1.Text = "";
            //    flag = false;
            //}
            //else
            //{
            //    label1.Text = "Hello World!";
            //    flag = true;
            //}

            var checkStates = "";
            CheckBox[] checkBox = { checkBox1, checkBox2, checkBox3, checkBox4 };

            foreach (var item in checkBox)
            {
                checkStates += string.Format("{0} : {1}\n", item.Text, item.Checked);
            }

            MessageBox.Show(checkStates, "Check States");

            var summary = "우주는? ";

            foreach (var item in checkBox)
            {
                if (item.Checked)
                {
                    summary += item.Text + " ";
                }
            }

            MessageBox.Show(summary, "Summary");
        }

        private void Handler_Butten2Click(object sender, EventArgs e)
        {
            var result = "";

            if (rbKR.Checked)
            {
                result += "국적: 대한민국\n";
            }

            if (_checkedRB == rbFemale)
            {
                result += "여성";
            }
            else if (_checkedRB == rbMale)
            {
                result += "남성";
            }
            else
            {
                result += "그 외";
            }

            MessageBox.Show(result, "Result: ");
        }

        private void Handler_rbFemaleCheckedChanged(object sender, EventArgs e)
        {
            _checkedRB = rbFemale;
        }

        private void Handler_rbMaleCheckedChanged(object sender, EventArgs e)
        {
            _checkedRB = rbMale;
        }

        private void Handler_CalculateButtonClick(object sender, EventArgs e)
        {
            var kor = Convert.ToDouble(korValue.Text);
            var math = Convert.ToDouble(mathValue.Text);
            var eng = Convert.ToDouble(engValue.Text);

            var sum = kor + math + eng;
            var avg = sum / 3;

            sumValue.Text = sum.ToString();
            avgValue.Text = avg.ToString("0.0");
        }

        private void Handler_TextChanged(object sender, EventArgs e)
        {
            if (!IsValueEmpty())
            {
                redBar.Value = int.Parse(redValue.Text);
                greenBar.Value = int.Parse(greenValue.Text);
                blueBar.Value = int.Parse(blueValue.Text);
                colorPanel.BackColor = Color.FromArgb(redBar.Value, greenBar.Value, blueBar.Value);
            }
        }

        private bool IsValueEmpty() => string.IsNullOrEmpty(redValue.Text) && string.IsNullOrEmpty(greenValue.Text) && string.IsNullOrEmpty(blueValue.Text);


        private void Handler_ChangedScroll(object sender, ScrollEventArgs e)
        {
            redValue.Text = redBar.Value.ToString();
            greenValue.Text = greenBar.Value.ToString();
            blueValue.Text = blueBar.Value.ToString();

            colorPanel.BackColor = Color.FromArgb(redBar.Value, greenBar.Value, blueBar.Value);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            redValue.Text = trackBar1.Value.ToString();
        }
    }
}
