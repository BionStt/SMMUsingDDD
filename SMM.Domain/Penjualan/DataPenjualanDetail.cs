using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain
{
    public class DataPenjualanDetail : Entity<Guid>
    {
        protected DataPenjualanDetail()
        {

        }
        public decimal? OffTheRoad { get; private set; }
        public decimal? Bbn { get; private set; }
        public decimal? HargaOTR { get; private set; }
        public decimal? UangMuka { get; private set; }
        public decimal? DiskonKredit { get; private set; }
        public decimal? DiskonTunai { get; private set; }
        public decimal? Subsidi { get; private set; }
        public decimal? Promosi { get; private set; }
        public decimal? Komisi { get; private set; }
        public decimal? JoinPromo1 { get; private set; }
        public decimal? JoinPromo2 { get; private set; }
        public decimal? SPF { get; private set; }
        public decimal? SellOut { get; private set; }
        public decimal? DendaWilayah { get; private  set; }
        public Guid StokUnitId { get; private set; }//dicek lagi
        public Guid DataPenjualanId { get; private set; }


        public CheckUangMuka DpStatus { get; private set; }
        public CheckLaporanBulanan CheckLaporanBulanan{get; private set;}
        public DateTime? TanggalCheckLaporanBulanan { get; private set; }
        public Guid UserCheckLaporanBulanan { get; private set; }
        public Guid UserInput { get; private set; }
       // public StatusPelunasan StatusPelunasan { get; private set; }
        public DateTime? TanggalPelunasan { get; private set; }


        public DataPenjualan DataPenjualan { get; set; }
        public StokUnit StokUnit { get; private set; }

        public DataPenjualanDetail(decimal? offTheRoad, decimal? bbn, decimal? hargaOTR, decimal? uangMuka, decimal? diskonKredit, decimal? diskonTunai, decimal? subsidi, decimal? promosi, decimal? komisi, decimal? joinPromo1, decimal? joinPromo2, decimal? sPF, decimal? sellOut, decimal? dendaWilayah, Guid stokUnitId, Guid dataPenjualanId)
        {
            Id = Guid.NewGuid();
            OffTheRoad = offTheRoad;
            Bbn = bbn;
            HargaOTR = hargaOTR;
            UangMuka = uangMuka;
            DiskonKredit = diskonKredit;
            DiskonTunai = diskonTunai;
            Subsidi = subsidi;
            Promosi = promosi;
            Komisi = komisi;
            JoinPromo1 = joinPromo1;
            JoinPromo2 = joinPromo2;
            SPF = sPF;
            SellOut = sellOut;
            DendaWilayah = dendaWilayah;
            StokUnitId = stokUnitId;
            DataPenjualanId = dataPenjualanId;
        }
        public static DataPenjualanDetail Create(decimal? offTheRoad, decimal? bbn, decimal? hargaOTR, decimal? uangMuka, decimal? diskonKredit, decimal? diskonTunai, decimal? subsidi, decimal? promosi, decimal? komisi, decimal? joinPromo1, decimal? joinPromo2, decimal? sPF, decimal? sellOut, decimal? dendaWilayah, Guid stokUnitId, Guid dataPenjualanId)
        {
            return new DataPenjualanDetail(offTheRoad, bbn, hargaOTR, uangMuka, diskonKredit, diskonTunai, subsidi, promosi, komisi, joinPromo1, joinPromo2, sPF, sellOut, dendaWilayah, stokUnitId, dataPenjualanId);
        }
        public void EditDataPenjualanDetail(decimal? offTheRoad, decimal? bbn, decimal? hargaOTR, decimal? uangMuka, decimal? diskonKredit, decimal? diskonTunai, decimal? subsidi, decimal? promosi, decimal? komisi, decimal? joinPromo1, decimal? joinPromo2, decimal? sPF, decimal? sellOut, decimal? dendaWilayah, Guid stokUnitId, Guid dataPenjualanId)
        {
            OffTheRoad = offTheRoad;
            Bbn = bbn;
            HargaOTR = hargaOTR;
            UangMuka = uangMuka;
            DiskonKredit = diskonKredit;
            DiskonTunai = diskonTunai;
            Subsidi = subsidi;
            Promosi = promosi;
            Komisi = komisi;
            JoinPromo1 = joinPromo1;
            JoinPromo2 = joinPromo2;
            SPF = sPF;
            SellOut = sellOut;
            DendaWilayah = dendaWilayah;
            StokUnitId = stokUnitId;
            DataPenjualanId = dataPenjualanId;
        }



    }
    public enum CheckUangMuka
    {
        BelumLunas = 0,
        Lunas = 1
    }
    public enum CheckLaporanBulanan
    {
        UnCheck = 0,
        Check = 1

    }
}
