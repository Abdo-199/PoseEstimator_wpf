using System;
using System.Collections.Generic;
using System.Drawing;
using CommonInterfaces;
using Emgu.CV;
using Emgu.CV.Structure;
using ApiManager;

namespace PoseEstimating
{
    public  class poseEstimation:IApiManager,IVideoToFrames
    {
        public  Image<Bgr, byte> currentFrame { get; set; }
        /// <summary>
        /// Method to get the current frame from the GUI and return the Image with a drawen rectangle
        /// </summary>
        /// <param name="currentFrame"></param>
        /// <returns></returns>
        public Image<Bgr,Byte> Posing(Image<Bgr, Byte> currentFrame)
        {
            apiHelper helper = new apiHelper();
            List<Rectangle> persons = PoseFraming(helper.getCoordinates(currentFrame));
           

            if (persons.Count > 0)
            {
                //draw a rectangle around each face
                foreach (Rectangle person in persons)
                {
                    CvInvoke.Rectangle(currentFrame, person, new Bgr(Color.Red).MCvScalar, 2);
                }
                //DrawItemEventArgs 
            }
            return currentFrame;
        }
        /// <summary>
        /// method to draw a rectangle arround each person
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public List<Rectangle> PoseFraming(List<Dictionary<string, Point>> coordinates)
        {
            List<Rectangle> Persons = new List<Rectangle>();
            foreach (var Person in coordinates)
            {
                int minX = Person["nose"].X;
                int maxX = 0;
                int minY = Person["nose"].Y;
                int maxY = 0;
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
                    if (part.Value.Y > maxY)
                    {
                        maxY = part.Value.Y;
                    }

                }
                //because the heighest coordinate in the list is one of the eyes coordinate 
                //and we need to draw the Rectangle arround the whole body
                int Margin = Person["left_shoulder"].Y - Person["right_eye"].Y;
                Persons.Add(new Rectangle((minX), (minY - Margin),(maxX - minX), (maxY - minY) + Margin));
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
