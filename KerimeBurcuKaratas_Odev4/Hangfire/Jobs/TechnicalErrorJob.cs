
using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangfireSchedule.Jobs
{
    public class TechnicalErrorJob
    {
        public TechnicalErrorJob()
        {
            RecurringJob.AddOrUpdate(() => DoJob(), Cron.Minutely);
        }

        public void DoJob()
        {
            System.Console.WriteLine("Deneme");
        }
    }
}
