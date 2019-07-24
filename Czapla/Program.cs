using Czapla.Tasks;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace Czapla
{
    class Program
    {
        public static Logger MainLogger;
        private static bool CloseScheduler;

        static void Main(string[] args)
        {
            CloseScheduler = false;
            MainLogger = new Logger("MainLogs");
            RunScheduler().GetAwaiter().GetResult();
            while (!CloseScheduler) { }
            MainLogger.AddMessage("Scheduler stopped");
        }

        private static async Task RunScheduler()
        {
            try
            {
                MainLogger.AddMessage("Scheduler started");
                StdSchedulerFactory factory = new StdSchedulerFactory();
                IScheduler scheduler = await factory.GetScheduler();

                await scheduler.Start();

                IJobDetail loggerJob = JobBuilder.Create<LogTask>()
                    .Build();

                ITrigger triggerLoggerJob = TriggerBuilder.Create()
                    .WithSimpleSchedule(x => x
                        .WithIntervalInSeconds(5)
                        .RepeatForever())
                    .Build();

                await scheduler.ScheduleJob(loggerJob, triggerLoggerJob);
            }
            catch (SchedulerException ex)
            {
                MainLogger.AddMessage(ex.ToString());
                await Console.Error.WriteLineAsync(ex.ToString());
            }
        }
    }
}
