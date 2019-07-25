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
    public class GetTFTItemsTask : RequestTask, IJob
    {
        public async void Execute()
        {
            Program.MainLogger.AddMessage("GetTFTItems - attempt to start ");
            var data = requestController.MakeRequest("https://solomid-resources.s3.amazonaws.com/blitz/tft/data/items.json");
            MongoController ctr = new MongoController();
            await ctr.InsertSingletonDocument("LeagueOfLegends", "TFT", "items", data);
            Program.MainLogger.AddMessage("GetTFTItems - finished");
        }
    }
}
