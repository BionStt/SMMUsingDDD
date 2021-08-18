using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain
{
    public class DataSPKSurvei:Entity<Guid>
    {
        public DataSPKSurvei(string noKTPPemesan, Name namaPemesan, Alamat alamatPemesan, DataNPWP dataNPWPPemesan, string pekerjaanPemesan)
        {
            Id = Guid.NewGuid();
            NoKTPPemesan = noKTPPemesan;
            NamaPemesan = namaPemesan;
            AlamatPemesan = alamatPemesan;
            DataNPWPPemesan = dataNPWPPemesan;
            PekerjaanPemesan = pekerjaanPemesan;
        }
        public void EditDataSPKSurvei(string noKTPPemesan, Name namaPemesan, Alamat alamatPemesan, DataNPWP dataNPWPPemesan, string pekerjaanPemesan)
        {
            NoKTPPemesan = noKTPPemesan;
            NamaPemesan = namaPemesan;
            AlamatPemesan = alamatPemesan;
            DataNPWPPemesan = dataNPWPPemesan;
            PekerjaanPemesan = pekerjaanPemesan;
        }
        public string NoKTPPemesan { get; private set; }
        public Name NamaPemesan { get; private set; }
        public Alamat AlamatPemesan { get; private set; }
        public DataNPWP DataNPWPPemesan{ get; private set; }
        public string PekerjaanPemesan { get; private set; }


        public DataSPK.DataSPK DataSPK { get; private set; }

        protected DataSPKSurvei()
        {

        }





    }
}
