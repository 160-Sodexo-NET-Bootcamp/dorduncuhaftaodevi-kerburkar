using Data.Context;
using Data.Generic;
using Entity;
using Microsoft.EntityFrameworkCore;
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
        public TechnicalErrorRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<List<TechnicalError>> GetAllOpenErrors()
        {
            var result = await context.TechnicalErrors.Where(q => q.StatusId == TechnicalStatus.Open).ToListAsync();
            return result;
        }
    }
}
