using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.UOW
{
    //Repositoryleri kullanmak için interface oluşturuldu.
    public interface IUnitOfWork
    {
        ITechnicalErrorRepository TechnicalError { get; }

        int Complete();
    }
}
