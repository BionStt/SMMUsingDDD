using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMvcCQRS.Ddd
{
    public class DomainEventBase : IDomainEvent
    {

        public DateTime OccurredOn { get; }

        public DomainEventBase()
        {
            OccurredOn = DateTime.Now;
        }
    }
}
