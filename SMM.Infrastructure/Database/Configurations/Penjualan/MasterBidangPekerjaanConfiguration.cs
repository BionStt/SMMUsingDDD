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
    public class MasterBidangPekerjaanConfiguration : IEntityTypeConfiguration<MasterBidangPekerjaan>
    {
        public void Configure(EntityTypeBuilder<MasterBidangPekerjaan> builder)
        {
            builder.ToTable("MasterBidangPekerjaan");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.TanggalInput).HasColumnType("datetime");
            builder.Property(e => e.NamaMasterBidangPekerjaan).HasMaxLength(100).IsUnicode(false);


        }
    }
}
