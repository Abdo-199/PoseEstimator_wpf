using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Emgu.CV;
using Emgu.CV.Structure;

namespace VideoToFrames
{
    public class inFrames
    {

        public List<Image<Bgr, Byte>> vidToFrames(string Filename)
        {
            List<Image<Bgr, Byte>> ListFrames = new List<Image<Bgr, Byte>>();

            VideoCapture capture = new VideoCapture(Filename);

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
