using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMM.Domain.Ddd;
using System.Threading;

namespace SMM.Domain.Penjualan
{
    public interface IMasterBidangPekerjaanRepository:IRepository<MasterBidangPekerjaan>
    {
        Task Add(MasterBidangPekerjaan masterBidangPekerjaan, CancellationToken cancellationToken= default);



    }
}
