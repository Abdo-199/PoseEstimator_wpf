using System;
using System.Text.RegularExpressions;
using Emgu.CV;
using Emgu.CV.Structure;

namespace VideoToFrames
{
    public class inFrames
    {
        public Image<Rgb, Byte> currentFrame = null;
        private Mat Matrix = null;

        public Image<Rgb, Byte> nextFrame(Capture videCapture)
        {
            return currentFrame;

        }
    }
}
