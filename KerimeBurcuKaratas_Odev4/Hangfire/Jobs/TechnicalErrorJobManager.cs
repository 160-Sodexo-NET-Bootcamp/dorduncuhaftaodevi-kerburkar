
using Data.UOW;
using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangfireSchedule.Jobs
{
    public class TechnicalErrorJobManager
    {
        private readonly IUnitOfWork _unitOfWork;
        public TechnicalErrorJobManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;           
        }

        public void DoJob()
        {
            _unitOfWork.TechnicalError.Add(new Entity.TechnicalError()
            {
                ErrorName = "ABC",
                ErrorDescription = "BBBBB",
                ErrorDate = DateTime.Now,
                CreateUser = "Kerime",
                StatusId = Entity.TechnicalStatus.Open,
            });
            _unitOfWork.Complete();
            System.Console.WriteLine("Deneme");
        }
    }
}
