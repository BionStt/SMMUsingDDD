using Smm.Contoh2.Ddd;
using Smm.ContohMVC.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.Contoh2.Domain
{
    public interface IContohUnitOfWork : IUnitOfWork
    {
        IDataKonsumenRepository DataKonsumenRepository { get; }
        IAgamaRepository AgamaRepository { get; }
        IJenisKelaminRepository JenisKelaminRepository { get; }
    }
}
