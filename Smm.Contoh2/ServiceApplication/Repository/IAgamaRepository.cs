using Smm.ContohMVC.Domain.EnumInEntity;
using Smm.ContohMVC.ServiceApplication.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Smm.ContohMVC.Domain.Repository
{
    public interface IAgamaRepository
    {
        Task<IReadOnlyList<AgamaDto>> GetAllAgamaAsync<AgamaDto>(Expression<Func<Agama, AgamaDto>> selector, CancellationToken cancellationToken = default);
    }
}
