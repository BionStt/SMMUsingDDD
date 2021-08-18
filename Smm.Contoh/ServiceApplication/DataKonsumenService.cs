using Smm.Contoh.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Smm.Contoh.ServiceApplication
{
    public class DataKonsumenService : IDataKonsumenService
    {
        private readonly IContohUnitOfWork _repo;
        public async Task AddDataKonsumenAsync(DataKonsumen NewDataKonsumen)
        {

             await _repo.DataKonsumenRepository.AddAsync(NewDataKonsumen);
        }
    }
}
