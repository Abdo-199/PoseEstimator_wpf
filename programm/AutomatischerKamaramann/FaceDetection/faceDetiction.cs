using System;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;

namespace FaceDetection
{
    public class faceDetiction
    {
        public CascadeClassifier faceCascadeClassifier { set; get; }
        private Mat grayImage=null;

        public faceDetiction(CascadeClassifier classifier)
        {
            faceCascadeClassifier = classifier;
        }

        public Rectangle[] FaceDet(Image<Rgb, Byte> currentFrame)
        {
            return null;
        }
    }
}
