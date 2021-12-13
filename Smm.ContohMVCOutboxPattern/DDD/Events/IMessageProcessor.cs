using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMVCOutboxPattern.DDD.Events
{
    public interface IMessageProcessor
    {
        Task ProcessMessages(int batchSize, CancellationToken cancellationToken);
    }
}
