using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Security.Cryptography.X509Certificates;
using CommonInterfaces;
using Emgu.CV;
using Emgu.CV.Structure;
using FaceDetection;



namespace Croping
{
    public static class photoCroping
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="originalWidth"></param>
        /// <param name="originalHeight"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>

        public static List<Bitmap> ResizeCrop(Image<Bgr, byte> source, List<Rectangle> Faces)
        {
            List<Bitmap> result = new List<Bitmap>();

            try
            {
                
                //Calculates the new width and height of the Crop
                foreach (var face in Faces)
                {

                    float sourceRatio = (float)source.Width / source.Height;

                    int nFaceX = face.Width * (int)1.4f;
                    int nFaceY = face.Height * (int)2.2f;

                    using (var targetBitmap = new Bitmap(nFaceX, nFaceY))
                    {
                        using (var g = Graphics.FromImage(targetBitmap))
                        {
                            g.CompositingQuality = CompositingQuality.HighQuality;
                            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            g.SmoothingMode = SmoothingMode.HighQuality;

                            float scalefacetorY = (float)source.Height / nFaceY;
                            float scalefacetorX = (float)source.Width / nFaceX;

                            int newWidth = (int)(source.Width / scalefacetorX);
                            int newHeight = (int)(source.Height / scalefacetorY);

                            if (newWidth < nFaceX) newWidth = nFaceX;
                            if (newHeight < nFaceY) newHeight = nFaceY;

                            int shiftX = 0;
                            int shiftY = 0;

                            if (newWidth > nFaceX)
                            {
                                shiftX = (newWidth - nFaceX) / 2;
                            }

                            if (newHeight > nFaceY)
                            {
                                shiftY = (newHeight - nFaceY) / 2;
                            }
                            // Draw image

                            //g.DrawImage(source.ToBitmap(), -shiftX, -shiftY, newWidth, newHeight);
                            result.Add(targetBitmap);

                        }

                    
                    }

                
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            

            return result;
        }


    }
}
