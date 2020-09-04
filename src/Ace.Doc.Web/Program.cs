using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
//using Microsoft.AspNetCore.Hosting.WindowsServices;
using Serilog;
using Serilog.Events;

namespace Ace.Doc.Web
{
    public class Program
    {
        public static int Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
#if DEBUG
                .MinimumLevel.Debug()
#else
                .MinimumLevel.Information()
#endif
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .MinimumLevel.Override("Microsoft.EntityFrameworkCore", LogEventLevel.Warning)
                .Enrich.FromLogContext()
                .WriteTo.Async(c => c.File("Logs/logs.txt"))
                .CreateLogger();
            Console.WriteLine("Ace.Doc Initia");

            try
            {
                Log.Information("Starting web host.");
                CreateHostBuilder(args).Build().Run();

                Console.WriteLine("Ace.Doc Start");

                return 0;
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly!");
                return 1;
            }
            finally
            {
                Log.CloseAndFlush();
            }

        }


        internal static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder
                    //.UseUrls("http://localhost:60000", "http://localhost:60001")
                    .UseStartup<Startup>();
                })
                .UseAutofac()
                .UseSerilog();
    }
}
