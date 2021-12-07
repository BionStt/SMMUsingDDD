using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMVCOutboxPattern.Domain.EnumInEntity
{
    public class Agama
    {
        public Guid AgamaId { get; set; }
        public int NoUrutId { get; set; }
        public String AgamaKeterangan { get; set; }
    }
}
