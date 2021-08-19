using Smm.ContohMvcCQRS.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMvcCQRS.Domain
{
    public interface IContohCQRSUnitOfWork : IUnitOfWork
    {
        IDataKonsumen Customers { get; }
        IStoredEvents StoredEvents { get; }
    }
}
