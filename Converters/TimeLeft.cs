using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace BeautySalon1.Converters
{
    class TimeLeft : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime now = new DateTime(2019, 6, 24, 16, 0, 0);
            DateTime start = (DateTime)value;
            TimeSpan leftSpan = start - now;
            string leftTime = $"Осталось {leftSpan.Days} дней {leftSpan.Hours} час {leftSpan.Minutes} мин";
            return leftTime;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
