using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMM.Domain;
namespace SMM.Infrastructure.Database.Configurations.Pembelian
{
    public class PembelianPurchaseOrderDetailConfiguration : IEntityTypeConfiguration<PembelianPurchaseOrderDetail>
    {
        public void Configure(EntityTypeBuilder<PembelianPurchaseOrderDetail> builder)
        {
            builder.ToTable("PembelianPurchaseOrderDetail");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Bbn).HasColumnType("money");
            builder.Property(e => e.Diskon).HasColumnType("money");
            builder.Property(e => e.Warna).HasMaxLength(25).IsUnicode(false);
            builder.Property(e => e.Qty);
            builder.Property(e => e.Keterangan).HasMaxLength(100).IsUnicode(false);




        }
    }
}
