﻿using MediatR;
using Smm.ContohMvcCQRS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Smm.ContohMvcCQRS.ServiceApplication.JenisKelamin.Queries.JenisKelaminList
{
    public class JenisKelaminListQueryHandler :  IRequestHandler<JenisKelaminListQuery, List<JenisKelaminListQueryResponse>>
    {
        private readonly ApplicationDbContext _dbContext;

        public JenisKelaminListQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<JenisKelaminListQueryResponse>> Handle(JenisKelaminListQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = _dbContext.JenisKelamin.Select(x=>new JenisKelaminListQueryResponse{
            Id = x.Id,
            JenisKelaminKeterangan = x.JenisKelaminKeterangan
            }).AsNoTracking().ToListAsync(cancellationToken);

            return returnQuery;
        }
    }
}