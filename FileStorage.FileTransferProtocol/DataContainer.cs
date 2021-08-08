using System.Collections.Generic;

namespace Fuchsbau.Components.Data.FileStorage.FileTransfer
{
    public class DataContainer
    {
        public IList<DataItem> Items;

        public DataContainer()
        {
            Items = new List<DataItem>();
        }
    }
}