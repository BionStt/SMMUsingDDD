using Microsoft.EntityFrameworkCore;
using SMM.Domain.DataKonsumen;
using SMM.Domain.DataSPK;
using SMM.Domain;
using SMM.Domain.MasterBarang;
using SMM.Domain.DataPerusahaan;
using SMM.Domain.Pembelian;
using SMM.Infrastructure.Database.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMM.Domain.STNKBPKB;

namespace SMM.Infrastructure.Database.Context
{
    public class SMMDDDContext : DbContext
    {

        public SMMDDDContext(DbContextOptions options) : base(options)
        {
           // Database.EnsureCreated();

        }

        public DbSet<DataKonsumen> DataKonsumens {get;set;}

         public DbSet<DataSPK> DataSPK { get; set; }
         public DbSet<DataSPKKendaraan> DataSPKKendaraan { get; set; }
        public DbSet<DataSPKKredit> DataSPKKredit { get; set; }
        public DbSet<DataSPKLeasing> DataSPKLeasing { get; set; }
         public DbSet<DataSPKSurvei> DataSPKSurvei { get; set; }
        public DbSet<MasterLeasing> MasterLeasing { get; set; }
    public DbSet<MasterLeasingCabang> MasterLeasingCabang { get; set; }
    public DbSet<Pembelian> Pembelian { get; set; }
    public DbSet<PembelianDetail> PembelianDetail { get; set; }
    public DbSet<PembelianPurchaseOrder> PembelianPurchaseOrder { get; set; }
    public DbSet<PembelianPurchaseOrderDetail> PembelianPurchaseOrderDetail { get; set; }
    public DbSet<StokUnit> StokUnit { get; set; }
    public DbSet<DataPenjualan> DataPenjualan { get; set; }
    public DbSet<DataPenjualanDetail> DataPenjualanDetail { get; set; }
    public DbSet<MasterBidangPekerjaan> MasterBidangPekerjaan{ get; set; }
    public DbSet<MasterBidangUsaha> MasterBidangUsaha { get; set; }
    public DbSet<MasterKategoriBayaran> MasterKategoriBayaran { get; set; }

    public DbSet<MasterKategoriCaraPembayaran> MasterKategoriCaraPembayaran{ get; set; }
    public DbSet<MasterKategoriPenjualan> MasterKategoriPenjualan { get; set; }
        public DbSet<DataPerusahaanCabang> DataPerusahaanCabang { get; set; }
        public DbSet<DataPerusahaan> DataPerusahaan { get; set; }
        public DbSet<MasterBarang> MasterBarang { get; set; }
        public DbSet<MasterSupplier> MasterSupplier { get; set; }
        public DbSet<PermohonanFaktur> PermohonanFaktur { get; set; }
        public DbSet<DataBPKB> DataBPKB { get; set; }
        public DbSet<DataSTNK> DataSTNK { get; set; }






        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // please. you want input one by one or assembly

            modelBuilder.ApplyConfiguration(new DataKonsumenConfiguration());


        }

    }
}
