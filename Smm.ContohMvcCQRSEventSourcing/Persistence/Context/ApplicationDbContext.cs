using Microsoft.EntityFrameworkCore;
using Smm.ContohMvcCQRSEventSourcing.DDD;
using Smm.ContohMvcCQRSEventSourcing.DDD.EventDomain;
using Smm.ContohMvcCQRSEventSourcing.DDD.Events;
using Smm.ContohMvcCQRSEventSourcing.Domain;
using Smm.ContohMvcCQRSEventSourcing.Domain.EnumInEntity;
using Smm.ContohMvcCQRSEventSourcing.Persistence.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Smm.ContohMvcCQRSEventSourcing.Persistence.Context
{
    public class ApplicationDbContext: DbContext
    {
        private readonly IEventSerializer _eventSerializer;
        public IStoredEvents StoredEvents { get; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public ApplicationDbContext(IEventSerializer eventSerializer, IStoredEvents storedEvents)
        {
            _eventSerializer=eventSerializer;
            StoredEvents=storedEvents;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // please. you want input one by one or assembly
            builder.Ignore<DomaintEvent>();
            //  builder.ApplyConfiguration(new DataKonsumenConfiguration());
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);//test pakai ini

        }
        public DbSet<StoredEvent> StoredEvent { get; set; }

        public DbSet<DataKonsumen> DataKonsumen { get; set; }
        public DbSet<JenisKelamin> JenisKelamin { get; set; }
        public DbSet<Agama> Agama { get; set; }

        //public override  int SaveChanges()
        //{
        //    var entities = this.ChangeTracker.Entries()
        //         .Where(e => e.Entity is IAggregateRoot c && c.DomainEvents != null)
        //         .Select(e => e.Entity as IAggregateRoot)
        //         .ToArray();

        //    foreach (var entity in entities)
        //    {
        //        var messages = entity.DomainEvents
        //            .Select(e =>
        //            StoredEventHelper.BuildFromDomainEvent(e as DomaintEvent, _eventSerializer)).ToArray();

        //        entity.ClearDomainEvents();
        //         this.AddRangeAsync(messages);
        //    }


        //    return base.SaveChanges();

        //}

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entities = this.ChangeTracker.Entries()
                            .Where(e => e.Entity is IAggregateRoot c && c.DomainEvents != null)
                            .Select(e => e.Entity as IAggregateRoot)
                            .ToArray();

            foreach (var entity in entities)
            {
                var messages = entity.DomainEvents
                    .Select(e =>
                    StoredEventHelper.BuildFromDomainEvent(e as DomaintEvent, _eventSerializer)).ToArray();

                entity.ClearDomainEvents();
                this.AddRangeAsync(messages);
            }


            return base.SaveChangesAsync();

        }

    }
}
