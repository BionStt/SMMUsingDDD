using Smm.Contoh.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.Contoh.Domain.ValueObject
{
    public class NomorKTP : ValueObject<NomorKTP>
    {
        public string Value { get; }

        protected NomorKTP()
        {

        }

        public NomorKTP(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Nomor KTP tidak bisa dikosongkan");

            if (value.Length != 12) throw new ArgumentException("Nomor KTP harus 12 digit");
            Value = value;
        }

        //public static NomorKTP NewNumber() => new NomorKTP(Guid.NewGuid().ToString());

        //public static NomorKTP Of(string value) => new NomorKTP(value);

        //public static implicit operator string(NomorKTP number) => number.Value;
        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            yield return Value;
        }
    }
}
