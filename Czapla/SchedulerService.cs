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
            Schedule<LogTask>().ToRunEvery(5).Seconds();
            Schedule<GetChampionsTask>().ToRunEvery(6).Hours();
            Schedule<GetClassesTask>().ToRunEvery(6).Hours();
            Schedule<GetItemsTask>().ToRunEvery(6).Hours();
            Schedule<GetOriginsTask>().ToRunEvery(6).Hours();
            Schedule<GetTierlistTask>().ToRunEvery(6).Hours();

        }
    }
}
