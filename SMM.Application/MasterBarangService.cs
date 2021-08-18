using SMM.Application.Api;
using SMM.Domain;
using SMM.Domain.MasterBarang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Application
{
    public class MasterBarangService
    {
        private readonly ISMMUnitOfWork _repo;

        public MasterBarangService(ISMMUnitOfWork repo)
        {
            _repo = repo;
        }

        public async Task<MasterBarang> AddMasterBarang(MasterBarangDto masterBarangDto)
        {
            return await _repo.MasterBarangRepository.Add();
        }
    }
}
