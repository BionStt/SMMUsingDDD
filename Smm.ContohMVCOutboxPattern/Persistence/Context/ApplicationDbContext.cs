using Microsoft.EntityFrameworkCore;
using Smm.ContohMVCOutboxPattern.DDD.EventDomainEntity;
using Smm.ContohMVCOutboxPattern.DDD.Events;
using Smm.ContohMVCOutboxPattern.DDD.OutboxPattern;
using Smm.ContohMVCOutboxPattern.Domain;
using Smm.ContohMVCOutboxPattern.Domain.EnumInEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMVCOutboxPattern.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
       // private readonly IEventSerializer _eventSerializer;
       //public IStoredEvents StoredEvents { get; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //public ApplicationDbContext(IEventSerializer eventSerializer, IStoredEvents storedEvents)
        //{
        //    _eventSerializer=eventSerializer;
        //    StoredEvents=storedEvents;
        //}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // please. you want input one by one or assembly
            builder.Ignore<DomaintEvent>();
            //  builder.ApplyConfiguration(new DataKonsumenConfiguration());
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);//test pakai ini


        }

        public DbSet<StoredEvent> StoredEvent { get; set; }
        public DbSet<OutboxMessageEntity> OutboxMessages { get; set; }
        public DbSet<DataKonsumen> DataKonsumen { get; set; }
        public DbSet<JenisKelamin> JenisKelamin { get; set; }
        public DbSet<Agama> Agama { get; set; }


    }
}
