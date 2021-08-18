using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain.STNKBPKB
{
    public class DataBPKB : Entity<Guid>
    {

        public int? PermohonanFakturDBId { get; set; }

        public string NoBpkb { get; set; }

        public DateTime? TanggalTerimaBPKB { get; set; }
    }
}
