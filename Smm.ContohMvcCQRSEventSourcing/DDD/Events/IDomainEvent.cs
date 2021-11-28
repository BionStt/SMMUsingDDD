using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMvcCQRSEventSourcing.DDD.Events
{
    public interface IDomainEvent : INotification
    {
        DateTime CreatedAt { get; }
        // DateTime OccurredOn { get; }
    }
}
