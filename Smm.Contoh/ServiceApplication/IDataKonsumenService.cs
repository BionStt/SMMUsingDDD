using Smm.Contoh.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.Contoh.ServiceApplication
{
    public interface IDataKonsumenService
    {
        Task AddDataKonsumenAsync(DataKonsumen NewDataKonsumen);
    }
}
