using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;
using PoseEstimating;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    class PoseEstimating_UT
    {
        //[Test]
        //public void PoseFraming_Test()
        //{
        //    //arrange
        //    poseEstimation poseEstimation=new poseEstimation();
        //    //assemble
        //    // preparing an input parameter for the Method
        //    List<Dictionary<string,Point>> assemblingList =new List<Dictionary<string, Point>>();
        //    Dictionary<string, Point> firstPerson=new Dictionary<string, Point>()
        //    {
        //        {"nose",new Point(688,852)},{"Left_eye",new Point(721,825)},
        //        {"right_eye",new Point(659,828)},{"left_ear",new Point(759,845)}
        //        ,{"right_ear",new Point(626,854) },{"left_shoulder",new Point(855,1014)}
        //    };
        //    Dictionary<string, Point> secondPerson = new Dictionary<string, Point>()
        //    {
        //        {"nose",new Point(393,870)},{"left_eye",new Point(421,835)},
        //        {"right_eye",new Point(366,835)},{"left_ear",new Point(464,834)}
        //        ,{"right_ear",new Point(323,825) },{"left_shoulder",new Point(543,984)}
        //    };
        //    assemblingList.Add(firstPerson);
        //    assemblingList.Add(secondPerson);
        //    List<Rectangle> result = poseEstimation.PoseFraming(assemblingList);
        //    //list of two rectangles expected 
        //    List<Rectangle> expected= new List<Rectangle>()
        //    {
        //        {new Rectangle(626,825-(1014-828),(855-626),(1014-825)+(1014-828))},
        //        {new Rectangle(323,825-(984-835),(543-323),(984-825)+(984-835))}

        //    };
        //   Assert.AreEqual(expected,result);
        //}
        [Test]
        public void getPoses_test()
        {

            Image<Bgr,Byte> testImage=new Image<Bgr, byte>($"{AppDomain.CurrentDomain.BaseDirectory}poseTestPic");
            poseEstimation PE=new poseEstimation();
            //assemble
            List<Rectangle> expected = new List<Rectangle>() 
            {
                    {new Rectangle(45,42,262,584)},
                    {new Rectangle(303,49,127,563)}
            };
            List<Rectangle> result = PE.getPoses(testImage);
            //assert
            Assert.AreEqual(expected, result);

        }

    }
}
