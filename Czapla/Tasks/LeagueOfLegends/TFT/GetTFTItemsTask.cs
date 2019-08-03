using Czapla.Abstract;
using Czapla.Controllers;
using Drzewo;
using Drzewo.Model;
using Drzewo.Model.LeagueOfLegends.TFT;
using FluentScheduler;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
            try
            {
                Program.MainLogger.AddMessage("GetTFTItems - attempt to start ");
                var data = MakeRequestAndGetResponse("https://solomid-resources.s3.amazonaws.com/blitz/tft/data/items.json");
                var converted = EntityController.SerializeJsonAndWrapToEntity<Dictionary<string, TftItems>>(data, "items");
                await MongoController.Instance.InsertSingletonDocument("LeagueOfLegends", "TFT", "items", converted);
                Program.MainLogger.AddMessage("GetTFTItems - finished");
            }
            catch (Exception ex)
            {
                Program.MainLogger.AddMessage(ex.StackTrace);
            }
        }
    }
}
