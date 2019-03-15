using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublisherService.Service;
using PublisherService.Utilities;

namespace PublisherService
{
    class Program
    {
        static void Main(string[] args)
        {
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
    }
}
