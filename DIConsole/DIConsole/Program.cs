﻿using DIConsole.Implementations;
using DIConsole.IServices;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Net;

namespace DIConsole
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddSingleton<IExampleTransientService, ExampleTransientService>();
                    services.AddScoped<IExampleScopedService, ExampleScopedService>();
                    services.AddSingleton<IExampleSingletonService, ExampleSingletonService>();
                    services.AddTransient<ServiceLifetimeReporter>();
                }
                ).Build();
            ExemplifyServiceLifetime(host.Services, "Lifetime 1");
            ExemplifyServiceLifetime(host.Services, "Lifetime 2");

            await host.RunAsync();
        }
        static void ExemplifyServiceLifetime(IServiceProvider hostProvider, string lifetime)
        {
            using IServiceScope serviceScope = hostProvider.CreateScope();
            IServiceProvider provider = serviceScope.ServiceProvider;
            ServiceLifetimeReporter logger = provider.GetRequiredService<ServiceLifetimeReporter>();
            logger.ReportServiceLifetimeDetails(
                $"{lifetime}: Call 1 to provider.GetRequiredService<ServiceLifetimeLogger>()");

            Console.WriteLine("...");

            logger = provider.GetRequiredService<ServiceLifetimeReporter>();
            logger.ReportServiceLifetimeDetails(
                $"{lifetime}: Call 2 to provider.GetRequiredService<ServiceLifetimeLogger>()");

            Console.WriteLine();
        }
    }
}