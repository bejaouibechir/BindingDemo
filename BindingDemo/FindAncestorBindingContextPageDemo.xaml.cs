using System.ComponentModel;

namespace BindingDemo;

public partial class FindAncestorBindingContextPageDemo : ContentPage
{
	public FindAncestorBindingContextPageDemo()
	{
		InitializeComponent();
	}
}




public class ViewModelBase : INotifyPropertyChanged
{
	public event PropertyChangedEventHandler PropertyChanged;


	private Color _colorBase;

	public Color ColorBase
	{
		get { return _colorBase; }
		set
		{
			_colorBase = value;
			OnPropertyChanged(nameof(ColorBase));
		}
	}

	protected void OnPropertyChanged(string propertyName)
	{
		if (PropertyChanged != null)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}


public class ViewModel : ViewModelBase
{

    private Color _color;

    public Color Color
    {
        get { return _color; }
        set
        {
            _color = value;
            OnPropertyChanged(nameof(ColorBase));
        }
    }

}