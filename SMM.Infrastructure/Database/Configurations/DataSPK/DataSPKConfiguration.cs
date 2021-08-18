using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SMM.Domain.DataSPK;

namespace SMM.Infrastructure.Database.Configurations.DataSPK
{
    public class DataSPKConfiguration : IEntityTypeConfiguration<SMM.Domain.DataSPK.DataSPK>
    {
        public void Configure(EntityTypeBuilder<SMM.Domain.DataSPK.DataSPK> builder)
        {
            builder.ToTable("DataSPK");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.LokasiSpk).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.NoRegistrasiSPK).HasMaxLength(25);
            builder.Property(e => e.TanggalInput).HasColumnType("datetime").HasDefaultValueSql("GetUtcDate()");

            var converterStatus = new EnumToStringConverter<StatusSPK>();
            builder.Property(e => e.StatusSPK).HasConversion(converterStatus);


        }
    }
}
