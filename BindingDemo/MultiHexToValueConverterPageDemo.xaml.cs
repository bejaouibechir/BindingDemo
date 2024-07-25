
using System.Globalization;

namespace BindingDemo;

public partial class MultiHexToValueConverterPageDemo : ContentPage
{
    private readonly HexToGradientColorConverter _hexToGradientColorConverter;

    public MultiHexToValueConverterPageDemo()
	{

		InitializeComponent();

        _hexToGradientColorConverter = (HexToGradientColorConverter)Resources["HexToGradientColorConverter"];

        hexEntry1.Text = "#001100";
        hexEntry2.Text = "#000055";
        
        hexEntry1.TextChanged += OnHexEntryTextChanged;
        hexEntry2.TextChanged += OnHexEntryTextChanged;
    }

    private void OnHexEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        var hex1 = hexEntry1.Text;
        var hex2 = hexEntry2.Text;
        var gradientBrush = (LinearGradientBrush)_hexToGradientColorConverter.Convert(
            new object[] { hex1, hex2 }, typeof(Brush), null, CultureInfo.CurrentCulture);
        gradientBoxView.Background = gradientBrush;
    }
}