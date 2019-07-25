using Czapla.Tasks;
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
            Schedule<LogTask>().ToRunNow().AndEvery(5).Hours();
            Schedule<GetChampionsTask>().ToRunNow().AndEvery(5).Hours();
            Schedule<GetClassesTask>().ToRunNow().AndEvery(5).Hours();
            Schedule<GetItemsTask>().ToRunNow().AndEvery(5).Hours();
            Schedule<GetOriginsTask>().ToRunNow().AndEvery(5).Hours();
            Schedule<GetTierlistTask>().ToRunNow().AndEvery(5).Hours();

        }
    }
}
