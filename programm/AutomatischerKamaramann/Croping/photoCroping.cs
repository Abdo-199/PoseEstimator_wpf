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

        public static Bitmap ResizeCrop(Image<Bgr, byte> source, Rectangle Face)
        {
            try
            {
                //Calculates the new width and height of the Crop
                double nFaceW = Face.Width * 2f;
                double nFaceH = Face.Height * 2.5f;

                int x = Face.X;
                int y = Face.Y;

                int shiftX = (Face.Width / 2) - (int)(nFaceW / 2);
                int shiftY = (Face.Height / 2) - (int)(nFaceH / 2);

                int nx = x + shiftX;
                int ny = y + shiftY;

                source = crop(source, nx, ny, (int)nFaceW, (int)nFaceH).ToImage<Bgr,byte>();
                return source.AsBitmap();

            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        public static Bitmap crop(Image<Bgr, byte> Img, int x, int y, int width, int height)
        {
            Rectangle crop = new Rectangle(x, y, width, height);
            var bmp = new Bitmap(Img.AsBitmap(), width, height);

            using (var gr = Graphics.FromImage(bmp))
            {
                gr.DrawImage(Img.AsBitmap(), new Rectangle(0, 0, width, height), crop, GraphicsUnit.Pixel);
            }

            return bmp;
        }
    }
}







