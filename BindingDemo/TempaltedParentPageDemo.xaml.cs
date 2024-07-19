using System.Windows.Input;

namespace BindingDemo;

public partial class TempaltedParentPageDemo : ContentPage
{
	public TempaltedParentPageDemo()
	{
		InitializeComponent();
	} 
}


public class NumericUpDown : ContentView
{
    public int Value
    {
        get { return (int)GetValue(ValueProperty); }
        set { SetValue(ValueProperty, value); }
    }

    public IncreaseCommand IncreaseCommand { get; set; }
    public DecreaseCommand DecreaseCommand { get; set; }

    public NumericUpDown()
    {
        IncreaseCommand = new IncreaseCommand(this);
        DecreaseCommand = new DecreaseCommand(this);
    }

    // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
    public static readonly BindableProperty ValueProperty =
        BindableProperty.Create("Value", typeof(int), typeof(NumericUpDown), 0,
            propertyChanged: OnPropertyValueChanged, coerceValue: OnCoerceValue);

    private static object OnCoerceValue(BindableObject bindable, object value)
    {
        int input = (int)value;
        if (input < 0) input = 0;
        if (input > 100) input = 0;
        return input;
    }


    public void up()
    {
        Value++;
    }
    public void down()
    {
        Value--;
    }

    private static void OnPropertyValueChanged(BindableObject bindable, object oldValue, object newValue)
    {
        ;
    }
}

public class IncreaseCommand : ICommand
{
    private readonly NumericUpDown _upDown;

    public event EventHandler CanExecuteChanged;

    public IncreaseCommand(NumericUpDown upDown)
    {
        _upDown = upDown;
    }

    public bool CanExecute(object parameter)
    {
        return true;
    }

    public void Execute(object parameter)
    {
        _upDown.up();
    }
}
public class DecreaseCommand : ICommand
{
    private readonly NumericUpDown _upDown;

    public DecreaseCommand(NumericUpDown upDown)
    {
        _upDown = upDown;
    }

    public event EventHandler CanExecuteChanged;

    public bool CanExecute(object parameter)
    {
        return true;
    }

    public void Execute(object parameter)
    {
        _upDown.down();

    }
}

