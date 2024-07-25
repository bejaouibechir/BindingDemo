using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingDemo
{
    public class HexToGradientColorConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length == 2 && values[0] is string hex1 && values[1] is string hex2)
            {
                if (Color.TryParse(hex1, out var color1) && Color.TryParse(hex2, out var color2))
                {
                    return new LinearGradientBrush(new GradientStopCollection
                    {
                        new GradientStop(color1, 0.0f),
                        new GradientStop(color2, 1.0f)
                    }, new Point(0, 0), new Point(1, 0));
                }
            }

            return Colors.Transparent; // Retourne une couleur transparente si la conversion échoue
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            // Inverse conversion is not needed for this example
            throw new NotImplementedException();
        }
    }
}
