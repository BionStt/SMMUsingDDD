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
    public class MasterKategoriBayaranConfiguration : IEntityTypeConfiguration<MasterKategoriBayaran>
    {
        public void Configure(EntityTypeBuilder<MasterKategoriBayaran> builder)
        {
            builder.ToTable("MasterKategoriBayaran");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.NamaKategoryBayaran).HasMaxLength(50).IsUnicode(false);



        }
    }
}
