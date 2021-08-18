using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Smm.ContohMvcCQRS.Ddd
{
    public abstract class Event : Message, INotification
    {
        public DateTime CreatedAt { get; private set; }
        protected Event()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
