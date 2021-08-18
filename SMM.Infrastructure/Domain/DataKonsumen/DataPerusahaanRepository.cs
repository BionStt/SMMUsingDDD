using SMM.Domain;
using SMM.Domain.DataPerusahaan;
using SMM.Infrastructure.Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SMM.Infrastructure.Domain.DataKonsumen
{
    public class DataPerusahaanRepository: IDataPerusahaanRepository
    {
        private readonly SMMDDDContext _dbContext;

        public DataPerusahaanRepository(SMMDDDContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddDataPerusahaan(DataPerusahaan dataPerusahaan, CancellationToken cancellationToken = default)
        {
             await _dbContext.DataPerusahaan.AddAsync(dataPerusahaan);
        }

        public async Task AddDataPerusahaanCabang(DataPerusahaan dataPerusahaan, CancellationToken cancellationToken = default)
        {

            await _dbContext.DataPerusahaan.AddAsync(dataPerusahaan);
        }


    }
}
