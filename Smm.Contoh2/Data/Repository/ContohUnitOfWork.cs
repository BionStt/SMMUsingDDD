using Smm.Contoh2.Domain;
using Smm.ContohMVC.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.Contoh2.Data.Repository
{
    public class ContohUnitOfWork : UnitOfWork<ApplicationDbContext>, IContohUnitOfWork
    {
        public ContohUnitOfWork(ApplicationDbContext dbContext, IDataKonsumenRepository dataKonsumenRepository, IAgamaRepository agamaRepository, IJenisKelaminRepository jenisKelaminRepository)
            : base(dbContext)
        {
            DataKonsumenRepository = dataKonsumenRepository;
            AgamaRepository = agamaRepository;
            JenisKelaminRepository = jenisKelaminRepository;
        }
        public IDataKonsumenRepository DataKonsumenRepository { get; }

        public IAgamaRepository AgamaRepository { get; }

        public IJenisKelaminRepository JenisKelaminRepository { get; }
    }
}
