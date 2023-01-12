using DIConsole.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIConsole.Implementations
{
    internal class ExampleSingletonService : IExampleSingletonService
    {
        public Guid Id => Guid.NewGuid();
    }
}
