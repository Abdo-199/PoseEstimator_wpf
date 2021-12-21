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
    class videoCroping : photoCroping
    {
        photoCroping member = new photoCroping();
        Image<Bgr, Byte> Frame = null;

        public List<Image<Bgr, Byte>> VideoCrop(Image<Rgb, Byte> currentFrame, Rectangle[] Object)
        {

            return null;
        }

        public Image<Bgr, Byte> export(string fileName)
        {

            return null;
        }
    }
}
