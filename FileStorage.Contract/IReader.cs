using System.Collections.Generic;
using System.Linq;

namespace Fuchsbau.Components.Data.FileStorage.Contract
{
    public interface IReader<T>
    {
        IList<T> Read();
        IList<T> ReadAsync();
    }
}