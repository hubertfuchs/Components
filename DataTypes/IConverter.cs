namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    public interface IConverter<TIn, TOut>
    {
        TOut Convert( TIn value );
    }
}
