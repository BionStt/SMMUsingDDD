using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMVCOutboxPattern.DDD.OutboxPattern
{
    public interface IOutbox
    {
        void Add(OutboxMessageEntity message);

        Task Save();
    }
}
