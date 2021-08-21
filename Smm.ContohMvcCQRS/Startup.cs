using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Smm.ContohMvcCQRS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Smm.ContohMvcCQRS.Services;
using Smm.ContohMvcCQRS.Ddd;
using Smm.ContohMvcCQRS.Data.Events;
using Smm.ContohMvcCQRS.Domain;
using Smm.ContohMvcCQRS.Data.Repository;
using Smm.ContohMvcCQRS.BackgroundServices;

namespace Smm.ContohMvcCQRS
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews();

            services.AddMediatR(typeof(Startup));
            services.AddTransient<IEmailSender, EmailSender>();

            // Infrastructure - Data EventSourcing
            services.AddScoped<IStoredEvents, StoredEvents>();
            services.AddSingleton<IEventSerializer, EventSerializer>();

            // Messaging
            services.AddScoped<IMessagePublisher, MessagePublisher>();
            services.AddScoped<IMessageProcessor, MessageProcessor>();

            // Infra - Domain persistence
            services.AddScoped<IContohCQRSUnitOfWork, ContohCQRSUnitOfWork>();
            services.AddScoped<IDataKonsumen, DataKonsumenRepository>();

            // Message processing
            var section = this.Configuration.GetSection(nameof(MessageProcessorServiceOptions));
            var messageProcessorTaskOptions = section.Get<MessageProcessorServiceOptions>();
            services.AddSingleton(messageProcessorTaskOptions);
            services.AddHostedService<MessagesProcessorService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
