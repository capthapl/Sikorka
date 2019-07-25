using FluentScheduler;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Czapla.Tasks
{
    public class LogTask : IJob
    {
        public async void Execute()
        {
            await Program.MainLogger.Log();
        }
    }
}
