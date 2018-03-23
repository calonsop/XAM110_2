using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Foundation;
using MyTunes.Shared;
using UIKit;

namespace MyTunes
{
    public class StreamLoader : IStreamLoader
    {
        public Stream GetStramForFilename(string filename)
        {
            return System.IO.File.OpenRead(filename);
        }
    }
}