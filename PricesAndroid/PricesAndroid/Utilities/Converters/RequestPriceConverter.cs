using System;
using System.Globalization;
using Xamarin.Forms;

namespace PricesAndroid.Utilities.Converters
{
    public class RequestPriceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (double.TryParse(value.ToString(), out var result)) return (int)result;

            return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
