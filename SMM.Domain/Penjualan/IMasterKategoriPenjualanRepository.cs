using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using SMM.Domain.Ddd;

namespace SMM.Domain.Penjualan
{
    public interface IMasterKategoriPenjualanRepository: IRepository<MasterKategoriPenjualan>
    {
        Task Add(MasterKategoriPenjualan masterKategoriPenjualan, CancellationToken cancellationToken = default);




    }
}
