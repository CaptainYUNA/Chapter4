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
        public Form1()
        {
            InitializeComponent();

            ClientSize = new Size(500, 500);

            Form2 form2 = new Form2();
            AddOwnedForm(form2);

            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Simply Message Box");
            //MessageBox.Show("Set Title", "Title Message");
            //MessageBox.Show("Exclamation Message Box", "느낌표와 알람 소리", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //var result1 = MessageBox.Show("두 개의 버튼을 갖는 메시지 박스", "Question", MessageBoxButtons.YesNo);
            //var result2 = MessageBox.Show("세 개의 버튼과 물음표 아이콘을 보여 주는 메시지 박스", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //var result3 = MessageBox.Show("디폴트 버튼을 두 번째 버튼으로 \n 지정한 메시지 박스", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            //var message = string.Format($"선택: {result1}, {result2}, {result3}");

            //MessageBox.Show(message, "Your Selections");

        }
    }
}
