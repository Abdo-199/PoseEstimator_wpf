using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private CascadeClassifier faceCascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt.xml");

        public List<Rectangle> FaceDetIm(Image<Bgr, byte> image)
        {
            List<Rectangle> facesList = new List<Rectangle>();

            var grayImage = image.Convert<Gray, byte>();
            CvInvoke.CvtColor(image, grayImage, ColorConversion.Bgr2Gray);
            CvInvoke.EqualizeHist(grayImage, grayImage);

            Rectangle[] faces = faceCascadeClassifier.DetectMultiScale(grayImage, 1.1, 4);

            if (faces.Length > 0)
            {
                foreach (var face in faces)
                {
                    facesList.Add(face);
                }
            }
         
            return facesList;

        }


    }

}

