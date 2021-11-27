using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movement_auto_models
{
    public class ImageSettings
    {
        public int MaxBytes { get; set; }
        public string[] SupportedFileTypes { get; set; }
        public bool IsSupported(string fileName)
        {
            return SupportedFileTypes.Any(s => s == Path.GetExtension(fileName).ToLower());
        }
    }
}
