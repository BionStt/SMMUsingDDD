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
    public class DataPenjualanDetailConfiguration : IEntityTypeConfiguration<DataPenjualanDetail>
    {
        public void Configure(EntityTypeBuilder<DataPenjualanDetail> builder)
        {
            builder.ToTable("DataPenjualanDetail");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.OffTheRoad).HasColumnType("money");
            builder.Property(e => e.Bbn).HasColumnType("money");
            builder.Property(e => e.HargaOTR).HasColumnType("money");
            builder.Property(e => e.UangMuka).HasColumnType("money");
            builder.Property(e => e.DiskonKredit).HasColumnType("money");
            builder.Property(e => e.DiskonTunai).HasColumnType("money");
            builder.Property(e => e.Subsidi).HasColumnType("money");
            builder.Property(e => e.Promosi).HasColumnType("money");
            builder.Property(e => e.Komisi).HasColumnType("money");
            builder.Property(e => e.JoinPromo1).HasColumnType("money");
            builder.Property(e => e.JoinPromo2).HasColumnType("money");
            builder.Property(e => e.SPF).HasColumnType("money");
            builder.Property(e => e.SellOut).HasColumnType("money");
            builder.Property(e => e.DendaWilayah).HasColumnType("money");
            builder.Property(e => e.TanggalCheckLaporanBulanan).HasColumnType("datetime");
            builder.Property(e => e.TanggalPelunasan).HasColumnType("datetime");

            var converterStatusUangMuka = new EnumToStringConverter<CheckUangMuka>();
            builder.Property(e => e.DpStatus).HasConversion(converterStatusUangMuka);

            var converterCheckLaporanBulanan = new EnumToStringConverter<CheckLaporanBulanan>();
            builder.Property(e => e.CheckLaporanBulanan).HasConversion(converterCheckLaporanBulanan);




        }
    }
}
