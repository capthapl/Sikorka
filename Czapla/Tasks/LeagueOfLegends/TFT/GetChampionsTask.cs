using Drzewo;
using Quartz;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Czapla.Tasks.LeagueOfLegends.TFT
{
    public class GetChampionsTask : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            Program.MainLogger.AddMessage("GetChampionsTask - attempt to start ");
            var client = new RestClient("https://solomid-resources.s3.amazonaws.com/blitz/tft/data/champions.json");
            var data = client.Execute(new RestRequest());
            MongoController ctr = new MongoController();
            if (data.StatusCode == System.Net.HttpStatusCode.OK)
            {
                ctr.InsertSingletonDocument("LeagueOfLegends", "TFT", "champions", data.Content);
                Program.MainLogger.AddMessage("GetChampionsTask - request response ok");
                return;
            }
            Program.MainLogger.AddMessage("GetChampionsTask - request response bad");
            return;
        }
    }
}
