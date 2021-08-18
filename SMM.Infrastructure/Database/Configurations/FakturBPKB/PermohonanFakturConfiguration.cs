using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Infrastructure.Database.Configurations
{
    public class PermohonanFakturConfiguration : IEntityTypeConfiguration<PermohonanFaktur>
    {
        public void Configure(EntityTypeBuilder<PermohonanFaktur> builder)
        {
            builder.ToTable("PermohonanFaktur");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.NoRegistrasiFaktur).HasMaxLength(30);
            builder.Property(e => e.TanggalMohonFaktur).HasColumnType("datetime");
            builder.Property(e => e.TanggalLahir).HasColumnType("datetime");
            builder.Property(e => e.NomorKTP).HasMaxLength(20);
            builder.Property(e => e.NamaFaktur).HasMaxLength(50).IsUnicode(false);
            builder.OwnsOne(o => o.AlamatKTPFaktur, a => {
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




        }
    }
}
