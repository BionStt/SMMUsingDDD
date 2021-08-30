using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohRazor.Data
{
    public class DataKonsumen
    {
        public DataKonsumen(string noKTP, DateTime tanggalLahir, string jenisKelamin, string agama, string nama, string namaBPKB, string alamatTinggal, string alamatKirim, string email, DateTime createdAt)
        {
            NoKTP = noKTP;
            TanggalLahir = tanggalLahir;
            JenisKelamin = jenisKelamin;
            Agama = agama;
            Nama = nama;
            NamaBPKB = namaBPKB;
            AlamatTinggal = alamatTinggal;
            AlamatKirim = alamatKirim;
            Email = email;
            CreatedAt = createdAt;
        }

        [Key]
        public int Id { get; set; }
        public string NoKTP { get; private set; }
        public DateTime TanggalLahir { get; private set; }
        public string JenisKelamin { get; private set; }
        public string Agama { get; private set; }

        public string Nama { get; private set; }
        public string NamaBPKB { get; private set; }
        public string AlamatTinggal { get; private set; }
        public string AlamatKirim { get; private set; }
        public string Email { get; private set; }

        public DateTime CreatedAt { get; private set; }





    }
}
