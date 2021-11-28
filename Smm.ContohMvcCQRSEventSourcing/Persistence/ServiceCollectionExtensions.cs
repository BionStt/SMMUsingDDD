using Smm.ContohMvcCQRSEventSourcing.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using MediatR;

namespace Smm.ContohMvcCQRSEventSourcing.Persistence
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddContohCQRSESDbContext(this IServiceCollection services, string connectionString)
        {

            services.AddDbContext<ApplicationDbContext>(options =>
              options.UseSqlServer(connectionString));

            //services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<LeasingRazorDbContext>().AddDefaultUI().AddDefaultTokenProviders();

            //         services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
            //        .AddEntityFrameworkStores<AccountingDbContext>()
            //        .AddDefaultUI()
            //.AddDefaultTokenProviders();

            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
