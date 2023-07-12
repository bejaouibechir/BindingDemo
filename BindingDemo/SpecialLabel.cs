using Microsoft.Maui.Graphics.Text;

namespace BindingDemo
{
    
    public enum VisiblityState { Visible,Hidden,Collapsed}
    
    
    public class SpecialLabel :Label
    {
        private static Brush _color;
        private static Color _textcolor;

        public VisiblityState Visibility
        {
            get { return (VisiblityState)GetValue(VisibilityProperty); }
            set { SetValue(VisibilityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Visibility.  This enables animation, styling, binding, etc...
        public static readonly BindableProperty VisibilityProperty =
            BindableProperty.Create("Visibility", typeof(VisiblityState),
                typeof(SpecialLabel),
                VisiblityState.Visible,propertyChanged:OnVisibilityChanged);
        private static void OnVisibilityChanged(BindableObject bindable, object oldValue, object newValue)
        {
            SpecialLabel current = (SpecialLabel)bindable;


            if (current.Visibility == VisiblityState.Collapsed)
            {
                current.IsVisible = false;
            }
            else if (current.Visibility == VisiblityState.Hidden)
            {
                current.IsVisible = true;
                _color = current.Background;
                _textcolor = current.TextColor;
                current.Background = new SolidColorBrush(Colors.Transparent);
                current.TextColor = Colors.Transparent;
            }
            else
            {
                current.IsVisible = true;
                current.Background = _color;
                current.TextColor = _textcolor;
            }



        }
    }
}

