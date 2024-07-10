using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.CustomModels
{
    class StringToCurrencyConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (parameter == null)
                return null;

            if (string.Equals(parameter.ToString(), "euro"))
            {
                return $"{value} €";
            }
            return $"{value} $";
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            return value.ToString().Replace(" €", string.Empty).Replace(" $", string.Empty);
        }
    }
}
