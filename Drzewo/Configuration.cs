using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Drzewo
{
    public static class Configuration
    {
        public const string MongoConnectionString = "mongodb://rekurencja:hermetyzacj4!@localhost:27017";

        public static void FetchConfiguration()
        {
            //here should be login for download configuration from mongodb.
            //before run any program/service config should be fetched and if failed then terminate.
            //This feature allow us to get configuration without recompile projects.
        }
    }
}