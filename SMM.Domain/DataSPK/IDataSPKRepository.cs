using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using SMM.Domain.DataSPK;


namespace SMM.Domain.DataSPK
{
    public interface IDataSPKRepository:IRepository<DataSPK>
    {
        Task Add(DataSPK dataSPK, CancellationToken cancellationToken = default);

        Task<DataSPK> GetById(Guid dataSPKId, CancellationToken cancellationToken = default);

        Task<List<DataSPK>> GetbyId(Guid dataSPKId, CancellationToken cancellationToken = default);




    }
}
