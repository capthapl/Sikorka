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
    public class GetTFTOriginsTask : RequestTask, IJob
    {
        public async void Execute()
        {
            try
            {
                Program.MainLogger.AddMessage("GetTFTOrigins - attempt to start ");
                var data = MakeRequestAndGetResponse("https://solomid-resources.s3.amazonaws.com/blitz/tft/data/origins.json");
                var converted = EntityController.SerializeJsonAndWrapToEntity<Dictionary<string,TftOrigins>>(data, "origins");
                await MongoController.Instance.InsertSingletonDocument("LeagueOfLegends", "TFT", "origins", converted);
                Program.MainLogger.AddMessage("GetTFTOrigins - finished");
            }
            catch (Exception ex)
            {
                Program.MainLogger.AddMessage(ex.StackTrace);
            }
        }
    }
}
