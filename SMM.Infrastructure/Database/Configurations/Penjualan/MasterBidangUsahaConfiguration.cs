using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SMM.Domain;

namespace SMM.Infrastructure.Database.Configurations.Penjualan
{
    public class MasterBidangUsahaConfiguration : IEntityTypeConfiguration<MasterBidangUsaha>
    {
        public void Configure(EntityTypeBuilder<MasterBidangUsaha> builder)
        {
            builder.ToTable("MasterBidangUsaha");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.NamaMasterBidangUsaha).HasMaxLength(100).IsUnicode(false);
            builder.Property(e => e.TanggalInput).HasColumnType("datetime");




        }
    }
}
