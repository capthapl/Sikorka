
using FluentScheduler;
using System;
using System.Collections.Specialized;
using System.Threading;
using System.Threading.Tasks;

namespace Czapla
{
    class Program 
    {
        public static Logger MainLogger;
        static void Main(string[] args)
        {
            MainLogger = new Logger("MainLogs");
            MainLogger.AddMessage("Scheduler started");
            RunScheduler().GetAwaiter().GetResult();

            do
            {
                Thread.Sleep(5);
            } while (true);
        }

        private async static Task RunScheduler()
        {
            try
            {
                SchedulerService service = new SchedulerService();
                JobManager.Initialize(service);
            }
            catch (Exception ex)
            {
                MainLogger.AddMessage(ex.ToString());
                await Console.Error.WriteLineAsync(ex.ToString());
            }
        }
    }
}

