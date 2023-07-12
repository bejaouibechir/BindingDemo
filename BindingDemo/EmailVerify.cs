using System.Text.RegularExpressions;

namespace BindingDemo
{
    public class EmailVerify :BindableObject
    {
        public static bool GetActivation(BindableObject obj)
        {
            return (bool)obj.GetValue(ActivationProperty);
        }

        public static void SetActivation(BindableObject obj, bool value)
        {
            obj.SetValue(ActivationProperty, value);
        }

        // Using a DependencyProperty as the backing store for Activation.  This enables animation, styling, binding, etc...
        public static readonly BindableProperty ActivationProperty =
            BindableProperty.CreateAttached("Activation", typeof(bool), typeof(View),false,
                propertyChanged:OnPropertyValueChanged);

        private static void OnPropertyValueChanged(BindableObject bindable, object oldValue, object newValue)
        {
            Entry e = bindable as Entry;
            if ((bool)newValue == true)
            {
                if (string.IsNullOrEmpty(e.Text))
                {
                    e.BackgroundColor = Colors.White;
                }
                else
                {
                    if (Regex.IsMatch(e.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                    {
                        e.BackgroundColor = Colors.White;
                    }
                    else
                    {
                        e.BackgroundColor = Colors.Red;
                    }
                }
            }
        }
        }
    }
