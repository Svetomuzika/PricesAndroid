using System;
using System.Globalization;
using Xamarin.Forms;

namespace PricesAndroid.Utilities.Converters
{
    public class ContainerWeightConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var weight = (int)value;
            var lastDigit = weight % 10;
            var lastDigits = weight % 100;

            if (lastDigit == 1 && lastDigits != 11) return $"{weight} тонна";

            if ((lastDigit == 2 || lastDigit == 3 || lastDigit == 4)
                && lastDigits != 12 && lastDigits != 13 && lastDigits != 14)
                return $"{weight} тонны";

            return $"{weight} тонн";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
