using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohCQRSNoEventSourcing.Ddd.Events
{
    public abstract class DomaintEvent : Message, IDomainEvent
    {
        public DateTime CreatedAt { get; private set; }



        protected DomaintEvent()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
