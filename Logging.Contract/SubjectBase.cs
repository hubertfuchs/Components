using System.Collections.Generic;

namespace Fuchsbau.Components.CrossCutting.Logging.Contract
{
    public abstract class SubjectBase
    {
        private IList<IObserver> _observers;

        public SubjectBase()
        {
            _observers = new List<IObserver>();
        }

        public void Subscribe( IObserver observer )
        {
            if( !_observers.Contains( observer ) )
            {
                _observers.Add( observer );
            }
        }

        public void Unsubscribe( IObserver observer )
        {
            _observers.Remove( observer );
        }

        public void Publish<T>( T param )
        {
            foreach( var observer in _observers )
            {
                observer.Update<T>( param );
            }
        }
    }
}
