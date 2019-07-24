using Quartz;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Czapla.Tasks
{
    public class LogTask : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
           await Program.MainLogger.Log();
        }
    }
}
