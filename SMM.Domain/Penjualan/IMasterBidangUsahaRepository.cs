﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using SMM.Domain.Ddd;

namespace SMM.Domain.Penjualan
{
    public interface IMasterBidangUsahaRepository: IRepository<MasterBidangUsaha>
    {
        Task Add(MasterBidangUsaha masterBidangUsaha, CancellationToken cancellationToken = default);



    }
}
