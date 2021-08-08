namespace Fuchsbau.Components.CrossCutting.Logging.Contract
{
    public interface IObserver
    {
        void Update<T>( T param );
    }
}
