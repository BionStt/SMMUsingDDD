using Smm.ContohMVCOutboxPattern.DDD.OutboxPattern;
using Smm.ContohMVCOutboxPattern.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMVCOutboxPattern.Persistence.Repository.OutboxPattern
{
    public class OutboxAccessor : IOutbox
    {
        private readonly ApplicationDbContext _meetingsContext;

        internal OutboxAccessor(ApplicationDbContext meetingsContext)
        {
            _meetingsContext = meetingsContext;
        }

        public void Add(OutboxMessageEntity message)
        {
            _meetingsContext.OutboxMessages.Add(message);
        }

        public Task Save()
        {
            return Task.CompletedTask; // Save is done automatically using EF Core Change Tracking mechanism during SaveChanges.
        }
    }
}
