using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace VideoToFrames
{
    public class inFrames
    {
        public double FPS;
        public double Totalframes;
        public int FrameNr;
        VideoCapture capture;

        public List<Image<Bgr, Byte>> vidToFrames(string Filename)
        {

            List<Image<Bgr, Byte>> ListFrames = new List<Image<Bgr, Byte>>(); 
            capture = new VideoCapture(Filename);

            Totalframes = capture.Get(CapProp.FrameCount);
            FPS = capture.Get(CapProp.Fps);

            try
            {
                bool ProCes = true;

                while (ProCes)
                {
                    Image<Bgr, Byte> frame = capture.QueryFrame().ToImage<Bgr, Byte>();

                    if (frame != null)
                    {
                        ListFrames.Add(frame);
                    }
                    else
                    {
                        ProCes = false;
                    }
                }

                return ListFrames;
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

    }

}
