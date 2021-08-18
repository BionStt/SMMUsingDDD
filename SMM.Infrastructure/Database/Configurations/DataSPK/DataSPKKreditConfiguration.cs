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
    public class DataSPKKreditConfiguration : IEntityTypeConfiguration<DataSPKKredit>
    {
        public void Configure(EntityTypeBuilder<DataSPKKredit> builder)
        {
            builder.ToTable("DataSPKKredit");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.BiayaAdministrasiKredit).HasColumnType("money");
            builder.Property(e => e.BiayaAdministrasiTunai).HasColumnType("money");
            builder.Property(e => e.BBN).HasColumnType("money");
            builder.Property(e => e.DendaWilayah).HasColumnType("money");
            builder.Property(e => e.DiskonDP).HasColumnType("money");
            builder.Property(e => e.DiskonTunai).HasColumnType("money");
            builder.Property(e => e.DPPriceList).HasColumnType("money");
            builder.Property(e => e.Komisi).HasColumnType("money");
            builder.Property(e => e.Komisi).HasColumnType("money");
            builder.Property(e => e.OffTheRoad).HasColumnType("money");
            builder.Property(e => e.Promosi).HasColumnType("money");
            builder.Property(e => e.UangTandaJadiTunai).HasColumnType("money");
            builder.Property(e => e.UangTandaJadiKredit).HasColumnType("money");




        }
    }
}

