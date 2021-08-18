﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMM.Domain;

namespace SMM.Infrastructure.Database.Configurations.DataSPK
{
    public class DataSPKLeasingConfiguration : IEntityTypeConfiguration<DataSPKLeasing>
    {
        public void Configure(EntityTypeBuilder<DataSPKLeasing> builder)
        {
            builder.ToTable("DataSPKLeasing");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Angsuran).HasColumnType("money");
            builder.Property(e => e.Mediator).HasMaxLength(30).IsUnicode(false);
            builder.Property(e => e.NamaCmo).HasMaxLength(30).IsUnicode(false);
            //   builder.Property(e => e.NamaSales);
            builder.Property(e => e.TanggalSurvei).HasColumnType("datetime").HasDefaultValueSql("GetUtcDate()");



        }
    }
}
