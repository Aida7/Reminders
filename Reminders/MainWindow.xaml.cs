using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Reminders
{

    /*Создать приложение-напоминалку.Пользователь может создавать таймер, 
    который будет запускаться раз в указанное время и предупреждать
    о каком-то деле, которое тоже задаёт пользователь.*/
   
    public partial class MainWindow : Window
    {
        int t ;
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void SaveButton_Clik(object sender, RoutedEventArgs e)
        {
            Timers timers = new Timers();

            timers.Hour= int.Parse(hour.Text);
            timers.Sec= int.Parse(sec.Text);
            timers.Min = int.Parse(hour.Text);
            

            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            timers.timer = new TimeSpan(timers.Hour, timers.Min, timers.Sec);
            dispatcherTimer.Interval = new TimeSpan (timers.Hour, timers.Min, timers.Sec);
            dispatcherTimer.Tick -= new EventHandler(dispatcherTimer_Tick);
            
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
           
            Content = new Page1();
            
        }

    }
}
