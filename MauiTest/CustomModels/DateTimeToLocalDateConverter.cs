using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.CustomModels
{
    class DateTimeToLocalDateConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if(value == null)
                return null;

            return ((DateTime)value).ToString("dd.MM.yyyy");
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if(value is string stringValue)
                return DateTime.Parse(stringValue);

            return null;
        }
    }
}
