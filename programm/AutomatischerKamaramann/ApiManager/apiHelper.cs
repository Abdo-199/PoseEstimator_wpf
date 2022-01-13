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
{   /// <summary>
    /// Eine Klasse zur Kommunikation mit der Rest-Api der Posenschätzung 
    /// </summary>
    public  class apiHelper
    {  
        // 
        public static serialisation DZ = new serialisation();
        public  List<Dictionary<string, PointF>> getCoordinates(Image<Bgr,Byte> img)
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
            #region response
            IRestResponse response = client.Execute(request);
            //json string
            string content = response.Content;
            //deserializing the JSON string into List<Dictionary<string,List<double>>>
            var deContent = JsonConvert.DeserializeObject<List<Dictionary<string, List<double>>>>(content);
            //new list with PointF instead of List<double>
            List<Dictionary<string, PointF>> coordinats = new List<Dictionary<string, PointF>>();
            //converting the List<double> part </double> to a pointf
            //to get valid coordinates for the drawing of the rectangle arround each person
            foreach (var person in deContent)
            {   // new Dictionary for each Person
                Dictionary<string, PointF> parts = new Dictionary<string, PointF>();
                foreach (var part in person)
                {       
                    parts.Add(part.Key, ToPointF(part.Value));
                }
                coordinats.Add(parts);
            }
            return coordinats;
            #endregion
        }
        /// <summary>
        /// Method to convert the list<double> to pointF
        /// </summary>
        /// <param name="part"> coordinate of the Bodypart as a List<double></param>
        /// <returns></returns>
        public   PointF ToPointF(List<double> part)
        {
            PointF partF = new PointF();
            partF.X = (float)Math.Round(part[0]);
            partF.Y = (float)Math.Round(part[1]);
            return partF;
        }
    }
}
