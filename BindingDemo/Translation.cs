using System.Globalization;
using Xamarin.Google.Crypto.Tink.Proto;

namespace BindingDemo
{
    public class TranslateExtension : IMarkupExtension
    {
        private string key;
        private BindableObject targetObject;
        private BindableProperty targetProperty;

        public TranslateExtension():this("French"){}

        public TranslateExtension(string key)
        {
            this.key = key;
        }

        public string Field { get; set; }

        void Translator_CultureChanged(object sender, EventArgs e)
        {
            if (targetObject != null && targetProperty != null)
            {
                targetObject.SetValue(targetProperty,
                      ResourceManager.GetObject(key,Field));
            }
        }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            var targetHelper = (IProvideValueTarget)serviceProvider.
                   GetService(typeof(IProvideValueTarget));
            targetObject = targetHelper.TargetObject as BindableObject;
            targetProperty = targetHelper.TargetProperty as BindableProperty;
            return ResourceManager.GetObject(key, Field);
        }
    }

    public class ResourceManager
    {
        Dictionary<string, object> _frenchdictionary;
        Dictionary<string, object> _englishdictionary;
        Dictionary<string, object> _germandictionary;
        public static object GetObject(string key,string field)
        {
           //To do implement the data rerivement 
            return "Not implemented";
        }

        
    }
}
