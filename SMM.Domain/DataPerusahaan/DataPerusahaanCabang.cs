using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain
{
    public class DataPerusahaanCabang : Entity<Guid>
    {
        protected DataPerusahaanCabang()
        {

        }
        public DataPerusahaanCabang(string namaCabang, Alamat alamatCabang, string kontakPerson)
        {
            Id = Guid.NewGuid();
            NamaCabang = namaCabang;
            AlamatCabang = alamatCabang;
            KontakPerson = kontakPerson;
            // DataPerusahaanId = dataPerusahaanId;
        }
        //public static DataPerusahaanCabang Create(string namaCabang, Alamat alamatCabang, string kontakPerson, Guid dataPerusahaanId)
        //{
        //    return new DataPerusahaanCabang(namaCabang,alamatCabang,kontakPerson,dataPerusahaanId);
        //}

        public string NamaCabang { get; private set; }
        public Alamat AlamatCabang { get; private set; }

        public string KontakPerson { get; private set; }
        public StatusCabang StatusCabang { get; private set; }
        // public Guid DataPerusahaanId { get; private set; }
        public DataPerusahaan.DataPerusahaan DataPerusahaan { get; private set; }

        public void CabangDiNonAktifkan()
        {
            StatusCabang = StatusCabang.TidakAktif;
        }

        public void ChangeDataPerusahaanCabang(string namaCabang, Alamat alamatCabang, string kontakPerson)
        {
            NamaCabang = namaCabang;
            AlamatCabang = alamatCabang;
            KontakPerson = kontakPerson;

        }

    }
    public enum StatusCabang
    {
        TidakAktif=0,
        Aktif=1


    }


}
