using Smm.Contoh2.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMVC.Domain.EnumInEntity
{
    public class Agama : AggregateRoot<int>
    {
        public String AgamaKeterangan { get; set; }

    }
}
