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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WindSpareParts
{

    public partial class WelcomeMessage : Window
    {
        public WelcomeMessage()
        {
            InitializeComponent();
            StartTimer();
        }

        private void StartTimer()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(3); // The amount of time before it changes the window
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Stops the timer
            ((DispatcherTimer)sender).Stop();

            // Opens the MainWindow
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            // Closes the welcome window
            this.Close();
        }
    }

}
