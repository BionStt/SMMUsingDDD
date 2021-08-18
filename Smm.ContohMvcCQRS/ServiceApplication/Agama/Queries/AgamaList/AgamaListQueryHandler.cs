﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Smm.ContohMvcCQRS.Data;
using Microsoft.EntityFrameworkCore;

namespace Smm.ContohMvcCQRS.ServiceApplication.Agama.Queries.AgamaList
{
    public class AgamaListQueryHandler:IRequestHandler<AgamaListQuery, List<AgamaListQueryResponse>>
    {
        private readonly ApplicationDbContext _dbContext;

        public AgamaListQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<AgamaListQueryResponse>> Handle(AgamaListQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = _dbContext.Agama.Select(x=> new AgamaListQueryResponse {
                Id= x.Id,
                AgamaKeterangan = x.AgamaKeterangan
            }).AsNoTracking().ToListAsync();

            return returnQuery;
        }
    }
}
