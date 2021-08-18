using SMM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace SMM.Application
{
    public class DataPenjualanService
    {
        private readonly ISMMUnitOfWork _repo;

        public DataPenjualanService(ISMMUnitOfWork repo)
        {
            _repo = repo;
        }


        public async Task<DataPenjualan> AddDataPenjualan()
        {
            return DataPenjualan;
        }

    }
}
