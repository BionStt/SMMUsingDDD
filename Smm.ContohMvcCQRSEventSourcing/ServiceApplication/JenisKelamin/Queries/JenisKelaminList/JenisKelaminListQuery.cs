using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMvcCQRSEventSourcing.ServiceApplication.JenisKelamin.Queries.JenisKelaminList
{
    public class JenisKelaminListQuery : IRequest<List<JenisKelaminListQueryResponse>>
    {

    }
}
