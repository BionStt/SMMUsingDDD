using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMM.Domain.DataPerusahaan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Infrastructure.Database.Configurations
{
    public class DataPerusahaanConfiguration : IEntityTypeConfiguration<DataPerusahaan>
    {
        public void Configure(EntityTypeBuilder<DataPerusahaan> builder)
        {
            builder.ToTable("DataPerusahaan");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.NamaPerusahaan).IsUnicode(false).HasMaxLength(50);
            builder.OwnsOne(o => o.AlamatPerusahaan, a => {
                a.WithOwner();
                a.Property(a => a.Jalan).IsUnicode(false).HasMaxLength(200);
                a.Property(a => a.Kelurahan).HasMaxLength(50);
                a.Property(a => a.Kecamatan).HasMaxLength(50);
                a.Property(a => a.Kota).HasMaxLength(50);
                a.Property(a => a.Propinsi).HasMaxLength(50);
                a.Property(a => a.KodePos).HasMaxLength(7);
                a.Property(a => a.NoTelepon).HasMaxLength(20);
                a.Property(a => a.NoFax).HasMaxLength(20);
                a.Property(a => a.NoHandphone).HasMaxLength(20);
            });
            builder.Property(e => e.ContakPerson).IsUnicode(false).HasMaxLength(50);




        }
    }
}
