using System;
using System.Globalization;
using Xamarin.Forms;

namespace PricesAndroid.Utilities.Converters
{
    public class TotalPriceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (string.IsNullOrEmpty(value as string) || (int)value == 0) return "--";

            return $"{value.ToString()} руб.";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
