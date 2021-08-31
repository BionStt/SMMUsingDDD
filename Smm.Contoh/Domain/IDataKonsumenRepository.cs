using Smm.Contoh.ServiceApplication.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Smm.Contoh.Domain
{
    public interface IDataKonsumenRepository
    {
        Task<List<DataKonsumen>> GetAllCustomerAsync(CancellationToken cancellationToken = default);
        Task AddAsync(DataKonsumen dataKonsumen, CancellationToken cancellationToken = default);

        Task<DataKonsumen> GetByIdAsync(Guid dataKonsumenId, CancellationToken cancellationToken = default);
        Task<DataKonsumen> GetByEmailAsync(string email, CancellationToken cancellationToken = default);
        Task<IReadOnlyList<ListDataKonsumenDto>> ListDataKonsumenAsync(Expression<Func<DataKonsumen, ListDataKonsumenDto>> listDataKonsumenSelector, CancellationToken cancellationToken = default);


    }
}
