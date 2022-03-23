using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WMPLib;

namespace Chapter4
{
    public partial class Form4 : Form
    {
        private Timer _myTimer = new Timer();
        private DateTime _dDay;
        private DateTime _tTime;
        private bool setAlarm;

        WindowsMediaPlayer myPlayer = new WindowsMediaPlayer();

        public Form4()
        {
            InitializeComponent();

            labelAlarmSet.ForeColor = Color.Gray;

            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "tt hh:mm";

            _myTimer.Interval = 1000;
            _myTimer.Tick += Handler_MyTimerTick;
            _myTimer.Start();
        }

        private void Handler_MyTimerTick(object sender, EventArgs e)
        {
            var cTime = DateTime.Now;
            dateLabel.Text = cTime.ToShortDateString();
            timeLabel.Text = cTime.ToLongTimeString();

            if (setAlarm == true)
            {
                if (_dDay == DateTime.Today && cTime.Hour == _tTime.Hour && cTime.Minute == _tTime.Minute)
                {
                    setAlarm = false;

                    myPlayer.URL = @"C:\Users\yocho\source\repos\Chapter4\Chapter4\music\alarm.wav";
                    myPlayer.controls.play();

                    var result = MessageBox.Show("Time to wake up!", "Alarm", MessageBoxButtons.OK);

                    if (result == DialogResult.OK)
                    {
                        myPlayer.controls.stop();
                    }
                }
            }
        }

        private void Handler_SettingButtonClick(object sender, EventArgs e)
        {
            _dDay = DateTime.Parse(dateTimePicker1.Text);
            _tTime = DateTime.Parse(timePicker.Text);

            setAlarm = true;
            labelAlarmSet.ForeColor = Color.Blue;
            labelAlarmSet.Text = "Alarm: " + _dDay.ToShortDateString() + " " + _tTime.ToLongTimeString();

            tabControl1.SelectedTab = settingPage;
        }

        private void Handler_ResetButtonClick(object sender, EventArgs e)
        {
            setAlarm = false;
            labelAlarmSet.ForeColor = Color.Gray;
            labelAlarmSet.Text = "Alarm: 설정 내역 없음";
            tabControl1.SelectedTab = timerPage;
        }
    }
}
