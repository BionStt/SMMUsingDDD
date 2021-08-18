using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMvcCQRS.Ddd
{
    /// <summary>
    ///  Aggregate root interface
    /// </summary>
    public interface IAggregateRoot
    {
        IReadOnlyCollection<Event> DomainEvents { get; }
        void ClearDomainEvents();
    }
}
