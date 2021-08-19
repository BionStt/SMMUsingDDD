using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMVC.Ddd.Events
{
    public abstract class DomainEvent : Message, IDomainEvent
    {
        public DateTime CreatedAt { get; private set; }

        public DomainEvent()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
