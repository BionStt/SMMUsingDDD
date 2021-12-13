using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMVCOutboxPattern.DDD.IntegrationEvents
{
    public interface IEventsBus : IDisposable
    {
        Task Publish<T>(T @event)
            where T : IntegrationEventViaMediaTR;

        void Subscribe<T>(IIntegrationEventHandlerViaMediaTR<T> handler)
            where T : IntegrationEventViaMediaTR;

        void StartConsuming();
    }
}
