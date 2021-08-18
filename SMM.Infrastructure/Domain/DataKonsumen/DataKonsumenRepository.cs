using SMM.Domain.DataKonsumen;
using SMM.Infrastructure.Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SMM.Infrastructure.Domain.DataKonsumen
{
    public class DataKonsumenRepository : IDataKonsumenRepository
    {

        private readonly SMMDDDContext _dbContext;


        public DataKonsumenRepository(SMMDDDContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentException(nameof(dbContext));
        }

        public async Task Add(SMM.Domain.DataKonsumen.DataKonsumen dataKonsumen, CancellationToken cancellationToken = default)
        {
              await _dbContext.DataKonsumens.AddAsync(dataKonsumen,cancellationToken);
        }

        public async Task<List<SMM.Domain.DataKonsumen.DataKonsumen>> GetAllCustomerAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.DataKonsumens.ToListAsync();

        }

        public async Task<SMM.Domain.DataKonsumen.DataKonsumen> GetByEmailAsync(string email, CancellationToken cancellationToken = default)
        {
            return await _dbContext.DataKonsumens.Where(c => c.Email == email).FirstOrDefaultAsync(cancellationToken);

        }

        public async Task<SMM.Domain.DataKonsumen.DataKonsumen> GetByIdAsync(Guid dataKonsumenId, CancellationToken cancellationToken = default)
        {
            return  await _dbContext.DataKonsumens
                .Where(c => c.Id == dataKonsumenId)
                .FirstOrDefaultAsync(cancellationToken);

        }
    }
}
