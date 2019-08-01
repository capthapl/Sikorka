
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
            bool createdNew;
            var waitHandle = new EventWaitHandle(false, EventResetMode.AutoReset, "CF2D4313-33DE-489D-9721-6AFF69841DEA", out createdNew);
            var signaled = false;
            if (!createdNew)
            {
                waitHandle.Set();
                return;
            }

            do
            {
                signaled = waitHandle.WaitOne(TimeSpan.FromSeconds(5));
            } while (!signaled);

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

