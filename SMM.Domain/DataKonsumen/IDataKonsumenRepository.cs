using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SMM.Domain.DataKonsumen
{
    public interface IDataKonsumenRepository: IRepository<DataKonsumen>
    {
        Task<List<DataKonsumen>> GetAllCustomerAsync(CancellationToken cancellationToken = default);
        Task Add(DataKonsumen dataKonsumen, CancellationToken cancellationToken = default);

        Task<DataKonsumen> GetByIdAsync(Guid dataKonsumenId, CancellationToken cancellationToken=default);
        Task<DataKonsumen> GetByEmailAsync(string email,CancellationToken cancellationToken=default);


    }
}
