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
    public interface IApiManager
    {
        public Point ToPoint(List<double> part);
        public List<Dictionary<string, Point>> getCoordinates(Image<Bgr, Byte> img);
        
    }
}
