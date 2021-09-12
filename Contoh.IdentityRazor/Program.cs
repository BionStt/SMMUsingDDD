using Contoh.IdentityRazor.Data;
using Contoh.IdentityRazor.ServiceApplication;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contoh.IdentityRazor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // CreateHostBuilder(args).Build().Run();

            var host = CreateWebHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    var context = services.GetRequiredService<ApplicationDbContext>();
                    var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
                    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                    var functional = services.GetRequiredService<IFunctional>();

                    //  context.Database.Migrate(); //lama loading
                    DbInitializer.Initialize(context, functional).Wait();
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database.");
                    logger.LogError(ex.StackTrace, "An error occurred while seeding the database.");
                    logger.LogError(ex.InnerException, "An error occurred while seeding the database.");
                }


            }
            host.Run();
        }

        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //    Host.CreateDefaultBuilder(args)
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>();
        //        });


        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
          (IWebHostBuilder)WebHost.CreateDefaultBuilder(args)
              // .UseKestrel()
              //  .UseContentRoot(Directory.GetCurrentDirectory())
              //.ConfigureAppConfiguration((hostingContext, config) =>
              //{
              //    var env = hostingContext.HostingEnvironment;
              //    config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
              //          .AddJsonFile($"appsettings.Local.json", optional: true, reloadOnChange: true)
              //          .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);
              //    config.AddEnvironmentVariables();
              //})

              //buat belajar
              //https://www.tutorialsteacher.com/core/aspnet-core-logging
              //.ConfigureLogging(logBuilder =>
              //{
              //    logBuilder.ClearProviders(); // removes all providers from LoggerFactory
              //    logBuilder.AddConsole();
              //    logBuilder.AddTraceSource("Information, ActivityTracing"); // Add Trace listener provider
              //})

              .ConfigureLogging((hostingContext, logging) =>
              {
                  logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                  logging.AddConsole();
                  logging.AddDebug();
                   //logging.AddEventSourceLogger();


               })


              .UseStartup<Startup>();
    }
}
