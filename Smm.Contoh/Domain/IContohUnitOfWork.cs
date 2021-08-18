using Smm.Contoh.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.Contoh.Domain
{
    public interface IContohUnitOfWork : IUnitOfWork
    {
        IDataKonsumenRepository DataKonsumenRepository { get; }
    }
}
