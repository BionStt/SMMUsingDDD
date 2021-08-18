using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain
{
    public class DataSPKKredit:Entity<Guid>
    {

        public decimal? BiayaAdministrasiKredit { get; private set; }
        public decimal? BiayaAdministrasiTunai { get; private set; }
        public decimal? BBN { get; private set; }
        public decimal? DendaWilayah { get; private set; }
        public decimal? DiskonDP { get; private set; }
        public decimal? DiskonTunai { get; private set; }
        public decimal? DPPriceList { get; private set; }
        public decimal? Komisi { get; private set; }
        public decimal? OffTheRoad { get; private set; }
        public decimal? Promosi { get; private set; }
        public decimal? UangTandaJadiTunai { get; private set; }
        public decimal? UangTandaJadiKredit { get; private set; }


        public DataSPK.DataSPK DataSPK { get; private set; }


        public DataSPKKredit(decimal? biayaAdministrasiKredit, decimal? biayaAdministrasiTunai, decimal? bBN, decimal? dendaWilayah, decimal? diskonDP, decimal? diskonTunai, decimal? dPPriceList, decimal? komisi, decimal? offTheRoad, decimal? promosi, decimal? uangTandaJadiTunai, decimal? uangTandaJadiKredit)
        {
            Id = Guid.NewGuid();
            BiayaAdministrasiKredit = biayaAdministrasiKredit;
            BiayaAdministrasiTunai = biayaAdministrasiTunai;
            BBN = bBN;
            DendaWilayah = dendaWilayah;
            DiskonDP = diskonDP;
            DiskonTunai = diskonTunai;
            DPPriceList = dPPriceList;
            Komisi = komisi;
            OffTheRoad = offTheRoad;
            Promosi = promosi;
            UangTandaJadiTunai = uangTandaJadiTunai;
            UangTandaJadiKredit = uangTandaJadiKredit;
        }
        public void EditDataSPKKredit(decimal? biayaAdministrasiKredit, decimal? biayaAdministrasiTunai, decimal? bBN, decimal? dendaWilayah, decimal? diskonDP, decimal? diskonTunai, decimal? dPPriceList, decimal? komisi, decimal? offTheRoad, decimal? promosi, decimal? uangTandaJadiTunai, decimal? uangTandaJadiKredit)
        {
            BiayaAdministrasiKredit = biayaAdministrasiKredit;
            BiayaAdministrasiTunai = biayaAdministrasiTunai;
            BBN = bBN;
            DendaWilayah = dendaWilayah;
            DiskonDP = diskonDP;
            DiskonTunai = diskonTunai;
            DPPriceList = dPPriceList;
            Komisi = komisi;
            OffTheRoad = offTheRoad;
            Promosi = promosi;
            UangTandaJadiTunai = uangTandaJadiTunai;
            UangTandaJadiKredit = uangTandaJadiKredit;
        }
        protected DataSPKKredit()
        {

        }
    }
}
