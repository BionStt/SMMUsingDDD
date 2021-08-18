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
    public class DataBPKBConfiguration : IEntityTypeConfiguration<DataBPKB>
    {
        public void Configure(EntityTypeBuilder<DataBPKB> builder)
        {
            builder.ToTable("DataBPKB");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.NoBpkb).HasMaxLength(30);
            builder.Property(e => e.TanggalTerimaBPKB).HasColumnType("datetime");



        }
    }
}
