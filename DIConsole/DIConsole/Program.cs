using DIConsole.Implementations;
using DIConsole.IServices;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Net;

namespace DIConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddSingleton<IExampleTransientService, ExampleTransientService>();
                    services.AddScoped<IExampleScopedService, ExampleScopedService>();
                    services.AddSingleton<IExampleSingletonService, ExampleSingletonService>();
                    services.AddTransient<IReportServiceLifetime, IReportServiceLifetime>();
                }
                ).Build();
        }
    }
}