using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain.MasterBarang
{
    public class MasterBarang:AggregateRoot<Guid>
    {
        protected MasterBarang()
        {

        }
        private MasterBarang(string namaBarang, string nomorRangka, string nomorMesin, string merek, string kapasitasMesin, decimal? hargaOff, decimal? bbn, string tahunPerakitan, string typeKendaraan)
        {
            NamaBarang = namaBarang;
            NomorRangka = nomorRangka;
            NomorMesin = nomorMesin;
            Merek = merek;
            KapasitasMesin = kapasitasMesin;
            HargaOff = hargaOff;
            Bbn = bbn;
            TahunPerakitan = tahunPerakitan;
            TypeKendaraan = typeKendaraan;
            MasterBarangStatus = MasterBarangStatus.Aktif;
        }
        public static MasterBarang Create(string namaBarang, string nomorRangka, string nomorMesin, string merek, string kapasitasMesin, decimal? hargaOff, decimal? bbn, string tahunPerakitan, string typeKendaraan)
        {
            return new MasterBarang(namaBarang,nomorRangka,nomorMesin,merek,kapasitasMesin,hargaOff,bbn,tahunPerakitan,typeKendaraan);
        }
        public void EditMasterBarang(string namaBarang, string nomorRangka, string nomorMesin, string merek, string kapasitasMesin, decimal? hargaOff, decimal? bbn, string tahunPerakitan, string typeKendaraan)
        {
            NamaBarang = namaBarang;
            NomorRangka = nomorRangka;
            NomorMesin = nomorMesin;
            Merek = merek;
            KapasitasMesin = kapasitasMesin;
            HargaOff = hargaOff;
            Bbn = bbn;
            TahunPerakitan = tahunPerakitan;
            TypeKendaraan = typeKendaraan;
        }
        public void NonAktifStatusMasterBarang()
        {
            MasterBarangStatus = MasterBarangStatus.TidakAktif;
        }
        public MasterBarangStatus MasterBarangStatus { get; private set; }

        public string NamaBarang { get; private set; }
        public string NomorRangka { get; private set; }
        public string NomorMesin { get; private set; }
         public string Merek { get; private set; }
        public string KapasitasMesin { get; private set; }
        public decimal? HargaOff { get; private set; }
        public decimal? Bbn { get; private set; }
        public string TahunPerakitan { get; private set; }

        public string TypeKendaraan { get; private set; }

    }
    public enum MasterBarangStatus
    {
        Aktif=0,
        TidakAktif=1

    }
}
