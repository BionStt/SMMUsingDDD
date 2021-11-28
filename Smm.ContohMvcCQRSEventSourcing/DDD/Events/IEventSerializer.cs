using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMvcCQRSEventSourcing.DDD.Events
{
    public interface IEventSerializer
    {
        string Serialize<TE>(TE @event) where TE : DomaintEvent;
    }
}
