using Smm.ContohMVCOutboxPattern.DDD.IntegrationEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace Smm.ContohMVCOutboxPattern.DDD.EventBus
{
    public class InMemoryEventBusClient : IEventsBus
    {
        private readonly Serilog.ILogger _logger;

        public InMemoryEventBusClient(Serilog.ILogger logger)
        {
            _logger = logger;
        }

        public void Dispose()
        {
        }

        public async Task Publish<T>(T @event)
            where T : IntegrationEventViaMediaTR
        {
            _logger.Information("Publishing {Event}", @event.GetType().FullName);
            await InMemoryEventBus.Instance.Publish(@event);
        }

        public void Subscribe<T>(IIntegrationEventHandlerViaMediaTR<T> handler)
            where T : IntegrationEventViaMediaTR
        {
            InMemoryEventBus.Instance.Subscribe(handler);
        }

        public void StartConsuming()
        {
        }
    }
}
