namespace BindingDemo
{
    public class ScaleAttachedProperty :BindableObject
    {

        public static int GetScale(BindableObject obj)
        {
            return (int)obj.GetValue(ScaleProperty);
        }

        public static void SetScale(BindableObject obj, int value)
        {
            obj.SetValue(ScaleProperty, value);
        }

        // Using a DependencyProperty as the backing store for Scale.  This enables animation, styling, binding, etc...
        public static readonly BindableProperty ScaleProperty =
            BindableProperty.CreateAttached("Scale", typeof(int), typeof(Layout), 1
                ,propertyChanged:OnPropertyValueChanged);

        private static void OnPropertyValueChanged(BindableObject bindable, object oldValue, object newValue)
        {
            View view = bindable as View;
            int scale = (int)view.GetValue(ScaleProperty);
            if (view != null)
            {
                view.HeightRequest = scale*view.Height;
                view.WidthRequest = scale*view.Width;
            }
        }
    }
}
