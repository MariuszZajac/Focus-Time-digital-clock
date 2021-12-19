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
            //TODO
            // DateTime start = DateTime.Now;           
            // Thread.Sleep(1000);
            // DateTime end = DateTime.Now;
            // TimeSpan timeDiff = end - start;
            //
            // DispatcherTimer timer1 = new DispatcherTimer();
            // timer1.Interval = TimeSpan.FromSeconds(1);
            // timer1.Tick += Timer_tick2;
            // timer1.Start();
            
           //  Stopwatch stopwatch = new Stopwatch();
           //  stopwatch.Start();
           //
           //  // ... This takes 10 seconds to finish.
           //  for (int i = 0; i < 100; i++)
           //  {
           //     Thread.Sleep(1000);
           //  }
           //
           //  // Stop.
           //  stopwatch.Stop();
           //
           //  // Write hours, minutes and seconds.
           // CountLabel.Content = stopwatch.Elapsed;
        }

        private void QuitButton_click1(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }
        public void Timer_tick(object sender, EventArgs e)
        {
            TimeLabel.Content = Now.ToLongTimeString();
            DateLabel.Content = Now.ToLongDateString();
        }

        private void Break_5_OnClick(object sender, RoutedEventArgs e)
        {
            //TODO
        }

        private void Break_15_OnClick(object sender, RoutedEventArgs e)
        {
             //TODO
        }
    }
}