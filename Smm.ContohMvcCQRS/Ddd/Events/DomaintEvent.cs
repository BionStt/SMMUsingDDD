using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Smm.ContohMvcCQRS.Ddd
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
