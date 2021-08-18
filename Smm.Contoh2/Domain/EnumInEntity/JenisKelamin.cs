using Smm.Contoh2.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMVC.Domain.EnumInEntity
{
    public class JenisKelamin: AggregateRoot<int>
    {
        public String JenisKelaminKeterangan { get; set; }
    }
}
