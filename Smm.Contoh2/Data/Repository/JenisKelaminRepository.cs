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

namespace Smm.ContohMVC.Data.Repository
{
    public class JenisKelaminRepository: IJenisKelaminRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public JenisKelaminRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IReadOnlyList<JenisKelaminDto>> GetAllJenisKelaminAsync<JenisKelaminDto>(Expression<Func<JenisKelamin, JenisKelaminDto>> selector, CancellationToken cancellationToken = default)
        {
            var aa = await _dbContext.JenisKelamin.AsNoTracking().Select(selector).ToListAsync();
            return aa;
        }


    }
}
