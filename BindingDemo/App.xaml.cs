//#define simplebinding --
//#define findancestor --
//#define relativeself --
//#define staticbinding --
//#define bindableproperty
//#define attachedproperty
//#define attachedproperty2
//#define notifyprop
#define markup


namespace BindingDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
#if simplebinding
        MainPage = new SimpleBindingPageDemo();
#endif
#if findancestor
      MainPage = new FindAncestorPageDemo();
#endif
#if relativeself
        MainPage = new RelativeSelfPageDemo();
#endif
#if templatedparent
        MainPage = new TempaltedParentPageDemo();
#endif
#if staticbinding
        MainPage = new StaticBindingPageDemo();
#endif
#if bindableproperty
        MainPage = new BindablePropertyPageDemo();
#endif
#if attachedproperty
        MainPage = new AttachedProeprtyPageDemo();
#endif
#if attachedproperty2
        MainPage = new AttachedPropertyPageDemo2();
#endif
#if notifyprop
        MainPage = new NotifyPropertyChangedPageDemo();
#endif
#if markup
        MainPage = new MarkupExtensionPageDemo(); 
#endif

    }
}
