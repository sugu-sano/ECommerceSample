using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace ECommerceSample.Infrastructure
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();

            await host.RunAsync();
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            IHostBuilder hostBuilder = Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                {
                    services.AddInfrastructureServices();
                });

            return hostBuilder;
        }
    }
}
