using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMM.Domain.Ddd;
using SMM.Domain.DataKonsumen;
using SMM.Domain.DataPerusahaan;
using SMM.Domain.DataSPK;
using SMM.Domain.Leasing;
using SMM.Domain.MasterBarang;
using SMM.Domain.Pembelian;
using SMM.Domain.Penjualan;
using SMM.Domain.STNKBPKB;
using SMM.Domain.Supplier;


namespace SMM.Domain
{
    public interface ISMMUnitOfWork:IUnitOfWork
    {
        IDataKonsumenRepository DataKonsumenRepository { get;  }
        IDataPerusahaanRepository DataPerusahaanRepository { get; }
        IDataSPKRepository DataSPKRepository { get; }
        IMasterLeasingRepository MasterLeasingRepository { get; }
        IMasterBarangRepository MasterBarangRepository { get; }
        IPembelianRepository PembelianRepository { get; }
        IPembelianPurchaseOrder PembelianPurchaseOrder { get; }

        IMasterBidangPekerjaanRepository MasterBidangPekerjaanRepository { get; }
        IMasterBidangUsahaRepository MasterBidangUsahaRepository { get; }
        IMasterKategoriBayaranRepository MasterKategoriBayaranRepository { get; }
        IMasterKategoriCaraPembayaranRepository MasterKategoriCaraPembayaranRepository { get; }
        IMasterKategoriPenjualanRepository MasterKategoriPenjualanRepository { get; }
        IPermohonanFakturRepository PermohonanFakturRepository { get; }
        IMasterSupplierRepository MasterSupplierRepository { get; }





    }
}
