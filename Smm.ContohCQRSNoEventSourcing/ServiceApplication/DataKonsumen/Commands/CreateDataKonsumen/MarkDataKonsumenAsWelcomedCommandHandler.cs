﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using Smm.ContohCQRSNoEventSourcing.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Smm.ContohCQRSNoEventSourcing.ServiceApplication.DataKonsumen.Commands.CreateDataKonsumen
{
    public class MarkDataKonsumenAsWelcomedCommandHandler : IRequestHandler<MarkDataKonsumenAsWelcomedCommand,Unit>
    {
        private readonly ApplicationDbContext _dbContext;

        public MarkDataKonsumenAsWelcomedCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(MarkDataKonsumenAsWelcomedCommand request, CancellationToken cancellationToken)
        {
            var dtKonsumen = await _dbContext.DataKonsumen.FirstOrDefaultAsync(x => x.Id == request.DataKonsumenId);
            if (dtKonsumen != null)
            {
                dtKonsumen.MarkAsWelcomedByEmail();
                await _dbContext.SaveChangesAsync(cancellationToken);
            }


            return Unit.Value;



        }
    }
}
