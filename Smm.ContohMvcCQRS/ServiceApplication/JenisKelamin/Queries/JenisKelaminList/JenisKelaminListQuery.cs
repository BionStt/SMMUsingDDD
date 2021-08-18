using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Smm.ContohMvcCQRS.ServiceApplication.JenisKelamin.Queries.JenisKelaminList
{
    public class JenisKelaminListQuery:IRequest<List<JenisKelaminListQueryResponse>>
    {

    }
}
