using Microsoft.EntityFrameworkCore;
using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SMM.Infrastructure.Domain
{
    public abstract class UnitOfWork<TDB> : IUnitOfWork where TDB: DbContext
    {

        protected readonly TDB DbContext;

        protected UnitOfWork(TDB dbContext)
        {
            DbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<bool> CommitAsync(CancellationToken cancellationToken = default)
        {
            return await DbContext.SaveChangesAsync(cancellationToken) > 0;

        }



    }
}
