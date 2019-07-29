using Czapla.Tasks;
using Czapla.Tasks.LeagueOfLegends.Standard;
using Czapla.Tasks.LeagueOfLegends.TFT;
using FluentScheduler;
using System;
using System.Collections.Generic;
using System.Text;

namespace Czapla
{
    class SchedulerService : Registry
    {
        public SchedulerService()
        {
            Schedule<LogTask>().ToRunNow().AndEvery(5).Seconds();
            Schedule<GetTFTChampionsTask>().ToRunNow().AndEvery(5).Hours().DelayFor(5).Seconds();
            Schedule<GetTFTClassesTask>().ToRunNow().AndEvery(5).Hours().DelayFor(15).Seconds();
            Schedule<GetTFTItemsTask>().ToRunNow().AndEvery(5).Hours().DelayFor(35).Seconds();
            Schedule<GetTFTOriginsTask>().ToRunNow().AndEvery(5).Hours().DelayFor(55).Seconds();
            Schedule<GetTFTTierlistTask>().ToRunNow().AndEvery(5).Hours().DelayFor(115).Seconds();
            Schedule<GetProfileIconsTask>().ToRunNow().AndEvery(5).Hours().DelayFor(175).Seconds();
            Schedule<GetChampionsTask>().ToRunNow().AndEvery(5).Hours().DelayFor(205).Seconds();
            Schedule<GetItemsTask>().ToRunNow().AndEvery(5).Hours().DelayFor(235).Seconds();
            Schedule<GetMasteriesTask>().ToRunNow().AndEvery(5).Hours().DelayFor(255).Seconds();
            Schedule<GetRunesTask>().ToRunNow().AndEvery(5).Hours().DelayFor(315).Seconds();
            Schedule<GetSummonerSpellsTask>().ToRunNow().AndEvery(5).Hours().DelayFor(345).Seconds();
        }
    }
}
