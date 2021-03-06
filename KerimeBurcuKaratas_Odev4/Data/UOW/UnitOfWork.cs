using Data.Context;
using Data.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.UOW
{
    //Repositoryleri kullanmak için class oluşturuldu.
    public class UnitOfWork : IUnitOfWork
    {
        //Dispose ve complete işlemleri için eklendi. Constractor inject edildi. (Dependency injection)
        private readonly ApplicationDbContext _context;
        public ITechnicalErrorRepository TechnicalError { get; private set; }

        //Dependency injection için constarctor oluşturuldu.
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;

            TechnicalError = new TechnicalErrorRepository(_context);

        }

        //Bu metot sorguları tamamlamak için kullanıldı.
        public int Complete()
        {
            return _context.SaveChanges();

        }

        //Contextin serbest bırakılması için kullanıldı.
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}