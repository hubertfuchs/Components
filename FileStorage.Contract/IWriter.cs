using System.Collections.Generic;

namespace Fuchsbau.Components.Data.FileStorage.Contract
{
    public interface IWriter<T>
    {
        void Write(IList<T> list);
        void WriteAsync(IList<T> list);
    }
}