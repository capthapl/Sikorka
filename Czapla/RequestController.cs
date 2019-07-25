using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Czapla
{
    public class RequestController
    {
        public string MakeRequest(string url)
        {
            var client = new RestClient(url);
            var data = client.Execute(new RestRequest());
            if (data.StatusCode == System.Net.HttpStatusCode.OK)
                return data.Content;
            else throw new Exception("Request returned not ok response code");
        }
    }
}
