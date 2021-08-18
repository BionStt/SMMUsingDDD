﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SMM.Domain.MasterBarang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Infrastructure.Database.Configurations
{
    public class MasterBarangConfiguration : IEntityTypeConfiguration<MasterBarang>
    {
        public void Configure(EntityTypeBuilder<MasterBarang> builder)
        {
            builder.ToTable("MasterBarang");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.NamaBarang).IsUnicode(false).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.NomorRangka).IsUnicode(false).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.NomorMesin).IsUnicode(false).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.Merek).IsUnicode(false).HasMaxLength(20).IsUnicode(false);
            builder.Property(e => e.KapasitasMesin).IsUnicode(false).HasMaxLength(5).IsUnicode(false);
            builder.Property(e => e.HargaOff).HasColumnType("money");
            builder.Property(e => e.Bbn).HasColumnType("money");
            builder.Property(e => e.TahunPerakitan).HasMaxLength(5).IsUnicode(false);
            builder.Property(e => e.TypeKendaraan).IsUnicode(false).HasMaxLength(50).IsUnicode(false);

            var converterStatus = new EnumToStringConverter<MasterBarangStatus>();
            builder.Property(e => e.MasterBarangStatus).HasConversion(converterStatus);



        }
    }
}
