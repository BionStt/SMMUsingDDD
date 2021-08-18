using SMM.Domain.Ddd;
using SMM.Domain.DataKonsumen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain
{
    public class DataPenjualan:AggregateRoot<DataPenjualanId>
    {
        protected DataPenjualan()
        {

        }

        public DataPenjualanNumber Number { get; private set; }
        public string NoBuku { get; private set; }

        public string Keterangan { get; private set; }
        public string Mediator { get; private set; }
        public string KodeSalesForce { get; private set; }
        public Guid MasterKategoriPenjualanId { get; private set; }
        public Guid MasterLeasingCabangId { get; private set; }
        public Guid DataKonsumenId { get; private set; }

        public DateTime TanggalPenjualan { get; private set; }
        public DataPenjualanStatus Status { get; private set; }

        public Guid UserInput { get;  private set; }

        private readonly List<DataPenjualanDetail> _dataPenjualanDetail = new List<DataPenjualanDetail>();
        public IReadOnlyCollection<DataPenjualanDetail> DataPenjualanDetail => _dataPenjualanDetail;

        //data spkb baru blom masuk
        //data asales


        public DataKonsumen.DataKonsumen DataKonsumen { get; set; }
        public MasterLeasingCabang MasterLeasingCabang { get; set; }
          public MasterKategoriPenjualan MasterKategoriPenjualan { get; private set; }

        private DataPenjualan(string noBuku, string keterangan, string mediator, string kodeSalesForce, Guid masterKategoriPenjualanId, Guid masterLeasingCabangId, Guid dataKonsumenId)
        {
            Id = new DataPenjualanId(Guid.NewGuid());
            NoBuku = noBuku;
            Keterangan = keterangan;
            Mediator = mediator;
            KodeSalesForce = kodeSalesForce;
            MasterKategoriPenjualanId = masterKategoriPenjualanId;
            MasterLeasingCabangId = masterLeasingCabangId;
            DataKonsumenId = dataKonsumenId;
        }
        public static DataPenjualan Create(string noBuku, string keterangan, string mediator, string kodeSalesForce, Guid masterKategoriPenjualanId, Guid masterLeasingCabangId, Guid dataKonsumenId)
        {
            return new DataPenjualan(noBuku,keterangan,mediator,kodeSalesForce,masterKategoriPenjualanId,masterLeasingCabangId,dataKonsumenId);
        }
        public void EditDataPenjualan(string noBuku, string keterangan, string mediator, string kodeSalesForce, Guid masterKategoriPenjualanId, Guid masterLeasingCabangId, Guid dataKonsumenId)
        {
            NoBuku = noBuku;
            Keterangan = keterangan;
            Mediator = mediator;
            KodeSalesForce = kodeSalesForce;
            MasterKategoriPenjualanId = masterKategoriPenjualanId;
            MasterLeasingCabangId = masterLeasingCabangId;
            DataKonsumenId = dataKonsumenId;
        }

        public DataPenjualanDetail AddDataPenjualanDetail(decimal? offTheRoad, decimal? bbn, decimal? hargaOTR, decimal? uangMuka, decimal? diskonKredit, decimal? diskonTunai, decimal? subsidi, decimal? promosi, decimal? komisi, decimal? joinPromo1, decimal? joinPromo2, decimal? sPF, decimal? sellOut, decimal? dendaWilayah, Guid stokUnitId, Guid dataPenjualanId)
        {
            var DataPenjualanDetail = new DataPenjualanDetail(offTheRoad,bbn,hargaOTR,uangMuka,diskonKredit,diskonTunai,subsidi,promosi,komisi,joinPromo1,joinPromo2,sPF,sellOut,dendaWilayah,stokUnitId,dataPenjualanId);
            _dataPenjualanDetail.Add(DataPenjualanDetail);
            return DataPenjualanDetail;
        }


    }
    public enum DataPenjualanStatus
    {
        BelumTerkirim = 0,
        Terkirim = 1,
        Dibatalkan = 2

    }
    public class DataPenjualanNumber : ValueObject<DataPenjualanNumber>
    {
        public string Number { get; }
        public DataPenjualanNumber(string number)
        {
            if (string.IsNullOrWhiteSpace(number)) throw new ArgumentNullException("");
            Number = number;
        }

        public static DataPenjualanNumber NewNumber() => new DataPenjualanNumber(Guid.NewGuid().ToString());
        public static DataPenjualanNumber of(string number) => new DataPenjualanNumber(number);

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            yield return Number;
        }
    }

    public class DataPenjualanId : ValueObject<DataPenjualanId>
    {
        public Guid Value { get; }
        public DataPenjualanId(Guid value)
        {
            Value = value;
        }
        protected DataPenjualanId()
        {

        }
        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            yield return Value;
        }
    }
}





