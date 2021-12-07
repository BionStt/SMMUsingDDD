using Microsoft.EntityFrameworkCore;
using Smm.ContohMVCOutboxPattern.DDD.EventDomainEntity;
using Smm.ContohMVCOutboxPattern.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMVCOutboxPattern.Persistence.Event
{
    public class StoredEvents : IStoredEvents
    {
        private readonly ApplicationDbContext _dbContext;

        public StoredEvents(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public void UpdateProcessedAt(StoredEvent message)
        {
            _dbContext.StoredEvent.Update(message);
        }

        public async Task StoreRange(List<StoredEvent> messages)
        {
            await _dbContext.StoredEvent.AddRangeAsync(messages);
        }

        public async Task<IList<StoredEvent>> GetByAggregateId(Guid aggregateId, CancellationToken cancellationToken)
        {
            var results = await _dbContext.StoredEvent
                .Where(c => c.AggregateId == aggregateId)
                .OrderBy(m => m.CreatedAt)
                .ToListAsync(cancellationToken);

            return results;
        }

        public async Task<IReadOnlyCollection<StoredEvent>> FetchUnprocessed(int batchSize, CancellationToken cancellationToken)
        {
            var results = await _dbContext.StoredEvent
                .Where(m => null == m.ProcessedAt)
                .OrderBy(m => m.CreatedAt)
                .Take(batchSize)
                .ToArrayAsync(cancellationToken);

            return results.ToImmutableArray();
        }
    }
}
