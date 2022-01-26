using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangfireSchedule.Jobs
{
    public static class TechnicalErrorInsertJob
    {
        //15 dakikada 1 kez çalışacak job.
        //her 15 dakika da 1 çalışarak veritabanına fake data insert ediyor.
        public static void TechnicalErrorInsertOperation()
        {
            RecurringJob.AddOrUpdate<TechnicalErrorInsertManager>(nameof(TechnicalErrorInsertManager), job => job.DataInsertJob(), "*/15 * * * *", TimeZoneInfo.Local);

        }

    }
}
