using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace src
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    var env = hostingContext.HostingEnvironment;
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);
                })
                .ConfigureKestrel((context, options) =>
                {
                    var env = context.HostingEnvironment;
                    if (env.IsDevelopment())
                    {
                        options.ListenAnyIP(5000); // Lauscht auf Port 5000 in der Entwicklungsumgebung
                    }
                    else if (env.IsProduction())
                    {
                        options.ListenAnyIP(80); // Lauscht auf Port 80 in der Produktionsumgebung
                    }
                    else
                    {
                        // Fallback-Konfiguration, falls weder Development noch Production
                        options.ListenAnyIP(5000);
                    }
                });
    }
}