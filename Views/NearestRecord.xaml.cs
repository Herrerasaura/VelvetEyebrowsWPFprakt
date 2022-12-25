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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BeautySalon1.Views
{
    /// <summary>
    /// Логика взаимодействия для NearestRecord.xaml
    /// </summary>
    public partial class NearestRecord : Page
    {
        public List<Service> Services { get; set; } = new();

        public List<ClientService> Records { get; set; } = new();

        public Client Client { get; set; }

        public string notFound = "";

        public List<Client> Clients { get; set; } = new();
        public NearestRecord()
        {
            DateTime now = new DateTime(2019, 6, 24, 16, 0, 0);
            Records = Session.Instance.Context.ClientServices.Where(s => s.StartTime > now).OrderBy(s => s.StartTime).ToList();
            
            InitializeComponent();

            if (Records.Count == 0)
            {
                notFound = "На сегодня нет записей";
            }

            DataContext = this;
        }

    }
}
