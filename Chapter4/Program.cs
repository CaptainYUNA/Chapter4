using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Chapter4
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Chapter 137 ~ 139
            //Application.Run(new Form1());

            //Chapter 140 ~ 144
            //Application.Run(new Form2());

            //Chapter 146 ~ 150
            Application.Run(new Form3());

            //CreateMyForm();
        }


        private static void CreateMyForm()
        {
            var form1 = new Form();

            var button1 = new Button();
            var button2 = new Button();

            button1.Text = "Click!";
            button1.Location = new Point(10, 10);
            button2.Text = "Cancel";
            button2.Location = new Point(button1.Left, button1.Height + button1.Top + 10);

            form1.Text = "My Dialog Box";

            button1.Click += _Handler_Button1Click;

            form1.FormBorderStyle = FormBorderStyle.FixedDialog;
            form1.StartPosition = FormStartPosition.CenterScreen;

            form1.Controls.Add(button1);
            form1.Controls.Add(button2);

            form1.ShowDialog();
        }

        private static void _Handler_Button1Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello! Windows Forms Application!");
        }
    }
}
