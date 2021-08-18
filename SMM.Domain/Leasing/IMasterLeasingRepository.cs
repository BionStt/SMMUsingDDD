using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace SMM.Domain.Leasing
{
    public interface IMasterLeasingRepository:IRepository<MasterLeasing>
    {
        Task Add(MasterLeasing masterLeasing, CancellationToken cancellationToken = default);

        Task<MasterLeasing> GetById(Guid id, CancellationToken cancellationToken = default);


    }
}
