using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain
{
    public class DataSPKLeasing:Entity<Guid>
    {
        public DataSPKLeasing(decimal? angsuran, string mediator, string namaCmo, Guid namaSales, int? tenor, DateTime? tanggalSurvei)
        {
            Id = Guid.NewGuid();
            Angsuran = angsuran;
            Mediator = mediator;
            NamaCmo = namaCmo;
            NamaSales = namaSales;
            Tenor = tenor;
            TanggalSurvei = tanggalSurvei;
        }
        public void EditDataSpkLeasing(decimal? angsuran, string mediator, string namaCmo, Guid namaSales, int? tenor, DateTime? tanggalSurvei)
        {
            Angsuran = angsuran;
            Mediator = mediator;
            NamaCmo = namaCmo;
            NamaSales = namaSales;
            Tenor = tenor;
            TanggalSurvei = tanggalSurvei;
        }
        public decimal? Angsuran { get; private set; }
        public string Mediator { get; private set; }
        public string NamaCmo { get; private set; }
        public Guid NamaSales { get; private set; }
        public int? Tenor { get; private set; }
        public DateTime? TanggalSurvei { get; private set; }


        public MasterKategoriBayaran MasterKategoriBayaran { get; private set; }
        public MasterKategoriPenjualan MasterKategoriPenjualan { get; private set; }

        public MasterLeasingCabang MasterLeasingCabang { get; private set; }
        public DataSPK.DataSPK DataSPK { get; private set; }
        protected DataSPKLeasing()
        {

        }
    }
}
