﻿using Czapla.Abstract;
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
    public class GetTFTTierlistTask : RequestTask, IJob
    {
        public async void Execute()
        {
            try
            {
                Program.MainLogger.AddMessage("GetTFTTierlist - attempt to start ");
                var data = MakeRequestAndGetResponse("https://solomid-resources.s3.amazonaws.com/blitz/tft/data/tierlist.json");
                var converted = EntityController.SerializeJsonAndWrapToEntity<TftTierList>(data, "tierlist");
                await MongoController.Instance.InsertSingletonDocument("LeagueOfLegends", "TFT", "tierlist", converted);
                Program.MainLogger.AddMessage("GetTFTTierlist - finished");
            }
            catch (Exception ex)
            {
                Program.MainLogger.AddMessage(ex.StackTrace);
            }
        }
    }
}
