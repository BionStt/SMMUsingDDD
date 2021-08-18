using Smm.Contoh2.Data;
using Smm.ContohMVC.Domain.EnumInEntity;
using Smm.ContohMVC.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Smm.ContohMVC.ServiceApplication.Dto;

namespace Smm.ContohMVC.Data.Repository
{
    public class AgamaRepository: IAgamaRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public AgamaRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IReadOnlyList<AgamaDto>> GetAllAgamaAsync<AgamaDto>(Expression<Func<Agama, AgamaDto>> selector, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Agama.AsNoTracking().Select(selector).ToListAsync();
        }
    }
}
