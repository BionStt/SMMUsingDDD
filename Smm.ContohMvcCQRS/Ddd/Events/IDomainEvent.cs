using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Smm.ContohMvcCQRS.Ddd
{
    public interface IDomainEvent : INotification
    {
        DateTime CreatedAt { get; }
       // DateTime OccurredOn { get; }
    }
}
