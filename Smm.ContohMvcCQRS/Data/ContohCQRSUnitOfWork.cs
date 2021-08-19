using Smm.ContohMvcCQRS.Data.Events;
using Smm.ContohMvcCQRS.Ddd;
using Smm.ContohMvcCQRS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Smm.ContohMvcCQRS.Data
{
    public class ContohCQRSUnitOfWork : UnitOfWork<ApplicationDbContext>, IContohCQRSUnitOfWork
    {
        public ContohCQRSUnitOfWork(ApplicationDbContext dbContext, IDataKonsumen customers) : base(dbContext)
        {
            Customers = customers;
        }

        public IDataKonsumen Customers { get; }

        public IStoredEvents StoredEvents { get; }

        private readonly IEventSerializer _eventSerializer;


        protected async override Task StoreEvents(CancellationToken cancellationToken)
        {
            var entities = DbContext.ChangeTracker.Entries()
                  .Where(e => e.Entity is IAggregateRoot c && c.DomainEvents != null)
                  .Select(e => e.Entity as IAggregateRoot)
                  .ToArray();

            foreach (var entity in entities)
            {
                var messages = entity.DomainEvents
                    .Select(e =>
                    StoredEventHelper.BuildFromDomainEvent(e as Event, _eventSerializer)).ToArray();

                entity.ClearDomainEvents();
                await DbContext.AddRangeAsync(messages, cancellationToken);
            }
        }
    }
}
