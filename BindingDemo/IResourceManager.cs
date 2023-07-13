namespace BindingDemo
{
    public interface IResourceManager
    {
        object GetObject(string key, string language);
    }
}