using System;
using System.Collections.Generic;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;

namespace FaceDetection
{
    public class faceDetection
    {
        public CascadeClassifier faceCascadeClassifier { set; get; }

        private Mat grayImage = null;

        public faceDetection(CascadeClassifier classifier)
        {
            faceCascadeClassifier = classifier;
        }

        public Rectangle[] FaceDet(List<Image<Rgb, Byte>>currentFrame)
        {

            return null;
        }
    }
}
