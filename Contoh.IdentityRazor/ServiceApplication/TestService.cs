using Contoh.IdentityRazor.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Contoh.IdentityRazor.ServiceApplication
{
    public interface ITestService
    {
        Task<UserProfile> GetUserProfileAsync(string Id,CancellationToken cancellationToken = default);

    }

    public class TestService: ITestService
    {
        private readonly ApplicationDbContext _dbContext;

        public TestService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<UserProfile> GetUserProfileAsync(string Id,CancellationToken cancellationToken = default)
        {
            var aa = _dbContext.UserProfile.SingleOrDefaultAsync(x=>x.ApplicationUserId.Equals(Id));
            throw new NotImplementedException();
        }
    }
}
