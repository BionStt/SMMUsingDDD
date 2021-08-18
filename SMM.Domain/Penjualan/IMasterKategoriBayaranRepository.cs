using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using SMM.Domain.Ddd;

namespace SMM.Domain.Penjualan
{
    public interface IMasterKategoriBayaranRepository: IRepository<MasterKategoriBayaran>
    {
        Task Add(MasterKategoriBayaran masterKategoriBayaran, CancellationToken cancellationToken = default);




    }
}
