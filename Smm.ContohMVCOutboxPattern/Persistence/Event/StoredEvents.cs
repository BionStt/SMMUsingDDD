using Microsoft.EntityFrameworkCore;
using Smm.ContohMVCOutboxPattern.DDD.EventDomainEntity;
using Smm.ContohMVCOutboxPattern.DDD.Events;
using Smm.ContohMVCOutboxPattern.Domain.Interfaces;
using Smm.ContohMVCOutboxPattern.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Smm.ContohMVCOutboxPattern.Persistence.Event
{
    public class StoredEvents : IStoredEvents
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IUser _user;
        public StoredEvents(ApplicationDbContext dbContext, IUser user)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _user=user;
        }

        public async Task<IReadOnlyCollection<StoredEvent>> FetchUnprocessed(int batchSize, CancellationToken cancellationToken)
        {
            var result = await _dbContext.StoredEvent.Where(x => x.ProcessedAt == null).OrderBy(m => m.CreatedAt).Take(batchSize).ToArrayAsync(cancellationToken);

            return result.ToImmutableArray();
        }

        //public void Save<T>(T theEvent) where T : DomaintEvent
        //{
        //    var serializedData = JsonSerializer.Serialize(theEvent);

        //    var storedEvent = new StoredEvent(
        //        theEvent,
        //        serializedData,
        //        _user.Name);

        //    _dbContext.StoredEvents
        //    _eventStoreRepository.Store(storedEvent);
        //}

        public async Task SaveEvent<T>(T theEvent) where T : DomaintEvent
        {
            var serializedData = JsonSerializer.Serialize(theEvent);
          
            var storedEvent = new StoredEvent(
                theEvent,
                serializedData,
                _user.Name);

            await _dbContext.StoredEvent.AddAsync(storedEvent);
            await _dbContext.SaveChangesAsync();

           // _eventStoreRepository.Store(storedEvent);
        }

        //public async Task UpdateProcessedAt(StoredEvent message)
        //{
            
        //    await _dbContext.StoredEvent.Update(message);

        //    await _dbContext.SaveChangesAsync();
        
        //}

        //public void UpdateProcessedAt(StoredEvent message)
        //{
        //    _dbContext.StoredEvent.Update(message);
        //}

        //public async Task StoreRange(List<StoredEvent> messages)
        //{
        //    await _dbContext.StoredEvent.AddRangeAsync(messages);
        //}

        //public async Task<IList<StoredEvent>> GetByAggregateId(Guid aggregateId, CancellationToken cancellationToken)
        //{
        //    var results = await _dbContext.StoredEvent
        //        .Where(c => c.AggregateId == aggregateId)
        //        .OrderBy(m => m.CreatedAt)
        //        .ToListAsync(cancellationToken);

        //    return results;
        //}

        //public async Task<IReadOnlyCollection<StoredEvent>> FetchUnprocessed(int batchSize, CancellationToken cancellationToken)
        //{
        //    var results = await _dbContext.StoredEvent
        //        .Where(m => null == m.ProcessedAt)
        //        .OrderBy(m => m.CreatedAt)
        //        .Take(batchSize)
        //        .ToArrayAsync(cancellationToken);

        //    return results.ToImmutableArray();
        //}
    }
}
