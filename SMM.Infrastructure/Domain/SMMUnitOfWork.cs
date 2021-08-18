using SMM.Domain;
using SMM.Domain.DataKonsumen;
using SMM.Domain.DataPerusahaan;
using SMM.Domain.DataSPK;
using SMM.Domain.Leasing;
using SMM.Domain.MasterBarang;
using SMM.Domain.Pembelian;
using SMM.Domain.Penjualan;
using SMM.Domain.STNKBPKB;
using SMM.Domain.Supplier;
using SMM.Infrastructure.Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Infrastructure.Domain
{
    public class SMMUnitOfWork:UnitOfWork<SMMDDDContext>, ISMMUnitOfWork
    {

        public SMMUnitOfWork(SMMDDDContext dbContext, IDataKonsumenRepository dataKonsumenRepository, IDataPerusahaanRepository dataPerusahaanRepository, IDataSPKRepository dataSPKRepository, IMasterLeasingRepository masterLeasingRepository, IMasterBarangRepository masterBarangRepository, IPembelianRepository pembelianRepository, IPembelianPurchaseOrder pembelianPurchaseOrder, IMasterBidangPekerjaanRepository masterBidangPekerjaanRepository, IMasterBidangUsahaRepository masterBidangUsahaRepository, IMasterKategoriBayaranRepository masterKategoriBayaranRepository, IMasterKategoriCaraPembayaranRepository masterKategoriCaraPembayaranRepository, IMasterKategoriPenjualanRepository masterKategoriPenjualanRepository, IPermohonanFakturRepository permohonanFakturRepository, IMasterSupplierRepository masterSupplierRepository) : base(dbContext)
        {
            DataKonsumenRepository = dataKonsumenRepository;
            DataPerusahaanRepository = dataPerusahaanRepository;
            DataSPKRepository = dataSPKRepository;
            MasterLeasingRepository = masterLeasingRepository;
            MasterBarangRepository = masterBarangRepository;
            PembelianRepository = pembelianRepository;
            PembelianPurchaseOrder = pembelianPurchaseOrder;
            MasterBidangPekerjaanRepository = masterBidangPekerjaanRepository;
            MasterBidangUsahaRepository = masterBidangUsahaRepository;
            MasterKategoriBayaranRepository = masterKategoriBayaranRepository;
            MasterKategoriCaraPembayaranRepository = masterKategoriCaraPembayaranRepository;
            MasterKategoriPenjualanRepository = masterKategoriPenjualanRepository;
            PermohonanFakturRepository = permohonanFakturRepository;
            MasterSupplierRepository = masterSupplierRepository;
        }

        public IDataKonsumenRepository DataKonsumenRepository { get; }

        public IDataPerusahaanRepository DataPerusahaanRepository { get; }

        public IDataSPKRepository DataSPKRepository { get; }

        public IMasterLeasingRepository MasterLeasingRepository { get; }

        public IMasterBarangRepository MasterBarangRepository { get; }

        public IPembelianRepository PembelianRepository { get; }

        public IPembelianPurchaseOrder PembelianPurchaseOrder { get; }

        public IMasterBidangPekerjaanRepository MasterBidangPekerjaanRepository { get; }

        public IMasterBidangUsahaRepository MasterBidangUsahaRepository { get; }

        public IMasterKategoriBayaranRepository MasterKategoriBayaranRepository { get; }

        public IMasterKategoriCaraPembayaranRepository MasterKategoriCaraPembayaranRepository { get; }

        public IMasterKategoriPenjualanRepository MasterKategoriPenjualanRepository { get; }

        public IPermohonanFakturRepository PermohonanFakturRepository { get; }

        public IMasterSupplierRepository MasterSupplierRepository { get; }

    }
}
