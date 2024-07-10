using System.Globalization;

namespace MauiTest.CustomModels
{
    class StringToColorConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is string colorString)
            {
                return colorString.ToLower() switch
                {
                    "red" => Colors.Red,
                    "green" => Colors.Green,
                    "blue" => Colors.Blue,
                    "yellow" => Colors.Yellow,
                    "gray" => Colors.Gray,
                    "black" => Colors.Black,
                    "white" => Colors.White,
                    _ => Colors.Gray
                };
            }

            return null; 
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is Color color)
            {
                return color.ToHex() switch
                {
                    "#FF0000" => Colors.Red,
                    "#00FF00" => Colors.Green,
                    "#0000FF" => Colors.Blue,
                    "#FFFF00" => Colors.Yellow,
                    "#808080" => Colors.Gray,
                    "#000000" => Colors.Black,
                    "#FFFFFF" => Colors.White,
                    _ => Colors.Gray
                };
            }

            return null;
        }
    }
}