using Smm.DomainEventMediaTR.Ddd;
using Smm.DomainEventMediaTR.Domain.Events;
using Smm.DomainEventMediaTR.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.DomainEventMediaTR.Domain
{
    public class DataKonsumen : AggregateRoot<Guid>
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
        public bool WelcomeEmailWasSent { get; private set; }

        public DateTime CreatedAt { get; private set; }
        protected DataKonsumen()
        {

        }

        private DataKonsumen(Guid Id, NomorKTP noKTP, DateTime tanggalLahir, string jenisKelamin, string agama, Name nama, Name namaBPKB, Alamat alamatTinggal, Alamat alamatKirim, string email)
        {
            Id = Id;
            CreatedAt = DateTime.Now.Date;
            NoKTP = noKTP;
            TanggalLahir = tanggalLahir;
            JenisKelamin = jenisKelamin;
            Agama = agama;
            Nama = nama;
            NamaBPKB = namaBPKB;
            AlamatTinggal = alamatTinggal;
            AlamatKirim = alamatKirim;
            Email = email;
            WelcomeEmailWasSent = false;
            AddDataKonsumenRegisteredEvent(Id, nama.NamaDepan);
           // AddDomainEvent(new DataKonsumenRegisteredEvent(Id, nama.NamaDepan));

        }
        private void AddDataKonsumenRegisteredEvent(Guid dataKonsumenId, string nama)
        {
            var domainEvents = new DataKonsumenRegisteredEvent(dataKonsumenId, nama);
            this.AddDomainEvent(domainEvents);

        }

        public static DataKonsumen Create(NomorKTP nomorKTP, DateTime tanggalLahir, string jenisKelamin, string agama, Name nama, Name namaBpkb, Alamat alamatTinggal, Alamat alamatKirim, string email)
        {

            return new DataKonsumen(Guid.NewGuid(), nomorKTP, tanggalLahir, jenisKelamin, agama, nama, namaBpkb, alamatTinggal, alamatKirim, email);
        }
        //public static DataKonsumen Create(DateTime createdAt, NomorKTP nomorKTP)
        //{
        //    var dataKonsumen = new DataKonsumen();
        //    dataKonsumen.CreatedAt = createdAt;

        //    return new DataKonsumen();
        //}
        public void MarkAsWelcomedByEmail()
        {
            WelcomeEmailWasSent = true;
        }
        public AgeInYears AgeInYearsAt(DateTime date)
        {
            return AgeInYears.Between(TanggalLahir, date);
        }


    }
}
