
using System.Globalization;


namespace BindingDemo
{
    public class HexToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string hex)
            {
                if (Color.TryParse(hex, out var color))
                {
                    return color;
                }
            }
            return Colors.Transparent; // Retourne une couleur transparente si la conversion échoue
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Color color)
            {
                return color.ToHex();
            }
            return "#000000"; // Retourne noir par défaut si la conversion échoue
        }
    }
}
