using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using CommonInterfaces;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace FaceDetection
{
    public class DetectFace : IFaceDetection
    {
        public Rectangle[] FacesExtracted;

        private CascadeClassifier faceCascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt.xml");

        public Image<Bgr, byte> FaceDetIm(Image<Bgr, byte> image)
        {
            
               var grayImage = image.Convert<Gray, byte>();

                CvInvoke.CvtColor(image, grayImage, ColorConversion.Bgr2Gray);
                CvInvoke.EqualizeHist(grayImage, grayImage);

                Rectangle[] faces = faceCascadeClassifier.DetectMultiScale(grayImage, 1.1, 4);
                FacesExtracted = faces;

                if (faces.Length > 0)
                {
                    foreach (var face in faces)
                    {
                        CvInvoke.Rectangle(image, face, new Bgr(Color.DarkSlateBlue).MCvScalar, 2);
                    }
                }

                return image;



        }

    }


}

