using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;

namespace CommonInterfaces
{
    public interface IDataManager
    {public string Path { get; set; }
        public Capture videoImport(string path);
        public Image<Bgr,Byte> photoImport(string path);

    }
}
