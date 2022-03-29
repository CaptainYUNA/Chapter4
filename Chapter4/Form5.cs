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
    enum DrawMode { LINE, RECTANGLE, CIRCLE, CURVED_LINE };

    public partial class Form5 : Form
    {
        Timer t = new Timer();

        private DrawMode _drawMode;
        private Graphics _g;
        private Pen pen = new Pen(Color.Black, 2);
        private Pen eraser;
        Point startP;
        Point endP;
        Point currentP;
        Point previousP;

        public Form5()
        {
            InitializeComponent();

            myPlayer.uiMode = "full";
            myPlayer.stretchToFit = true;

            t.Interval = 1000;
            t.Tick += Handler_tTick;
            t.Start();

            _g = CreateGraphics();
            currentModeLabel.Text = "None";
            BackColor = Color.White;
            eraser = new Pen(BackColor, 2);
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

        private void Handler_ToolStripLabel1Click(object sender, EventArgs e)
        {
            _drawMode = DrawMode.LINE;
            currentModeLabel.Text = "Line Mode";
        }

        private void Handler_ToolStripLabel2Click(object sender, EventArgs e)
        {
            _drawMode = DrawMode.RECTANGLE;
            currentModeLabel.Text = "Rectangle Mode";
        }

        private void Handler_ToolStripLabel3Click(object sender, EventArgs e)
        {
            _drawMode = DrawMode.CIRCLE;
            currentModeLabel.Text = "Circle Mode";
        }

        private void Handler_ToolStripLabel4Click(object sender, EventArgs e)
        {
            _drawMode = DrawMode.CURVED_LINE;
            currentModeLabel.Text = "Curved_Line Mode";
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog.Color;
            }
        }

        private void Handler_Form5MouseDown(object sender, MouseEventArgs e)
        {
            startP = new Point(e.X, e.Y);
            previousP = startP;
            currentP = startP;
        }

        private void Handler_Form5MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            previousP = currentP;
            currentP = new Point(e.X, e.Y);

            switch (_drawMode)
            {
                case DrawMode.LINE:
                    _g.DrawLine(eraser, startP, previousP);
                    _g.DrawLine(pen, startP, currentP);
                    break;

                case DrawMode.RECTANGLE:
                    _g.DrawRectangle(eraser, new Rectangle(startP, new Size(previousP.X - startP.X, previousP.Y - startP.Y)));
                    _g.DrawRectangle(pen, new Rectangle(startP, new Size(currentP.X - startP.X, currentP.Y - startP.Y)));
                    break;

                case DrawMode.CIRCLE:
                    _g.DrawEllipse(eraser, new Rectangle(startP, new Size(previousP.X - startP.X, previousP.Y - startP.Y)));
                    _g.DrawEllipse(pen, new Rectangle(startP, new Size(currentP.X - startP.X, currentP.Y - startP.Y)));
                    break;

                case DrawMode.CURVED_LINE:
                    _g.DrawLine(pen, previousP, currentP);
                    break;
            }
        }

        private void Handler_Form5MouseUp(object sender, MouseEventArgs e)
        {
            endP = new Point(e.X, e.Y);

            switch (_drawMode)
            {
                case DrawMode.LINE:
                    _g.DrawLine(pen, startP, endP);
                    break;

                case DrawMode.RECTANGLE:
                    _g.DrawRectangle(pen, new Rectangle(startP, new Size(endP.X - startP.X, endP.Y - startP.Y)));
                    break;

                case DrawMode.CIRCLE:
                    _g.DrawEllipse(pen, new Rectangle(startP, new Size(endP.X - startP.X, endP.Y - startP.Y)));
                    break;

                case DrawMode.CURVED_LINE:
                    break;

                default:
                    break;
            }
        }
    }
}
