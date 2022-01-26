
using Data.UOW;
using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangfireSchedule.Jobs
{
    public class TechnicalErrorInsertManager
    {
        private readonly IUnitOfWork _unitOfWork;
        public TechnicalErrorInsertManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;           
        }

        
        public async Task DataInsertJob()
        {
            //Son kaydın Id'si alınarak ve +1 eklenerek ErrorDescription ve ErrorName'e üretmek de kullanılıyor. Hiç kayıt yok ise Id=1 olarak alınıyor.
            var maxId = 1;
            var allRecord = await _unitOfWork.TechnicalError.GetAll();
            if (allRecord.Count() > 0)
            {
                var lastRecord = allRecord.Last();
                maxId = lastRecord != null ? lastRecord.Id : maxId;
            }
            //Oluşan nesne kaydediliyor.
            await _unitOfWork.TechnicalError.Add(new Entity.TechnicalError()
            {
                ErrorName = "Deneme Hatası "+(maxId+1),
                ErrorDescription = "Deneme Hatası Açıklaması "+(maxId+1),
                ErrorDate = DateTime.Now,
                CreateUser = "User",
                StatusId = Entity.TechnicalStatus.Open,
            });
            _unitOfWork.Complete();
        }

    }
}
