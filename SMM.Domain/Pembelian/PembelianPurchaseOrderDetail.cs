using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain
{
    public class PembelianPurchaseOrderDetail:Entity<Guid>
    {
        protected PembelianPurchaseOrderDetail()
        {

        }
        private PembelianPurchaseOrderDetail(decimal? offTheRoad, decimal? bbn, decimal? diskon, string warna, int? qty, string keterangan)
        {
            OffTheRoad = offTheRoad;
            Bbn = bbn;
            Diskon = diskon;
            Warna = warna;
            Qty = qty;
            Keterangan = keterangan;
        }

        public decimal? OffTheRoad { get; private set; }

        public decimal? Bbn { get; private set; }
        public decimal? Diskon { get; private set; }
        public string Warna { get; private set; }
        public int? Qty { get; private set; }
        public string Keterangan { get; private set; }



        public Guid PembelianPurchaseOrderId { get; private set; }
        public PembelianPurchaseOrder PembelianPurchaseOrder { get; private set; }
        public Guid MasterBarangId { get; private set; }
        public MasterBarang.MasterBarang MasterBarang { get; private set; }

        public static PembelianPurchaseOrderDetail Create(decimal? offTheRoad, decimal? bbn, decimal? diskon, string warna, int? qty, string keterangan)
        {
            return new PembelianPurchaseOrderDetail(offTheRoad,bbn,diskon,warna,qty,keterangan);
        }

    }
}
