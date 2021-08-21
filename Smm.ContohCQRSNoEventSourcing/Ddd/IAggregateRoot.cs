using Smm.ContohCQRSNoEventSourcing.Ddd.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohCQRSNoEventSourcing.Ddd
{
    /// <summary>
    ///  Aggregate root interface
    /// </summary>
    public interface IAggregateRoot
    {
        // IReadOnlyCollection<DomaintEvent> DomainEvents { get; }
        //void ClearDomainEvents();

        IReadOnlyCollection<IDomainEvent> DomainEvents { get; }
        void ClearDomainEvents();
    }
}
