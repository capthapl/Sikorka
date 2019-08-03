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
    public class GetTFTClassesTask : RequestTask, IJob
    {
        public async void Execute()
        {
            try
            {
                Program.MainLogger.AddMessage("GetTFTClassesTask - attempt to start ");
                var data = MakeRequestAndGetResponse("https://solomid-resources.s3.amazonaws.com/blitz/tft/data/classes.json");
                var converted = EntityController.SerializeJsonAndWrapToEntity<TftClasses>(data, "classes");
                await MongoController.Instance.InsertSingletonDocument("LeagueOfLegends", "TFT", "classes", converted);
                Program.MainLogger.AddMessage("GetTFTClassesTask - finished");
            }
            catch (Exception ex)
            {
                Program.MainLogger.AddMessage(ex.StackTrace);
            }
        }
    }
}
