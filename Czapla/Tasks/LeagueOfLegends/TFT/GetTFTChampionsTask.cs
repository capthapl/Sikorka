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
    public class GetTFTChampionsTask : RequestTask, IJob
    {
        public async void Execute()
        {
            Program.MainLogger.AddMessage("GetTFTChampionsTask - attempt to start ");
            var data = requestController.MakeRequest("https://solomid-resources.s3.amazonaws.com/blitz/tft/data/champions.json");
            MongoController ctr = new MongoController();
            await ctr.InsertSingletonDocument("LeagueOfLegends", "TFT", "champions", data);
            Program.MainLogger.AddMessage("GetTFTChampionsTask - finished");
        }
    }
}
