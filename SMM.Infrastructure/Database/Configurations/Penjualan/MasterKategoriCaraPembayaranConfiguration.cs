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
    public class MasterKategoriCaraPembayaranConfiguration : IEntityTypeConfiguration<MasterKategoriCaraPembayaran>
    {
        public void Configure(EntityTypeBuilder<MasterKategoriCaraPembayaran> builder)
        {
            builder.ToTable("MasterKategoriCaraPembayaran");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.CaraPembayaran).HasMaxLength(50);

        }
    }
}
