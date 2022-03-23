using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter4
{
    public partial class Form5 : Form
    {
        Timer t = new Timer();

        public Form5()
        {
            InitializeComponent();

            myPlayer.uiMode = "full";
            myPlayer.stretchToFit = true;

            t.Interval = 1000;
            t.Tick += Handler_tTick;
            t.Start();
        }

        private void Handler_tTick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void Handler_selectFileClick(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                myPlayer.URL = dialog.FileName;
            }
        }

        private void Handler_Button1Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                FileName = "Select a text file",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text file"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = dialog.FileName;
                    using (var fs = File.Open(filePath, FileMode.Open))
                    {
                        Process.Start("notepad.exe", filePath);
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error \n Error message: {ex.Message}");
                    throw;
                }
            }
        }

        private void Handler_끝내기toolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }

        private void Handler_폰트toolStripMenuItemClick(object sender, EventArgs e)
        {
            var fontDialog = new FontDialog
            {
                ShowColor = true,
                ShowEffects = true,
                Font = label1.Font,
                Color = label1.ForeColor
            };

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fontDialog.Font;
                label1.ForeColor = fontDialog.Color;
            }
        }

        private void Handler_배경색toolStripMenuItem4Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog.Color;
            }
        }

        //private void Handler_form5Resize(object sender, EventArgs e)
        //{
        //    selectFileButton.Location = new Point(
        //        ClientSize.Width - selectFileButton.Size.Width - 5, 
        //        ClientSize.Height - selectFileButton.Size.Height - 5);
        //}
    }
}
