using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohCQRSNoEventSourcing.ServiceApplication.Agama.Queries.AgamaList
{
    public class AgamaListQuery : IRequest<List<AgamaListQueryResponse>>
    {

    }
}
