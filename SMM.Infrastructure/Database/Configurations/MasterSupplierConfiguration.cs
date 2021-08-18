using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SMM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Infrastructure.Database.Configurations
{
    public class MasterSupplierConfiguration : IEntityTypeConfiguration<MasterSupplier>
    {
        public void Configure(EntityTypeBuilder<MasterSupplier> builder)
        {
            builder.ToTable("MasterSupplier");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.NamaSupplier).HasMaxLength(50).IsUnicode(false);
            builder.OwnsOne(o => o.AlamatSupplier, a => {
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

            var converterStatus = new EnumToStringConverter<MasterSupplierStatus>();
            builder.Property(e => e.MasterSupplierStatus).HasConversion(converterStatus);


        }
    }
}
