namespace BindingDemo;

public partial class HexToColorConverterPageDemo : ContentPage
{
    private readonly HexToColorConverter _hexToColorConverter;

    public HexToColorConverterPageDemo()
	{
		InitializeComponent();
        _hexToColorConverter = (HexToColorConverter)Resources["HexToColorConverter"];
    }
    private void OnHexEntryChanged(object sender, TextChangedEventArgs e)
    {
        var hexColor = e.NewTextValue;
        var color = (Color)_hexToColorConverter.Convert(hexColor, typeof(Color), null, null);
        colorBoxView.Color = color;
    }
}