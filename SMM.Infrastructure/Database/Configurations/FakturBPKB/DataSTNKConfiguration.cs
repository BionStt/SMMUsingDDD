using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMM.Domain;
using SMM.Domain.STNKBPKB;

namespace SMM.Infrastructure.Database.Configurations.FakturBPKB
{
    public class DataSTNKConfiguration : IEntityTypeConfiguration<DataSTNK>
    {
        public void Configure(EntityTypeBuilder<DataSTNK> builder)
        {
            builder.ToTable("DataSTNK");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.TanggalBayarSTNK).HasColumnType("datetime");
            builder.Property(e => e.NoStnk).HasMaxLength(30);
            builder.Property(e => e.PajakStnk).HasColumnType("money");
            builder.Property(e => e.Birojasa).HasColumnType("money");
            builder.Property(e => e.BiayaTambahan).HasColumnType("money");
            builder.Property(e => e.FormA).HasColumnType("money");
            builder.Property(e => e.NomorPlat).HasMaxLength(10);
            builder.Property(e => e.Perwil).HasColumnType("money");
            builder.Property(e => e.PajakProgresif).HasColumnType("money");
            builder.Property(e => e.BbnPabrik).HasColumnType("money");
            builder.Property(e => e.ProgresifKe);






        }
    }
}
