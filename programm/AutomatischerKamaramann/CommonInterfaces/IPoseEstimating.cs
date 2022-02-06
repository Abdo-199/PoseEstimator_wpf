using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterfaces
{
    public interface IPoseEstimating
    {
       
        public List<Rectangle> getPoses(Image<Bgr,Byte> currentFrame);
    }
}
