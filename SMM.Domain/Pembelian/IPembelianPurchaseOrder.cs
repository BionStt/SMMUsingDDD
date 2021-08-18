using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using SMM.Domain.Ddd;

namespace SMM.Domain.Pembelian
{
    public interface IPembelianPurchaseOrder:IRepository<PembelianPurchaseOrder>
    {
        Task Add(PembelianPurchaseOrder pembelianPurchaseOrder, CancellationToken cancellationToken = default);




    }
}
