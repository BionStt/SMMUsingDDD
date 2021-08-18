using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain
{
    public class DataNPWP:ValueObject<DataNPWP>
    {
        public DataNPWP(string noNPWP, string namaNPWP, Alamat alamatNPWP)
        {
            NoNPWP = noNPWP;
            NamaNPWP = namaNPWP;
            AlamatNPWP = alamatNPWP;
        }

        public string NoNPWP { get; private set; }
        public string NamaNPWP { get; private set; }
        public Alamat AlamatNPWP { get; private set; }


        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            yield return NoNPWP;
            yield return NamaNPWP;
            yield return AlamatNPWP;
        }
    }
}
