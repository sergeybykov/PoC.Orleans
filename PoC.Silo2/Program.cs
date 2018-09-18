using Microsoft.Extensions.Logging;
using Orleans.Configuration;
using Orleans.Hosting;
using PoC.Grains.Implementation;
using System;
using System.Threading.Tasks;

namespace PoC.Silo2
{
    class Program
    {
        public static void Main(string[] args)
        {
            MainAsync(args).Wait();
        }

        public static async Task MainAsync(string[] args)
        {
            var t = typeof(DeviceGrain);
            Console.WriteLine($"Type:{t.FullName}");

            var silo = new SiloHostBuilder()
                .UseLocalhostClustering()
                .Configure((ClusterOptions options) =>
                {
                    options.ServiceId = "PoCService";
                    options.ClusterId = "dev"; // TODO Set cluster id
                })
                .ConfigureLogging(logging =>
                {
                    logging.SetMinimumLevel(LogLevel.Information);

                    logging.AddConsole();
                })

                .Build();

            Console.WriteLine("Starting silo...");
            await silo.StartAsync();

            Console.ReadKey();
        }


    }
}
