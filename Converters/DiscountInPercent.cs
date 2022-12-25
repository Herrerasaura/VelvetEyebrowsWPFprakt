using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace BeautySalon1.Converters
{
    class DiscountInPercent : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double? fraction = (double?)value;
            return fraction * 100;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double? per = (double?)value;
            return per / 100;
        }
    }
}
