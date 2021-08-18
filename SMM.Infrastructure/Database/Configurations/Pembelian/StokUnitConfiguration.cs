using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SMM.Domain;

namespace SMM.Infrastructure.Database.Configurations.Pembelian
{
    public class StokUnitConfiguration : IEntityTypeConfiguration<StokUnit>
    {
        public void Configure(EntityTypeBuilder<StokUnit> builder)
        {
            builder.ToTable("StokUnit");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.NoRangka).HasMaxLength(25);
            builder.Property(e => e.NoMesin).HasMaxLength(25);
            builder.Property(e => e.Warna).HasMaxLength(25).IsUnicode(false);
            var converterStatusStokUnit = new EnumToStringConverter<StatusStokUnit>();
            builder.Property(e => e.Jual).HasConversion(converterStatusStokUnit);
            builder.Property(e => e.Kembali).HasMaxLength(1);
            builder.Property(e => e.Faktur).HasMaxLength(1);
            builder.Property(e => e.Harga).HasColumnType("money");
            builder.Property(e => e.Diskon).HasColumnType("money");
            builder.Property(e => e.SellIn).HasColumnType("money");
            builder.Property(e => e.Harga1).HasColumnType("money");
            builder.Property(e => e.Diskon2).HasColumnType("money");
            builder.Property(e => e.SellIn2).HasColumnType("money");
            builder.Property(e => e.HargaPPN).HasColumnType("money");
            builder.Property(e => e.DiskonPPN).HasColumnType("money");
            builder.Property(e => e.SellInPPN).HasColumnType("money");
            builder.Property(e => e.TanggalInput).HasColumnType("datetime").HasDefaultValueSql("GetUtcDate()");




        }
    }
}
