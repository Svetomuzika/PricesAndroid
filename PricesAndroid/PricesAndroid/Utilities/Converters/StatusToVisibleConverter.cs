using PricesAndroid.Models;
using System;
using System.Globalization;
using Xamarin.Forms;

namespace PricesAndroid.Utilities.Converters
{
    public class StatusToVisibleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (Enum.TryParse<StatusEnum>((string)parameter, out var status)) return (StatusEnum)value == status;

            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
