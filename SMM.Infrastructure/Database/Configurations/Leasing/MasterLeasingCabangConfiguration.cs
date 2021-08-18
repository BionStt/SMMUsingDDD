﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SMM.Domain;

namespace SMM.Infrastructure.Database.Configurations.Leasing
{
    public class MasterLeasingCabangConfiguration : IEntityTypeConfiguration<MasterLeasingCabang>
    {
        public void Configure(EntityTypeBuilder<MasterLeasingCabang> builder)
        {
            builder.ToTable("MasterLeasingCabang");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.NamaCabang).HasMaxLength(50);
            builder.Property(e => e.EmailCabang).HasMaxLength(50);

            var converterStatus = new EnumToStringConverter<LeasingCabangStatus>();
            builder.Property(e => e.Status).HasConversion(converterStatus);

            builder.OwnsOne(o => o.AlamatCabangLeasing, a => {
                a.WithOwner();
                a.Property(a => a.Jalan).HasMaxLength(200);
                a.Property(a => a.Kelurahan).HasMaxLength(50);
                a.Property(a => a.Kecamatan).HasMaxLength(50);
                a.Property(a => a.Kota).HasMaxLength(50);
                a.Property(a => a.Propinsi).HasMaxLength(50);
                a.Property(a => a.KodePos).HasMaxLength(7);
                a.Property(a => a.NoTelepon).HasMaxLength(20);
                a.Property(a => a.NoFax).HasMaxLength(20);
                a.Property(a => a.NoHandphone).HasMaxLength(20);
            });

        }
    }
}
