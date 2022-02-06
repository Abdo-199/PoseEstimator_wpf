using System;
using System.Collections.Generic;
using System.Drawing;
using CommonInterfaces;
using Emgu.CV;
using Emgu.CV.Structure;
using ApiManager;

namespace PoseEstimating
{
    public  class poseEstimation:IPoseEstimating
    {
        /// <summary>
        /// method to draw a rectangle arround each person
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public List<Rectangle> getPoses(Image<Bgr,Byte> currentFrame)
        {
            apiHelper helper = new apiHelper();

            List<Dictionary<string, Point>> coordinates = helper.getCoordinates(currentFrame);
            List<Rectangle> persons = new List<Rectangle>();
            foreach (var person in coordinates)
            {
                int minX = person["nose"].X;
                int maxX = 0;
                int minY = person["nose"].Y;
                int maxY = 0;
                foreach (var part in person)
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
                    if (part.Value.Y > maxY)
                    {
                        maxY = part.Value.Y;
                    }

                }
                //because the highest coordinate in the list is one of the eyes coordinate 
                //and we need to draw the Rectangle around the whole body
                int margin = person["left_shoulder"].Y - person["right_eye"].Y;
                persons.Add(new Rectangle((minX), (minY - margin),(maxX - minX), (maxY - minY) + margin));
            }
            return persons;
        }
       
    }
}
