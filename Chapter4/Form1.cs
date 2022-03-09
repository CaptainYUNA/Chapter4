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
        private RadioButton checkedRB;

        public Form1()
        {
            InitializeComponent();

            ClientSize = new Size(500, 500);

            Form2 form2 = new Form2();
            AddOwnedForm(form2);

            form2.Show();
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

            if (checkedRB == rbFemale)
            {
                result += "여성";
            }
            else if (checkedRB == rbMale)
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
            checkedRB = rbFemale;
        }

        private void Handler_rbMaleCheckedChanged(object sender, EventArgs e)
        {
            checkedRB = rbMale;
        }
    }
}
