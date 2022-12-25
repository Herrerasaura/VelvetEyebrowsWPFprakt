using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace BeautySalon1.Converters
{
    class TimeColor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime now = new DateTime(2019, 6, 24, 16, 0, 0);
            DateTime start = (DateTime)value;
            TimeSpan leftSpan = start - now;
            if (leftSpan.Hours == 0 & leftSpan.Days == 0)
            {
                return Brushes.Red;
            }
            return Brushes.AliceBlue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
