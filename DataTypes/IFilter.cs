namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    public interface IFilter<T>
    {
        T Filter( T enumeration );
    }
}
