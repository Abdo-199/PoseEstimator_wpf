﻿using System;
using System.Collections.Generic;
using System.Drawing;
using CommonInterfaces;
using Emgu.CV;
using Emgu.CV.Structure;

namespace PoseEstimating
{
    public class poseEstimation:IApiManager,IVideoToFrames
    {
        public List<Dictionary<string, Point>> Posing(Image<Rgb, Byte> currentFrame)
        {
            return null;
        }
        public List<Rectangle> PoseFraming(List<Dictionary<string, PointF>> coordinates)
        {
            return null;
        }

        public void getPoseestimation()
        {
            throw new NotImplementedException();
        }

        public Image<Bgr, byte> currentFrame { get; set; }
        public void inFrames()
        {
            throw new NotImplementedException();
        }
    }
}