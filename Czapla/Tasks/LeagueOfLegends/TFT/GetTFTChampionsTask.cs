using Czapla.Abstract;
using Czapla.Controllers;
using Drzewo;
using Drzewo.Model.LeagueOfLegends.TFT;
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
            try
            {
                Program.MainLogger.AddMessage("GetTFTChampionsTask - attempt to start ");
                var data = MakeRequestAndGetResponse("https://solomid-resources.s3.amazonaws.com/blitz/tft/data/champions.json");
                var converted = EntityController.SerializeJsonAndWrapToEntity<Dictionary<string, TftChampions>>(data, "champions");
                await MongoController.Instance.InsertSingletonDocument("LeagueOfLegends", "TFT", "champions", converted);
                Program.MainLogger.AddMessage("GetTFTChampionsTask - finished");
            }
            catch (Exception ex)
            {
                Program.MainLogger.AddMessage(ex.StackTrace);
            }
        }
    }
}
