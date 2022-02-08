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
        // the drawing method has been moved under Cropping\drawing to be used with pose estimation  
        //and face detection
        /// <summary>
        /// method to get the rectangle coordinates for each pose 
        /// </summary>
        /// <param name="currentFrame">
        /// the image to be processed
        /// </param>
        /// <returns></returns>
        public List<Rectangle> getPoses(Image<Bgr,Byte> currentFrame)
        {
            apiHelper helper = new apiHelper();
            // get the coordinates for all the parts  each person
            List<Dictionary<string, Point>> coordinates = helper.getCoordinates(currentFrame);
            List<Rectangle> persons = new List<Rectangle>();
            //calculate the maximum and minimum x and y coordinates for each person
            foreach (var person in coordinates)
            {
                int minX = person["nose"].X;
                int maxX = 0;
                int minY = person["nose"].Y;
                int maxY = 0;
                //going through each part and chick the min and max x and y
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
                // the coordinates of the rectangle 
                persons.Add(new Rectangle((minX), (minY - margin),(maxX - minX), (maxY - minY) + margin));
            }
            return persons;
        }
       
    }
}
