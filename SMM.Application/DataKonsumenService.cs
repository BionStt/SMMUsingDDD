using SMM.Domain;
using SMM.Domain.DataKonsumen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SMM.Application
{
    public class DataKonsumenService
    {
        private readonly ISMMUnitOfWork _repo;

        public DataKonsumenService(ISMMUnitOfWork repo)
        {
            _repo = repo;
        }
        public  async Task<DataKonsumen> GetByIdAsync(Guid DataKonsumenId, CancellationToken cancellationToken)
        {
            var dataKonsumen = await _repo.DataKonsumenRepository.GetByIdAsync(DataKonsumenId, cancellationToken);
            return dataKonsumen;
        }



    }
}
