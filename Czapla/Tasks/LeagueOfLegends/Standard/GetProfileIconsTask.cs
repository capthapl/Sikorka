using Czapla.Abstract;
using Drzewo;
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
                await MongoController.Instance.InsertSingletonDocument("LeagueOfLegends", "Standard", "profileicon", data);
                Program.MainLogger.AddMessage("GetProfileIconsTask - finished");
            }
            catch (Exception ex)
            {
                Program.MainLogger.AddMessage(ex.StackTrace);
            }
        }
    }
}
