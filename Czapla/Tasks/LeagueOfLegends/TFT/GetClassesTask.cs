using Drzewo;
using FluentScheduler;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Czapla.Tasks.LeagueOfLegends.TFT
{
    public class GetClassesTask : IJob
    {
        public void Execute()
        {
            Program.MainLogger.AddMessage("GetClassesTask - attempt to start ");
            var client = new RestClient("https://solomid-resources.s3.amazonaws.com/blitz/tft/data/classes.json");
            var data = client.Execute(new RestRequest());
            MongoController ctr = new MongoController();
            if (data.StatusCode == System.Net.HttpStatusCode.OK)
            {
                ctr.InsertSingletonDocument("LeagueOfLegends", "TFT", "classes", data.Content);
                Program.MainLogger.AddMessage("GetClassesTask - request response ok");
                return;
            }
            Program.MainLogger.AddMessage("GetClassesTask - request response bad");
            return;
        }
    }
}
