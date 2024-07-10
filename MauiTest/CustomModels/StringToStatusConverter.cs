using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.CustomModels
{
    class StringToStatusConverter : IValueConverter
    {
        public string ApprovedStatus { get; set; } = "Approved";
        public string DeniedStatus { get; set; } = "Denied";


        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is string username && username == "admin")
                return ApprovedStatus;

            return DeniedStatus;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is string status && status == ApprovedStatus)
                return "admin";

            return "user";
        }
    }
}
