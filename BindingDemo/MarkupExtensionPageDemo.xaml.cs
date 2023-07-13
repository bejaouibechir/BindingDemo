using System.Globalization;

namespace BindingDemo;

public partial class MarkupExtensionPageDemo : ContentPage
{
	public MarkupExtensionPageDemo()
	{
		InitializeComponent();
	}
}

public class ToStringConverter : IValueConverter
{
    object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }

    object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}