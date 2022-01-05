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
        private Image<Bgr, Byte> Cutout = null;

        public  Image<Bgr, Byte> PhotoCrop(Image<Rgb, Byte> currentFrame, Rectangle[] FaceRec)
        {
            if (FaceRec.Length > 0)
            {
                foreach (var face in FaceRec)
                {
                    

                }

            }

            return null;
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
