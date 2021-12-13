using MediatR;
using Smm.ContohMVCOutboxPattern.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMVCOutboxPattern.ServiceApplication.DomainEventHandler
{
    public class DataKonsumenRegisteredHandler : INotificationHandler<DataKonsumenRegisteredEvent>
    {
        public Task Handle(DataKonsumenRegisteredEvent notification, CancellationToken cancellationToken)
        {
          return Task.CompletedTask;

        }
    }
}
