using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using PoseEstimating;

namespace Croping
{
    public static class videoCroping
    {


        public static List<Bitmap> VideoCrop(List<Image<Bgr, byte>> allFrames, List<Rectangle> poseList)
        {
            List<Bitmap> cropedPoseBitmaps = new List<Bitmap>();

            try
            {
                foreach (var frame in allFrames)
                {
                    foreach (var pose in poseList)
                    {

                        Bitmap crop = Crop(frame, pose.X, pose.Y, pose.Width, pose.Height);
                        cropedPoseBitmaps.Add(crop);
                            
                    }    
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return cropedPoseBitmaps;
        }

        public static Bitmap Crop(Image<Bgr, byte> img, int x, int y, int width, int height)
        {
            Rectangle crop = new Rectangle(x, y, width, height);
            var bmp = new Bitmap(img.AsBitmap(), width, height);

            using (var gr = Graphics.FromImage(bmp))
            {
                gr.DrawImage(img.AsBitmap(), new Rectangle(0, 0, width, height), crop, GraphicsUnit.Pixel);
            }

            return bmp;
        }

    }
}

