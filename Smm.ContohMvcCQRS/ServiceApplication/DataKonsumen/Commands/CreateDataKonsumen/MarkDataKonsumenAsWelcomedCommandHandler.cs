using MediatR;
using Smm.ContohMvcCQRS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Smm.ContohMvcCQRS.Domain.Events;

namespace Smm.ContohMvcCQRS.ServiceApplication.DataKonsumen.Commands.CreateDataKonsumen
{
    public class MarkDataKonsumenAsWelcomedCommandHandler : IRequestHandler<MarkDataKonsumenAsWelcomedCommand, Unit>
    {
        private readonly ApplicationDbContext _dbContext;

        public MarkDataKonsumenAsWelcomedCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(MarkDataKonsumenAsWelcomedCommand request, CancellationToken cancellationToken)
        {
            var dtKonsumen = await _dbContext.DataKonsumen.SingleOrDefaultAsync(x => x.Id == request.DataKonsumenId);
            dtKonsumen.MarkAsWelcomedByEmail();

            return Unit.Value;



        }
    }
}
