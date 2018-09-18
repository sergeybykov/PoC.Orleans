using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace PoC.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();
            var client = Startup.CreateClusterClient();
        }

        //public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //    WebHost.CreateDefaultBuilder(args)
        //        .UseStartup<Startup>();
    }
}
