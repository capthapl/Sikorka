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
    public class GetChampionsTask : RequestTask, IJob
    {
        public async void Execute()
        {
            try { 
                Program.MainLogger.AddMessage("GetChampionsTask - attempt to start ");
                var data = MakeRequestAndGetResponse($@"http://ddragon.leagueoflegends.com/cdn/{Configuration.CurrentDataDragonVersion}/data/en_US/champion.json");
                var converted = EntityController.SerializeJsonAndWrapToEntity<StandardChampions>(data, "champion");
                await MongoController.Instance.InsertSingletonDocument("LeagueOfLegends", "Standard", "champion", converted);
                Program.MainLogger.AddMessage("GetChampionsTask - finished");
            }
            catch (Exception ex)
            {
                Program.MainLogger.AddMessage(ex.StackTrace);
            }
        }
    }
}
