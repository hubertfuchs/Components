using System;
using Fuchsbau.Components.Data.FileStorage.Contract;

namespace Fuchsbau.Components.Data.FileStorage
{
    public class ImageGroupReader //: IImageGroupReader
    {
        private readonly IFile _file;

        public ImageGroupReader(
            IFile file)
        {
            _file = file ?? throw new ArgumentNullException(nameof(file));

            // TODO: Configuration lesen
        }

    }
}