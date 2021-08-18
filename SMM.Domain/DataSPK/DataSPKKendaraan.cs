using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain
{
    public class DataSPKKendaraan:Entity<Guid>
    {
        public DataSPKKendaraan(string tahunPerakitan, string warna, string namaSTNK, string noKtpSTNK)
        {
            Id = Guid.NewGuid();
            TahunPerakitan = tahunPerakitan;
            Warna = warna;
            NamaSTNK = namaSTNK;
            NoKtpSTNK = noKtpSTNK;
        }
        public void EditDataSPKKendaraan(string tahunPerakitan, string warna, string namaSTNK, string noKtpSTNK)
        {
            TahunPerakitan = tahunPerakitan;
            Warna = warna;
            NamaSTNK = namaSTNK;
            NoKtpSTNK = noKtpSTNK;
        }
        public string TahunPerakitan { get; private set; }
        public string Warna { get; private set; }
        public string NamaSTNK { get; private set; }
        public string NoKtpSTNK { get; private set; }

        public MasterBarang.MasterBarang MasterBarang { get; private set; }
        public DataSPK.DataSPK DataSPK { get; private set; }
        protected DataSPKKendaraan()
        {

        }
    }
}
