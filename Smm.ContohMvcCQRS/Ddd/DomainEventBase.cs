using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMvcCQRS.Ddd
{
    public class DomainEventBase : IDomainEvent
    {

       // public DateTime OccurredOn { get; }

        public DateTime CreatedAt { get; }

        public DomainEventBase()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
