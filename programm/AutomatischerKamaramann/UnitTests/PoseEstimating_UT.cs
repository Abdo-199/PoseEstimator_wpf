using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoseEstimating;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    class PoseEstimating_UT
    {
        [Test]
        public void PoseFraming_Test()
        {
            //arrange
            poseEstimation poseEstimation=new poseEstimation();
            //assemble
            // preparing an input parameter for the Method
            List<Dictionary<string,PointF>> assemblingList =new List<Dictionary<string, PointF>>();
            Dictionary<string, PointF> firstPerson=new Dictionary<string, PointF>()
            {
                {"nose",new PointF(7.909f,5.606f)},{"Left_eye",new PointF(9.909f,10.606f)},
                {"right_eye",new PointF(11.909f,3.606f)},{"Left_ear",new PointF(15.909f,2.606f)}
                ,{"right_ear",new PointF(70.909f,20.606f)}
            };
            Dictionary<string, PointF> secondPerson = new Dictionary<string, PointF>()
            {
                {"nose",new PointF(5.909f,5.606f)},{"Left_eye",new PointF(9.909f,10.606f)},
                {"right_eye",new PointF(11.909f,3.606f)},{"Left_ear",new PointF(15.909f,2.606f)}
                ,{"right_ear",new PointF(70.909f,30.606f)}
            };
            assemblingList.Add(firstPerson);
            assemblingList.Add(secondPerson);
            List<Rectangle> result = poseEstimation.PoseFraming(assemblingList);
            //list of two rectangles expected 
            List<Rectangle> expected= new List<Rectangle>()
            {
                {new Rectangle((int)Math.Round(7.909f),(int)Math.Round(20.606f),(int)Math.Round(70.909f-7.909f),(int)Math.Round(20.606f-2.606f))},
                {new Rectangle((int)Math.Round(5.909f),(int)Math.Round(30.606f),(int)Math.Round(70.909f-5.909f),(int)Math.Round(30.606f-2.606f))}

            };
           Assert.AreEqual(expected,result);
        }

    }
}
