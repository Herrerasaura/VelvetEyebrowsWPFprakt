using BeautySalon1.Models;
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

namespace BeautySalon1.Views
{
    /// <summary>
    /// Логика взаимодействия для VelvetMain.xaml
    /// </summary>
    public partial class VelvetMain : Window
    {
        public VelvetMain(bool isAdmin)
        {
            InitializeComponent();
            if (!isAdmin)
            {
                firstGridColumn.IsEnabled = false;
                firstGridColumn.Width = new GridLength(0);
                WindowStyle = WindowStyle.None;
                ResizeMode = ResizeMode.NoResize;
                WindowState = WindowState.Maximized;
                mainFrame.Navigate(new ServicesPage1(false));
            }
        }
        
        private void navigateToServices(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new ServicesPage1(true));
        }

        private void navigateToRecords(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new NearestRecord());
        }

        private void goToAddServicePage(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new UpdateServicePage(new Service()));
        }
    }
}
