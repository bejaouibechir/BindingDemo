namespace BindingDemo;

public partial class StaticBindingPageDemo : ContentPage
{
    static public string Value { get { return "Some static value"; } }

    public StaticBindingPageDemo()
	{
		InitializeComponent();
	}
}