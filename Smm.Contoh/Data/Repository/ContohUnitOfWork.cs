using Smm.Contoh.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.Contoh.Data.Repository
{
    public class ContohUnitOfWork : UnitOfWork<ApplicationDbContext>, IContohUnitOfWork
    {
        public ContohUnitOfWork(ApplicationDbContext dbContext, IDataKonsumenRepository dataKonsumenRepository)
            :base(dbContext)
        {
            DataKonsumenRepository = dataKonsumenRepository;
        }
        public IDataKonsumenRepository DataKonsumenRepository { get; }
    }
}
