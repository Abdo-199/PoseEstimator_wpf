using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;
using Newtonsoft.Json;
using RestSharp;

namespace ApiManager
{
    public class apiHelper
    {
        public static serialisation DZ = new serialisation();
        public List<Dictionary<string, PointF>> getCoordinates(Image<Rgb,Byte> img)
        {
            #region ApiCall
            //Encoding the Image to base64str png
            string base64string = DZ.ImageEncode(img);
            //request
            RestClient client = new RestClient("http://141.45.150.62:4713/predict");
            RestRequest request = new RestRequest(Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-Type", " application/json");
            request.AddJsonBody(new { base64str = base64string });
            #endregion
            //response
            IRestResponse response = client.Execute(request);
            //json string
            string content = response.Content;
            //deserializing the JSON string into List<Dictionary<string,List<double>>>
            var deContent = JsonConvert.DeserializeObject<List<Dictionary<string, List<double>>>>(content);
            //new list with PointF instead of List<double>
            List<Dictionary<string, PointF>> coordinats = new List<Dictionary<string, PointF>>();
            foreach (var person in deContent)
            {
                Dictionary<string, PointF> parts = new Dictionary<string, PointF>();
                foreach (var part in person)
                {
                    parts.Add(part.Key, ToPointF(part.Value));
                }
                coordinats.Add(parts);
            }
            return coordinats;
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
