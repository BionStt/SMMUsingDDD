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
    public class DataPenjualanConfiguration : IEntityTypeConfiguration<DataPenjualan>
    {
        public void Configure(EntityTypeBuilder<DataPenjualan> builder)
        {
            builder.ToTable("DataPenjualan");
            // please check again
            //  builder.HasKey(e => e.Id);
            builder.Property(e => e.NoBuku).HasMaxLength(15);
            builder.Property(e => e.Keterangan).HasMaxLength(50);
            builder.Property(e => e.Mediator).HasMaxLength(50);
            builder.Property(e => e.TanggalPenjualan).HasColumnType("datetime").HasDefaultValueSql("GetUtcDate()");
            var converterStatusPenjualan = new EnumToStringConverter<DataPenjualanStatus>();
            builder.Property(e => e.Status).HasConversion(converterStatusPenjualan);





        }
    }
}
