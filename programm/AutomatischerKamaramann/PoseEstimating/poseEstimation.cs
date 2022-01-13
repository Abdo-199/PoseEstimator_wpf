using System;
using System.Collections.Generic;
using System.Drawing;
using CommonInterfaces;
using Emgu.CV;
using Emgu.CV.Structure;

namespace PoseEstimating
{
    public  class poseEstimation:IApiManager,IVideoToFrames
    {
        public  Image<Bgr, byte> currentFrame { get; set; }
        //public List<Dictionary<string, Point>> Posing(Image<Rgb, Byte> currentFrame)
        //{
        //    return null;
        //}
        //each person withe an rectangle contouring
        public  List<Rectangle> PoseFraming(List<Dictionary<string, PointF>> coordinates)
        {
            List<Rectangle> Persons = new List<Rectangle>();
            foreach (var Person in coordinates)
            {
                float minX = Person["nose"].X;
                float maxX = 0;
                float minY = Person["nose"].Y;
                float maxY = 0;
                foreach (var part in Person)
                {
                    if (part.Value.X < minX)
                    {
                        minX = part.Value.X;
                    }
                    if (part.Value.X > maxX)
                    {
                        maxX = part.Value.X;
                    }
                    if (part.Value.Y < minY)
                    {
                        minY = part.Value.Y;
                    }
                    if (part.Value.Y > minY)
                    {
                        maxY = part.Value.Y;
                    }

                }
                Persons.Add(new Rectangle((int)Math.Round(minX), (int)Math.Round(maxY), (int)Math.Round(maxX - minX), (int)Math.Round(maxY - minY)));
            }
            return Persons;
        }

        public void getPoseestimation()
        {
            throw new NotImplementedException();
        }


        public void inFrames()
        {
            throw new NotImplementedException();
        }
    }
}
