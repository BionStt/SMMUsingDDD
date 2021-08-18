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
    public class PembelianConfiguration : IEntityTypeConfiguration<SMM.Domain.Pembelian.Pembelian>
    {
        public void Configure(EntityTypeBuilder<SMM.Domain.Pembelian.Pembelian> builder)
        {
            builder.ToTable("Pembelian");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.NoRegistrasiPembelian).HasMaxLength(30);
            builder.Property(e => e.Tenor).HasMaxLength(4).IsUnicode(false);
            builder.Property(e => e.Keterangan).HasMaxLength(100).IsUnicode(false);
            var converterJenisPembatalStatus = new EnumToStringConverter<SMM.Domain.Pembelian.JenisPembatalanPembelian>();
            builder.Property(e => e.Batal).HasConversion(converterJenisPembatalStatus);

            var convereterJenisStatusPembelian = new EnumToStringConverter<SMM.Domain.Pembelian.JenisStatusPembelian>();
            builder.Property(e => e.Status).HasConversion(convereterJenisStatusPembelian);




        }
    }
}
