using MediatR;
using Smm.DomainEventMediaTR.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.DomainEventMediaTR.Data
{
    static class MediatorExtension
    {
        public static async Task DispatchDomainEventsAsync(this IMediator mediator, ApplicationDbContext ctx)
        {
            //var domainEntities = ctx.ChangeTracker
            //    .Entries<Entity>()
            //    .Where(x => x.Entity.DomainEvents != null && x.Entity.DomainEvents.Any());

            var domainEntities = ctx.ChangeTracker.Entries()
                  .Where(e => e.Entity is IAggregateRoot c && c.DomainEvents != null)
                  .Select(e => e.Entity as IAggregateRoot)
                  .ToArray();


            var domainEvents = domainEntities
                  //.SelectMany(x => x.Entity.DomainEvents)
                  .SelectMany(x => x.DomainEvents)
                .ToList();

            domainEntities.ToList()
                 //.ForEach(entity => entity.Entity.ClearDomainEvents());
                 .ForEach(entity => entity.ClearDomainEvents());

            foreach (var domainEvent in domainEvents)
                await mediator.Publish(domainEvent);


            //batas

            //var entities = DbContext.ChangeTracker.Entries()
            //       .Where(e => e.Entity is IAggregateRoot c && c.DomainEvents != null)
            //       .Select(e => e.Entity as IAggregateRoot)
            //       .ToArray();

            //foreach (var entity in entities)
            //{
            //    var messages = entity.DomainEvents
            //        .Select(e =>
            //        StoredEventHelper.BuildFromDomainEvent(e as DomainEvent, _eventSerializer)).ToArray();

            //    entity.ClearDomainEvents();
            //    await DbContext.AddRangeAsync(messages, cancellationToken);
            //}



        }
    }
}
