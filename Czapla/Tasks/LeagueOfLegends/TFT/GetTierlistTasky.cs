using Czapla.Abstract;
using Drzewo;
using FluentScheduler;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Czapla.Tasks.LeagueOfLegends.TFT
{
    public class GetTierlistTask : RequestTask, IJob
    {
        public async void Execute()
        {
            Program.MainLogger.AddMessage("GetTierlist - attempt to start ");
            var data = requestController.MakeRequest("https://solomid-resources.s3.amazonaws.com/blitz/tft/data/tierlist.json");
            MongoController ctr = new MongoController();
            await ctr.InsertSingletonDocument("LeagueOfLegends", "TFT", "tierlist", data);
            Program.MainLogger.AddMessage("GetTierlist - finished");
        }
    }
}
