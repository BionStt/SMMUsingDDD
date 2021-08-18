using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SMM.Domain.DataPerusahaan
{
    public interface IDataPerusahaanRepository:IRepository<DataPerusahaan>
    {
        Task AddDataPerusahaan(DataPerusahaan dataPerusahaan, CancellationToken cancellationToken = default);

        Task AddDataPerusahaanCabang(DataPerusahaan dataPerusahaan, CancellationToken cancellationToken = default);


    }
}
