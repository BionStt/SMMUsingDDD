using Smm.Contoh.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Smm.Contoh.Data.Repository
{
    public class DataKonsumenRepository : IDataKonsumenRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public DataKonsumenRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentException(nameof(dbContext));
        }

        public async Task AddAsync(DataKonsumen dataKonsumen, CancellationToken cancellationToken = default)
        {
            await _dbContext.DataKonsumen.AddAsync(dataKonsumen, cancellationToken);
        }

        public async Task<List<DataKonsumen>> GetAllCustomerAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.DataKonsumen.ToListAsync();
        }

        public async Task<DataKonsumen> GetByEmailAsync(string email, CancellationToken cancellationToken = default)
        {
            return await _dbContext.DataKonsumen
                .Where(c => c.Email == email)
                .FirstOrDefaultAsync(cancellationToken);

        }

        public async Task<DataKonsumen> GetByIdAsync(Guid dataKonsumenId, CancellationToken cancellationToken = default)
        {
            return await _dbContext.DataKonsumen
                 .Where(c => c.Id == dataKonsumenId)
                 .FirstOrDefaultAsync(cancellationToken);
        }
    }
}
