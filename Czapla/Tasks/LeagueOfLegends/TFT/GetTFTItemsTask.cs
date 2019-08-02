using Czapla.Abstract;
using Drzewo;
using Drzewo.Model;
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
                 Dictionary<string, TftItems> foo = Drzewo.Configuration.DeserializeJson<Dictionary<string, TftItems>>(data);
                 
                 await MongoController.Instance.InsertSingletonDocument("LeagueOfLegends", "TFT", "items", foo);
                Program.MainLogger.AddMessage("GetTFTItems - finished");
            }
            catch (Exception ex)
            {
                Program.MainLogger.AddMessage(ex.StackTrace);
            }
        }
    }
}
