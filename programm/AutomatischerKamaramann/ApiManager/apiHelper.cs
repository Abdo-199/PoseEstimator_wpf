using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace ApiManager
{
    class apiHelper
    {

        RestClient client = new RestClient("http://141.45.150.62:4713/openapi.json");
        RestResponse restResponse = new RestResponse();
        RestRequest request = new RestRequest();
        public static void getposeEstimation()
        {
        }
    }
}
