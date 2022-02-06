using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;

namespace CommonInterfaces
{
    public interface IFaceDetection
    {
        public Rectangle[] FaceDetIm(Image<Bgr, byte> image);
    }
}
