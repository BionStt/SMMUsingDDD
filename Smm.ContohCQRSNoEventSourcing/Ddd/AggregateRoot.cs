using Smm.ContohCQRSNoEventSourcing.Ddd.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohCQRSNoEventSourcing.Ddd
{
    /// <summary>
    /// Aggregate root base class
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public abstract class AggregateRoot<TKey> : Entity<TKey>, IAggregateRoot
    {
        //public IReadOnlyCollection<DomaintEvent> DomainEvents => _domainEvents?.AsReadOnly();

        //public void AddDomainEvent<TE>(TE @event) where TE : DomaintEvent
        //{
        //    _domainEvents = _domainEvents ?? new List<DomaintEvent>();
        //    _domainEvents.Add(@event);
        //}

        //public void ClearDomainEvents()
        //{
        //    _domainEvents.Clear();
        //}

        //private List<DomaintEvent> _domainEvents;

        public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents?.AsReadOnly();

        protected void AddDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents = _domainEvents ?? new List<IDomainEvent>();
            _domainEvents.Add(domainEvent);
        }

        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }

        private List<IDomainEvent> _domainEvents;


    }
}
