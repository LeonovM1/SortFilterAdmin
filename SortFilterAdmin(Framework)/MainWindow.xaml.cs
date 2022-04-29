using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;
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

namespace SortFilterAdmin_Framework_
{

    
    public partial class MainWindow : Window
    {

        DispatcherTimer timer = new DispatcherTimer();
        Point now = new Point(0, 0);

        int time = 0;


        public MainWindow()
        {
            InitializeComponent();
            timer.Tick += timer_tick;
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            time++;
            
            if (time == 10)
            {
                this.Close();
            }
        }

        private void MainButtonRegistration_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            Registration registration = new Registration();
            registration.Show();
            this.Close();
        }

        private void MainButtonEnter_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Close();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            Point pp = e.GetPosition(this);
            if(pp != now)
            {
                time = 0;
            }
            now = pp;
        }

        private void Window_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            time = 0;
        }

        private void Window_KeyDownAndUp(object sender, KeyEventArgs e)
        {
            time = 0;
        }

        private void Window_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            time = 0;
        }
    }
}
