using MyTunes.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace MyTunes
{
    public class StreamLoader : IStreamLoader
    {
        public Stream GetStramForFilename(string filename)
        {
            StorageFile file = Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync(filename).AsTask().Result;
            return file.OpenStreamForReadAsync().Result;
        }
    }
}
