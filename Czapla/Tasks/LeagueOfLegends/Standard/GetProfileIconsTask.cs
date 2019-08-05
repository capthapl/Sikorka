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
    public class GetProfileIconsTask : RequestTask, IJob
    {
        public async void Execute()
        {
            try
            {
                Program.MainLogger.AddMessage("GetProfileIconsTask - attempt to start ");
                var data = MakeRequestAndGetResponse($@"http://ddragon.leagueoflegends.com/cdn/{Configuration.CurrentDataDragonVersion}/data/en_US/profileicon.json");
                var converted = EntityController.SerializeJsonAndWrapToEntity<StandardProfileIcon>(data, "profileicon");
                await MongoController.Instance.InsertSingletonDocument("LeagueOfLegends", "Standard", "profileicon", converted);
                Program.MainLogger.AddMessage("GetProfileIconsTask - finished");
            }
            catch (Exception ex)
            {
                Program.MainLogger.AddMessage(ex.StackTrace);
            }
        }
    }
}
