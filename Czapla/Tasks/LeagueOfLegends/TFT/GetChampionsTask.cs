﻿using Drzewo;
using FluentScheduler;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Czapla.Tasks.LeagueOfLegends.TFT
{
    public class GetChampionsTask : IJob
    {
        public async void Execute()
        {
            Program.MainLogger.AddMessage("GetChampionsTask - attempt to start ");
            var data = RequestController.MakeRequest("https://solomid-resources.s3.amazonaws.com/blitz/tft/data/champions.json");
            MongoController ctr = new MongoController();
            await ctr.InsertSingletonDocument("LeagueOfLegends", "TFT", "champions", data);
        }
    }
}
