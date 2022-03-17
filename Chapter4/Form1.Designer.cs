using System.Windows.Forms;

namespace Chapter4
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.rbKR = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbEct = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.engValue = new System.Windows.Forms.TextBox();
            this.mathValue = new System.Windows.Forms.TextBox();
            this.korValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.avgValue = new System.Windows.Forms.TextBox();
            this.sumValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.red = new System.Windows.Forms.Label();
            this.blue = new System.Windows.Forms.Label();
            this.green = new System.Windows.Forms.Label();
            this.redBar = new System.Windows.Forms.HScrollBar();
            this.greenBar = new System.Windows.Forms.HScrollBar();
            this.blueBar = new System.Windows.Forms.HScrollBar();
            this.redValue = new System.Windows.Forms.TextBox();
            this.greenValue = new System.Windows.Forms.TextBox();
            this.blueValue = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "인사하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Handler_button1Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(20, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "우주";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(20, 78);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(60, 16);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "귀여워";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(20, 109);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(72, 16);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "도도공주";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(20, 140);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(60, 16);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "겸댕이";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // rbKR
            // 
            this.rbKR.AutoSize = true;
            this.rbKR.Location = new System.Drawing.Point(6, 20);
            this.rbKR.Name = "rbKR";
            this.rbKR.Size = new System.Drawing.Size(48, 16);
            this.rbKR.TabIndex = 6;
            this.rbKR.TabStop = true;
            this.rbKR.Text = "KOR";
            this.rbKR.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(6, 13);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(47, 16);
            this.rbFemale.TabIndex = 7;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "여성";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.Handler_rbFemaleCheckedChanged);
            // 
            // rbEct
            // 
            this.rbEct.AutoSize = true;
            this.rbEct.Location = new System.Drawing.Point(6, 75);
            this.rbEct.Name = "rbEct";
            this.rbEct.Size = new System.Drawing.Size(51, 16);
            this.rbEct.TabIndex = 9;
            this.rbEct.TabStop = true;
            this.rbEct.Text = "그 외";
            this.rbEct.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(6, 45);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(47, 16);
            this.rbMale.TabIndex = 8;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "남성";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.Handler_rbMaleCheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Complete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Handler_Butten2Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbKR);
            this.groupBox1.Location = new System.Drawing.Point(216, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(75, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbMale);
            this.groupBox2.Controls.Add(this.rbFemale);
            this.groupBox2.Controls.Add(this.rbEct);
            this.groupBox2.Location = new System.Drawing.Point(297, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(75, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.engValue);
            this.groupBox3.Controls.Add(this.mathValue);
            this.groupBox3.Controls.Add(this.korValue);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(20, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 107);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "성적 입력";
            // 
            // engValue
            // 
            this.engValue.Location = new System.Drawing.Point(42, 75);
            this.engValue.Name = "engValue";
            this.engValue.Size = new System.Drawing.Size(100, 21);
            this.engValue.TabIndex = 5;
            // 
            // mathValue
            // 
            this.mathValue.Location = new System.Drawing.Point(42, 48);
            this.mathValue.Name = "mathValue";
            this.mathValue.Size = new System.Drawing.Size(100, 21);
            this.mathValue.TabIndex = 4;
            // 
            // korValue
            // 
            this.korValue.Location = new System.Drawing.Point(42, 18);
            this.korValue.Name = "korValue";
            this.korValue.Size = new System.Drawing.Size(100, 21);
            this.korValue.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "수학";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "영어";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "국어";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.calculateButton);
            this.groupBox4.Controls.Add(this.avgValue);
            this.groupBox4.Controls.Add(this.sumValue);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(194, 201);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(160, 107);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "결과";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(67, 75);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "계산";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.Handler_CalculateButtonClick);
            // 
            // avgValue
            // 
            this.avgValue.Location = new System.Drawing.Point(42, 48);
            this.avgValue.Name = "avgValue";
            this.avgValue.Size = new System.Drawing.Size(100, 21);
            this.avgValue.TabIndex = 4;
            // 
            // sumValue
            // 
            this.sumValue.Location = new System.Drawing.Point(42, 18);
            this.sumValue.Name = "sumValue";
            this.sumValue.Size = new System.Drawing.Size(100, 21);
            this.sumValue.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "평균";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "총점";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(217, 162);
            this.maskedTextBox1.Mask = "99999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 21);
            this.maskedTextBox1.TabIndex = 14;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // colorPanel
            // 
            this.colorPanel.Location = new System.Drawing.Point(20, 329);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(200, 100);
            this.colorPanel.TabIndex = 15;
            // 
            // red
            // 
            this.red.AutoSize = true;
            this.red.Location = new System.Drawing.Point(234, 329);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(27, 12);
            this.red.TabIndex = 15;
            this.red.Text = "Red";
            // 
            // blue
            // 
            this.blue.AutoSize = true;
            this.blue.Location = new System.Drawing.Point(234, 417);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(30, 12);
            this.blue.TabIndex = 16;
            this.blue.Text = "Blue";
            // 
            // green
            // 
            this.green.AutoSize = true;
            this.green.Location = new System.Drawing.Point(234, 372);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(39, 12);
            this.green.TabIndex = 17;
            this.green.Text = "Green";
            // 
            // redBar
            // 
            this.redBar.Location = new System.Drawing.Point(276, 329);
            this.redBar.Maximum = 255;
            this.redBar.Name = "redBar";
            this.redBar.Size = new System.Drawing.Size(161, 17);
            this.redBar.TabIndex = 18;
            this.redBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Handler_ChangedScroll);
            // 
            // greenBar
            // 
            this.greenBar.Location = new System.Drawing.Point(276, 372);
            this.greenBar.Name = "greenBar";
            this.greenBar.Size = new System.Drawing.Size(161, 17);
            this.greenBar.TabIndex = 19;
            this.greenBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Handler_ChangedScroll);
            // 
            // blueBar
            // 
            this.blueBar.Location = new System.Drawing.Point(276, 417);
            this.blueBar.Name = "blueBar";
            this.blueBar.Size = new System.Drawing.Size(161, 17);
            this.blueBar.TabIndex = 20;
            this.blueBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Handler_ChangedScroll);
            // 
            // redValue
            // 
            this.redValue.Location = new System.Drawing.Point(444, 329);
            this.redValue.Name = "redValue";
            this.redValue.Size = new System.Drawing.Size(47, 21);
            this.redValue.TabIndex = 6;
            this.redValue.Text = "0";
            this.redValue.TextChanged += new System.EventHandler(this.Handler_TextChanged);
            // 
            // greenValue
            // 
            this.greenValue.Location = new System.Drawing.Point(446, 372);
            this.greenValue.Name = "greenValue";
            this.greenValue.Size = new System.Drawing.Size(45, 21);
            this.greenValue.TabIndex = 21;
            this.greenValue.Text = "0";
            this.greenValue.TextChanged += new System.EventHandler(this.Handler_TextChanged);
            // 
            // blueValue
            // 
            this.blueValue.Location = new System.Drawing.Point(446, 417);
            this.blueValue.Name = "blueValue";
            this.blueValue.Size = new System.Drawing.Size(45, 21);
            this.blueValue.TabIndex = 22;
            this.blueValue.Text = "0";
            this.blueValue.TextChanged += new System.EventHandler(this.Handler_TextChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(279, 329);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(158, 45);
            this.trackBar1.TabIndex = 23;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 457);
            this.Controls.Add(this.blueValue);
            this.Controls.Add(this.greenValue);
            this.Controls.Add(this.redValue);
            this.Controls.Add(this.blueBar);
            this.Controls.Add(this.greenBar);
            this.Controls.Add(this.green);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.red);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.redBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapter 137 ~ 139";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private RadioButton rbKR;
        private RadioButton rbFemale;
        private RadioButton rbEct;
        private RadioButton rbMale;
        private Button button2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox engValue;
        private TextBox mathValue;
        private TextBox korValue;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox4;
        private Button calculateButton;
        private TextBox avgValue;
        private TextBox sumValue;
        private Label label4;
        private Label label6;
        private MaskedTextBox maskedTextBox1;
        private Panel colorPanel;
        private Label red;
        private Label blue;
        private Label green;
        private HScrollBar redBar;
        private HScrollBar greenBar;
        private HScrollBar blueBar;
        private TextBox redValue;
        private TextBox greenValue;
        private TextBox blueValue;
        private TrackBar trackBar1;
    }
}

