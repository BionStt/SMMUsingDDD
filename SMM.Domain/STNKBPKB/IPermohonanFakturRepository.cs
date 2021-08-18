using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using SMM.Domain.Ddd;

namespace SMM.Domain.STNKBPKB
{
    public interface IPermohonanFakturRepository: IRepository<PermohonanFaktur>
    {
        Task Add(PermohonanFaktur permohonanFaktur, CancellationToken cancellationToken = default);




    }
}
