using System.ComponentModel;

namespace BindingDemo;

public partial class NotifyPropertyChangedPageDemo : ContentPage
{

	private int _value;
	/*Uncomment the line 14 and see how the label text 
	 * will change incrementing decrementing Value*/

	public int Value
	{
		get { return _value; }
		set { _value = value;
		     /*OnPropertyChanged(nameof(Value))*/;
		}
	}


	public NotifyPropertyChangedPageDemo()
	{
		InitializeComponent();
	    
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Button button = sender as Button;
		if (button.Text == "+") Value++;
		if (button.Text == "-") Value--;
    }
}