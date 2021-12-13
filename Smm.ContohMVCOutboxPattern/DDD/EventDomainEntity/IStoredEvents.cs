using Smm.ContohMVCOutboxPattern.DDD.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMVCOutboxPattern.DDD.EventDomainEntity
{
    public interface IStoredEvents
    {
     //   void Save<T>(T theEvent) where T : DomaintEvent;

        Task SaveEvent<T>(T theEvent) where T : DomaintEvent;
        Task<IReadOnlyCollection<StoredEvent>> FetchUnprocessed(int batchSize, CancellationToken cancellationToken);

       // Task UpdateProcessedAt(StoredEvent message);

        //void UpdateProcessedAt(StoredEvent message);
        //Task StoreRange(List<StoredEvent> messages);
        //Task<IList<StoredEvent>> GetByAggregateId(Guid aggregateId, CancellationToken cancellationToken);
        //Task<IReadOnlyCollection<StoredEvent>> FetchUnprocessed(int batchSize, CancellationToken cancellationToken);


    }
}
