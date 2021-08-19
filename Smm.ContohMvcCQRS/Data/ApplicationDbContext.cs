using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Smm.ContohMvcCQRS.Ddd;
using Smm.ContohMvcCQRS.Domain;
using Smm.ContohMvcCQRS.Domain.EnumInEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smm.ContohMvcCQRS.Data
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
            builder.Ignore<Event>();
            //  builder.ApplyConfiguration(new DataKonsumenConfiguration());
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);//test pakai ini

        }
        public DbSet<StoredEvent> StoredEvents { get; set; }

        public DbSet<DataKonsumen> DataKonsumen { get; set; }
        public DbSet<JenisKelamin> JenisKelamin { get; set; }
        public DbSet<Agama> Agama { get; set; }



    }
}
