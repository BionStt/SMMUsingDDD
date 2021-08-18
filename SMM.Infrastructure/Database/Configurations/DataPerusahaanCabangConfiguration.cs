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
    public class DataPerusahaanCabangConfiguration : IEntityTypeConfiguration<DataPerusahaanCabang>
    {
        public void Configure(EntityTypeBuilder<DataPerusahaanCabang> builder)
        {
            builder.ToTable("DataPerusahaanCabang");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.NamaCabang).HasMaxLength(50);

            builder.OwnsOne(o => o.AlamatCabang, a => {
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
            builder.Property(e => e.KontakPerson).HasMaxLength(40);

            var converterStatus = new EnumToStringConverter<StatusCabang>();
            builder.Property(e => e.StatusCabang).HasConversion(converterStatus);





        }
    }
}
