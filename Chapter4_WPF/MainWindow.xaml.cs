using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Chapter4_WPF
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = new TimeSpan(5000000);
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (redButton.Background == Brushes.Red)
            {
                redButton.ClearValue(BackgroundProperty);
                greenButton.Background = Brushes.Green;
            }
            else
            {
                greenButton.ClearValue(BackgroundProperty);
                redButton.Background = Brushes.Red;
            }
        }

        private void Handler_CalculateClick(object sender, RoutedEventArgs e)
        {
            if (height.Text == string.Empty)
            {
                result.Content = "키를 입력하세요.";
                return;
            }
            else if (weight.Text == string.Empty)
            {
                result.Content = "체중을 입력하세요.";
                return;
            }

            var heightValue = Convert.ToDouble(height.Text) / 100.0;
            var weightValue = double.Parse(weight.Text);
            var bmi = weightValue / (heightValue * heightValue);

            result.Content = string.Format("당신의 BMI는 {0:F2} 입니다", bmi);
        }

        private void Handler_GreenClick(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void Handler_RedClick(object sender, RoutedEventArgs e)
        {
            timer.Stop();

            //멈췄을 때 원래 색상이 아닌 경우가 있어서 강제로 지정
            redButton.Background = Brushes.Red;
            greenButton.Background = Brushes.Green;
        }
    }
}
