using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.Contoh.Ddd
{
    /// <summary>
    /// Aggregate root base class
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public abstract class AggregateRoot<TKey> : Entity<TKey>, IAggregateRoot
    {
        //public IReadOnlyCollection<Event> DomainEvents => _domainEvents?.AsReadOnly();

        //public void AddDomainEvent<TE>(TE @event) where TE : Event
        //{
        //    _domainEvents = _domainEvents ?? new List<Event>();
        //    _domainEvents.Add(@event);
        //}

        //public void ClearDomainEvents()
        //{
        //    _domainEvents.Clear();
        //}

        //private List<Event> _domainEvents;
    }
}
