using Czapla.Abstract;
using Czapla.Controllers;
using Drzewo;
using Drzewo.Model.LeagueOfLegends.Standard;
using FluentScheduler;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Czapla.Tasks.LeagueOfLegends.Standard
{
    public class GetItemsTask : RequestTask, IJob
    {
        public async void Execute()
        {
            try
            {
                Program.MainLogger.AddMessage("GetItemsTask - attempt to start ");
                var data = MakeRequestAndGetResponse($@"http://ddragon.leagueoflegends.com/cdn/{Configuration.CurrentDataDragonVersion}/data/en_US/item.json");
                var converted = EntityController.SerializeJsonAndWrapToEntity<StandardItems>(data, "item");
                await MongoController.Instance.InsertSingletonDocument("LeagueOfLegends", "Standard", "item", converted); Program.MainLogger.AddMessage("GetItemsTask - finished");
            }catch(Exception ex)
            {
                Program.MainLogger.AddMessage(ex.StackTrace);
            }
        }
    }
}
