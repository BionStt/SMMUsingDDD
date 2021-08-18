using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using SMM.Domain.Ddd;

namespace SMM.Domain.Pembelian
{
    public interface IPembelianRepository:IRepository<Pembelian>
    {
        Task Add(Pembelian pembelian, CancellationToken cancellationToken = default);






    }
}
