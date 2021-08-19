using Microsoft.EntityFrameworkCore;
using Smm.ContohMvcCQRS.Domain;
using Smm.ContohMvcCQRS.ServiceApplication.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Smm.ContohMvcCQRS.Data.Repository
{
    public class DataKonsumenRepository : IDataKonsumen
    {
        private readonly ApplicationDbContext _dbContext;

        public DataKonsumenRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(DataKonsumen dataKonsumen, CancellationToken cancellationToken = default)
        {
            await _dbContext.DataKonsumen.AddAsync(dataKonsumen, cancellationToken);
        }

        public async Task<IReadOnlyList<DataKonsumen>> GetAllCustomerAsync(CancellationToken cancellationToken = default)
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

        public async Task<IReadOnlyList<ListDataKonsumenDto>> ListDataKonsumenAsync(Expression<Func<DataKonsumen, ListDataKonsumenDto>> listDataKonsumenSelector, CancellationToken cancellationToken = default)
        {
            return await _dbContext.DataKonsumen.Select(listDataKonsumenSelector).ToListAsync();
        }
    }
}
