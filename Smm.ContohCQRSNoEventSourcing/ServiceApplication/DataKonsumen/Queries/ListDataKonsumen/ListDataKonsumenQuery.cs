﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohCQRSNoEventSourcing.ServiceApplication.DataKonsumen.Queries.ListDataKonsumen
{
    public class ListDataKonsumenQuery : IRequest<List<ListDataKonsumenQueryResponse>>
    {

    }
}
