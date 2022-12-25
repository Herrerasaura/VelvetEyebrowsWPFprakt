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
    class ServiceIdToTitle : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int id = (int)value;
            Service Service;
            Service = Session.Instance.Context.Services.Where(s => s.Id == id).First();
            string servTitle = $"{Service.Title}";
            return servTitle;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
