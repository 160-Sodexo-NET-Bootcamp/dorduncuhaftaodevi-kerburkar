using Data.Context;
using Data.Generic;
using Entity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    //Vehicle için repository eklendi. GenericRepository miras verildi.
    public class TechnicalErrorRepository : GenericRepository<TechnicalError>, ITechnicalErrorRepository
    {
        public TechnicalErrorRepository(ApplicationDbContext context, ILogger logger) : base(context, logger)
        {
        }
    }
}
