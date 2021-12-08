using System;
using System.Drawing;
using CommonInterfaces;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Croping
{
    public class photoCroping:IFaceDetection,IPoseEstimating
    {
        private Image<Rgb, Byte> Cutout = null;

        public Image<Rgb, Byte> Crop(Image<Rgb, Byte> currentFrame, Rectangle[] Object)
        {
            return Cutout;
        }
        public Image<Bgr, Byte> export(string fileName)
        {
            return null;
        }

        public Rectangle[] faceDet()
        {
            throw new NotImplementedException();
        }

        public Rectangle[] Poseframing()
        {
            throw new NotImplementedException();
        }
    }
}
