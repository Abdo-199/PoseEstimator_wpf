using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Croping
{
    public class drawing
    {
        public Image<Bgr,Byte> drawRect(List<Rectangle> rectList, Image<Bgr, Byte> currentFrame)
        {
            if (rectList.Count > 0)
            {
                //draw a rectangle around each face
                foreach (Rectangle person in rectList)
                {
                    CvInvoke.Rectangle(currentFrame, person, new Bgr(Color.Red).MCvScalar, 2);
                }
                //DrawItemEventArgs 
            }
            return currentFrame;
        }
    }
}
