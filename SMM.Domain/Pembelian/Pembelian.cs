using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain.Pembelian
{
    public class Pembelian:AggregateRoot<Guid>
    {
        protected Pembelian()
        {

        }
        public string NoRegistrasiPembelian { get; private set; }
        public Guid UserInput { get; private set; }
        public string Tenor { get; private set; }
        public string Keterangan { get; private set; }
        public JenisPembatalanPembelian Batal { get; private set; }
        public JenisStatusPembelian Status { get; private set; }

        public Guid MasterSupplierId { get; private set; }
        public MasterSupplier MasterSupplier { get; private set; }
        public Guid PembelianPurchaseOrderId { get; private set; }
        public PembelianPurchaseOrder PembelianPurchaseOrder { get; private set; }

        private readonly List<PembelianDetail> _PembelianDetails = new List<PembelianDetail>();
        public IReadOnlyCollection<PembelianDetail> Pembeliandetails => _PembelianDetails;

        private Pembelian(string noRegistrasiPembelian, Guid userInput, string tenor, string keterangan)
        {
            Id = Guid.NewGuid();
            NoRegistrasiPembelian = noRegistrasiPembelian;
            UserInput = userInput;
            Tenor = tenor;
            Keterangan = keterangan;
        }

        public static Pembelian Create(string noRegistrasiPembelian, Guid userInput, string tenor, string keterangan)
        {
            return new Pembelian(noRegistrasiPembelian, userInput, tenor, keterangan);

        }

        public PembelianDetail AddPembelianDetail(decimal? hargaOffTheRoad, decimal? bBN, int qty, decimal? diskon, decimal? sellIn, decimal? harga1, decimal? diskon2, decimal? sellIn2, decimal? hargaPPN, decimal? diskonPPN, decimal? sellInPPN, Guid masterBarangId)
        {
            var PembelianDetails = new PembelianDetail(hargaOffTheRoad,bBN,qty,diskon,sellIn,harga1,diskon2, sellIn2,hargaPPN,diskonPPN,sellInPPN,masterBarangId);
            _PembelianDetails.Add(PembelianDetails);
            return PembelianDetails;
        }
        public PembelianDetail EditPembelianDetail(decimal? hargaOffTheRoad, decimal? bBN, int qty, decimal? diskon, decimal? sellIn, decimal? harga1, decimal? diskon2, decimal? sellIn2, decimal? hargaPPN, decimal? diskonPPN, decimal? sellInPPN, Guid masterBarangId,Guid PembelianDetailId)
        {
            var listEditPembelianDetail = _PembelianDetails.FirstOrDefault(i => i.Id == PembelianDetailId);
            listEditPembelianDetail.EditPembelianDetail(hargaOffTheRoad,bBN,qty,diskon,sellIn,harga1,diskon2,sellIn2,hargaPPN,diskonPPN,sellInPPN, masterBarangId);
            return listEditPembelianDetail;
        }

    }

    public enum JenisStatusPembelian
    {
        Tunai=0,
        Kredit=1,
        Titipan=2


    }
    public enum JenisPembatalanPembelian
    {
        Aktif=0,
        Dibatalkan=1
    }
}
