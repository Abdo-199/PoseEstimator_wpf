using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Emgu.CV;
using Emgu.CV.Structure;

namespace VideoToFrames
{
    public class inFrames
    {
        
        public List<Image<Rgb, Byte>> vidToFrames(string Filename)
        {
            List<Image<Rgb, Byte>> listFrames = new List<Image<Rgb, Byte>>();

            VideoCapture _capture = new VideoCapture(Filename);
            bool ProCes = true;

            while (ProCes)
            {
                Image<Rgb,Byte> frame = _capture.QueryFrame().ToImage<Rgb,Byte>();

                if (frame != null)
                {
                    listFrames.Add(frame);
                }
                else
                {
                    ProCes = false;
                }
            }

            return listFrames;
        }
    }
    
}
