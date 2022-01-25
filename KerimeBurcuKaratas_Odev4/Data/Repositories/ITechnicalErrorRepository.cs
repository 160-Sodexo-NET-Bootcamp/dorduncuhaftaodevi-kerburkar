using Data.Generic;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    //TechnicalError için Repository patern uygulandı. (GenericRepository)
    public interface ITechnicalErrorRepository : IGenericRepository<TechnicalError>
    {
    }
}
