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
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            var JITRoot = new TreeNode("JIT Solution");

            var CEO = new TreeNode("대표이사");
            var departmentHead = new TreeNode("부장");
            var researcher = new TreeNode("연구원");
            var @operator = new TreeNode("항법 운영");

            CEO.Nodes.Add("장석래");

            departmentHead.Nodes.Add("박성철");
            departmentHead.Nodes.Add("황승희");

            researcher.Nodes.Add("송영재");
            researcher.Nodes.Add("김바울");
            researcher.Nodes.Add("최윤아");

            JITRoot.Nodes.Add(CEO);
            JITRoot.Nodes.Add(departmentHead);
            JITRoot.Nodes.Add(researcher);
            JITRoot.Nodes.Add(@operator);

            treeView1.Nodes.Add(JITRoot);
            treeView1.ExpandAll();
        }
    }
}
