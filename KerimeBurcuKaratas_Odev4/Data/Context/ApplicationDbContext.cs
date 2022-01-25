using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    //Veritabanı bağlantı sınıfı oluşturuldu.
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        //Startup'da oluşurken option parametresi gönderilecek, bu option için de bağlantı bilgisi olacak ve base'e gönderecek.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<TechnicalError> TechnicalErrors { get ; set ; }

        //base'deki SavaChange kullanması için eklendi. 
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
