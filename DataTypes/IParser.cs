namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    public interface IParser<T>
    {
        T Parse( T value );
    }
}
