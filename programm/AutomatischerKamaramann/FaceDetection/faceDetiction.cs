using System;
using System.Collections.Generic;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace FaceDetection
{
    public class FaceDetection
    {
        public readonly CascadeClassifier faceCascadeClassifier;

        private Mat grayImage = null;


        public FaceDetection(CascadeClassifier classifier)
        {
            faceCascadeClassifier = classifier;
        }

        /*public Rectangle[] FaceDetVid(List<Image<Rgb, Byte>> ListFrames)
        {

            Rectangle[] faces = null;

            foreach (var Cframe in ListFrames)
            {
                CvInvoke.CvtColor(Cframe, grayImage, ColorConversion.Bgr2Gray);
                CvInvoke.EqualizeHist(grayImage, grayImage);

                faces = faceCascadeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);

                if (faces.Length > 0)
                {
                    foreach (var face in faces)
                    {
                        CvInvoke.Rectangle(Cframe, face, new Bgr(Color.Green).MCvScalar,2);
                        // VideoCropping Methode fehlt
                    }
                    
                }
            }
            
            return faces;
        }*/

        public Rectangle[] FaceDetIm(Image<Bgr, Byte> Image)
        {
            CvInvoke.CvtColor(Image,grayImage,ColorConversion.Bgr2Gray);
            CvInvoke.EqualizeHist(grayImage,grayImage);

            Rectangle[] faces = faceCascadeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);

            if (faces.Length > 0)
            {
                foreach (var face in faces)
                {
                    CvInvoke.Rectangle(Image,face,new Bgr(Color.Green).MCvScalar,2);
                    //PhotoCropping Mehtode fehlt
                }
            }

            return faces;
        }

    }
}

