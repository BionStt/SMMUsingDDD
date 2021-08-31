using Smm.Contoh.Ddd;
using Smm.Contoh.Domain.Enum;
using Smm.Contoh.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.Contoh.Domain
{
    public class DataKonsumen:AggregateRoot<Guid>
    {
        public NomorKTP NoKTP { get; private set; }
        public DateTime TanggalLahir { get; private set; }
        public string JenisKelamin { get; private set; }
        public string Agama { get; private set; }

        public Name Nama { get; private set; }
        public Name NamaBPKB { get; private set; }
        public Alamat AlamatTinggal { get; private set; }
        public Alamat AlamatKirim { get; private set; }
        public string Email { get; private set; }

        public DateTime CreatedAt { get; private set; }
        protected DataKonsumen()
        {

        }

        public DataKonsumen(NomorKTP noKTP, DateTime tanggalLahir, string jenisKelamin, Name nama, Name namaBPKB, Alamat alamatTinggal, Alamat alamatKirim)
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now.Date;
            NoKTP = noKTP;
            TanggalLahir = tanggalLahir;
            JenisKelamin = jenisKelamin;
            Nama = nama;
            NamaBPKB = namaBPKB;
            AlamatTinggal = alamatTinggal;
            AlamatKirim = alamatKirim;
        }

        public static DataKonsumen Create(NomorKTP nomorKTP, DateTime tanggalLahir, string jenisKelamin, Name nama, Name namaBpkb, Alamat alamatTinggal, Alamat alamatKirim)
        {
            return new DataKonsumen(nomorKTP, tanggalLahir, jenisKelamin, nama, namaBpkb, alamatTinggal, alamatKirim);
        }
        //public static DataKonsumen Create(DateTime createdAt, NomorKTP nomorKTP)
        //{
        //    var dataKonsumen = new DataKonsumen();
        //    dataKonsumen.CreatedAt = createdAt;

        //    return new DataKonsumen();
        //}

        public AgeInYears AgeInYearsAt(DateTime date)
        {
            return AgeInYears.Between(TanggalLahir, date);
        }

    }
}
