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
        public Image<Bgr, Byte> getPoses(Image<Bgr, Byte> currentFrame);
        public List<Rectangle> PoseFraming(List<Dictionary<string, Point>> coordinates);
    }
}
