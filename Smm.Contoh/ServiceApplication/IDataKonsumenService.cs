using Smm.Contoh.Domain;
using Smm.Contoh.ServiceApplication.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Smm.Contoh.ServiceApplication
{
    public interface IDataKonsumenService
    {
        Task AddDataKonsumenAsync(DataKonsumen NewDataKonsumen, CancellationToken cancellationToken);
        Task<IReadOnlyList<ListDataKonsumenDto>> GetListDataKonsumen();
    }
}
