using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangfireSchedule.Jobs
{
    public static class TechnicalErrorJob
    {
        public static void TechnicalErrorDataOperation()
        {
            RecurringJob.AddOrUpdate<TechnicalErrorJobManager>(nameof(TechnicalErrorJobManager), job => job.DoJob(), Cron.Minutely);
        }
    }
}
