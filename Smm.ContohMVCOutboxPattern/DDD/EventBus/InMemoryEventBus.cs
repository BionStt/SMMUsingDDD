using Smm.ContohMVCOutboxPattern.DDD.IntegrationEvents;
using Smm.ContohMVCOutboxPattern.DDD.IntegrationEvents.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMVCOutboxPattern.DDD.EventBus
{
    public sealed class InMemoryEventBus
    {
        static InMemoryEventBus()
        {
        }

        private InMemoryEventBus()
        {
            _handlers = new List<HandlerSubscription>();
        }

        public static InMemoryEventBus Instance { get; } = new InMemoryEventBus();

        private readonly List<HandlerSubscription> _handlers;

        public void Subscribe<T>(IIntegrationEventHandlerViaMediaTR<T> handler)
            where T : IntegrationEventViaMediaTR
        {
            _handlers.Add(new HandlerSubscription(handler, typeof(T).FullName));
        }

        public async Task Publish<T>(T @event)
            where T : IntegrationEventViaMediaTR
        {
            var eventType = @event.GetType();

            var integrationEventHandlers = _handlers.Where(x => x.EventName == eventType.FullName).ToList();

            foreach (var integrationEventHandler in integrationEventHandlers)
            {
                if (integrationEventHandler.Handler is IIntegrationEventHandlerViaMediaTR<T> handler)
                {
                    await handler.Handle(@event);
                }
            }
        }

        private class HandlerSubscription
        {
            public HandlerSubscription(IIntegrationEventHandlerViaMediaTR handler, string eventName)
            {
                Handler = handler;
                EventName = eventName;
            }

            public IIntegrationEventHandlerViaMediaTR Handler { get; }

            public string EventName { get; }
        }
    }
}
