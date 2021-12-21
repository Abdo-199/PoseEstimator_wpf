using System;
using System.Drawing;
using System.Collections.Generic;
using CommonInterfaces;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Croping
{
    public class photoCroping
    {
        private Image<Rgb, Byte> Cutout = null;

        public  Image<Rgb, Byte> PhotoCrop(Image<Rgb, Byte> currentFrame, Rectangle[] FaceRec)
        {
            return Cutout;
        }
        
        /*public Rectangle[] faceDet()
        {
            throw new NotImplementedException();
        }

        public Rectangle[] Poseframing()
        {
            throw new NotImplementedException();
        }*/
    }
}
