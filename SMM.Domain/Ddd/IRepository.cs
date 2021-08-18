using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain.Ddd
{
    public interface IRepository<T> where T : IAggregateRoot
    {
    }
}
