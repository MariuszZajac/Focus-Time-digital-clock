using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Timers;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Forms;
using static System.DateTime;
using Timer = System.Windows.Forms.Timer;


namespace DigitalClock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_tick;
            timer.Start();
        }
        
        private void Focus_30_OnClick(object sender, EventArgs e)
        {
            TimeSpan ts = TimeSpan.FromMinutes(30);
            DispatcherTimer timer2 = new DispatcherTimer();
            timer2.Interval = TimeSpan.FromSeconds(1);
            timer2.Tick += Timer_tick2;
            timer2.Start();

            void Timer_tick2(object sender, EventArgs e)
            {
                ts = ts.Subtract(TimeSpan.FromSeconds(1));
                Timer1.Content = ts.ToString(@"mm\:ss");
            }
        }

        private void QuitButton_click1(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }
        public void Timer_tick3(object sender, EventArgs e)
        {
            TimeSpan ts = TimeSpan.FromMinutes(5);
            ts = ts.Subtract(TimeSpan.FromSeconds(1));
            Timer1.Content = ts.ToString(@"mm\:ss");
        }
        public void Timer_tick(object sender, EventArgs e)
        {
            TimeLabel.Content = Now.ToLongTimeString();
            DateLabel.Content = Now.ToLongDateString();
        }
    }
}