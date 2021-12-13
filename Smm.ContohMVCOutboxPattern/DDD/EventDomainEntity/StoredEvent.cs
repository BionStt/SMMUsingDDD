using Smm.ContohMVCOutboxPattern.DDD.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMVCOutboxPattern.DDD.EventDomainEntity
{
    public class StoredEvent : DomaintEvent
    {
        public StoredEvent(DomaintEvent @event, string payload, string user)
        {
            Id = Guid.NewGuid();
            AggregateId = @event.AggregateId;
            MessageType = @event.MessageType;
            Payload = payload;
            User = user;
        }
        public StoredEvent(DomaintEvent @event, string payload)
        {
            Id = Guid.NewGuid();
            AggregateId = @event.AggregateId;
            MessageType = @event.MessageType;
            Payload = payload;
        }

        //public StoredEvent(Guid id, string payload, DateTime? processedAt)
        //{
        //    Id = id;
        //    Payload = payload;
        //    ProcessedAt = processedAt;
        //}
        public string User { get; private set; }
        public Guid Id { get; private set; }
        public string Payload { get; private set; }
        public DateTime? ProcessedAt { get; private set; }
        public void SetProcessedAt(DateTime? date)
        {
            if (date == null)
                throw new ArgumentNullException(nameof(date));

            ProcessedAt = date;
        }

        // EF Constructor
        protected StoredEvent() { }



    }
}
