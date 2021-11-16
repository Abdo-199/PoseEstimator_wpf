using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Croping
{
    class videoCroping
    {
        photoCroping member = new photoCroping();
        Image<Bgr, Byte>[] Frames = null;

        public Image<Bgr, Byte>[] Crop(Image<Rgb, Byte> currentFrame, Rectangle[] Opject)
        {
            return Frames;
        }

        public Image<Bgr, Byte>[] export(string fileName)
        {
            return null;
        }
    }
}
