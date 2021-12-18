using System;
using System.Windows;
using System.Windows.Threading;

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
            timer.Interval= TimeSpan.FromSeconds(1);
            timer.Tick += Timer_tick;
            timer.Start();  
        }

        private void QuitButton_click1(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }

        public void Timer_tick(object sender, EventArgs e)
        {
            TimeLabel.Content = DateTime.Now.ToLongTimeString();
            DateLabel.Content = DateTime.Now.ToLongDateString();

        }
    }
}