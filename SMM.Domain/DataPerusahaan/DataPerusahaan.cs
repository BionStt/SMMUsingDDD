using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain.DataPerusahaan
{
    public class DataPerusahaan:AggregateRoot<Guid>
    {

        public string NamaPerusahaan { get; private set; }
        public Alamat AlamatPerusahaan { get; private set; }
        public string ContakPerson { get; private set; }

        private readonly List<DataPerusahaanCabang> listCabang = new List<DataPerusahaanCabang>();//utk nambah cabang

        public IReadOnlyCollection<DataPerusahaanCabang> ListCabang => listCabang;// dari data perusahaan bisa ambil data cabang.

        private DataPerusahaan(string namaPerusahaan, Alamat alamatPerusahaan, string contakPerson)
        {
            Id = Guid.NewGuid();
            NamaPerusahaan = namaPerusahaan;
            AlamatPerusahaan = alamatPerusahaan;
            ContakPerson = contakPerson;
        }
        protected DataPerusahaan()
        {

        }
        public static DataPerusahaan Create(string namaCabang, Alamat alamatCabang, string contakPerson)
        {
            return new DataPerusahaan(namaCabang, alamatCabang, contakPerson);
        }

        public DataPerusahaanCabang AddCabang(string namaCabang, Alamat alamatCabang, string kontakPerson, Guid dataPerusahaanId)
        {
            var _listCabang = new DataPerusahaanCabang(namaCabang, alamatCabang,kontakPerson);
            listCabang.Add(_listCabang);
            return _listCabang;
        }

        public DataPerusahaanCabang EditCabang(Guid DataCabangPerusahaanId, string namaCabang, Alamat alamatCabang, string kontakPerson)
        {
            var _listCabang = listCabang.FirstOrDefault(i => i.Id == DataCabangPerusahaanId);
            _listCabang.ChangeDataPerusahaanCabang(namaCabang,alamatCabang,kontakPerson);
            return _listCabang;

        }
        public DataPerusahaanCabang NonAktifkanCabang(Guid DataCabangPerusahaanId)
        {
            var _listCabang = listCabang.FirstOrDefault(i => i.Id == DataCabangPerusahaanId);
            _listCabang.CabangDiNonAktifkan();
            return _listCabang;
        }


    }
}
