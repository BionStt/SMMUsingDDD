using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SMM.Domain.MasterBarang
{
    public interface IMasterBarangRepository: IRepository<MasterBarang>
    {
        Task Add(MasterBarang masterBarang, CancellationToken cancellationToken = default);

        Task<MasterBarang> GetById(Guid id, CancellationToken cancellationToken = default);







    }
}
