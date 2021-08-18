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
    public class PembelianPurchaseOrderConfiguration : IEntityTypeConfiguration<PembelianPurchaseOrder>
    {
        public void Configure(EntityTypeBuilder<PembelianPurchaseOrder> builder)
        {
            builder.ToTable("PembelianPurchaseOrder");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.TanggalPurchaseOrder).HasColumnType("datetime");
            builder.Property(e => e.Keterangan).HasMaxLength(100).IsUnicode(false);


        }
    }
}
