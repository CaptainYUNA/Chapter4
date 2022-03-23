
namespace Chapter4
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.settingPage = new System.Windows.Forms.TabPage();
            this.settingButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timerPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.labelAlarmSet = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.settingPage.SuspendLayout();
            this.timerPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.settingPage);
            this.tabControl1.Controls.Add(this.timerPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(595, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // settingPage
            // 
            this.settingPage.Controls.Add(this.settingButton);
            this.settingPage.Controls.Add(this.resetButton);
            this.settingPage.Controls.Add(this.label2);
            this.settingPage.Controls.Add(this.timePicker);
            this.settingPage.Controls.Add(this.label1);
            this.settingPage.Controls.Add(this.dateTimePicker1);
            this.settingPage.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.settingPage.Location = new System.Drawing.Point(4, 22);
            this.settingPage.Name = "settingPage";
            this.settingPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingPage.Size = new System.Drawing.Size(587, 400);
            this.settingPage.TabIndex = 0;
            this.settingPage.Text = "알람 설정";
            this.settingPage.UseVisualStyleBackColor = true;
            // 
            // settingButton
            // 
            this.settingButton.Location = new System.Drawing.Point(43, 174);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(75, 23);
            this.settingButton.TabIndex = 4;
            this.settingButton.Text = "설정";
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.Handler_SettingButtonClick);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(138, 174);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "해제";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.Handler_ResetButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "시간 설정";
            // 
            // dateTimePicker2
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(26, 122);
            this.timePicker.Name = "dateTimePicker2";
            this.timePicker.Size = new System.Drawing.Size(200, 23);
            this.timePicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "날짜 설정";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // timerPage
            // 
            this.timerPage.Controls.Add(this.groupBox1);
            this.timerPage.Controls.Add(this.labelAlarmSet);
            this.timerPage.Location = new System.Drawing.Point(4, 22);
            this.timerPage.Name = "timerPage";
            this.timerPage.Padding = new System.Windows.Forms.Padding(3);
            this.timerPage.Size = new System.Drawing.Size(587, 400);
            this.timerPage.TabIndex = 1;
            this.timerPage.Text = "디지털 시계";
            this.timerPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timeLabel);
            this.groupBox1.Controls.Add(this.dateLabel);
            this.groupBox1.Location = new System.Drawing.Point(24, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 107);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "현재 시각";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeLabel.Location = new System.Drawing.Point(6, 54);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 32);
            this.timeLabel.TabIndex = 3;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(6, 28);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 12);
            this.dateLabel.TabIndex = 2;
            // 
            // labelAlarmSet
            // 
            this.labelAlarmSet.AutoSize = true;
            this.labelAlarmSet.Location = new System.Drawing.Point(22, 31);
            this.labelAlarmSet.Name = "labelAlarmSet";
            this.labelAlarmSet.Size = new System.Drawing.Size(73, 12);
            this.labelAlarmSet.TabIndex = 0;
            this.labelAlarmSet.Text = "설정된 알람:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form4";
            this.Text = "Chapter 150";
            this.tabControl1.ResumeLayout(false);
            this.settingPage.ResumeLayout(false);
            this.settingPage.PerformLayout();
            this.timerPage.ResumeLayout(false);
            this.timerPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage settingPage;
        private System.Windows.Forms.TabPage timerPage;
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAlarmSet;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
    }
}