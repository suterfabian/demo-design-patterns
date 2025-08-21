namespace ch.px.designpattern.Creational.Singleton.BadSolution;
internal class AppSettings
{
    private Dictionary<string, object> _settings = [];

    public object? Get(string key)
    {
        if (!_settings.ContainsKey(key))
        {
            return null;
        }

        return _settings[key];
    }

    public void Set(string key, object value)
    {
        _settings[key] = value;
    }
}
