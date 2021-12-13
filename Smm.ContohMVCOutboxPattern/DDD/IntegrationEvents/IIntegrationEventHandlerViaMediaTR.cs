using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMVCOutboxPattern.DDD.IntegrationEvents
{
  
    public interface IIntegrationEventHandlerViaMediaTR<in TIntegrationEvent> : IIntegrationEventHandlerViaMediaTR
     where TIntegrationEvent : IntegrationEventViaMediaTR
    {
        Task Handle(TIntegrationEvent @event);
    }

    public interface IIntegrationEventHandlerViaMediaTR
    {
    }
}
