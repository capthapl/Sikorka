using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Czapla
{
    public static class RequestController
    {
        public static string MakeRequest(string url)
        {
            var client = new RestClient("https://solomid-resources.s3.amazonaws.com/blitz/tft/data/champions.json");
            var data = client.Execute(new RestRequest());
            if (data.StatusCode == System.Net.HttpStatusCode.OK)
                return data.Content;
            else throw new Exception("Request returned not ok response code");
        }
    }
}
