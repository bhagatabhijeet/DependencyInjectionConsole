using DIConsole.IServices;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIConsole.Implementations
{
    internal class ExampleScopedService : IExampleScopedService
    {
        public Guid Id => Guid.NewGuid();

        public ServiceLifetime Lifetime => ServiceLifetime.Scoped;
    }
}
