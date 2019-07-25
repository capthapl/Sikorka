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
            Schedule<GetTFTChampionsTask>().ToRunNow().AndEvery(5).Hours();
            Schedule<GetTFTClassesTask>().ToRunNow().AndEvery(5).Hours();
            Schedule<GetTFTItemsTask>().ToRunNow().AndEvery(5).Hours();
            Schedule<GetTFTOriginsTask>().ToRunNow().AndEvery(5).Hours();
            Schedule<GetTFTTierlistTask>().ToRunNow().AndEvery(5).Hours();
            Schedule<GetProfileIconsTask>().ToRunNow().AndEvery(5).Hours();
            Schedule<GetChampionsTask>().ToRunNow().AndEvery(5).Hours();
            Schedule<GetItemsTask>().ToRunNow().AndEvery(5).Hours();
            Schedule<GetMasteriesTask>().ToRunNow().AndEvery(5).Hours();
            Schedule<GetRunesTask>().ToRunNow().AndEvery(5).Hours();
            Schedule<GetSummonerSpellsTask>().ToRunNow().AndEvery(5).Hours();

        }
    }
}
