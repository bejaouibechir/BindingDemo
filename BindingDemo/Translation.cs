namespace BindingDemo
{
    public class TranslateExtension : IMarkupExtension
    {
        private string _key;
        private BindableObject targetObject;
        private BindableProperty targetProperty;

        public TranslateExtension(){
            Language = "Français";
            Key = "File";
        }

        //public TranslateExtension(string key)
        //{
        //    _key = key;
        //    Language = "Français";
        //}

        public string Language { get; set; }
        public string Key { get; set; }


        public object ProvideValue(IServiceProvider serviceProvider)
        {
            var targetHelper = (IProvideValueTarget)serviceProvider.
                   GetService(typeof(IProvideValueTarget));
            targetObject = targetHelper.TargetObject as BindableObject;
            targetProperty = targetHelper.TargetProperty as BindableProperty;
            ResourceManager manager = new ResourceManager();
            
            return manager.GetObject(Key, Language);
        }
    }
    public class ResourceManager : IResourceManager
    {
        public object GetObject(string key, string language)
        {
            switch (language)
            {
                case "Français":
                    {
                        switch (key)
                        {
                            case "file":
                                return "Fiche";
                            case "identifier":
                                return "Identifiant";
                            case "name":
                                return "Nom";
                            case "salary":
                                return "Salaire";
                            case "flag":
                                return "france.png";
                            default:
                                throw new ArgumentException("key must be defined");
                        }
                    }
                case "English":
                    {
                        switch (key)
                        {
                            case "file":
                                return "File";
                            case "identifier":
                                return "Identifier";
                            case "name":
                                return "Name";
                            case "salary":
                                return "Salary";
                            case "flag":
                                return "english.png";
                            default:
                                throw new ArgumentException("key must be defined");
                        }
                    }
                case "Deutsch":
                    {
                        switch (key)
                        {
                            case "file":
                                return "DatenBlatt";
                            case "identifier":
                                return "Kennung";
                            case "name":
                                return "Name";
                            case "salary":
                                return "Gehalt";
                            case "flag":
                                return "deutsch.png";
                            default:
                                throw new ArgumentException("key must be defined");
                        }
                    }
            }


            //To do implement the data rerivement 
            return "Not implemented";
        }


    }
}
