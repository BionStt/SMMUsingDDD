using MediatR;
using Smm.DomainEventMediaTR.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.DomainEventMediaTR.ServiceApplication.DataKonsumen.Commands.CreateDataKonsumen
{
    public class MarkDataKonsumenAsWelcomedCommand : IRequest<Unit>
    {
        public Guid DataKonsumenId { get; }
        public MarkDataKonsumenAsWelcomedCommand(Guid dataKonsumenId)
        {
            DataKonsumenId = dataKonsumenId;
        }
        public MarkDataKonsumenAsWelcomedCommand(DataKonsumenRegisteredEvent dataKonsumenRegisteredEvent)
        {
            DataKonsumenId = dataKonsumenRegisteredEvent.DataKonsumenId;
        }
    }
}
