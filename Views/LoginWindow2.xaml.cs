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
    /// Логика взаимодействия для LoginWindow2.xaml
    /// </summary>
    public partial class LoginWindow2 : Window
    {
        public LoginWindow2()
        {
            InitializeComponent();
        }

        private void login(object sender, RoutedEventArgs e)
        {
            var wnd = (isKioskCheckBox.IsChecked, pinCodeInput.Password) switch
            {
                (false, "0000") => new VelvetMain(true),
                (true, _) => new VelvetMain(false),
                _ => null
            };

            if (wnd is null)
            {
                MessageBox.Show("Не верный PIN!", "Вход не выполнен", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            wnd.Show();
            Close();
        }
    }
}
