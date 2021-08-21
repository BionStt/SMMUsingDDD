using Smm.ContohCQRSNoEventSourcing.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohCQRSNoEventSourcing.Domain.EnumInEntity
{
    public class Agama : AggregateRoot<int>
    {
        public String AgamaKeterangan { get; set; }
    }
}
