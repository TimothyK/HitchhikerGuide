using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using PublisherService.Service;
using PublisherService.Utilities;
using Serilog;
using Serilog.Events;

namespace PublisherService
{
    class Program
    {
        static void Main(string[] args)
        {
            InitializeLogging();
            Log.Information("Starting Publisher Service");

            Console.WriteLine("Starting Publisher Service...");

            var server = new Service.PublisherService();
            var listener = new WcfHttpListener<IPublisher>
            {
                PortNumber = 1234,
                ExposeMetadata = true
            };

            try
            {
                listener.Open(server);

                Console.WriteLine("Service Started");
                Console.WriteLine("Endpoint: " + listener.MetadataExchangeAddress);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);                
            }

            Console.WriteLine();
            Console.WriteLine("Press Any Key to exit...");
            Console.WriteLine();
            Console.ReadKey();

        }

        private static void InitializeLogging()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .Enrich.FromLogContext()
                .Enrich.WithMachineName()
                .Enrich.WithEnvironmentUserName()
                .Enrich.WithProcessId()
                .Enrich.WithThreadId()
                .Enrich.WithAssemblyName()
                .Enrich.WithAssemblyVersion()
                .WriteTo.Console(LogEventLevel.Information)
                .WriteTo.Seq("http://localhost:5341")
                .CreateLogger();

        }

    }
}
