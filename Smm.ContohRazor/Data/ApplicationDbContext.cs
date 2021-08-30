﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smm.ContohRazor.Data
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

            //  builder.ApplyConfiguration(new DataKonsumenConfiguration());
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);//test pakai ini
        }
        public DbSet<DataKonsumen> DataKonsumen { get; set; }



    }

}
