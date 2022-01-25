using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{

    public interface IApplicationDbContext
    {
        //Sınıf ile veri tabanındaki tablo ilişkisi kuruldu.
        DbSet<TechnicalError> TechnicalErrors { get; set; }

        //Bu metot sorguların tamamlanmasını sağlar. 
        int SaveChanges();
    }
}
