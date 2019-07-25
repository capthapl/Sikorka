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
    public class GetChampionsTask : RequestTask, IJob
    {
        public async void Execute()
        {
            Program.MainLogger.AddMessage("GetChampionsTask - attempt to start ");
            var data = requestController.MakeRequest($@"http://ddragon.leagueoflegends.com/cdn/{Configuration.CurrentDataDragonVersion}/data/en_US/champion.json");
            MongoController ctr = new MongoController();
            await ctr.InsertSingletonDocument("LeagueOfLegends", "Standard", "champion", data);
            Program.MainLogger.AddMessage("GetChampionsTask - finished");
        }
    }
}
