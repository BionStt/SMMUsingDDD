using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Smm.ContohMvcCQRS.ServiceApplication.DataKonsumen.Queries.ListDataKonsumen
{
    public class ListDataKonsumenQuery:IRequest<List<ListDataKonsumenQueryResponse>>
    {

    }
}
