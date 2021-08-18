using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using SMM.Domain.Ddd;


namespace SMM.Domain.Supplier
{
    public interface IMasterSupplierRepository: IRepository<MasterSupplier>
    {
        Task Add(MasterSupplier masterSupplier, CancellationToken cancellationToken = default);



    }
}
