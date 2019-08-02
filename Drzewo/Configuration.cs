using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Drzewo
{
    public static class Configuration
    {
        public const string MongoConnectionString = "mongodb://rekurencja:hermetyzacj4!@localhost:27017";

        public static T DeserializeJson<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}