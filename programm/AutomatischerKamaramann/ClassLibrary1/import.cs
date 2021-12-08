using System;
using System.Text.RegularExpressions;
using Emgu.CV;
using Emgu.CV.Structure;

namespace ClassLibrary1
{
    public class import
    {
        public string Path { get; set; }

        public import(string path)
        {
            Path = path;
        }

        public Capture videoImport()
        {
            return null;
        }

        public Image<Rgb, Byte> photoImport()
        {
            return null;
        }
    }
}
