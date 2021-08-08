namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    public interface IConfiguration
    {
        void Set(string category, string key, object value);
        T Get<T>(string category, string key);
    }
}
