using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Smm.ContohCQRSNoEventSourcing.Ddd.Events;
using Smm.ContohCQRSNoEventSourcing.Domain;
using Smm.ContohCQRSNoEventSourcing.Domain.EnumInEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smm.ContohCQRSNoEventSourcing.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // please. you want input one by one or assembly
            builder.Ignore<DomaintEvent>();
            //  builder.ApplyConfiguration(new DataKonsumenConfiguration());
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);//test pakai ini

        }

        public DbSet<DataKonsumen> DataKonsumen { get; set; }
        public DbSet<JenisKelamin> JenisKelamin { get; set; }
        public DbSet<Agama> Agama { get; set; }
    }
}
