using Data.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangfireSchedule.Jobs
{
    public class TechnicalErrorUpdateManager
    {
        private readonly IUnitOfWork _unitOfWork;
        public TechnicalErrorUpdateManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        //Status'u 1(Open) olan tüm kayıtlar çekilerek 2(Process) olarak update ediliyor.
        public async Task DataUpdateJob()
        {
            var data = await _unitOfWork.TechnicalError.GetAllOpenErrors();
            foreach (var item in data)
            {
                item.StatusId = Entity.TechnicalStatus.Process;
                await _unitOfWork.TechnicalError.Update(item);

            }
            _unitOfWork.Complete();
        }

    }
}
