using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using BeautySalon1.Models;

namespace BeautySalon1.Converters
{
    class ClientIdToEmailPhone : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int id = (int)value;
            Client Client;
            Client = Session.Instance.Context.Clients.Where(s => s.Id == id).First();
            string clientEmailPhone = $"Email - {Client.Email} Phone - {Client.Phone}";
            return clientEmailPhone;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
