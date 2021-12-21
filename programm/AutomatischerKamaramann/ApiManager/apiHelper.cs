using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;
using RestSharp;

namespace ApiManager
{
    public class apiHelper
    {

        RestClient client = new RestClient("http://141.45.150.62:4713/openapi.json");
        RestResponse restResponse = new RestResponse();
        RestRequest request = new RestRequest();
        public List<Dictionary<string, PointF>> getCoordinates(Image<Rgb,Byte> img)
        {
           
            return null;
        }

        public  PointF ToPointF(List<double> part)
        {
            PointF partF = new PointF();
            partF.X = (float)part[0];
            partF.Y = (float)part[1];
            return partF;
        }
    }
}
