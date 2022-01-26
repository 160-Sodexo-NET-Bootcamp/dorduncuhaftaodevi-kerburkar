using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangfireSchedule.Jobs
{
    public static class TechnicalErrorUpdateJob
    {
        //Günde bir kez 18:00 da çalışan job.
        //18:00'da çekilen fake verileri update ediyor.
        public static void TechnicalErrorUpdateOperation()
        {
            
            RecurringJob.AddOrUpdate<TechnicalErrorUpdateManager>(nameof(TechnicalErrorUpdateManager), job => job.DataUpdateJob(), "0 18 * * *", TimeZoneInfo.Local);
        }

    }
}
