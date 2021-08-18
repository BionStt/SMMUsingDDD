using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMM.Domain;

namespace SMM.Infrastructure.Database.Configurations.Pembelian
{
    public class PembelianDetailConfiguration : IEntityTypeConfiguration<PembelianDetail>
    {
        public void Configure(EntityTypeBuilder<PembelianDetail> builder)
        {
            builder.ToTable("PembelianDetail");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.HargaOffTheRoad).HasColumnType("money");
            builder.Property(e => e.BBN).HasColumnType("money");
            builder.Property(e => e.Qty);
            builder.Property(e => e.Diskon).HasColumnType("money");
            builder.Property(e => e.SellIn).HasColumnType("money");
            builder.Property(e => e.Harga1).HasColumnType("money");
            builder.Property(e => e.Diskon2).HasColumnType("money");
            builder.Property(e => e.SellIn2).HasColumnType("money");
            builder.Property(e => e.HargaPPN).HasColumnType("money");
            builder.Property(e => e.DiskonPPN).HasColumnType("money");
            builder.Property(e => e.SellInPPN).HasColumnType("money");




        }
    }
}
