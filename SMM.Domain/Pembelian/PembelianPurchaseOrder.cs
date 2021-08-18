using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain
{
    public class PembelianPurchaseOrder : AggregateRoot<Guid>
    {
        protected PembelianPurchaseOrder()
        {

        }
        public DateTime? TanggalPurchaseOrder { get; private set; }
       public string Keterangan { get; private set; }
        public Guid UserInput { get; private set; }
        public string NoRegistrasiPOPMB { get; private set; }
        public Guid MasterSupplierId { get; private set; }
        public MasterSupplier MasterSupplier { get; private set; }

        private readonly List<PembelianPurchaseOrderDetail> _details = new List<PembelianPurchaseOrderDetail>();
        public IReadOnlyCollection<PembelianPurchaseOrderDetail> Details => _details;


        private PembelianPurchaseOrder(DateTime? tanggalPurchaseOrder, string keterangan, Guid userInput)
        {
            Id = Guid.NewGuid();
            TanggalPurchaseOrder = tanggalPurchaseOrder;
            Keterangan = keterangan;
            UserInput = userInput;
            NoRegistrasiPOPMB = GenerateNomorRegistrasiPOPMB(tanggalPurchaseOrder);
        }

        public PembelianPurchaseOrder Create(DateTime? tanggalPurchaseOrder, string keterangan, Guid userInput)
        {
            return new PembelianPurchaseOrder(tanggalPurchaseOrder, keterangan, userInput);
        }

       // private int tahun;
        private string GenerateNomorRegistrasiPOPMB(DateTime? tanggalPurchaseOrder)
        {
            //PO 01/XII/SM/2017
            //PO-XII/SM/2017/xx
           var bulan = tanggalPurchaseOrder.Value.Month;
            var tahun = tanggalPurchaseOrder.Value.Year;
            string bulanCetak="";
            switch(bulan)
            {
                case 1:
                    bulanCetak = "/I/SM/";
                break;
              case 2:
                    bulanCetak = "/II/SM/";
                    break;
              case 3:
                    bulanCetak = "/III/SM/";
                    break;
              case 4:
                    bulanCetak = "/IV/SM/";
                    break;
              case 5:
                    bulanCetak = "/V/SM/";
                    break;
              case 6:
                    bulanCetak = "/VI/SM/";
                    break;
              case 7:
                    bulanCetak = "/VII/SM/";
                    break;
             case 8:
                    bulanCetak = "/VIII/SM/";
                    break;
             case 9:
                    bulanCetak = "/IX/SM/";
                    break;
             case 10:
                    bulanCetak = "/X/SM/";
                    break;
             case 11:
                    bulanCetak = "/XI/SM/";
                    break;
             case 12:
                    bulanCetak = "/XXI/SM/";
                    break;
            }
            return string.Format("PO{0}-{1}",bulanCetak,tahun);
        }

        public PembelianPurchaseOrderDetail AddPODetail(decimal? offTheRoad, decimal? bbn, decimal? diskon, string warna, int? qty, string keterangan)
        {
            var PoDetails = PembelianPurchaseOrderDetail.Create(offTheRoad,bbn,diskon,warna,qty,keterangan);
            _details.Add(PoDetails);
            return PoDetails;
        }
        public void RemovePODetail(Guid POIdDetails)
        {
            var PODetails = _details.FirstOrDefault(i => i.Id == POIdDetails);
            if (PODetails == null) throw new ArgumentException("Invalid Po Details");

            _details.Remove(PODetails);
        }



    }
}
