using MediatR;
using Smm.ContohMVCOutboxPattern.DDD.Bus;
using Smm.ContohMVCOutboxPattern.DDD.EventDomainEntity;
using Smm.ContohMVCOutboxPattern.DDD.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMVCOutboxPattern.Infrastructure.CrossCuttingBus
{
    public class InMemoryBus: IMediatorHandler
    {
        private readonly IMediator _mediator;
        private readonly IStoredEvents _eventStore;

        public InMemoryBus(IStoredEvents eventStore, IMediator mediator)
        {
            _eventStore = eventStore;
            _mediator = mediator;
        }

        //public Task SendCommand<T>(T command) where T : Command
        //{
        //    return _mediator.Send(command);
        //}

        public  Task RaiseEvent<T>(T @event) where T : DomaintEvent
        {
            //if (!@event.MessageType.Equals("DomainNotification"))
            //    _eventStore?.SaveEvent(@event);

             _eventStore?.SaveEvent(@event);
            return  _mediator.Publish(@event);
        }
    }
}
