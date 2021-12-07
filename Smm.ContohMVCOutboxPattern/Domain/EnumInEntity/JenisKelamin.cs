using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMVCOutboxPattern.Domain.EnumInEntity
{
    public class JenisKelamin
    {
        public Guid JenisKelaminId { get; set; }
        public int NoUrutId { get; set; }
        public String JenisKelaminKeterangan { get; set; }
    }
}
