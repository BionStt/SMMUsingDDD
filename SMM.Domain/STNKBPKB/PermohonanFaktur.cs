using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain
{
    public class PermohonanFaktur:AggregateRoot<Guid>
    {
        protected PermohonanFaktur()
        {

        }
        public string NoRegistrasiFaktur { get; private set; }
        public DateTime? TanggalMohonFaktur { get; private set; }

        public Guid DataPenjualanDetailId { get; private set; }

        public DateTime? TanggalLahir { get; private set; }
        public string NomorKTP { get; private set; }
        public string NamaFaktur { get; private set; }
        public Alamat AlamatKTPFaktur { get; private set; }
      //  public string Telepon { get; private set; }
       // public string HandphoneF { get; private set; }
        public DataPenjualanDetail DataPenjualanDetail { get; private set; }



        public PermohonanFaktur(string noRegistrasiFaktur, DateTime? tanggalMohonFaktur, Guid dataPenjualanDetailId, DateTime? tanggalLahir, string nomorKTP, string namaFaktur, Alamat alamatKTPFaktur)
        {
            Id = Guid.NewGuid();
            NoRegistrasiFaktur = noRegistrasiFaktur;//mao buat generateID faktur
            TanggalMohonFaktur = tanggalMohonFaktur;
            DataPenjualanDetailId = dataPenjualanDetailId;
            TanggalLahir = tanggalLahir;
            NomorKTP = nomorKTP;
            NamaFaktur = namaFaktur;
            AlamatKTPFaktur = alamatKTPFaktur;
          //  Telepon = telepon;
           // HandphoneF = handphoneF;
        }
        public void EditPermohonanFaktur(string noRegistrasiFaktur, DateTime? tanggalMohonFaktur, Guid dataPenjualanDetailId, DateTime? tanggalLahir, string nomorKTP, string namaFaktur, Alamat alamatKTPFaktur)
        {
            NoRegistrasiFaktur = noRegistrasiFaktur;//mao buat generateID faktur
            TanggalMohonFaktur = tanggalMohonFaktur;
            DataPenjualanDetailId = dataPenjualanDetailId;
            TanggalLahir = tanggalLahir;
            NomorKTP = nomorKTP;
            NamaFaktur = namaFaktur;
            AlamatKTPFaktur = alamatKTPFaktur;
          //  Telepon = telepon;
          //  HandphoneF = handphoneF;
        }


    }
}
