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
using CommonInterfaces;


namespace ApiManager
{   /// <summary>
    /// Eine Klasse zur Kommunikation mit der Rest-Api der Posenschätzung 
    /// </summary>
    public  class apiHelper:IApiManager
    {  
        // 
        public static serialisation DZ = new serialisation();
        public  List<Dictionary<string, Point>> getCoordinates(Image<Bgr,Byte> img)
        {
            #region ApiCall
            //Encoding the Image to base64str png
            string base64string = DZ.ImageEncode(img);
            //request
            RestClient client = new RestClient("http://141.45.150.62:4711/predict");
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
            //new list with Point instead of List<double>
            List<Dictionary<string, Point>> coordinats = new List<Dictionary<string, Point>>();
            //converting the List<double> part </double> to a system.drawing.point
            //to get valid coordinates for the drawing of the rectangle 
            foreach (var person in deContent)
            {   // new Dictionary for each Person
                Dictionary<string, Point> parts = new Dictionary<string, Point>();
                foreach (var part in person)
                {       
                    parts.Add(part.Key, ToPoint(part.Value));
                }
                coordinats.Add(parts);
            }
            return coordinats;
            #endregion
        }
        /// <summary>
        /// Method to convert the list<double> to point 
        /// converting to PointF doesn't make any sense, because we need int points to draw the rectangle later
        /// </summary>
        /// <param name="part"> coordinate of the Bodypart as a List<double></param>
        /// <returns></returns>
        public   Point ToPoint(List<double> part)
        {
            Point partp = new Point();
            partp.X = (int)Math.Round((part[0]));
            partp.Y = (int)Math.Round((part[1]));
            return partp;
        }
    }
}
