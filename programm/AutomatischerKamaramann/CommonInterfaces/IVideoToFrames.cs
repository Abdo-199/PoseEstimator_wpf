using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;

namespace CommonInterfaces
{
    interface IVideoToFrames
    {
        Image<Bgr,Byte> currentFrame { get; set; }
        void inFrames();
    }
}
